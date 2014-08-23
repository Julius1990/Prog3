using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Prog3
{
    public class _Histogramm
    {
        //Globale Variablen
        public BackgroundWorker BwHisto;
        _hauptfenster parent;
        List<PictureBox> HistoPictureBoxes;
        List<Button> HistoCancelButtons;
        int geradeBerechnetesHistogramm;
        
        //Kontstuktor
        public _Histogramm(_hauptfenster parent_in)
        {
            //Elternfenster
            parent = parent_in;

            //Backgroundworker erzeugen und initialisieren
            BwHisto = new BackgroundWorker();
            BwHisto.WorkerSupportsCancellation = true;
            BwHisto.WorkerReportsProgress = true;
            BwHisto.DoWork += new DoWorkEventHandler(BwHisto_doWork);
            BwHisto.ProgressChanged += new ProgressChangedEventHandler(BwHisto_progress);
            BwHisto.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BwHistp_completed);

            //Pictureboxen und CancelButtons in Liste aufnehmen
            HistoPictureBoxes = new List<PictureBox> { parent.pictureBoxHistoGrau,parent.pictureBoxHistoRGB,
                parent.pictureBoxHistoRed,parent.pictureBoxHistoGruen,parent.pictureBoxHistoBlau};
            HistoCancelButtons = new List<Button> {parent.buttonCancelHistGray,parent.buttonCancelHistRGB,
                parent.buttonCancelHistoRed,parent.buttonCancelHistoGreen,parent.buttonCancelHistoBlue};
            
        }

        //Kommunikation mit Form1
        public void berechneHistogramm(string aktiverTab_in)
        {
            //Herausfinden welcher Tab gerade geöffnet ist
            if (aktiverTab_in == "Grau")
                geradeBerechnetesHistogramm = 1;
            else if (aktiverTab_in == "RGB")
                geradeBerechnetesHistogramm = 2;
            else if (aktiverTab_in == "Rot")
                geradeBerechnetesHistogramm = 3;
            else if (aktiverTab_in == "Grün")
                geradeBerechnetesHistogramm = 4;
            else if (aktiverTab_in == "Blau")
                geradeBerechnetesHistogramm = 5;

            ordneButtons();

            //Versuchen die Berechnung anzustoßen
            if (!BwHisto.IsBusy)
                BwHisto.RunWorkerAsync();
            else
            {
                BwHisto.CancelAsync();
                Debug.WriteLine("BwHisto cancelAsync");
                try
                {
                    BwHisto.RunWorkerAsync();
                }
                catch
                {
                    Debug.WriteLine("BwHisto konnte nicht gestartet werdee");
                }

            }
        }

        //BackgroundWorker
        private void BwHisto_doWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Kritischen Bereich betreten
                //parent.sem.WaitOne(5000);

                Debug.WriteLine("BwHisto startet");


                if (geradeBerechnetesHistogramm == 1)
                {
                    Debug.WriteLine("BwHisto doWork: calcGrey()");
                    if (parent.pictureBoxHistoGrau.Image == null)
                        calcGray();
                }
                else if (geradeBerechnetesHistogramm == 2)
                {
                    Debug.WriteLine("BwHisto doWork: calcRGB()");
                    if (parent.pictureBoxHistoRGB.Image == null)
                        calcRGB();
                }
                else if (geradeBerechnetesHistogramm == 3)
                {
                    Debug.WriteLine("BwHisto doWork: calcRed()");
                    if (parent.pictureBoxHistoRed.Image == null)
                        calcRed();
                }
                else if (geradeBerechnetesHistogramm == 4)
                {
                    Debug.WriteLine("BwHisto doWork: calcGreen()");
                    if (parent.pictureBoxHistoGruen.Image == null)
                        calcGreen();
                }
                else if (geradeBerechnetesHistogramm == 5)
                {
                    Debug.WriteLine("BwHisto doWork: calcBlue()");
                    if (parent.pictureBoxHistoBlau.Image == null)
                        calcBlue();
                }
            }
            catch
            {
                Debug.WriteLine("BwHisto doWork Semaphor timeout");
            }
        }
        private void BwHisto_progress(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                parent.toolStripProgressBar.Value = e.ProgressPercentage;
            }
            catch
            {
                Debug.WriteLine("Fehler in BwHisto_progress");
            }
        }
        private void BwHistp_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (geradeBerechnetesHistogramm == 1)
            {
                parent.buttonCancelHistGray.Visible = false;
            }
            else if (geradeBerechnetesHistogramm==2)
            {
                parent.buttonCancelHistRGB.Visible = false;
            }
            else if (geradeBerechnetesHistogramm == 3)
            {
                parent.buttonCancelHistoRed.Visible = false;
            }
            else if (geradeBerechnetesHistogramm == 4)
            {
                parent.buttonCancelHistoGreen.Visible = false;
            }
            else if (geradeBerechnetesHistogramm == 5)
            {
                parent.buttonCancelHistoBlue.Visible = false;
            }

            //Progress Bar auf 0 setzen
            parent.toolStripProgressBar.Value = 0;

            Debug.WriteLine("BwHisto Arbeit beendet");

            //Kritischen Bereich verlassen
            parent.sem.Release();
        }        
    
        //Alles Plätten wenn neues Bild geladen wird oder etwas bearbeitet wurde
        public void clearAllHistos()
        {
            Debug.WriteLine("clearAllHistos()");
            foreach (PictureBox pi in HistoPictureBoxes)
            {
                pi.Image = null;
            }
            GC.Collect();
        }

        //Abbrechen Button ordentlich anordne
        private void ordneButtons()
        {
            //gewünschte Position berechnen
            float top = ((float)parent.pictureBoxHistoGrau.Height / 2.0f) - ((float)parent.buttonCancelHistGray.Height / 2.0f);
            float left = ((float)parent.pictureBoxHistoGrau.Width / 2.0f) - ((float)parent.buttonCancelHistGray.Width / 2.0f);
            //buttons an gewünschter stelle positionieren
            foreach (Button bt in HistoCancelButtons)
            {
                bt.Top = parent.pictureBoxHistoGrau.Top + (int)top;
                bt.Left = parent.pictureBoxHistoGrau.Left + (int)left;
            }
        }

        //Histogramm Funktionen
        public void calcGray()
        {
            if (BwHisto.CancellationPending)
                return;

            Bitmap origBitmap = (Bitmap)parent.bildPicturebox.Image.Clone();

            int[] hist = new int[256];
            int max = 0;

            for (int a = 0; a < 255; a++)
            {
                hist[a] = 0;
            }

            //Fortschritt (maximum wird in form1 gesetzt)
            parent.toolStripProgressBar.Value = 0;
            //Abrrechen Button
            parent.buttonCancelHistGray.Invoke(new Action(() =>
            {
                parent.buttonCancelHistGray.Visible = true;
            }));
            
            //läuft jedes Pixel einzeln durch
            for (int x = 0; x < origBitmap.Width; x++)
            {
                for (int y = 0; y < origBitmap.Height; y++)
                {
                    Color orig = origBitmap.GetPixel(x, y);
                    //Diese Werte sind aus der Vorlesung
                    int grey = (int)((orig.R * 0.3) + (orig.G * 0.6) + (orig.B * 0.1));

                    int grauWert = grey;
                    hist[grauWert]++;
                    if (hist[grauWert] > max)
                    {
                        max = hist[grauWert];
                    }
                }
                BwHisto.ReportProgress(x);
                if (BwHisto.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)hist[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Black);
                }
                if (BwHisto.CancellationPending)
                    return;
            }
            parent.pictureBoxHistoGrau.Image = histogramm;        
        }
        public void calcRGB()
        {
            if (BwHisto.CancellationPending)
                return;

            parent.buttonCancelHistRGB.Invoke(new Action(()=> parent.buttonCancelHistRGB.Visible = true));

            Bitmap orig = new Bitmap(parent.bildPicturebox.Image);

            //blau
            long[] blue = new long[256];
            long maxBlau = 0;
            for (int a = 0; a < 255; a++)
            {
                blue[a] = 0;
            }

            //rot
            long[] red = new long[256];
            long maxRot = 0;
            for (int a = 0; a < 255; a++)
            {
                red[a] = 0;
            }

            //Grün
            long[] greene = new long[256];
            long maxGruen = 0;
            for (int a = 0; a < 255; a++)
            {
                greene[a] = 0;
            }

            //Fortschritt
            parent.toolStripProgressBar.Value = 0;
            parent.toolStripProgressBar.Maximum = orig.Width;

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int rotwert = orig.GetPixel(x, y).R;
                    int gruenwert = orig.GetPixel(x, y).G;
                    int blauwert = orig.GetPixel(x, y).B;

                    //rot
                    red[rotwert]++;
                    if (red[rotwert] > maxRot)
                        maxRot = red[rotwert];

                    //grün
                    greene[gruenwert]++;
                    if (greene[gruenwert] > maxGruen)
                        maxGruen = greene[gruenwert];

                    //blau
                    blue[blauwert]++;
                    if (blue[blauwert] > maxBlau)
                        maxBlau = blue[blauwert];
                }
                BwHisto.ReportProgress(x);
                if (BwHisto.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            long groesste = 0;

            if (maxBlau > maxGruen && maxBlau > maxRot)
            {
                groesste = maxBlau;
            }
            else if (maxGruen > maxBlau && maxGruen > maxRot)
            {
                groesste = maxGruen;
            }
            else
                groesste = maxRot;

            Debug.WriteLine(groesste);
            Debug.WriteLine("Blau:" + maxBlau.ToString());

            double ratio = 132.0 / (double)groesste;

            //rot
            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)red[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Red);
                }
                if (BwHisto.CancellationPending)
                    return;
            }

            //grün
            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)greene[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    if (histogramm.GetPixel(x, 131 - b).R != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.Yellow);
                    }
                    else
                        histogramm.SetPixel(x, 131 - b, Color.Green);
                }
                if (BwHisto.CancellationPending)
                    return;
            }

            //blau
            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)blue[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    Color grab = histogramm.GetPixel(x + 1, 131 - b);
                    if (grab.R != 0 && grab.G != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.Gray);
                    }
                    else if (grab.R != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.Magenta);
                    }
                    else if (grab.G != 0)
                    {
                        histogramm.SetPixel(x, 131 - b, Color.LightBlue);
                    }
                    else
                        histogramm.SetPixel(x, 131 - b, Color.Blue);
                }
                if (BwHisto.CancellationPending)
                    return;
            }
            parent.pictureBoxHistoRGB.Invoke(new Action(() => parent.pictureBoxHistoRGB.Image = histogramm));

        }
        public void calcRed()
        {
            if (BwHisto.CancellationPending)
                return;

            Bitmap orig = new Bitmap(parent.bildPicturebox.Image);
            int[] rot = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                rot[a] = 0;
            }

            //Fortschritt
            parent.toolStripProgressBar.Value = 0;
            //Abbrechen
            parent.buttonCancelHistoRed.Invoke(new Action(() => parent.buttonCancelHistoRed.Visible = true));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int rotwert = orig.GetPixel(x, y).R;
                    rot[rotwert]++;
                    if (rot[rotwert] > max)
                        max = rot[rotwert];
                }
                BwHisto.ReportProgress(x);
                if (BwHisto.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)rot[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Red);
                }
                if (BwHisto.CancellationPending)
                    return;
            }
            parent.pictureBoxHistoRed.Invoke(new Action(() => parent.pictureBoxHistoRed.Image = histogramm));
        }
        public void calcGreen()
        {
            if (BwHisto.CancellationPending)
                return;

            Bitmap orig = new Bitmap(parent.bildPicturebox.Image);
            int[] green = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                green[a] = 0;
            }

            //Fortschritt
            parent.toolStripProgressBar.Value = 0;
            //Abbrechen
            parent.buttonCancelHistoGreen.Invoke(new Action(() => parent.buttonCancelHistoGreen.Visible = true));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int gruenwert = orig.GetPixel(x, y).G;
                    green[gruenwert]++;
                    if (green[gruenwert] > max)
                        max = green[gruenwert];
                }
                BwHisto.ReportProgress(x);
                if (BwHisto.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)green[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Green);
                }
                if (BwHisto.CancellationPending)
                    return;
            }
            parent.pictureBoxHistoGruen.Invoke(new Action(() => parent.pictureBoxHistoGruen.Image = histogramm));
        }
        public void calcBlue()
        {
            if (BwHisto.CancellationPending)
                return;

            Bitmap orig = new Bitmap(parent.bildPicturebox.Image);
            int[] blue = new int[256];
            int max = 0;
            for (int a = 0; a <= 255; a++)
            {
                blue[a] = 0;
            }

            //Fortschritt
            parent.toolStripProgressBar.Value = 0;
            //Abbrechen
            parent.buttonCancelHistoBlue.Invoke(new Action(() => parent.buttonCancelHistoBlue.Visible = true));

            for (int x = 0; x < orig.Width; x++)
            {
                for (int y = 0; y < orig.Height; y++)
                {
                    int blauwert = orig.GetPixel(x, y).B;
                    blue[blauwert]++;
                    if (blue[blauwert] > max)
                        max = blue[blauwert];
                }
                BwHisto.ReportProgress(x);
                if (BwHisto.CancellationPending)
                    return;
            }
            Bitmap histogramm = new Bitmap(258, 132);

            double ratio = 132.0 / (double)max;

            for (int x = 1; x <= 256; x++)
            {
                int y = (int)((double)blue[256 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Blue);
                }
                if (BwHisto.CancellationPending)
                    return;
            }
            parent.pictureBoxHistoBlau.Invoke(new Action(() => parent.pictureBoxHistoBlau.Image = histogramm));
        }
    }
}
