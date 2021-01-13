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
    public partial class Oefening4_MainMenu : Form
    {
        public Oefening4_MainMenu()
        {
            InitializeComponent();
        }
        private void btnOef1_Click(object sender, EventArgs e)
        {
            //Application.Run(new Oefening1_Rommelzin());
            Oefening1_Rommelzin oef1 = new Oefening1_Rommelzin();
            oef1.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            Oefening2_HowOld oef2 = new Oefening2_HowOld();
            oef2.Show();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            Oefening3_NumbersQuiz oef3 = new Oefening3_NumbersQuiz();
            oef3.Show();
        }
    }
}
