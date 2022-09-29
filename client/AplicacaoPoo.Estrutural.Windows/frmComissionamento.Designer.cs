namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissionamento
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
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitarioDaPeca = new System.Windows.Forms.TextBox();
            this.txtCodigoDaPeca = new System.Windows.Forms.TextBox();
            this.cmbVendedoresCadastrados = new System.Windows.Forms.ComboBox();
            this.LBLVendedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(12, 41);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.PlaceholderText = "Quantidade Vendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(112, 23);
            this.txtQuantidadeVendida.TabIndex = 0;
            // 
            // txtPrecoUnitarioDaPeca
            // 
            this.txtPrecoUnitarioDaPeca.Location = new System.Drawing.Point(12, 99);
            this.txtPrecoUnitarioDaPeca.Name = "txtPrecoUnitarioDaPeca";
            this.txtPrecoUnitarioDaPeca.PlaceholderText = "Preço Unitário ";
            this.txtPrecoUnitarioDaPeca.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoUnitarioDaPeca.TabIndex = 1;
            // 
            // txtCodigoDaPeca
            // 
            this.txtCodigoDaPeca.Location = new System.Drawing.Point(12, 70);
            this.txtCodigoDaPeca.Name = "txtCodigoDaPeca";
            this.txtCodigoDaPeca.PlaceholderText = "Código Da Peça";
            this.txtCodigoDaPeca.Size = new System.Drawing.Size(112, 23);
            this.txtCodigoDaPeca.TabIndex = 2;
            this.txtCodigoDaPeca.TextChanged += new System.EventHandler(this.txtCodigoDaPeca_TextChanged);
            // 
            // cmbVendedoresCadastrados
            // 
            this.cmbVendedoresCadastrados.FormattingEnabled = true;
            this.cmbVendedoresCadastrados.Items.AddRange(new object[] {
            "Aika ",
            "Eduardo",
            "Gabriel",
            "Luiza",
            "Miriam",
            "Reuber",
            "Ryan",
            "Samara",
            "Shamyra",
            "Sophie",
            "",
            ""});
            this.cmbVendedoresCadastrados.Location = new System.Drawing.Point(92, 12);
            this.cmbVendedoresCadastrados.Name = "cmbVendedoresCadastrados";
            this.cmbVendedoresCadastrados.Size = new System.Drawing.Size(121, 23);
            this.cmbVendedoresCadastrados.TabIndex = 3;
            // 
            // LBLVendedor
            // 
            this.LBLVendedor.AutoSize = true;
            this.LBLVendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLVendedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLVendedor.Location = new System.Drawing.Point(1, 13);
            this.LBLVendedor.Name = "LBLVendedor";
            this.LBLVendedor.Size = new System.Drawing.Size(85, 19);
            this.LBLVendedor.TabIndex = 4;
            this.LBLVendedor.Text = "VENDEDOR:";
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(352, 169);
            this.Controls.Add(this.LBLVendedor);
            this.Controls.Add(this.cmbVendedoresCadastrados);
            this.Controls.Add(this.txtCodigoDaPeca);
            this.Controls.Add(this.txtPrecoUnitarioDaPeca);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Name = "frmComissionamento";
            this.Text = "frmComissionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtQuantidadeVendida;
        private TextBox txtPrecoUnitarioDaPeca;
        private TextBox txtCodigoDaPeca;
        private ComboBox cmbVendedoresCadastrados;
        private Label LBLVendedor;
    }
}