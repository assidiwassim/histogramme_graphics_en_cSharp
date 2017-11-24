using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace histogramme
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form22_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;

            string[] Ville = new string[14];
            Ville[0] = "Monastir";
            Ville[1] = "Tunis";
            Ville[2] = "Nabel";
            Ville[3] = "Jerba";
            Ville[4] = "Kasserine";
            Ville[5] = "Touzer";
            Ville[6] = "Gafssa";
            Ville[7] = "Ariana";
            Ville[8] = "Manouba";

            Ville[9] = "Kasserine";
            Ville[10] = "Touzer";
            Ville[11] = "Gafssa";
            Ville[12] = "Ariana";
            Ville[13] = "Manouba";

            int[] nbrHabitant = new int[14];
            nbrHabitant[0] = 50;
            nbrHabitant[1] = 100;
            nbrHabitant[2] = 150;
            nbrHabitant[3] = 0;
            nbrHabitant[4] = 200;
            nbrHabitant[5] = 10;
            nbrHabitant[6] = 200;
            nbrHabitant[7] = 100;
            nbrHabitant[8] = 80;

            nbrHabitant[9] = 200;
            nbrHabitant[10] = 10;
            nbrHabitant[11] = 200;
            nbrHabitant[12] = 100;
            nbrHabitant[13] = 80;

            Histogramme H = new Histogramme(l, nbrHabitant, Ville);
            H.setTitle("Histogramme nombre habitants par Ville");
            H.Show();

        }

    }
}
