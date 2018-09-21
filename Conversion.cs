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
            RB_Distance.Checked = false;
            RB_POIDS.Checked = false;
            RB_Volume.Checked = false;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            TB_Values.Text = "1";
            Resultat_Conversion.Text = "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Volume.Checked)
            {        
            // Volume impérial UK/US
                comboBox1.Items.Clear();
                comboBox1.Items.Add("litres");
                comboBox1.Text = "litres";
                comboBox1.Items.Add("millilitres");
                comboBox1.Items.Add(" mètres cube");
                comboBox1.Items.Add("centimètres cube");
                comboBox1.Items.Add("onces UK");
                comboBox1.Items.Add("onces US");
                comboBox1.Items.Add("pintes US");
                comboBox1.Items.Add("pintes UK");
                comboBox1.Items.Add("pouces cube");
                comboBox1.Items.Add("pieds cube");
                comboBox1.Items.Add("gallons US");
                comboBox1.Items.Add("gallons UK");
                comboBox1.Items.Add("barils de pétrole");

                comboBox2.Items.Clear();
                comboBox2.Items.Add("litres");
                comboBox2.Text = "millilitres";
                comboBox2.Items.Add("millilitres");
                comboBox2.Items.Add(" mètres cube");
                comboBox2.Items.Add("centimètres cube");
                comboBox2.Items.Add("onces UK");
                comboBox2.Items.Add("onces US");
                comboBox2.Items.Add("pintes US");
                comboBox2.Items.Add("pintes UK");
                comboBox2.Items.Add("pouces cube");
                comboBox2.Items.Add("pieds cube");
                comboBox2.Items.Add("gallons US");
                comboBox2.Items.Add("gallons UK");
                comboBox2.Items.Add("barils de pétrole");

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 1;
            }
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
          //  this.btn_quitter.BackgroundImage = Properties.Resources.ICON_Annuler_Over;
        }

        private void btn_quitter_MouseLeave(object sender, EventArgs e)
        {
          //  this.btn_quitter.BackgroundImage = Properties.Resources.ICON_Annuler_Neutral;
        }

        private void btn_quitter_MouseDown(object sender, MouseEventArgs e)
        {
           // this.btn_quitter.BackgroundImage = Properties.Resources.ICON_Annuler_Click;
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

        private void TB_Values_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.Button_Exit_Click;
            this.Close();
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.Button_Exit_Hover;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.Button_Exit_Neutral;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RB_POIDS_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_POIDS.Checked)
            {

                comboBox1.Items.Clear();
         
                comboBox1.Items.Add("kilogrammes");
                comboBox1.Text = "kilogrammes";
                comboBox1.Items.Add("grammes");
                comboBox1.Items.Add("milligrammes");
                comboBox1.Items.Add("tonnes");
                comboBox1.Items.Add("Livre");
                comboBox1.Items.Add("onces");
                comboBox1.Items.Add("tonnes UK");
                comboBox1.Items.Add("tonnes US");

                comboBox2.Items.Clear();
                comboBox2.Items.Add("kilogrammes");
                comboBox2.Text = "grammes";
                comboBox2.Items.Add("grammes");
                comboBox2.Items.Add("milligrammes");
                comboBox2.Items.Add("tonnes");
                comboBox2.Items.Add("Livre");
                comboBox2.Items.Add("onces");
                comboBox2.Items.Add("tonnes UK");
                comboBox2.Items.Add("tonnes US");

                comboBox1.SelectedIndex = 1;
                comboBox2.SelectedIndex = 2;
            }
        }

        private void RB_Distance_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Distance.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("kilomètres");
                comboBox1.Text = "kilomètres";
                comboBox1.Items.Add("mètres");
                comboBox1.Items.Add("centimètres");
                comboBox1.Items.Add("millimètres");
                comboBox1.Items.Add("Pied");

                // Distance impériale UK/US
                comboBox1.Items.Add("pieds");
                comboBox1.Items.Add("pouces");
                comboBox1.Items.Add("verges");
                comboBox1.Items.Add("milles");
                comboBox1.Items.Add("milles marin");

                comboBox2.Items.Clear();
                comboBox2.Items.Add("kilomètres");
                comboBox2.Text = "kilomètres";
                comboBox2.Items.Add("mètres");
                comboBox2.Items.Add("centimètres");
                comboBox2.Items.Add("millimètres");
                comboBox2.Items.Add("Pied");

                // Distance impériale UK/US
                comboBox2.Items.Add("pieds");
                comboBox2.Items.Add("pouces");
                comboBox2.Items.Add("verges");
                comboBox2.Items.Add("milles");
                comboBox2.Items.Add("milles marin");

                comboBox1.SelectedIndex = 1;
                comboBox2.SelectedIndex = 2;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resultat_Conversion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
