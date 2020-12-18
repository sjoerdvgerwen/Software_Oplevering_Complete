using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KoekjesController koekjesController = new KoekjesController();

        Upgrade upgradeBakker = new Upgrade("Bakker", 10, 100, 150);
        Upgrade upgradeOven = new Upgrade("Oven", 50, 2000, 450);
        Upgrade upgradeDeegroller = new Upgrade("Deegroller", 10, 3500, 700);



        public void ControleerUpgrades()
        {
            if (koekjesController.Koekjes >= upgradeBakker.Prijs)
            {
                buttonBakker.Enabled = true;
                
            }
            else
            {
                buttonBakker.Enabled = false;
            }
            if (koekjesController.Koekjes >= upgradeOven.Prijs)
            {
                buttonOven.Enabled = true;
            }
            else
            {
                buttonOven.Enabled = false;
            }
            if (koekjesController.Koekjes >= upgradeDeegroller.Prijs)
            {
                buttonDeegroller.Enabled = true;
            }
            else
            {
                buttonDeegroller.Enabled = false;
            }
        }




        private void pictureBox1_MouseDown(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes + koekjesController.KoekjesPerKlik;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBakker_Click(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes - upgradeBakker.Prijs;

            koekjesController.Kps = koekjesController.Kps + upgradeBakker.Kps;

            upgradeBakker.Prijs = upgradeBakker.Prijs + upgradeBakker.PrijsInterval;
        }

        private void buttonOven_Click(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes - upgradeOven.Prijs;

            koekjesController.Kps = koekjesController.Kps + upgradeOven.Kps;

            upgradeOven.Prijs = upgradeOven.Prijs + upgradeOven.PrijsInterval;
        }

        private void buttonDeegroller_Click(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes - upgradeDeegroller.Prijs;

            koekjesController.KoekjesPerKlik = koekjesController.KoekjesPerKlik + upgradeDeegroller.Kps;

            upgradeDeegroller.Prijs = upgradeDeegroller.Prijs + upgradeDeegroller.PrijsInterval;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            koekjesController.Koekjes = koekjesController.Koekjes + koekjesController.Kps;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            koekjesTb.Text = Convert.ToString(koekjesController.Koekjes);
            kpsTb.Text = Convert.ToString(koekjesController.Kps);
           

            ControleerUpgrades();
        }
    }
}
