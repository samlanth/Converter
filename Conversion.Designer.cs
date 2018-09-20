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
            this.LB_Unité_Final = new System.Windows.Forms.ListBox();
            this.LB_Unité_Départ = new System.Windows.Forms.ListBox();
            this.TB_Values = new System.Windows.Forms.TextBox();
            this.Resultat_Conversion = new System.Windows.Forms.TextBox();
            this.btn_conversion = new Calculator.FlashButton();
            this.btn_effacer_val = new Calculator.FlashButton();
            this.btn_quitter = new Calculator.FlashButton();
            this.SuspendLayout();
            // 
            // RB_Volume
            // 
            this.RB_Volume.AutoSize = true;
            this.RB_Volume.Location = new System.Drawing.Point(12, 12);
            this.RB_Volume.Name = "RB_Volume";
            this.RB_Volume.Size = new System.Drawing.Size(60, 17);
            this.RB_Volume.TabIndex = 0;
            this.RB_Volume.TabStop = true;
            this.RB_Volume.Text = "Volume";
            this.RB_Volume.UseVisualStyleBackColor = true;
            this.RB_Volume.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RB_POIDS
            // 
            this.RB_POIDS.AutoSize = true;
            this.RB_POIDS.Location = new System.Drawing.Point(109, 12);
            this.RB_POIDS.Name = "RB_POIDS";
            this.RB_POIDS.Size = new System.Drawing.Size(51, 17);
            this.RB_POIDS.TabIndex = 1;
            this.RB_POIDS.TabStop = true;
            this.RB_POIDS.Text = "Poids";
            this.RB_POIDS.UseVisualStyleBackColor = true;
            // 
            // RB_Distance
            // 
            this.RB_Distance.AutoSize = true;
            this.RB_Distance.Location = new System.Drawing.Point(196, 12);
            this.RB_Distance.Name = "RB_Distance";
            this.RB_Distance.Size = new System.Drawing.Size(67, 17);
            this.RB_Distance.TabIndex = 2;
            this.RB_Distance.TabStop = true;
            this.RB_Distance.Text = "Distance";
            this.RB_Distance.UseVisualStyleBackColor = true;
            // 
            // LB_Unité_Final
            // 
            this.LB_Unité_Final.FormattingEnabled = true;
            this.LB_Unité_Final.Location = new System.Drawing.Point(166, 74);
            this.LB_Unité_Final.Name = "LB_Unité_Final";
            this.LB_Unité_Final.Size = new System.Drawing.Size(120, 95);
            this.LB_Unité_Final.TabIndex = 3;
            // 
            // LB_Unité_Départ
            // 
            this.LB_Unité_Départ.FormattingEnabled = true;
            this.LB_Unité_Départ.Location = new System.Drawing.Point(12, 74);
            this.LB_Unité_Départ.Name = "LB_Unité_Départ";
            this.LB_Unité_Départ.Size = new System.Drawing.Size(120, 95);
            this.LB_Unité_Départ.TabIndex = 4;
            // 
            // TB_Values
            // 
            this.TB_Values.Location = new System.Drawing.Point(12, 194);
            this.TB_Values.Name = "TB_Values";
            this.TB_Values.Size = new System.Drawing.Size(100, 20);
            this.TB_Values.TabIndex = 5;
            // 
            // Resultat_Conversion
            // 
            this.Resultat_Conversion.Location = new System.Drawing.Point(186, 194);
            this.Resultat_Conversion.Name = "Resultat_Conversion";
            this.Resultat_Conversion.ReadOnly = true;
            this.Resultat_Conversion.Size = new System.Drawing.Size(100, 20);
            this.Resultat_Conversion.TabIndex = 6;
            // 
            // btn_conversion
            // 
            this.btn_conversion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conversion.BackgroundImage")));
            this.btn_conversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_conversion.ClickedImage = null;
            this.btn_conversion.DisabledImage = null;
            this.btn_conversion.Location = new System.Drawing.Point(135, 178);
            this.btn_conversion.Name = "btn_conversion";
            this.btn_conversion.NeutralImage = null;
            this.btn_conversion.OverImage = null;
            this.btn_conversion.Size = new System.Drawing.Size(36, 36);
            this.btn_conversion.TabIndex = 7;
            this.btn_conversion.Text = "flashButton1";
            this.btn_conversion.Click += new System.EventHandler(this.btn_conversion_Click);
            this.btn_conversion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_conversion_MouseDown);
            this.btn_conversion.MouseLeave += new System.EventHandler(this.btn_conversion_MouseLeave);
            this.btn_conversion.MouseHover += new System.EventHandler(this.btn_conversion_MouseHover);
            // 
            // btn_effacer_val
            // 
            this.btn_effacer_val.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_effacer_val.BackgroundImage")));
            this.btn_effacer_val.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_effacer_val.ClickedImage = null;
            this.btn_effacer_val.DisabledImage = null;
            this.btn_effacer_val.Location = new System.Drawing.Point(308, 178);
            this.btn_effacer_val.Name = "btn_effacer_val";
            this.btn_effacer_val.NeutralImage = null;
            this.btn_effacer_val.OverImage = null;
            this.btn_effacer_val.Size = new System.Drawing.Size(36, 36);
            this.btn_effacer_val.TabIndex = 8;
            this.btn_effacer_val.Text = "flashButton2";
            this.btn_effacer_val.Click += new System.EventHandler(this.btn_effacer_val_Click);
            this.btn_effacer_val.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_effacer_val_MouseDown);
            this.btn_effacer_val.MouseLeave += new System.EventHandler(this.btn_effacer_val_MouseLeave);
            this.btn_effacer_val.MouseHover += new System.EventHandler(this.btn_effacer_val_MouseHover);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quitter.BackgroundImage")));
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quitter.ClickedImage = null;
            this.btn_quitter.DisabledImage = null;
            this.btn_quitter.Location = new System.Drawing.Point(432, 12);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.NeutralImage = null;
            this.btn_quitter.OverImage = null;
            this.btn_quitter.Size = new System.Drawing.Size(36, 36);
            this.btn_quitter.TabIndex = 9;
            this.btn_quitter.Text = "flashButton3";
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            this.btn_quitter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_quitter_MouseDown);
            this.btn_quitter.MouseLeave += new System.EventHandler(this.btn_quitter_MouseLeave);
            this.btn_quitter.MouseHover += new System.EventHandler(this.btn_quitter_MouseHover);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_effacer_val);
            this.Controls.Add(this.btn_conversion);
            this.Controls.Add(this.Resultat_Conversion);
            this.Controls.Add(this.TB_Values);
            this.Controls.Add(this.LB_Unité_Départ);
            this.Controls.Add(this.LB_Unité_Final);
            this.Controls.Add(this.RB_Distance);
            this.Controls.Add(this.RB_POIDS);
            this.Controls.Add(this.RB_Volume);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_Volume;
        private System.Windows.Forms.RadioButton RB_POIDS;
        private System.Windows.Forms.RadioButton RB_Distance;
        private System.Windows.Forms.ListBox LB_Unité_Final;
        private System.Windows.Forms.ListBox LB_Unité_Départ;
        private System.Windows.Forms.TextBox TB_Values;
        private System.Windows.Forms.TextBox Resultat_Conversion;
        private Calculator.FlashButton btn_conversion;
        private Calculator.FlashButton btn_effacer_val;
        private Calculator.FlashButton btn_quitter;
    }
}