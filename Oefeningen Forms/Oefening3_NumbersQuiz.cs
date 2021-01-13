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
    public partial class Oefening3_NumbersQuiz : Form
    {
        Random random = new Random();
        int som1, som2, min1, min2, maal1, maal2, deel1, deel2, mod1, mod2;
        bool somJuist;
        bool minJuist;
        bool maalJuist;
        bool deelJuist;
        bool modJuist;

        int timeLeft = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            GenereerCijfers();
        }

        public Oefening3_NumbersQuiz()
        {
            InitializeComponent();
            GenereerCijfers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                if(timeLeft < 10)
                {
                    lblTimeLeft.ForeColor = Color.Red;
                }
                timeLeft--;
                lblTimeLeft.Text = timeLeft.ToString();
            }
            else
            {
                timer1.Stop();                
                MessageBox.Show("TE TRAAG!", "Tijd is op.", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            lblTimeLeft.Visible = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            BerekenSom();
            BerekenVerschil();
            BerekenProduct();
            BerekenQuotient();
            BerekenModulus();
            VeranderKleur();

            if (AllesJuist())
            {
                MessageBox.Show("Proficiat!");
            }
            else
                MessageBox.Show("Jammer maar helaas..");           
            
        }
        private int BerekenSom()
        {
            int som = som1 + som2;
            if (txtSom.Value == som)
            {
                somJuist = true;
            }
            else
                somJuist = false;

            return som;
        }
        private int BerekenVerschil()
        {
            int verschil = min1 - min2;
            if (txtMin.Value == verschil)
            {
                minJuist = true;
            }
            else
                minJuist = false;

            return verschil;
        }
        private int BerekenProduct()
        {
            int product = maal1 * maal2;
            if (txtMaal.Value == product)
            {
                maalJuist = true;
            }
            else
                maalJuist = false;

            return product;
        }
        private double BerekenQuotient()
        {
            int quotient = deel1 / deel2;
            if (txtDeel.Value == quotient)
            {
                deelJuist = true;
            }
            else
                deelJuist = false;

            return quotient;
        }
        private int BerekenModulus()
        {
            int modulus = mod1 % mod2;
            if (txtMod.Value == modulus)
            {
                modJuist = true;
            }
            else
                modJuist = false;

            return modulus;
        }
        private bool AllesJuist()
        {
            if(somJuist && minJuist && maalJuist && deelJuist && modJuist)
            {
                return true;
            }
            else
                return false;
        }
        private void VeranderKleur()
        {
            if (somJuist)
            {
                txtSom.BackColor = Color.LightGreen;
            }
            else
            {
                txtSom.BackColor = Color.LightSalmon;
            }
            if (minJuist)
            {
                txtMin.BackColor = Color.LightGreen;
            }
            else
            {
                txtMin.BackColor = Color.LightSalmon;
            }
            if (maalJuist)
            {
                txtMaal.BackColor = Color.LightGreen;
            }
            else
            {
                txtMaal.BackColor = Color.LightSalmon;
            }
            if (deelJuist)
            {
                txtDeel.BackColor = Color.LightGreen;
            }
            else
            {
                txtDeel.BackColor = Color.LightSalmon;
            }
            if (modJuist)
            {
                txtMod.BackColor = Color.LightGreen;
            }
            else
            {
                txtMod.BackColor = Color.LightSalmon;
            }
        }

        private void GenereerCijfers()
        {
            som1 = random.Next(0, 20);
            som2 = random.Next(0, 20);
            min1 = random.Next(0, 20);
            min2 = random.Next(0, 20);
            maal1 = random.Next(0, 20);
            maal2 = random.Next(0, 20);
            deel1 = random.Next(0, 20);
            deel2 = random.Next(1, 20);
            mod1 = random.Next(0, 20);
            mod2 = random.Next(1, 20);

            lblSom1.Text = som1.ToString();
            lblSom2.Text = som2.ToString();
            lblMin1.Text = min1.ToString();
            lblMin2.Text = min2.ToString();
            lblMaal1.Text = maal1.ToString();
            lblMaal2.Text = maal2.ToString();
            lblDeel1.Text = deel1.ToString();
            lblDeel2.Text = deel2.ToString();
            lblMod1.Text = mod1.ToString();
            lblMod2.Text = mod2.ToString();
        }
    }
}
