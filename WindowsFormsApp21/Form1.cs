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
            string Jmeno_nejstarsiho = " ";
            DateTime Ted = DateTime.Now;
            DateTime Datum;

            foreach(string text in textBox1.Lines)
            {
                string[] datum = text.Split(';');
                if(DateTime.TryParse(datum[2], out Datum))
                {
                    if(Datum < Ted)
                    {
                        Ted = Datum;
                        Jmeno_nejstarsiho = datum[0] + " " + datum[1];
                    }
                }
            }
            MessageBox.Show("nejstarsi je:" + Jmeno_nejstarsiho);
        }
    }
}
