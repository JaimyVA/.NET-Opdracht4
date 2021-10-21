using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        Rij<string> Agenda = new Rij<string>();
        TeDoen task = new TeDoen();
        public Boolean dringend;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (cbTijd.Checked)
            {
                TeDoen task = new TeDoen();
                task.Id++;

                task.Titel = tbTitel.Text;
                task.tijdstip = DateTime.Now;
                task.informatie = tbMeedelen.Text;
                dringend = true;

                string taak = "id " + task.Id.ToString() + " titel " + task.Titel.ToString() + " tijd: " + task.tijdstip.ToString() + " message: " + task.informatie.ToString() + " dringend?: " + dringend.ToString();
                Agenda.Toevoegen(taak);
            }
            else
            {

                string opslaan()
                {
                    TeDoen task = new TeDoen();
                    task.Id++;

                    task.Titel = tbTitel.Text;


                    task.informatie = tbMeedelen.Text;

                    dringend = false;
                    string taak = "id " + task.Id.ToString() + " titel " + task.Titel.ToString() + " message: " + task.informatie.ToString() + " Op tijd?: " + dringend.ToString();
                    return taak;

                }
                Agenda.Toevoegen(opslaan());
            }
        }

        private void btnVolgendeTaak_Click(object sender, EventArgs e)
        {
            if (!Agenda.isEmpty)
            {
                MessageBox.Show(Agenda.Toon(index));

                tbAgenda.Text = Agenda.Toon(index);
            }
            index++;
        }

        private void btnVerwijderTaak_Click(object sender, EventArgs e)
        {
            if (!Agenda.isEmpty)
            {
                Agenda.Verwijderen();
                tbAgenda.Text = "";
            }
        }

        private void btnZetAchteraan_Click(object sender, EventArgs e)
        {
            Agenda.LaatsteElement(Agenda.EersteElement().ToString());
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            if (btnMessageBox.BackColor == Color.Green)
            {
                btnMessageBox.BackColor = Color.Red;
            }
            else if (btnMessageBox.BackColor == Color.Red)
            {
                MessageBox.Show(Agenda.ToString());
                btnMessageBox.BackColor = Color.Green;
            }
        }

        private void btnTextveld_Click(object sender, EventArgs e)
        {
            if (btnTextveld.BackColor == Color.Red)
            {
                btnTextveld.BackColor = Color.Green;
            }
            else if (btnTextveld.BackColor == Color.Green)
            {
                tbMeedelen.Text = Agenda.ToString();
                btnMessageBox.BackColor = Color.Red;
            }
        }
    }
}
