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

        private void label1_Click(object sender, EventArgs e)
        {

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
            this.flashButton2.BackgroundImage = Properties.Resources.Button_Exit_Click;
        }

        private void flashButton2_MouseHover(object sender, EventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.Button_Exit_Hover;
        }

        private void flashButton2_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.Button_Exit_Neutral;
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
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Neutral;
        }
    }
    
}
