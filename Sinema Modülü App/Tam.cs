using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Modülü_App
{
    public class Tam
    {
        public int boşkoltuksayısı;
        public int dolukoltuksayısı;

        public int bakiye = 300;
        public int cbakiye = 0;
        public int csks = 0;
        public int cbks;

        public int tb = 25;

        public int ba = 0;

        public int bf;

        public void BiletAl(int a, int tbx, int cbksx, int cbakiyex,int csksx)
        {
            ba = a;
            bf = tb * ba;

            if (ba >= cbksx)
            {
                MessageBox.Show("Boş Koltuk Sayısını Aştınız");
            }

            else
            {
                cbakiye += bf;
                csks = csksx + ba; // 3
            }

            cbks = cbksx - ba; // 47
        }
    }
}
