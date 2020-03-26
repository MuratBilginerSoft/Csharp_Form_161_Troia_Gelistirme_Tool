using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EKS_Troia_Geliştirme_Tool_v1._0
{
    public partial class Form1 : Form
    {

        #region Tanımlamalar

        EKSTroia MBEKS = new EKSTroia();

        string[] Kod1,Kod2, Kolon1,Kolon2;

        #endregion

        #region Metodlar

        #region Diziye Al

        public void DiziyeAlKod(RichTextBox RichAlp, RichTextBox RichİAS, string[] Kod1, string[] Kod2, int X1, int X2)
        {
            Kod1 = RichAlp.Text.Split('\n');
            X1 = Kod1.Length;

            Kod2 = RichİAS.Text.Split('\n');
            X2 = Kod2.Length;
        }

        public void DiziyeAlKolon(RichTextBox RichAlp, RichTextBox RichİAS, int X1, int X2)
        {
            Kolon1 = RichAlp.Text.Split(';');
            X1 = Kolon1.Length;

            Kolon2 = RichİAS.Text.Split(';');
            X2 = Kolon2.Length;

        }

        #endregion

        #endregion

        #region Değişkenler

        bool Durum = true;

        int Satır1, Satır2 = 0;

        string Cümle = "";

        #endregion

        #region Form İşlemleri

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region PictureBox İşlemeri

        private void PicKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicSimge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        #endregion

        #region Radial Menü İşlemleri

        #region Sil Komutları

        private void RadialSil1_Click(object sender, EventArgs e)
        {
            MBEKS.Sil(RichAlp);
        }

        private void RadialSil2_Click(object sender, EventArgs e)
        {
            MBEKS.Sil(RichİAS);
        }


        #endregion

        #region Yapıştır

        private void RadialYapıştır1_Click(object sender, EventArgs e)
        {
            MBEKS.Yapistir(RichAlp);
        }

        int i2;

        private void RadialOnayla_Click(object sender, EventArgs e)
        {
            
        }

        private void RadialDüzenle_Click(object sender, EventArgs e)
        {
           
        }

        private void RadialYapıştır2_Click(object sender, EventArgs e)
        {
            MBEKS.Yapistir(RichİAS);
        }




        #endregion

       

        #endregion

        #region Radio Buton İşlemleri

        private void RadioTablo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTablo.Checked==true)
            {
                Durum = false;
            }

            else
            {
                Durum = true;
            }
        }

        private void RadialNumaralandır_Click(object sender, EventArgs e)
        {

            MBEKS.Numaralandır(RichAlp, RichİAS, Kod1, Kod2, Kolon1, Kolon2, Durum, Satır1, Satır2);
        }

        private void RadioKod_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioKod.Checked == true)
            {
                Durum = true;
            }

            else
            {
                Durum = false;
            }


        }

        #endregion


    }
}
