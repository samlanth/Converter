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
    public partial class Gestion : Form
    {

        public string DisplayName { get; set; }

        public Gestion()
        {
            InitializeComponent();
        }
        private void Ajouter_Unité()
        {
            Ajouter dlg = new Ajouter();
            

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
            }
        }
        private void Retirer_Unité()
        {

            Retirer dlg = new Retirer(listBox1.SelectedItem as Unit);


            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void Modifier_Unité()
        {
            Modifier dlg = new Modifier(listBox1.SelectedItem as Unit);


            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                Unit unit = (Unit)listBox1.SelectedItem;
         
           // LBL_UnitName.Text = unit.Name;
            //LBL_UnitType.Text = unit.Type.ToString();
            //LBL_UnitMetricValue.Text = unit.MetricValue.ToString(); ;
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            foreach (Unit unit in CONVERTER.GetAllUnits())
            {
                listBox1.Items.Add(unit);            
            }
            listBox1.SelectedIndex = 0;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.flashButton1, "Ajouter une Unité");
            toolTip1.SetToolTip(this.flashButton2, "Retirer une Unité");
            toolTip1.SetToolTip(this.flashButton4, "Modifier une Unité");

        }
//        ---------------------EFFACER---------------------------------------
        private void flashButton2_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.ICON_Effacer_Click;
        }

        private void flashButton2_MouseHover(object sender, EventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.ICON_Effacer_Over;
        }

        private void flashButton2_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton2.BackgroundImage = Properties.Resources.ICON_Effacer_Neutral;
        }
        //        ---------------------EFFACER---------------------------------------
        //        ---------------------AJOUTER---------------------------------------
        private void flashButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Ajouter_Click;
        }

        private void flashButton1_MouseHover(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Ajouter_Over;
        }

        private void flashButton1_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton1.BackgroundImage = Properties.Resources.ICON_Ajouter_Neutral;
        }

        private void flashButton3_MouseDown(object sender, MouseEventArgs e)
        {

            this.Close();
            this.flashButton3.BackgroundImage = Properties.Resources.Button_Exit_Click;
        }

        private void flashButton3_MouseHover(object sender, EventArgs e)
        {
            this.flashButton3.BackgroundImage = Properties.Resources.Button_Exit_Hover;
        }

        private void flashButton3_MouseLeave(object sender, EventArgs e)
        {
            this.flashButton3.BackgroundImage = Properties.Resources.Button_Exit_Neutral;
        }

        private void flashButton4_Click(object sender, EventArgs e)
        {
            Modifier_Unité();
            listBox1.Items.Clear();
            foreach (Unit unit in CONVERTER.GetAllUnits())
            {
                listBox1.Items.Add(unit);
            }

        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            Ajouter_Unité();

            listBox1.Items.Clear();
            foreach (Unit unit in CONVERTER.GetAllUnits())
            {
                listBox1.Items.Add(unit);
            }
            listBox1.SelectedIndex = 0;
        }

        private void flashButton2_Click(object sender, EventArgs e)
        {
            Retirer_Unité();
            listBox1.Items.Clear();
            foreach (Unit unit in CONVERTER.GetAllUnits())
            {
                listBox1.Items.Add(unit);
            }

        }

        private void Gestion_Enter(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Unit unit in CONVERTER.GetAllUnits())
            {
                listBox1.Items.Add(unit);
           
            }
        }
        //        ---------------------AJOUTER---------------------------------------
    }
}
