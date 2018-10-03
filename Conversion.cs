using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UnitConverter;

namespace TP_DE_CONVERSION
{
    public partial class Conversion : Form
    {
        public string DisplayName { get; set; }


        public Conversion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_conversion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text) == true)
            {
                Resultat_Conversion.Text = "";
            }
            else
            {
                Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
            }
            btn_conversion.Enabled = false;
            btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Disabled;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_effacer_val_Click(object sender, EventArgs e)
        {
            TB_Values.Text = "";
            Resultat_Conversion.Text = "";

            if (string.IsNullOrEmpty(TB_Values.Text) == false)
            {
                btn_conversion.Enabled = true;
                btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Neutral;
                btn_effacer_val.Enabled = true;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Neutral;
            }
            else
            {
                btn_conversion.Enabled = false;
                btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Disabled;
                btn_effacer_val.Enabled = false;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Disable;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Volume.Checked)
            {
                // Volume impérial UK/US
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                foreach (Unit unit in CONVERTER.GetUnitsByType(UnitType.Volume))
                {
                    comboBox1.Items.Add(unit);
                    comboBox2.Items.Add(unit);
                }
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 4;
            }
        }
        /* ---------------------------BTN_CONVERSION---------------------------- */
        private void btn_conversion_MouseHover(object sender, EventArgs e)
        {
            
                this.btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Over;
        }

        private void btn_conversion_MouseLeave(object sender, EventArgs e)
        {
            
                this.btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Neutral;
        }

        private void btn_conversion_MouseDown(object sender, MouseEventArgs e)
        {
            
                this.btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Clicked;
        }
        /* ---------------------------BTN_CONVERSION---------------------------- */
        
        /* --------------------------- BTN_EFFACER---------------------------- */
        private void btn_effacer_val_MouseHover(object sender, EventArgs e)
        {
            this.btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Over;
        }

        private void btn_effacer_val_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text) == false)
            {
                btn_effacer_val.Enabled = true;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Neutral;
            }
            else
            {
                btn_effacer_val.Enabled = false;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Disable;
            }
        }

        private void btn_effacer_val_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Click;
        }
        /* --------------------------- BTN_EFFACER---------------------------- */

        private void TB_Values_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Un '.' uniquement
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (string.IsNullOrEmpty(TB_Values.Text) == false)
            {
                btn_conversion.Enabled = true;
                btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Neutral;
                btn_effacer_val.Enabled = true;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Neutral;
            }
            else
            {
                btn_conversion.Enabled = false;
                btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Disabled;
                btn_effacer_val.Enabled = false;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Disable;
            }
        }

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.return_button2;
           
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.return_button4;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.return_button;
        }

        private void RB_POIDS_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_POIDS.Checked)
            {

                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                foreach (Unit unit in CONVERTER.GetUnitsByType(UnitType.Poids))
                {
                    comboBox1.Items.Add(unit);
                    comboBox2.Items.Add(unit);
                }
                comboBox1.SelectedIndex = 1;
                comboBox2.SelectedIndex = 2;
            }
        }

        private void RB_Distance_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Distance.Checked)
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                foreach (Unit unit in CONVERTER.GetUnitsByType(UnitType.Distance))
                {
                    comboBox1.Items.Add(unit);
                    comboBox2.Items.Add(unit);
                }
                comboBox1.SelectedIndex = 1;
                comboBox2.SelectedIndex = 2;
            }
        }

        private void TB_Values_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TB_Values.Text))
                {
                    Resultat_Conversion.Text = "";
                }
                else
                {
                   Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
                }

                if (string.IsNullOrEmpty(TB_Values.Text) == false)
                {
                    btn_conversion.Enabled = true;
                    btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Neutral;
                    btn_effacer_val.Enabled = true;
                    btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Neutral;
                }
                else
                {
                    btn_conversion.Enabled = false;
                    btn_conversion.BackgroundImage = Properties.Resources.convert_Icon_Disabled;
                    btn_effacer_val.Enabled = false;
                    btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Disable;

                }
            }
            catch
            {
                MessageBox.Show("Valeur entrer est invalide");
            }
        }

        private void RB_Volume_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text))
            {
            }
            else
            {
                Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
            }
        }

        private void RB_POIDS_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text))
            {
            }
            else
            {
                Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
            }
        }

        private void RB_Distance_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text))
            {
            }
            else
            {
                Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text))
            {
            }
            else
            {
                Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text))
            {
            }
            else
            {
                Resultat_Conversion.Text = CONVERTER.Convert(decimal.Parse(TB_Values.Text), CONVERTER.GetUnitByName(comboBox1.Text), CONVERTER.GetUnitByName(comboBox2.Text));
            }
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Values.Text))
            {
                btn_conversion.Enabled = false;
                btn_conversion.BackgroundImage  = Properties.Resources.convert_Icon_Disabled;
                btn_effacer_val.Enabled = false;
                btn_effacer_val.BackgroundImage = Properties.Resources.ICON_Effacer_Disable;
            }
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
