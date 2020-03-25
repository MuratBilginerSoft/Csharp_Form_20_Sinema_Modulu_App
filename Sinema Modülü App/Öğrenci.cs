using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Modülü_App
{
    public class Öğrenci
    {
        public int boşkoltuksayısı;
        public int dolukoltuksayısı;

        public int bakiye = 300;
        public int cbakiye = 0;
        public int csks = 0;
        public int cbks;



        public int öb = 15;
        public int tb = 25;

        public int ba = 0;

        public int bf;

        public void BiletAl(int a,int öbx,int cbksx,int cbakiyex,int csksx)
        {
            csks = 0;

            ba = a; // 3
            bf = öbx * ba; // 45

            if (ba >= cbksx) // 3>30
            {
                MessageBox.Show("Boş Koltuk Sayısını Aştınız");
            }

            else
            {
                cbakiye += bf; // 45
                csks = csksx + ba; // 3 
            }

            cbks = cbksx - ba; // 27
        }

        
                

               

               




    }
}
