using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Prog3
{
    public class _schrittspeicher
    {
        private int counter;
        private int maxSchritt;
        private string ordnerName;
        private _hauptfenster parent;

        //Konstruktor
        public _schrittspeicher(_hauptfenster parent_in)
        {
            parent = parent_in;
            ordnerName = "zwischenSchritte";
        }

        //Speicher anlegen und löschen
        public void speicherAnlegen()
        {
            //Ordner für Zwischenschritte anlegen
            bool existiert = System.IO.Directory.Exists(ordnerName);
            //falls er existiert, lösche den Inhalt
            if (existiert)
            {
                speicherlöschen();
            }
            //falls er nicht existiert, legt er den Ordner an
            else if (!existiert)
            {
                System.IO.Directory.CreateDirectory(ordnerName);
            }
            //optionen für rückgängig und wiederholen "ausblenden"
            parent.rückgängigToolStripMenuItem.Visible = false;
            parent.wiederholenToolStripMenuItem.Visible = false;
        }
        public void speicherlöschen()
        {
            try
            {
                counter = -1;
                maxSchritt = counter;
                //sucht alle dateien und löscht diese
                string[] dateien = Directory.GetFiles(ordnerName);
                foreach (string filePath in dateien)
                {
                    File.Delete(filePath);
                }
                //optionen für rückgängig und wiederholen ausblenden
                parent.rückgängigToolStripMenuItem.Visible = false;
                parent.wiederholenToolStripMenuItem.Visible = false;
            }
            catch
            {
                Debug.WriteLine("Schrittspeicher konnte nicht gelöscht werden");
            }
        }

        //einzelnen Schritt speichern
        public void schrittSpeichern(Bitmap bild)
        {
            try
            {
                Debug.WriteLine("schrittSpeichern()");
                //überflüssig gespeichertes löschen
                if (maxSchritt > counter)
                {
                    string[] dateien = Directory.GetFiles(ordnerName);
                    foreach (string filePath in dateien)
                    {
                        string name = Path.GetFileNameWithoutExtension(filePath);
                        Int32 number = Convert.ToInt32(name);

                        if (number > counter)
                        {
                            File.Delete(filePath);
                        }

                        parent.histogramme.clearAllHistos();
                    }
                }

                counter++;
                Debug.WriteLine("ZwischenSchrittCounter: " + counter.ToString());

                //bild speichern
                string dateiName = "zwischenSchritte\\" + counter.ToString() + ".bmp";
                bild.Save(dateiName);

                //rückgängig zulassen oder blockieren
                if (counter > 0)
                    parent.rückgängigToolStripMenuItem.Visible = true;
                else
                    parent.rückgängigToolStripMenuItem.Visible = false;

                //wiederholen deaktivieren
                parent.wiederholenToolStripMenuItem.Visible = false;
                //benötigt für wiederholen
                maxSchritt = counter;
            }
            catch
            {
                Debug.WriteLine("Schritt konnte nicht gespeichert werden");
            }
        }

        //Navigation zwischen den Schritten
        public void schrittVor()
        {
            if (parent.sem.WaitOne(500))
            {
                Debug.WriteLine("Schritt vor Angefordert");

                Thread.Sleep(1000);

                counter++;
                string dateiname = ordnerName + "\\" + counter.ToString() + ".bmp";
                parent.bildPicturebox.Image = Image.FromFile(dateiname);
                if (counter == maxSchritt)
                    parent.wiederholenToolStripMenuItem.Visible = false;
                parent.rückgängigToolStripMenuItem.Visible = true;

                Debug.WriteLine("Schritt vor Ausgeführt");

                //Histogramme löschen
                parent.histogramme.clearAllHistos();

                parent.sem.Release();
            }
            else
            {
                MessageBox.Show("Das Bild wird gerade bearbeitet");
            }
        }
        public void schrittZurueck()
        {
            if (parent.sem.WaitOne(500))
            {
                Thread.Sleep(1000);

                Debug.WriteLine("Schritt zurück Angefordert");

                counter--;
                Debug.WriteLine("ZwischenSchrittCounter: " + counter.ToString());
                string dateiname = ordnerName + "\\" + counter.ToString() + ".bmp";
                parent.bildPicturebox.Image = Image.FromFile(dateiname);
                if (counter == 0)
                {
                    parent.rückgängigToolStripMenuItem.Visible = false;
                }
                parent.wiederholenToolStripMenuItem.Visible = true;

                Debug.WriteLine("Schritt zurück Ausgeführt");

                //Histogramme löschen
                parent.histogramme.clearAllHistos();

                parent.sem.Release();
            }
            else
            {
                MessageBox.Show("Das Bild wird gerade bearbeitet");
            }
        }
    }
}
