using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Primary;

namespace Kurs.WindowsForms
{
    public partial class Form1 : Form
    {
        private PrimaryNumbers _pn;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wynik.Text = "Hello World";
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            try
            {
                int limit = Convert.ToInt32(tbZakres.Text);
                limit = limit < 2 || limit > 100000 ? 2000 : limit;
                _pn = new PrimaryNumbers(limit);
                List<int> primes = _pn.GetNumbers();
                StringBuilder sb = new StringBuilder();
                sb.Append("Zbiór liczb pierwszych:" + Environment.NewLine);
                foreach (int prime in primes)
                {
                    sb.Append(prime + " ");
                }

                wynik.Text = sb.ToString();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Błąd danych!!: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błąd danych!!: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inny błąd: " + ex.Message);
            }
        }

     

        private void tbZakres_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
