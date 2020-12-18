using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Speler Knight = new Speler("Knight", 100);
        Speler Archer = new Speler("Archer", 100);

        

        public void Button_Archer_Click(object sender, EventArgs e)
        {
            Knight.HitPoints = Knight.HitPoints - Archer.Attack();

            HP_Knight.Text = Knight.HitPoints.ToString();

            Button_Archer.Enabled = false;
            Button_Knight.Enabled = true;
        }
     
        private void Button_Knight_Click(object sender, EventArgs e)
        {
            
            Archer.HitPoints = Archer.HitPoints - Knight.Attack();

            HP_Archer.Text = Archer.HitPoints.ToString();

            Button_Archer.Enabled = true;
            Button_Knight.Enabled = false;
        }

    }
}
