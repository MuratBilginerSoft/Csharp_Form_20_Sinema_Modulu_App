using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Modülü_App
{
    public partial class Form1 : Form
    {
        #region Paramters

        int boşkoltuksayısı;
        int dolukoltuksayısı;

        int bakiye = 300;
        int cbakiye=0;
        int csks = 0;
        int cbks;

        int öb = 15;
        int tb = 25;

        int ba = 0;

        int bf;

        #endregion

        #region Definitions

        Öğrenci ÖBA = new Öğrenci();
        Tam TBA = new Tam();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salon Salon1 = new Salon();

            Salon1.SalonAdı = textBox1.Text;
            Salon1.Koltuksayısı = Convert.ToInt32(textBox2.Text);

            label3.Text = Salon1.SalonAdı + " Salon Oluşturuldu " + "Koltuk Sayısı:" + Salon1.Koltuksayısı;

            boşkoltuksayısı = Salon1.Koltuksayısı; // 30
            dolukoltuksayısı = 0;

            cbks = boşkoltuksayısı; // 30
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = bakiye.ToString()+" TL niz Var";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = boşkoltuksayısı.ToString() + " Boş Koltuk Var";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbakiye = 0;

            if (radioButton1.Checked==true)
            {
                ba = Convert.ToInt32(textBox3.Text); // 3

                ÖBA.BiletAl(ba, öb, cbks, cbakiye,csks);

                label8.Text = ÖBA.cbakiye.ToString();
                label9.Text = ÖBA.csks.ToString();
            }

            else
            {
                ba = Convert.ToInt32(textBox3.Text);

                TBA.BiletAl(ba, tb, cbks, cbakiye,csks);

                label8.Text = TBA.cbakiye.ToString();
                label9.Text = TBA.csks.ToString();
            }

            cbakiye = ÖBA.cbakiye + TBA.cbakiye;
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bakiye = bakiye - cbakiye;
            boşkoltuksayısı = cbks;
            dolukoltuksayısı = dolukoltuksayısı + csks;

            MessageBox.Show("Bilet ALımı Gerçekleşti\nBakiye:"+bakiye);

        }
    }
}
