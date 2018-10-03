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
    public partial class Modifier : Form
    {
        private Unit unitToModify = null;
        public Modifier(Unit U)
        {
            InitializeComponent();
            unitToModify = U;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void flashButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flashButton2_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.return_button2;
        }

        private void flashButton2_MouseHover(object sender, EventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.return_button4;
        }

        private void flashButton2_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.return_button;
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.flashButton1, "Accepter la modification et revenir a la gestion");
            toolTip1.SetToolTip(this.flashButton2, "Annuler et revenir a la gestion");

            textBox1.Text = unitToModify.Name;
            textBox2.Text = unitToModify.MetricValue.ToString();
            if (unitToModify.Type == UnitType.Volume)
            {
                RB_VOLUME.Checked = true;
            }
            if (unitToModify.Type == UnitType.Distance)
            {
                RB_DISTANCE.Checked = true;
            }
            if (unitToModify.Type == UnitType.Poids)
            {
                RB_POIDS.Checked = true;
            }
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            UnitConverter.CONVERTER.DeleteByName(unitToModify.Name);
            UnitConverter.CONVERTER.Add(new Unit { Type = UnitType.Volume, Name = textBox1.Text, MetricValue = decimal.Parse(textBox2.Text) });
           
            this.Close();
        }

        private void RB_DISTANCE_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Valeur Métrique (metre)";
        }

        private void RB_POIDS_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Valeur Métrique (kilogramme)";
        }

        private void RB_VOLUME_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Valeur Métrique (litre)";
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Over;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Neutral;
        }

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Click;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox2.Text) == false)
            {
                flashButton1.Enabled = true;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Neutral;
            }
            else
            {
                flashButton1.Enabled = false;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Disable;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                flashButton1.Enabled = true;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Neutral;
            }
            else
            {
                flashButton1.Enabled = false;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Disable;
            }
        }
    }
}
