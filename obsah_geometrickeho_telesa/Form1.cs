using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace obsah_geometrickeho_telesa
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buttonPocitej_Click(sender, e);
        }

        private void textInStrana_TextChanged(object sender, EventArgs e)
        {
            buttonPocitej_Click(sender, e);
        }

        private void buttonPocitej_Click(object sender, EventArgs e)
        {
            textInStrana.Text = textInStrana.Text.Replace(" ", "");
            textInJednotky.Text = textInJednotky.Text.Replace(" ", "");
            if (textInStrana.Text != "" && textInJednotky.Text != "")
            {
                double strana = Convert.ToInt32(textInStrana.Text);

                double obvod = 5 * strana;
                double obsahspravne = Math.Round((Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Math.Pow(strana, 2), 5, MidpointRounding.AwayFromZero);

                string outtextobsah = $"Obsah: {obsahspravne} {textInJednotky.Text}";
                string outtextobvod = $"Obsah: {obvod} {textInJednotky.Text}";

                textOut.Text = outtextobsah;
                textOut.Text += Environment.NewLine;
                textOut.Text += outtextobvod;
            }
            else
            {
                textOut.Text = "zadej všechny parametry";
            }
        }
    }
}