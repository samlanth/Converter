using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculator;

namespace TP_DE_CONVERSION
{
    public partial class Form1 : Form
    {
        private string DisplayName { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Effectuer_Conversion()
        {
            Conversion dlg = new Conversion();
            dlg.DisplayName = DisplayName;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DisplayName = dlg.DisplayName;
            }
        }



        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Effectuer_Conversion();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONVERSION_Click(object sender, EventArgs e)
        {
            Effectuer_Conversion();
        }

        private void gérerLesUnitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Effectuer_Conversion();
        }

        private void quitterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* ---------------------------BTN_CONVERSION---------------------------- */
        private void BTN_CONVERSION_MouseHover(object sender, EventArgs e)
        {
            this.BTN_CONVERSION.BackgroundImage = Properties.Resources.convert_Icon_Over;
        }

        private void BTN_CONVERSION_MouseLeave(object sender, EventArgs e)
        {
            this.BTN_CONVERSION.BackgroundImage = Properties.Resources.convert_Icon_Neutral; 
        }

        private void BTN_CONVERSION_MouseDown(object sender, MouseEventArgs e)
        {
            this.BTN_CONVERSION.BackgroundImage = Properties.Resources.convert_Icon_Clicked;
        }
        /* ---------------------------BTN_CONVERSION---------------------------- */

        /* ---------------------------BTN_GERER---------------------------- */
        private void flashButton3_MouseHover(object sender, EventArgs e)
        {
            this.flashButton3.BackgroundImage = Properties.Resources.ICON_Editer_Survol;
        }

        private void flashButton3_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton3.BackgroundImage = Properties.Resources.ICON_Editer_Neutre;
        }

        private void flashButton3_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton3.BackgroundImage = Properties.Resources.ICON_Editer_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.BTN_CONVERSION, "Conversion d'Unité");
            toolTip1.SetToolTip(this.flashButton3, "Ajouter une Unité");
            toolTip1.SetToolTip(this.flashButton1, "Quitter");
            
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.return_button4;
        }

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.return_button2;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.return_button;
        }
        private void Effectuer_Gestion()
        {
            Gestion dlg = new Gestion();
            dlg.DisplayName = DisplayName;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DisplayName = dlg.DisplayName;
            }
        }

        private void flashButton3_Click(object sender, EventArgs e)
        {
            Effectuer_Gestion();
        }

        private void effectuerUneConversionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Effectuer_Gestion();
        }
        /* ---------------------------BTN_GERER---------------------------- */
    }
}
