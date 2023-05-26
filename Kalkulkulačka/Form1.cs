using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulkulačka
{
    public partial class Form1 : Form
    {
        kalkulacka kalkulacka; 
        public Form1()
        {
            kalkulacka = new kalkulacka();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int length = txtOutput.TextLength - 1;
            string text = txtOutput.Text;
            txtOutput.Clear();
            for (int i = 0; i < length; i++)
            {
                txtOutput.Text = txtOutput.Text + text[i];
            }
        }

        private void btnklik(object sender, EventArgs e)
        {
            string stisknuto = ((Button)sender).Text;

            if (txtOutput.Text.Contains(",") && stisknuto == ",")
                return;

            if (txtOutput.Text == "0" && stisknuto != ",")
                txtOutput.Text = "";

            txtOutput.Text += stisknuto;
        }

        private void btnrovnasa(object sender, EventArgs e)
        {
            try
            {
                kalkulacka.cislo2 = double.Parse(txtOutput.Text,
                    CultureInfo.GetCultureInfo("cs"));

                kalkulacka.Vypocitej();
                txtOutput.Text = kalkulacka.Vysledek.ToString();
            }
            catch (Exception ex)
            {
                kalkulacka.Resetuj();

                txtOutput.Text = "0";

                MessageBox.Show(ex.Message);
            }
        }

        private void btnresetuj(object sender, EventArgs e)
        {
            kalkulacka.Resetuj();
            txtOutput.Text = "0";
        }

        private void btndeleno(object sender, EventArgs e)
        {
            label1.Text = txtOutput.Text + "/";
            NastavOperaci(Operace.Podil);
        }

        private void btnkrat(object sender, EventArgs e)
        {
            label1.Text = txtOutput.Text + "*";
            NastavOperaci(Operace.Soucin);
        }

        private void btnplus(object sender, EventArgs e)
        {
            label1.Text = txtOutput.Text + "+";
            NastavOperaci(Operace.Soucet);
        }

        private void btnminus(object sender, EventArgs e)
        {
            label1.Text = txtOutput.Text + "-";
            NastavOperaci(Operace.Rozdil);
        }

        
        public void compute()
        {
            switch (count)
            {
                case 1:

                    ans = nmr + float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                case 2:
                    ans = nmr - float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                case 3:
                    ans = nmr * float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                case 4:
                    ans = nmr / float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                default:
                    break;


            }
        }
        

        private void NastavOperaci(Operace operace)
        {
            kalkulacka.cislo1 = double.Parse(txtOutput.Text, CultureInfo.GetCultureInfo("cs"));

            kalkulacka.Operace = operace;

            txtOutput.Text = "0";
        }
    }
}

