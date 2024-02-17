using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int licznik = 0;
        bool uzytkownik = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor Marek", "Informacje o autorze");
        }

        private void zamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (uzytkownik)
                b.Text = "X";
            else 
                b.Text = "O";
            uzytkownik = !uzytkownik;
            b.Enabled = false;
            licznik++;
            sprawdzenie();
        }
        private void sprawdzenie()
        {
                bool zwyciezca = false;
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&& (!A1.Enabled))
                    zwyciezca = true;
                else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                    zwyciezca = true;
                else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                    zwyciezca = true;
                else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                    zwyciezca = true;
                else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                    zwyciezca = true;
                else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                    zwyciezca = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                zwyciezca = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                zwyciezca = true;
            else if(licznik == 9)
                {
                
                MessageBox.Show("Remis!", "Ups");
            }
            if(zwyciezca)
            {
                restart();
                string gracz;
                if (uzytkownik)
                    gracz = "O";
                else
                    gracz = "X";
                MessageBox.Show("Gracz " +gracz + " Wygral!", "Gratulacje!");
            }
        }
        private void restart()
        {
            foreach(Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                catch
                {

                }
            }
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            licznik = 0;
            uzytkownik = true;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch
                {

                }
            }
        }
    }
}
