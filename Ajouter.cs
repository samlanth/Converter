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
    public partial class Ajouter : Form
    {
        private string DisplayName { get; set; }
        public Ajouter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Ajouter_Unité()
        {
            Ajouter dlg = new Ajouter();
            dlg.DisplayName = DisplayName;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DisplayName = dlg.DisplayName;
            }
        }
        private void flashButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Click;
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

        private void flashButton1_Click(object sender, EventArgs e)
        {
            if (RB_DISTANCE.Checked)
            {
                UnitConverter.CONVERTER.Add(new Unit { Type = UnitType.Distance, Name = textBox1.Text, MetricValue = Decimal.Parse(textBox2.Text) });

                this.Close();

            }
            if (RB_POIDS.Checked)
            {
                UnitConverter.CONVERTER.Add(new Unit { Type = UnitType.Poids, Name = textBox1.Text, MetricValue = Decimal.Parse(textBox2.Text) });
                this.Close();

            }
            if (RB_VOLUME.Checked)
            {
                UnitConverter.CONVERTER.Add(new Unit { Type = UnitType.Volume, Name = textBox1.Text, MetricValue = Decimal.Parse(textBox2.Text) });
                this.Close();

            }
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                flashButton1.Enabled = true;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Neutral;

            }

        }

        private void RB_POIDS_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Valeur Métrique (Kilogramme)";
        }

        private void RB_DISTANCE_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Valeur Métrique (Metre)";
        }

        private void RB_VOLUME_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Valeur Métrique (Litre)";
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Over;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                flashButton1.Enabled = true;
                this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Neutral;
            }
            else
            {
                flashButton1.Enabled = false;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Disable;
            }
            
        }

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Click;
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.flashButton1, "Accepter l'ajout et revenir a la gestion");
            toolTip1.SetToolTip(this.flashButton2, "Annuler et revenir a la gestion");
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                
                flashButton1.Enabled = false;
                flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Disable;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false)
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
            catch
            {
                MessageBox.Show("erreur");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if  (string.IsNullOrEmpty(textBox2.Text) == false && string.IsNullOrEmpty(textBox1.Text) == false)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flashButton1.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flashButton1.PerformClick();
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
    }
    
}
