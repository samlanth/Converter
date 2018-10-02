namespace TP_DE_CONVERSION
{
    partial class Modifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RB_POIDS = new System.Windows.Forms.RadioButton();
            this.RB_DISTANCE = new System.Windows.Forms.RadioButton();
            this.RB_VOLUME = new System.Windows.Forms.RadioButton();
            this.flashButton2 = new Calculator.FlashButton();
            this.flashButton1 = new Calculator.FlashButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valeur Métrique Unitaire";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // RB_POIDS
            // 
            this.RB_POIDS.AutoCheck = false;
            this.RB_POIDS.AutoSize = true;
            this.RB_POIDS.Location = new System.Drawing.Point(158, 12);
            this.RB_POIDS.Name = "RB_POIDS";
            this.RB_POIDS.Size = new System.Drawing.Size(51, 17);
            this.RB_POIDS.TabIndex = 11;
            this.RB_POIDS.TabStop = true;
            this.RB_POIDS.Text = "Poids";
            this.RB_POIDS.UseVisualStyleBackColor = true;
            this.RB_POIDS.CheckedChanged += new System.EventHandler(this.RB_POIDS_CheckedChanged);
            // 
            // RB_DISTANCE
            // 
            this.RB_DISTANCE.AutoCheck = false;
            this.RB_DISTANCE.AutoSize = true;
            this.RB_DISTANCE.Location = new System.Drawing.Point(85, 12);
            this.RB_DISTANCE.Name = "RB_DISTANCE";
            this.RB_DISTANCE.Size = new System.Drawing.Size(67, 17);
            this.RB_DISTANCE.TabIndex = 10;
            this.RB_DISTANCE.TabStop = true;
            this.RB_DISTANCE.Text = "Distance";
            this.RB_DISTANCE.UseVisualStyleBackColor = true;
            this.RB_DISTANCE.CheckedChanged += new System.EventHandler(this.RB_DISTANCE_CheckedChanged);
            // 
            // RB_VOLUME
            // 
            this.RB_VOLUME.AutoCheck = false;
            this.RB_VOLUME.AutoSize = true;
            this.RB_VOLUME.Location = new System.Drawing.Point(12, 12);
            this.RB_VOLUME.Name = "RB_VOLUME";
            this.RB_VOLUME.Size = new System.Drawing.Size(60, 17);
            this.RB_VOLUME.TabIndex = 9;
            this.RB_VOLUME.TabStop = true;
            this.RB_VOLUME.Text = "Volume";
            this.RB_VOLUME.UseVisualStyleBackColor = true;
            this.RB_VOLUME.CheckedChanged += new System.EventHandler(this.RB_VOLUME_CheckedChanged);
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.Button_Exit_Neutral;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton2.ClickedImage = null;
            this.flashButton2.DisabledImage = null;
            this.flashButton2.Image = ((System.Drawing.Image)(resources.GetObject("flashButton2.Image")));
            this.flashButton2.Location = new System.Drawing.Point(105, 139);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.NeutralImage = null;
            this.flashButton2.OverImage = null;
            this.flashButton2.Size = new System.Drawing.Size(36, 36);
            this.flashButton2.TabIndex = 17;
            this.flashButton2.Text = "flashButton2";
            this.flashButton2.UseVisualStyleBackColor = true;
            this.flashButton2.Click += new System.EventHandler(this.flashButton2_Click);
            this.flashButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton2_MouseDown);
            this.flashButton2.MouseLeave += new System.EventHandler(this.flashButton2_MouseLeave);
            this.flashButton2.MouseHover += new System.EventHandler(this.flashButton2_MouseHover);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.ICON_Accepter_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(63, 139);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(36, 36);
            this.flashButton1.TabIndex = 16;
            this.flashButton1.Text = "flashButton1";
            this.flashButton1.UseVisualStyleBackColor = true;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 193);
            this.Controls.Add(this.flashButton2);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RB_POIDS);
            this.Controls.Add(this.RB_DISTANCE);
            this.Controls.Add(this.RB_VOLUME);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Calculator.FlashButton flashButton2;
        private Calculator.FlashButton flashButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RB_POIDS;
        private System.Windows.Forms.RadioButton RB_DISTANCE;
        private System.Windows.Forms.RadioButton RB_VOLUME;
    }
}