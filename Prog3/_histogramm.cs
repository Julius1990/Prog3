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
        public BackgroundWorker BwHisto;
        _hauptfenster parent;
        List<PictureBox> HistoPictureBoxes;
        List<Button> HistoCancelButtons;
        List<ProgressBar> HistoProgessBars;
        int geradeBerechnetesHistogramm;
        

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

            //Pictureboxen, ProgressBars und CancelButtons in Liste aufnehmen
            HistoPictureBoxes = new List<PictureBox> { parent.pictureBoxHistoGrau,parent.pictureBoxHistoRGB,
                parent.pictureBoxHistoRed,parent.pictureBoxHistoGruen,parent.pictureBoxHistoBlau};
            HistoCancelButtons = new List<Button> {parent.buttonCancelHistGray,parent.buttonCancelHistRGB,
                parent.buttonCancelHistoRed,parent.buttonCancelHistoGreen,parent.buttonCancelHistoBlue};
            HistoProgessBars = new List<ProgressBar>{parent.progressBarHistGray,parent.progressBarHistoRGB,
                parent.progressBarHistoRed,parent.progressBarHistoGreen,parent.progressBarHistoBlue};
            
        }

        public void berechneHistogramm(string aktiverTab_in)
        {
            Debug.WriteLine("Tab change Event ausgelöst");
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

            if (!BwHisto.IsBusy)
                BwHisto.RunWorkerAsync();
            else
                Debug.WriteLine("BwHisto is busy");
        }

        //BackgroundWorker
        private void BwHisto_doWork(object sender, DoWorkEventArgs e)
        {
            //Kritischen Bereich betreten
            parent.sem.WaitOne();

            Debug.WriteLine("BwHisto startet");

            Thread.Sleep(1000);

            //TabControl sperren
            lockTabs();
            
            
            if (geradeBerechnetesHistogramm == 1)
            {
                Debug.WriteLine("BwHisto: calcGrey()");
                calcGray();
            }
            else if (geradeBerechnetesHistogramm == 2)
            {
                Debug.WriteLine("BwHisto: calcRGB()");
                calcRGB();
            }
            else if (geradeBerechnetesHistogramm == 3)
            {
                Debug.WriteLine("BwHisto: calcRed()");
                calcRed();
            }
            else if (geradeBerechnetesHistogramm == 4)
            {
                Debug.WriteLine("BwHisto: calcGreen()");
                calcGreen();
            }
            else if (geradeBerechnetesHistogramm == 5)
            {
                Debug.WriteLine("BwHisto: calcBlue()");
                calcBlue();
            }
        }
        private void BwHisto_progress(object sender, ProgressChangedEventArgs e)
        {
            if (geradeBerechnetesHistogramm == 1)
            {
                parent.progressBarHistGray.Value = e.ProgressPercentage;
            }
            else if (geradeBerechnetesHistogramm == 2)
            {
                parent.progressBarHistoRGB.Value = e.ProgressPercentage;
            }
            else if (geradeBerechnetesHistogramm == 3)
            {
                parent.progressBarHistoRed.Value = e.ProgressPercentage;
            }
            else if (geradeBerechnetesHistogramm == 4)
            {
                parent.progressBarHistoGreen.Value = e.ProgressPercentage;
            }
            else if (geradeBerechnetesHistogramm == 5 )
            {
                parent.progressBarHistoBlue.Value = e.ProgressPercentage;
            }
        }
        private void BwHistp_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (parent.tabControllHistogramme.SelectedTab == parent.tabGrau)
            {
                //jeweilige ProgressBar und AbbrechenButton entfernen
            }
            else if (parent.tabControllHistogramme.SelectedTab == parent.tabRGB)
            {
                //jeweilige ProgressBar und AbbrechenButton entfernen
            }
            else if (parent.tabControllHistogramme.SelectedTab == parent.tabR)
            {
                //jeweilige ProgressBar und AbbrechenButton entfernen
            }
            else if (parent.tabControllHistogramme.SelectedTab == parent.tabG)
            {
                //jeweilige ProgressBar und AbbrechenButton entfernen
            }
            else if (parent.tabControllHistogramme.SelectedTab == parent.tabB)
            {
                //jeweilige ProgressBar und AbbrechenButton entfernen
            }

            unlockTabs();

            Debug.WriteLine("BwHisto Arbeit beendet");

            //Kritischen Bereich verlassen
            parent.sem.Release();
        }        
    
        public void clearAllHistos()
        {
            throw new System.NotImplementedException();
        }

        //TabControl
        public void lockTabs()
        {
            Debug.WriteLine("Histogramm Tabs locked");
            parent.tabControllHistogramme.Invoke(new Action(() => parent.tabControllHistogramme.Enabled = false));
        }
        public void unlockTabs()
        {
            Debug.WriteLine("Histogramm Tabs unlocked");
            parent.tabControllHistogramme.Invoke(new Action(() => parent.tabControllHistogramme.Enabled = true));
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

            //Fortschritt
            parent.progressBarHistGray.Invoke(new Action(() =>
            {
                parent.progressBarHistGray.Visible = true;
                parent.progressBarHistGray.Maximum = origBitmap.Width;
                parent.progressBarHistGray.Value = 0;
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

            //Mal schauen was ich mit der Farbe noch mache
            //histoPictureBox.Invoke(new Action(() => histoPictureBox.BackColor = Color.White));

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
            Debug.WriteLine("hallo");
            //throw new System.NotImplementedException();
        }
        public void calcRed()
        {
            throw new System.NotImplementedException();
        }
        public void calcGreen()
        {
            throw new System.NotImplementedException();
        }
        public void calcBlue()
        {
            throw new System.NotImplementedException();
        }
    }
}
