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

        private void Modifier_Load(object sender, EventArgs e)
        {
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
    }
}
