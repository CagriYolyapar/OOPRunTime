using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPRuntime_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         
         RunTime'da kontrol olusturdugumuzda bu kontrolün kendisini ve eventlerini konvensiyonel yöntemlerle olusturamayız...
         
         EventArgs ve object parametreleri....

        Bir event metodunun object parametresi o event'i tetikleyen kontrolü temsil eder...

        object sender parametresi : Bir event'i tetikleyen kontrolü temsil eder

        EventArgs e parametres: Tetiklenen event'in özelliklerini (ne zaman prevention (engelleme)yapılacak)o tetiklendiginde mouse nerede , bilgisayarda hangi servisler calısıyor gibi ozelliklerini tutar...

         */



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);


        }
    }
}
