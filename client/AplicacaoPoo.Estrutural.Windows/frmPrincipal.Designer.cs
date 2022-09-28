namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conversorDeModasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversorDeModasToolStripMenuItem,
            this.comissionamentoToolStripMenuItem,
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conversorDeModasToolStripMenuItem
            // 
            this.conversorDeModasToolStripMenuItem.Name = "conversorDeModasToolStripMenuItem";
            this.conversorDeModasToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.conversorDeModasToolStripMenuItem.Text = "Conversor de Modas ";
            this.conversorDeModasToolStripMenuItem.Click += new System.EventHandler(this.conversorDeModasToolStripMenuItem_Click);
            // 
            // comissionamentoToolStripMenuItem
            // 
            this.comissionamentoToolStripMenuItem.Name = "comissionamentoToolStripMenuItem";
            this.comissionamentoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.comissionamentoToolStripMenuItem.Text = "Comissionamento";
            this.comissionamentoToolStripMenuItem.Click += new System.EventHandler(this.comissionamentoToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Clientes";
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem1.Text = "Funcionários";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 175);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversorDeModasToolStripMenuItem;
        private ToolStripMenuItem comissionamentoToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem1;
    }
}