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
    public partial class Oefening1_Rommelzin : Form
    {
        public Oefening1_Rommelzin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtNormal.Text = GenerateCorrectSentence();
            txtNormal.Visible = true;

            txtRommel.Text = GenerateScrambledSentence();
            txtRommel.Visible = true;
        }

        private string GenerateCorrectSentence()
        {
            string sentence = $"Hallo {textBoxName.Text}. Jij bent {numericAge.Value} jaar oud, jouw favoriete kleur is {textBoxColour.Text} en je kijkt heel graag naar {textBoxFilm.Text}";

            return sentence; 
        }
        private string GenerateScrambledSentence()
        {
            string sentence = $"Hallo {textBoxColour.Text}. Jij bent {textBoxFilm.Text} jaar oud, jouw favoriete kleur is {numericAge.Value} en je kijkt heel graag naar {textBoxName.Text}";

            return sentence;
        }

        private bool FormFilled()
        {
            if(textBoxName.Text != "" && textBoxColour.Text != "" && textBoxFilm.Text != "" && numericAge.Value != 0)
            {
                return true;
            }
            return false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if(FormFilled())
            {
                btnGenerate.Enabled = true;
            }
        }

        private void textBoxColour_TextChanged(object sender, EventArgs e)
        {
            if (FormFilled())
            {
                btnGenerate.Enabled = true;
            }
        }

        private void textBoxFilm_TextChanged(object sender, EventArgs e)
        {
            if (FormFilled())
            {
                btnGenerate.Enabled = true;
            }
        }

        private void numericAge_ValueChanged(object sender, EventArgs e)
        {
            if (FormFilled())
            {
                btnGenerate.Enabled = true;
            }
        }
    }
}
