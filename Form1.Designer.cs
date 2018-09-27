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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesUnitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerUneConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesUnitésToolStripMenuItem,
            this.effectuerUneConversionToolStripMenuItem,
            this.quitterToolStripMenuItem2});
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.quitterToolStripMenuItem.Text = "Action";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gérerLesUnitésToolStripMenuItem
            // 
            this.gérerLesUnitésToolStripMenuItem.Name = "gérerLesUnitésToolStripMenuItem";
            this.gérerLesUnitésToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.gérerLesUnitésToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.gérerLesUnitésToolStripMenuItem.Text = "Effectuer une conversion";
            this.gérerLesUnitésToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUnitésToolStripMenuItem_Click);
            // 
            // effectuerUneConversionToolStripMenuItem
            // 
            this.effectuerUneConversionToolStripMenuItem.Name = "effectuerUneConversionToolStripMenuItem";
            this.effectuerUneConversionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.effectuerUneConversionToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.effectuerUneConversionToolStripMenuItem.Text = "Gérer les unités de mesure";
            this.effectuerUneConversionToolStripMenuItem.Click += new System.EventHandler(this.effectuerUneConversionToolStripMenuItem_Click_1);
            // 
            // quitterToolStripMenuItem2
            // 
            this.quitterToolStripMenuItem2.Name = "quitterToolStripMenuItem2";
            this.quitterToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem2.Size = new System.Drawing.Size(250, 22);
            this.quitterToolStripMenuItem2.Text = "Quitter";
            this.quitterToolStripMenuItem2.Click += new System.EventHandler(this.quitterToolStripMenuItem2_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.Button_Exit_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(273, 35);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(92, 73);
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
            this.flashButton3.Image = ((System.Drawing.Image)(resources.GetObject("flashButton3.Image")));
            this.flashButton3.Location = new System.Drawing.Point(164, 43);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.NeutralImage = null;
            this.flashButton3.OverImage = null;
            this.flashButton3.Size = new System.Drawing.Size(74, 65);
            this.flashButton3.TabIndex = 5;
            this.flashButton3.Text = "flashButton3";
            this.flashButton3.Click += new System.EventHandler(this.flashButton3_Click);
            this.flashButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flashButton3_MouseDown);
            this.flashButton3.MouseLeave += new System.EventHandler(this.flashButton3_MouseLeave);
            this.flashButton3.MouseHover += new System.EventHandler(this.flashButton3_MouseHover);
            // 
            // BTN_CONVERSION
            // 
            this.BTN_CONVERSION.BackgroundImage = global::TP_DE_CONVERSION.Properties.Resources.convert_Icon_Neutral;
            this.BTN_CONVERSION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CONVERSION.ClickedImage = null;
            this.BTN_CONVERSION.DisabledImage = null;
            this.BTN_CONVERSION.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CONVERSION.Image")));
            this.BTN_CONVERSION.Location = new System.Drawing.Point(42, 35);
            this.BTN_CONVERSION.Name = "BTN_CONVERSION";
            this.BTN_CONVERSION.NeutralImage = null;
            this.BTN_CONVERSION.OverImage = null;
            this.BTN_CONVERSION.Size = new System.Drawing.Size(81, 73);
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
            this.ClientSize = new System.Drawing.Size(391, 136);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.flashButton3);
            this.Controls.Add(this.BTN_CONVERSION);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Conversion";
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
        private Calculator.FlashButton flashButton1;
    }
}

