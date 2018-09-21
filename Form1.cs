using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_DE_CONVERSION
{
    public partial class Form1 : Form
    {
        private string DisplayName { get; set; }

        public Form1()
        {
            InitializeComponent();
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

        private void effectuerUneConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Effectuer_Conversion();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flashButton2_Click(object sender, EventArgs e)
        {
            
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
            this.BTN_CONVERSION.BackgroundImage = Properties.Resources.Icon_Survolé;
        }

        private void BTN_CONVERSION_MouseLeave(object sender, EventArgs e)
        {
            this.BTN_CONVERSION.BackgroundImage = Properties.Resources.Icon_Neutral; 
        }

        private void BTN_CONVERSION_MouseDown(object sender, MouseEventArgs e)
        {
            this.BTN_CONVERSION.BackgroundImage = Properties.Resources.Icon_Cliqué;
        }
        /* ---------------------------BTN_CONVERSION---------------------------- */

        /* ---------------------------BTN_QUITTER---------------------------- */
        private void BTN_QUITTER_MouseHover(object sender, EventArgs e)
        {
           // this.BTN_QUITTER.BackgroundImage = Properties.Resources.ICON_Annuler_Over;
        }

        private void BTN_QUITTER_MouseLeave(object sender, EventArgs e)
        {
            //this.BTN_QUITTER.BackgroundImage = Properties.Resources.ICON_Annuler_Neutral;
        }

        private void BTN_QUITTER_MouseDown(object sender, MouseEventArgs e)
        {
           // this.BTN_QUITTER.BackgroundImage = Properties.Resources.ICON_Annuler_Click;
        }
        /* ---------------------------BTN_QUITTER---------------------------- */

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

        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.Button_Exit_Hover;
        }

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.Button_Exit_Click;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.Button_Exit_Neutral;
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();

        //    Form1


        //    this.ClientSize = new System.Drawing.Size(507, 261);
        //    this.Name = "Form1";
        //    this.ResumeLayout(false);

        //}
        /* ---------------------------BTN_GERER---------------------------- */

    }

}
