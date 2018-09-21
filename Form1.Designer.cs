namespace TP_DE_CONVERSION
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesUnitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerUneConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LB_EFFECTUER_CONVERSION = new System.Windows.Forms.Label();
            this.LB_GÉRER = new System.Windows.Forms.Label();
            this.flashButton1 = new Calculator.FlashButton();
            this.flashButton3 = new Calculator.FlashButton();
            this.BTN_CONVERSION = new Calculator.FlashButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesUnitésToolStripMenuItem,
            this.effectuerUneConversionToolStripMenuItem,
            this.quitterToolStripMenuItem2});
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.quitterToolStripMenuItem.Text = "Formulaire de l’application ";
            // 
            // gérerLesUnitésToolStripMenuItem
            // 
            this.gérerLesUnitésToolStripMenuItem.Name = "gérerLesUnitésToolStripMenuItem";
            this.gérerLesUnitésToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.gérerLesUnitésToolStripMenuItem.Text = "Effectuer une conversion";
            this.gérerLesUnitésToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUnitésToolStripMenuItem_Click);
            // 
            // effectuerUneConversionToolStripMenuItem
            // 
            this.effectuerUneConversionToolStripMenuItem.Name = "effectuerUneConversionToolStripMenuItem";
            this.effectuerUneConversionToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.effectuerUneConversionToolStripMenuItem.Text = "Gérer les unités de mesure";
            // 
            // quitterToolStripMenuItem2
            // 
            this.quitterToolStripMenuItem2.Name = "quitterToolStripMenuItem2";
            this.quitterToolStripMenuItem2.Size = new System.Drawing.Size(212, 22);
            this.quitterToolStripMenuItem2.Text = "Quitter";
            this.quitterToolStripMenuItem2.Click += new System.EventHandler(this.quitterToolStripMenuItem2_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // LB_EFFECTUER_CONVERSION
            // 
            this.LB_EFFECTUER_CONVERSION.AutoSize = true;
            this.LB_EFFECTUER_CONVERSION.Location = new System.Drawing.Point(12, 105);
            this.LB_EFFECTUER_CONVERSION.Name = "LB_EFFECTUER_CONVERSION";
            this.LB_EFFECTUER_CONVERSION.Size = new System.Drawing.Size(126, 13);
            this.LB_EFFECTUER_CONVERSION.TabIndex = 6;
            this.LB_EFFECTUER_CONVERSION.Text = "Effectuer une conversion";
            // 
            // LB_GÉRER
            // 
            this.LB_GÉRER.AutoSize = true;
            this.LB_GÉRER.Location = new System.Drawing.Point(212, 105);
            this.LB_GÉRER.Name = "LB_GÉRER";
            this.LB_GÉRER.Size = new System.Drawing.Size(82, 13);
            this.LB_GÉRER.TabIndex = 8;
            this.LB_GÉRER.Text = "Gérer les Unités";
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.Button_Exit_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Location = new System.Drawing.Point(408, 121);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(79, 29);
            this.flashButton1.TabIndex = 9;
            this.flashButton1.Text = "flashButton1";
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            this.flashButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton1_MouseDown);
            this.flashButton1.MouseLeave += new System.EventHandler(this.flashButton1_MouseLeave);
            this.flashButton1.MouseHover += new System.EventHandler(this.flashButton1_MouseHover);
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.ICON_Editer_Neutre;
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton3.ClickedImage = null;
            this.flashButton3.DisabledImage = null;
            this.flashButton3.Location = new System.Drawing.Point(239, 54);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.NeutralImage = null;
            this.flashButton3.OverImage = null;
            this.flashButton3.Size = new System.Drawing.Size(36, 36);
            this.flashButton3.TabIndex = 5;
            this.flashButton3.Text = "flashButton3";
            this.flashButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton3_MouseDown);
            this.flashButton3.MouseLeave += new System.EventHandler(this.flashButton3_MouseLeave);
            this.flashButton3.MouseHover += new System.EventHandler(this.flashButton3_MouseHover);
            // 
            // BTN_CONVERSION
            // 
            this.BTN_CONVERSION.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.Icon_Neutral;
            this.BTN_CONVERSION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONVERSION.ClickedImage = null;
            this.BTN_CONVERSION.DisabledImage = null;
            this.BTN_CONVERSION.Location = new System.Drawing.Point(58, 54);
            this.BTN_CONVERSION.Name = "BTN_CONVERSION";
            this.BTN_CONVERSION.NeutralImage = null;
            this.BTN_CONVERSION.OverImage = null;
            this.BTN_CONVERSION.Size = new System.Drawing.Size(36, 36);
            this.BTN_CONVERSION.TabIndex = 3;
            this.BTN_CONVERSION.Text = "flashButton1";
            this.BTN_CONVERSION.Click += new System.EventHandler(this.BTN_CONVERSION_Click);
            this.BTN_CONVERSION.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_CONVERSION_MouseDown);
            this.BTN_CONVERSION.MouseLeave += new System.EventHandler(this.BTN_CONVERSION_MouseLeave);
            this.BTN_CONVERSION.MouseHover += new System.EventHandler(this.BTN_CONVERSION_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 162);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.LB_GÉRER);
            this.Controls.Add(this.LB_EFFECTUER_CONVERSION);
            this.Controls.Add(this.flashButton3);
            this.Controls.Add(this.BTN_CONVERSION);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Accueil de l’application ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Calculator.FlashButton BTN_CONVERSION;
        private Calculator.FlashButton flashButton3;
        private System.Windows.Forms.ToolStripMenuItem gérerLesUnitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectuerUneConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem2;
        private System.Windows.Forms.Label LB_EFFECTUER_CONVERSION;
        private System.Windows.Forms.Label LB_GÉRER;
        private Calculator.FlashButton flashButton1;
    }
}

