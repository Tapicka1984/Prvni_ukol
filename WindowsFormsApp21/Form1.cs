using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string datum = " ";
            string jmeno = " ";
            string Jmeno_nejstarsiho = " ";
            DateTime Ted = DateTime.Now;
            DateTime Datum;
            foreach(string text in textBox1.Lines)
            {
                foreach (char znak in text)
                {
                    if ((znak == '1') || (znak == '2') || (znak == '3') || (znak == '4') || (znak == '5') || (znak == '6') || (znak == '7') || (znak == '8') || (znak == '9') || (znak == '0') || (znak == '.'))
                    {
                        datum += znak;
                    }
                    else
                    {
                        jmeno += znak;
                    }
                }
                if(DateTime.TryParse(datum, out Datum))
                {
                    if(Datum < Ted)
                    {
                        Ted = Datum;
                        Jmeno_nejstarsiho = jmeno;
                    }
                }
                datum = " ";
                jmeno = " ";
            }
            MessageBox.Show("nejstarsi je:" + Jmeno_nejstarsiho);
        }
    }
}
