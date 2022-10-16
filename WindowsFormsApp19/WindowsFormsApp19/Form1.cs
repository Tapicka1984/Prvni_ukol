using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime datum;
        DateTime Ted = DateTime.Now;
        double cas= 0;
        DateTime Posledni_Nejvetsi;
        bool zamecek = false;
        int pocitadlo_Kliknuti = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Cele_Jmeno = " ";
                string Text1 = " ";
                string Jméno_nejstarsiho = " ";
                bool spravnost = false;
                foreach (string text in textBox1.Lines)
                {
                    foreach (char znak in text)
                    {
                        if ((znak == '1') || (znak == '2') || (znak == '3') || (znak == '4') || (znak == '5') || (znak == '6') || (znak == '7') || (znak == '8') || (znak == '9') || (znak == '0') || (znak == '.'))
                        {
                            Text1 += znak;
                        }
                        else
                        {
                            Cele_Jmeno += znak;
                        }
                    }
                    if (DateTime.TryParse(Text1, out datum))
                    {
                        if (zamecek == false)
                        {
                            Posledni_Nejvetsi = datum;
                            zamecek = true;
                        }

                        if (datum < Posledni_Nejvetsi)
                        {
                            Posledni_Nejvetsi = datum;
                            Jméno_nejstarsiho = Cele_Jmeno;
                        }
                    }
                    else
                    {
                        label2.Visible = true;
                        MessageBox.Show("jedno z datumu je spatne, prosíme o kontrolu poctu dní, měsíců či let");
                        spravnost = true;
                    }
                    Cele_Jmeno = " ";
                    Text1 = " ";
                }
                Jméno_nejstarsiho = Jméno_nejstarsiho.Replace(';', ' ');
                if (spravnost == false)
                {
                    MessageBox.Show("nejsarsi je:" + Jméno_nejstarsiho);
                }
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("vyskytla se chybička, prosíme o kontaktování podpory");
            }
        }
    }
}
