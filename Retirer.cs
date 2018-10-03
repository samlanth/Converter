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
    public partial class Retirer : Form
    {
        private Unit unitToDelete = null;
        public Retirer(Unit U)
        {
            unitToDelete = U;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            UnitConverter.CONVERTER.DeleteByName(unitToDelete.Name);
            this.Close();
            //this.Update();
        }

        private void Retirer_Load(object sender, EventArgs e)
        {
            textBox1.Text = unitToDelete.Name;
            textBox2.Text = unitToDelete.MetricValue.ToString();
            textBox3.Text = unitToDelete.Type.ToString();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.flashButton1, "Accepter de retirer l'unité et revenir a la gestion");
            toolTip1.SetToolTip(this.flashButton2, "Annuler et revenir a la gestion");

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

        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Accepter_Click;
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
