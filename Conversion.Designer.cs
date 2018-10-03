namespace TP_DE_CONVERSION
{
    partial class Conversion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversion));
            this.RB_Volume = new System.Windows.Forms.RadioButton();
            this.RB_POIDS = new System.Windows.Forms.RadioButton();
            this.RB_Distance = new System.Windows.Forms.RadioButton();
            this.TB_Values = new System.Windows.Forms.TextBox();
            this.Resultat_Conversion = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flashButton1 = new Calculator.FlashButton();
            this.btn_effacer_val = new Calculator.FlashButton();
            this.btn_conversion = new Calculator.FlashButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RB_Volume
            // 
            this.RB_Volume.AutoSize = true;
            this.RB_Volume.Location = new System.Drawing.Point(22, 42);
            this.RB_Volume.Name = "RB_Volume";
            this.RB_Volume.Size = new System.Drawing.Size(60, 17);
            this.RB_Volume.TabIndex = 1;
            this.RB_Volume.TabStop = true;
            this.RB_Volume.Text = "Volume";
            this.RB_Volume.UseVisualStyleBackColor = true;
            this.RB_Volume.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.RB_Volume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RB_Volume_MouseClick);
            // 
            // RB_POIDS
            // 
            this.RB_POIDS.AutoSize = true;
            this.RB_POIDS.Location = new System.Drawing.Point(138, 42);
            this.RB_POIDS.Name = "RB_POIDS";
            this.RB_POIDS.Size = new System.Drawing.Size(51, 17);
            this.RB_POIDS.TabIndex = 2;
            this.RB_POIDS.TabStop = true;
            this.RB_POIDS.Text = "Poids";
            this.RB_POIDS.UseVisualStyleBackColor = true;
            this.RB_POIDS.CheckedChanged += new System.EventHandler(this.RB_POIDS_CheckedChanged);
            this.RB_POIDS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RB_POIDS_MouseClick);
            // 
            // RB_Distance
            // 
            this.RB_Distance.AutoSize = true;
            this.RB_Distance.Location = new System.Drawing.Point(249, 42);
            this.RB_Distance.Name = "RB_Distance";
            this.RB_Distance.Size = new System.Drawing.Size(67, 17);
            this.RB_Distance.TabIndex = 3;
            this.RB_Distance.TabStop = true;
            this.RB_Distance.Text = "Distance";
            this.RB_Distance.UseVisualStyleBackColor = true;
            this.RB_Distance.CheckedChanged += new System.EventHandler(this.RB_Distance_CheckedChanged);
            this.RB_Distance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RB_Distance_MouseClick);
            // 
            // TB_Values
            // 
            this.TB_Values.Location = new System.Drawing.Point(22, 91);
            this.TB_Values.Name = "TB_Values";
            this.TB_Values.Size = new System.Drawing.Size(121, 20);
            this.TB_Values.TabIndex = 4;
            this.TB_Values.TextChanged += new System.EventHandler(this.TB_Values_TextChanged);
            this.TB_Values.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Values_KeyPress);
            // 
            // Resultat_Conversion
            // 
            this.Resultat_Conversion.Location = new System.Drawing.Point(195, 91);
            this.Resultat_Conversion.Name = "Resultat_Conversion";
            this.Resultat_Conversion.ReadOnly = true;
            this.Resultat_Conversion.Size = new System.Drawing.Size(121, 20);
            this.Resultat_Conversion.TabIndex = 6;
            this.Resultat_Conversion.TextChanged += new System.EventHandler(this.Resultat_Conversion_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.comboBox2.Location = new System.Drawing.Point(195, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sélection du type d’unité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Conversion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.Button_Exit_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(276, 151);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(82, 31);
            this.flashButton1.TabIndex = 9;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            this.flashButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton1_MouseDown);
            this.flashButton1.MouseLeave += new System.EventHandler(this.flashButton1_MouseLeave);
            this.flashButton1.MouseHover += new System.EventHandler(this.flashButton1_MouseHover);
            // 
            // btn_effacer_val
            // 
            this.btn_effacer_val.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.ICON_Effacer_Neutral;
            this.btn_effacer_val.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_effacer_val.ClickedImage = null;
            this.btn_effacer_val.DisabledImage = null;
            this.btn_effacer_val.Image = ((System.Drawing.Image)(resources.GetObject("btn_effacer_val.Image")));
            this.btn_effacer_val.Location = new System.Drawing.Point(322, 100);
            this.btn_effacer_val.Name = "btn_effacer_val";
            this.btn_effacer_val.NeutralImage = null;
            this.btn_effacer_val.OverImage = null;
            this.btn_effacer_val.Size = new System.Drawing.Size(36, 36);
            this.btn_effacer_val.TabIndex = 8;
            this.btn_effacer_val.Click += new System.EventHandler(this.btn_effacer_val_Click);
            this.btn_effacer_val.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_effacer_val_MouseDown);
            this.btn_effacer_val.MouseLeave += new System.EventHandler(this.btn_effacer_val_MouseLeave);
            this.btn_effacer_val.MouseHover += new System.EventHandler(this.btn_effacer_val_MouseHover);
            // 
            // btn_conversion
            // 
            this.btn_conversion.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.convert_Icon_Neutral;
            this.btn_conversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_conversion.ClickedImage = null;
            this.btn_conversion.DisabledImage = null;
            this.btn_conversion.Image = ((System.Drawing.Image)(resources.GetObject("btn_conversion.Image")));
            this.btn_conversion.Location = new System.Drawing.Point(153, 100);
            this.btn_conversion.Name = "btn_conversion";
            this.btn_conversion.NeutralImage = null;
            this.btn_conversion.OverImage = null;
            this.btn_conversion.Size = new System.Drawing.Size(36, 36);
            this.btn_conversion.TabIndex = 6;
            this.btn_conversion.Text = "flashButton1";
            this.btn_conversion.Click += new System.EventHandler(this.btn_conversion_Click);
            this.btn_conversion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_conversion_MouseDown);
            this.btn_conversion.MouseLeave += new System.EventHandler(this.btn_conversion_MouseLeave);
            this.btn_conversion.MouseHover += new System.EventHandler(this.btn_conversion_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resultat";
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_effacer_val);
            this.Controls.Add(this.btn_conversion);
            this.Controls.Add(this.Resultat_Conversion);
            this.Controls.Add(this.TB_Values);
            this.Controls.Add(this.RB_Distance);
            this.Controls.Add(this.RB_POIDS);
            this.Controls.Add(this.RB_Volume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Conversion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_Volume;
        private System.Windows.Forms.RadioButton RB_POIDS;
        private System.Windows.Forms.RadioButton RB_Distance;
        private System.Windows.Forms.TextBox TB_Values;
        private System.Windows.Forms.TextBox Resultat_Conversion;
        private Calculator.FlashButton btn_conversion;
        private Calculator.FlashButton btn_effacer_val;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private Calculator.FlashButton flashButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}