using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace EKS_Troia_Geliştirme_Tool_v1._0
{
    public class EKSTroia
    {
        #region Değişkenler

        #endregion


        #region Tanımlamalar


        #endregion

        #region Metodlar

        #region Yapıştır

        public void Yapistir(RichTextBox Rich)
        {
            IDataObject Nesne = Clipboard.GetDataObject();

            if (Nesne.GetDataPresent(DataFormats.Text))
            {
                Rich.Text = Nesne.GetData(DataFormats.Text).ToString();
            }

        }

        #endregion

        #region Sil

        public void Sil(RichTextBox Rich)
        {
            Rich.Clear();
        }

        #endregion

        #region Numaralandır

        public void Numaralandır(RichTextBox Rich,RichTextBox Rich2,string[] Kod1, string[] Kod2, string[] Kolon1, string[] Kolon2,  bool Durum,int X1,int X2)
        {
            if (Durum == true)
            {
               

                Kod1 = Rich.Text.Split('\n');
                X1 = Kod1.Length;

                Kod2 = Rich2.Text.Split('\n');
                X2 = Kod2.Length;


                Sil(Rich);
                Sil(Rich2);

                for (int i1 = 0; i1 < X1; i1++)
                {
                    Rich.Text += (i1 + 1) + "  " + Kod1[i1] + "\n";
                }

                for (int i2 = 0; i2 < X2; i2++)
                {
                    Rich2.Text += (i2 + 1) + "  " + Kod2[i2] + "\n";
                }
            }

            else
            {
                Kolon1 = Rich.Text.Split(';');
                X1 = Kolon1.Length;

                Kolon2 = Rich2.Text.Split(';');
                X2 = Kolon2.Length;

                Sil(Rich);
                Sil(Rich2);

                for (int i1 = 0; i1 < X1; i1++)
                {
                    Rich.Text += (i1 + 1) + "  " + Kolon1[i1] + "\n";
                }

                for (int i2 = 0; i2 < X2; i2++)
                {
                    Rich2.Text += (i2 + 1) + "  " + Kolon2[i2] + "\n";
                }
            }



        }

        #endregion

        #region Düzenle

        public void Düzenle(RichTextBox RichAlp, RichTextBox RichİAS, string[] Kod1, string[] Kod2,string Cümle,bool Durum)
        {
            #region Alp Düzenle

            if (Durum==true)
            {
                RichAlp.Clear();

                for (int i1 = 0; i1 < Kod1.Length; i1++)
                {
                    string[] Kelime1 = Kod1[i1].Split(' ');

                    Cümle = "";
                    foreach (string item in Kelime1)
                    {
                        if (item.Trim() != "")
                        {
                            Cümle += item.Trim() + " ";
                        }
                    }

                    RichAlp.Text += Cümle + "\n";
                }
            }
            #endregion

            #region İAS Düzenle

            else
            {
                RichİAS.Clear();

                for (int i2 = 0; i2 < Kod2.Length; i2++)
                {
                    string[] Kelime2 = Kod2[i2].Split(' ');

                    Cümle = "";

                    foreach (string item in Kelime2)
                    {
                        if (item.Trim() != "")
                        {
                            Cümle += item.Trim() + " ";
                        }
                    }

                    RichİAS.Text += Cümle + "\n";
                }

            }


            #endregion

        }

        #endregion


        #endregion

      

    }
}
