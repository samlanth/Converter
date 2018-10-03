namespace TP_DE_CONVERSION
{
    partial class Gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flashButton5 = new Calculator.FlashButton();
            this.flashButton4 = new Calculator.FlashButton();
            this.flashButton3 = new Calculator.FlashButton();
            this.flashButton2 = new Calculator.FlashButton();
            this.flashButton1 = new Calculator.FlashButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unité de mesure";
            // 
            // flashButton5
            // 
            this.flashButton5.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.QuestionMark;
            this.flashButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton5.ClickedImage = null;
            this.flashButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashButton5.DisabledImage = null;
            this.flashButton5.Image = ((System.Drawing.Image)(resources.GetObject("flashButton5.Image")));
            this.flashButton5.Location = new System.Drawing.Point(172, 9);
            this.flashButton5.Name = "flashButton5";
            this.flashButton5.NeutralImage = null;
            this.flashButton5.OverImage = null;
            this.flashButton5.Size = new System.Drawing.Size(49, 36);
            this.flashButton5.TabIndex = 6;
            this.flashButton5.Text = "flashButton5";
            this.flashButton5.UseVisualStyleBackColor = true;
            this.flashButton5.Click += new System.EventHandler(this.flashButton5_Click);
            this.flashButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton5_MouseDown);
            this.flashButton5.MouseLeave += new System.EventHandler(this.flashButton5_MouseLeave);
            this.flashButton5.MouseHover += new System.EventHandler(this.flashButton5_MouseHover);
            // 
            // flashButton4
            // 
            this.flashButton4.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.ICON_Editer_Neutre;
            this.flashButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton4.ClickedImage = null;
            this.flashButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashButton4.DisabledImage = null;
            this.flashButton4.Image = ((System.Drawing.Image)(resources.GetObject("flashButton4.Image")));
            this.flashButton4.Location = new System.Drawing.Point(172, 93);
            this.flashButton4.Name = "flashButton4";
            this.flashButton4.NeutralImage = null;
            this.flashButton4.OverImage = null;
            this.flashButton4.Size = new System.Drawing.Size(49, 36);
            this.flashButton4.TabIndex = 5;
            this.flashButton4.Text = "flashButton4";
            this.flashButton4.UseVisualStyleBackColor = true;
            this.flashButton4.Click += new System.EventHandler(this.flashButton4_Click);
            this.flashButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton4_MouseDown);
            this.flashButton4.MouseLeave += new System.EventHandler(this.flashButton4_MouseLeave);
            this.flashButton4.MouseHover += new System.EventHandler(this.flashButton4_MouseHover);
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.return_button;
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton3.ClickedImage = null;
            this.flashButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashButton3.DisabledImage = null;
            this.flashButton3.Image = ((System.Drawing.Image)(resources.GetObject("flashButton3.Image")));
            this.flashButton3.Location = new System.Drawing.Point(172, 177);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.NeutralImage = null;
            this.flashButton3.OverImage = null;
            this.flashButton3.Size = new System.Drawing.Size(49, 36);
            this.flashButton3.TabIndex = 4;
            this.flashButton3.Text = "flashButton3";
            this.flashButton3.UseVisualStyleBackColor = true;
            this.flashButton3.Click += new System.EventHandler(this.flashButton3_Click);
            this.flashButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton3_MouseDown);
            this.flashButton3.MouseLeave += new System.EventHandler(this.flashButton3_MouseLeave);
            this.flashButton3.MouseHover += new System.EventHandler(this.flashButton3_MouseHover);
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.ICON_Effacer_Neutral;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton2.ClickedImage = null;
            this.flashButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashButton2.DisabledImage = null;
            this.flashButton2.Image = ((System.Drawing.Image)(resources.GetObject("flashButton2.Image")));
            this.flashButton2.Location = new System.Drawing.Point(172, 135);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.NeutralImage = null;
            this.flashButton2.OverImage = null;
            this.flashButton2.Size = new System.Drawing.Size(49, 36);
            this.flashButton2.TabIndex = 3;
            this.flashButton2.Text = "flashButton2";
            this.flashButton2.UseVisualStyleBackColor = true;
            this.flashButton2.Click += new System.EventHandler(this.flashButton2_Click);
            this.flashButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton2_MouseDown);
            this.flashButton2.MouseLeave += new System.EventHandler(this.flashButton2_MouseLeave);
            this.flashButton2.MouseHover += new System.EventHandler(this.flashButton2_MouseHover);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.ICON_Ajouter_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(172, 51);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(49, 36);
            this.flashButton1.TabIndex = 2;
            this.flashButton1.Text = "flashButton1";
            this.flashButton1.UseVisualStyleBackColor = true;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            this.flashButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton1_MouseDown);
            this.flashButton1.MouseLeave += new System.EventHandler(this.flashButton1_MouseLeave);
            this.flashButton1.MouseHover += new System.EventHandler(this.flashButton1_MouseHover);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 216);
            this.Controls.Add(this.flashButton5);
            this.Controls.Add(this.flashButton4);
            this.Controls.Add(this.flashButton3);
            this.Controls.Add(this.flashButton2);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Gestion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gestion des Unités";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.Enter += new System.EventHandler(this.Gestion_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private Calculator.FlashButton flashButton1;
        private Calculator.FlashButton flashButton2;
        private Calculator.FlashButton flashButton3;
        private Calculator.FlashButton flashButton4;
        private Calculator.FlashButton flashButton5;
    }
}