using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefeningen_Forms
{
    public partial class Oefening2_HowOld : Form
    {
        bool isChecked = false;
        bool isDateSelected = false;
        public Oefening2_HowOld()
        {
            InitializeComponent();
        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {
            SetprogressBar();
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Oefeningen_Forms.Properties.Resources.male;
            pictureBox1.BackColor = Color.Blue;
            SetprogressBar();
        }

        private void radioButtonVrouw_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Oefeningen_Forms.Properties.Resources.female;
            pictureBox1.BackColor = Color.Pink;
            SetprogressBar();
        }

        private void radioButtonOverige_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Oefeningen_Forms.Properties.Resources.Trans2;
            pictureBox1.BackColor = Color.Aquamarine;
            SetprogressBar();
        }

        private void dateTimePickerGeboorteDatum_ValueChanged(object sender, EventArgs e)
        {
            isDateSelected = true;
            SetprogressBar();
            BerekenLeeftijd();
            
        }

        private void BerekenLeeftijd()
        {
            DateTime geboorteDatum =  dateTimePickerGeboorteDatum.Value;
            DateTime vandaag = DateTime.Today;
            
            int leeftijd = vandaag.Year - geboorteDatum.Year;
            if (geboorteDatum.Date > vandaag.AddYears(-leeftijd))
            {
                leeftijd--;
            }

            MessageBox.Show($"Je bent {leeftijd} jaar oud!");

        }

        private void SetprogressBar()
        {
            if(txtNaam.Text != "" && isChecked && isDateSelected)
            {
                progressBar1.Value = 100;
            }
            else if(txtNaam.Text != "" && isChecked || isDateSelected)
            {
                progressBar1.Value = 66;
            }
            else if(txtNaam.Text != "" || isChecked || isDateSelected)
            {
                progressBar1.Value = 33;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }
    }
}
