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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
    }
}
