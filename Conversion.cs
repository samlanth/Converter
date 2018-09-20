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
    public partial class Conversion : Form
    {
        public string DisplayName { get; set; }

        private ToolTip toolTip;

        public Conversion()
        {
            InitializeComponent();
        }

        private void btn_conversion_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_effacer_val_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        /* ---------------------------BTN_CONVERSION---------------------------- */
        private void btn_conversion_MouseHover(object sender, EventArgs e)
        {
            this.btn_conversion.BackgroundImage = Properties.Resources.Icon_Survolé;
        }

        private void btn_conversion_MouseLeave(object sender, EventArgs e)
        {
            this.btn_conversion.BackgroundImage = Properties.Resources.Icon_Neutral;
        }

        private void btn_conversion_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_conversion.BackgroundImage = Properties.Resources.Icon_Cliqué;
        }
        /* ---------------------------BTN_CONVERSION---------------------------- */
        /* ---------------------------BTN_QUITTER---------------------------- */
        private void btn_quitter_MouseHover(object sender, EventArgs e)
        {
            this.btn_quitter.BackgroundImage = Properties.Resources.ICON_Annuler_Over;
        }

        private void btn_quitter_MouseLeave(object sender, EventArgs e)
        {
            this.btn_quitter.BackgroundImage = Properties.Resources.ICON_Annuler_Neutral;
        }

        private void btn_quitter_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_quitter.BackgroundImage = Properties.Resources.ICON_Annuler_Click;
        }
        /* ---------------------------BTN_QUITTER---------------------------- */
        /* --------------------------- BTN_EFFACER---------------------------- */
        private void btn_effacer_val_MouseHover(object sender, EventArgs e)
        {
            this.btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Over;
        }

        private void btn_effacer_val_MouseLeave(object sender, EventArgs e)
        {
            this.btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Neutral;
        }

        private void btn_effacer_val_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Click;
        }
        /* --------------------------- BTN_EFFACER---------------------------- */
    }
}
