﻿namespace TP_DE_CONVERSION
{
    partial class Retirer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retirer));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flashButton2 = new Calculator.FlashButton();
            this.flashButton1 = new Calculator.FlashButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valeur Métrique Unitaire";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.Button_Exit_Neutral;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton2.ClickedImage = null;
            this.flashButton2.DisabledImage = null;
            this.flashButton2.Image = ((System.Drawing.Image)(resources.GetObject("flashButton2.Image")));
            this.flashButton2.Location = new System.Drawing.Point(94, 167);
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
            this.flashButton1.Location = new System.Drawing.Point(42, 167);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(36, 36);
            this.flashButton1.TabIndex = 16;
            this.flashButton1.Text = "flashButton1";
            this.flashButton1.UseVisualStyleBackColor = true;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Type";
            // 
            // Retirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.flashButton2);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Retirer";
            this.Text = "Retirer";
            this.Load += new System.EventHandler(this.Retirer_Load);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}