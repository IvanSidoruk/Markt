using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNaturMarktGMBH
{
    public partial class LoadingScreen : Form
    {
        private int LodingBarValue = 0;
        protected int maxValue = 0;
        
        public LoadingScreen()
        {
            InitializeComponent();
            maxValue = progressBar1.Maximum;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            StartTimer();
            // MessageBox.Show("Hallo!");
            // DialogResult dialogResult = MessageBox.Show("Wolen Sie witer arbeiten?", "Weiter", MessageBoxButtons.YesNo);
            //
            //if (dialogResult != DialogResult.Yes)
            //{
            //this.Close();
            //}
            //else
            //{
            //this.pr 
            //progressBar1.Value += 50; 

            //for (int i = 0; i < 10000; i++)
            //{
            //    progressBar1.Value += 1;
            //    label2.Text = ""+progressBar1.Value.ToString() +"%";
            //    if (progressBar1.Value == 100) {
            //        break;

            //    }
            //}



            //}   
        }

        private void StartTimer()
        {
            if (LodingBarValue == maxValue)
            {
                LodingBarValue = 0;
            }
            LoadingBarTimer.Start();
        }

        private void StopTimer()
        {
            LoadingBarTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {


            LodingBarValue += 1;
            progressBar1.Value = LodingBarValue;
            label2.Text = LodingBarValue.ToString() + "%";
            if (LodingBarValue == maxValue)
            {
                StopTimer();
            }
        }
    }
}
