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

        /*
        float nmr, ans;
        int count;
        */

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOutput.Text += 9;
        }

        */
        /*
        private void btnlomeno_Click(object sender, EventArgs e)
        {
            nmr = float.Parse(txtOutput.Text);
            txtOutput.Clear();
            txtOutput.Focus();
            count = 4;
            label1.Text = nmr.ToString() + "/";
        }

        private void btnhvezda_Click(object sender, EventArgs e)
        {
            nmr = float.Parse(txtOutput.Text);
            txtOutput.Clear();
            txtOutput.Focus();
            count = 3;
            label1.Text = nmr.ToString() + "*";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            nmr = float.Parse(txtOutput.Text);
            txtOutput.Clear();
            txtOutput.Focus();
            count = 1;
            label1.Text = nmr.ToString() + "+";
        }
        */
        /*
        private void btnequal_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }
        */
        /*
        private void btnminus_Click(object sender, EventArgs e)
        {
            nmr = float.Parse(txtOutput.Text);
            txtOutput.Clear();
            txtOutput.Focus();
            count = 2;
            label1.Text = nmr.ToString() + "-";
        }
        */

        /*
        private void btncarka_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + ",";
        }
        */

        /*
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            label1.Text = "";
        }
        */

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

            // Když už je jedna desetinná čárka napsaná, tak se další nenapíše.
            if (txtOutput.Text.Contains(",") && stisknuto == ",")
                return;

            // Když je napsaná jen nula, tak se vymaže,
            // aby se napsal stisknutý znak.
            // Když je stisknuta desetinná čárka, tak se nula nevymaže.
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
            // Když se dělí nulou, tak se zachytí výjimka.
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

        /*
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
        */

        private void NastavOperaci(Operace operace)
        {
            kalkulacka.cislo1 = double.Parse(txtOutput.Text, CultureInfo.GetCultureInfo("cs"));

            kalkulacka.Operace = operace;

            txtOutput.Text = "0";
        }
    }
}

