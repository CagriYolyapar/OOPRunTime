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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Ekle()
        {
            for (int i = 1; i <= 12; i++)
            {
                Button a = new Button();
                a.Text = $"button{i}";
                a.BackColor = Color.Blue;
                flowLayoutPanel1.Controls.Add(a);
                a.Click += Tikla;

            }
        }


        public void Temizle()
        {
            //flowLayoutPanel1.Controls.Clear();

            //foreach (Control item in flowLayoutPanel1.Controls)
            //{
            //    flowLayoutPanel1.Controls.Remove(item);
            //}
            //for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            //{
            //    flowLayoutPanel1.Controls.Remove(flowLayoutPanel1.Controls[i]);
            //}

            for (int i = flowLayoutPanel1.Controls.Count-1; i>=0; i--)
            {
                flowLayoutPanel1.Controls.Remove(flowLayoutPanel1.Controls[i]);
            }
        }



        private void Tikla(object sender, EventArgs e)
        {
            MessageBox.Show($"{(sender as Button).Text} isimli butona bastınız");
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            #region RuntimeButton
            //Button b = new Button();
            //b.Text = "Hello World";
            //b.BackColor = Color.Red;

            ////Olusturdugunuz bir kontrol nesnesini kesinlikle bir yapıya eklemeniz gerekir..
            //flowLayoutPanel1.Controls.Add(b);

            ////event'ler += operatoru ile tanımlanırlar...

            //b.Click += B_Click; 
            #endregion
            Ekle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
