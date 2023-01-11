using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_1_23_Kazaliste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbtParter.Checked = true;
        }
        
        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNumTicket.Text == "")
                MessageBox.Show("Sva polja su obavezna!");
            else if (rbtLoza.Checked == false && rbtParter.Checked == false)
                MessageBox.Show("Molimo izaberite parter ili ložu!");
            else
            {
                try
                {
                    Rezervacija nova = new Rezervacija();
                    nova.Ime = txtName.Text;
                    nova.BrKarata = Convert.ToInt32(txtNumTicket.Text);

                    if (rbtParter.Checked == true)
                        nova.TipSjedala = rbtParter.Text;
                    else if (rbtLoza.Checked == true)
                        nova.TipSjedala = rbtLoza.Text;

                    lblShowReturn.Text = $"Rezervacija uspješna!\nKodrezervacije: {nova.BrRezervacije()}\nCijena rezervacije: {nova.CijenaRezervacije():C}\nUživajte u predstavi!";
                }
                catch (FormatException x)
                {
                    MessageBox.Show(x.Message);
                }
                catch (ArgumentException x)
                {
                    MessageBox.Show(x.Message);
                }
               
            }
        }
    }
}
