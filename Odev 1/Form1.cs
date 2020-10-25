using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Otopark otopark = new Otopark();
        BasitKuyruk bkuyruk = new BasitKuyruk(200);
        OncelikliSira okuyruk = new OncelikliSira(200);
        Random r = new Random();
        int BeklemeSuresi=0;
        int aracSayisi = 1;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            

            aracSayisi++;

            a.AracNo += aracSayisi;

            bkuyruk.Insert(a);

            okuyruk.Insert(a);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOncelikli_Click(object sender, EventArgs e)
        {
            txtListe.Text = "";

            float temp = 0;
            int sayac = 0;
            float ortalama = 0;
            for (int i = 0; i < okuyruk.OKuyruk.Length; i++)
            {
                if (okuyruk.OKuyruk[i] == null)
                {
                    break;
                }
                sayac++;
                temp += okuyruk.OKuyruk[i].IslemSuresi;

            }


            ortalama = temp / sayac;
            lblOrtalama.Text = Convert.ToString(ortalama);

            for (int i = 0; i < okuyruk.OKuyruk.Length; i++)
            {
                if (okuyruk.OKuyruk[i] == null)
                {
                    break;
                }
                txtListe.Text += "Arac No :" + okuyruk.OKuyruk[i].AracNo + " Islem Suresi :" + okuyruk.OKuyruk[i].IslemSuresi + Environment.NewLine;

            }

        }

        private void btnSirali_Click(object sender, EventArgs e)
        {
            float temp = 0;
            int sayac = 0;
            float ortalama = 0;
            for (int i = bkuyruk.front; i < bkuyruk.Bkuyruk.Length; i++)
            {
                if (bkuyruk.Bkuyruk[i] == null)
                {
                    break;
                }
                sayac++;
                temp += bkuyruk.Bkuyruk[i].IslemSuresi;

            }


            ortalama = temp / sayac;
            lblOrtalama.Text = Convert.ToString(ortalama);
            txtListe.Text = "";
            for (int i = bkuyruk.front; i < bkuyruk.Bkuyruk.Length; i++)
            {
                if (bkuyruk.Bkuyruk[i] == null)
                {
                    break;
                }
                txtListe.Text += "Arac No :" + bkuyruk.Bkuyruk[i].AracNo + " Islem Suresi :" + bkuyruk.Bkuyruk[i].IslemSuresi + Environment.NewLine;




            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {


            BeklemeSuresi = r.Next(10, 300);
            
            timer1.Enabled = true;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtListe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(BeklemeSuresi>0)
            {
                timer1.Interval = 1000;
                BeklemeSuresi--;
                btnCikar.Enabled = false;
                lblSure.Text = Convert.ToString(BeklemeSuresi);
                txtListe.Text = "ARABA ÇIKIŞ YAPIYOR";

            }
            if(BeklemeSuresi==0)
            {
                
                btnCikar.Enabled = true;
                timer1.Enabled = false;
            }
            if (timer1.Enabled == false)
            {
                bkuyruk.Remove();
                okuyruk.Remove();
                txtListe.Text = "ARABA ÇIKTI";
            }
        }

        private void btnAtla_Click(object sender, EventArgs e)
        {
            BeklemeSuresi = 0;
            lblSure.Text = "0";
        }

        private void btnKiyasla_Click(object sender, EventArgs e)
        {
            float OrtalamaKazanc = 0;
            int sayac = 0;

            for (int i = bkuyruk.count-1; i > 0; i--)
            {
                int Kazanc = 0;
                
                
                for (int j = bkuyruk.front; j < bkuyruk.count; j++)
                {
                    

                  
                    if(bkuyruk.Bkuyruk[i].IslemSuresi<bkuyruk.Bkuyruk[j].IslemSuresi && bkuyruk.Bkuyruk[i].AracNo > bkuyruk.Bkuyruk[j].AracNo)
                    {
                        Kazanc += bkuyruk.Bkuyruk[j].IslemSuresi;
                        
                        
                    }

                    if (bkuyruk.Bkuyruk[i].IslemSuresi > bkuyruk.Bkuyruk[j].IslemSuresi && bkuyruk.Bkuyruk[i].AracNo < bkuyruk.Bkuyruk[j].AracNo)
                    {
                        Kazanc -= bkuyruk.Bkuyruk[j].IslemSuresi;


                    }


                }
                if(Kazanc > 0)
                {
                    sayac++;
                txtListe.Text += "" + bkuyruk.Bkuyruk[i].AracNo + "No'lu Aracın Kazancı: " + Kazanc + " Saniyedir."+Environment.NewLine;
                    OrtalamaKazanc += Kazanc;
                }

                

                
            }
            OrtalamaKazanc = OrtalamaKazanc / sayac;
            txtListe.Text += "Ortalama Kazanç : " + OrtalamaKazanc + "Saniyedir." + "";
            

        }
    }
}
