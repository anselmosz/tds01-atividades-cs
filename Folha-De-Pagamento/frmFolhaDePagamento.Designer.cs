namespace Folha_De_Pagamento
{
    partial class frmFolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaDePagamento));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSalarioInput = new System.Windows.Forms.Label();
            this.lblClube = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblImpostoDeRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiq = new System.Windows.Forms.Label();
            this.cmbClubes = new System.Windows.Forms.ComboBox();
            this.txtbSalarioInput = new System.Windows.Forms.TextBox();
            this.txtbImpostoDeRenda = new System.Windows.Forms.TextBox();
            this.txtbSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtbSalarioLiq = new System.Windows.Forms.TextBox();
            this.ckbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.dtpcDataFolha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(483, 41);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 45);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(483, 136);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 45);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(483, 232);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(41, 24);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 20);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data da Folha";
            // 
            // lblSalarioInput
            // 
            this.lblSalarioInput.AutoSize = true;
            this.lblSalarioInput.Location = new System.Drawing.Point(40, 91);
            this.lblSalarioInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioInput.Name = "lblSalarioInput";
            this.lblSalarioInput.Size = new System.Drawing.Size(58, 20);
            this.lblSalarioInput.TabIndex = 4;
            this.lblSalarioInput.Text = "Salário";
            // 
            // lblClube
            // 
            this.lblClube.AutoSize = true;
            this.lblClube.Location = new System.Drawing.Point(41, 232);
            this.lblClube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClube.Name = "lblClube";
            this.lblClube.Size = new System.Drawing.Size(110, 20);
            this.lblClube.TabIndex = 5;
            this.lblClube.Text = "Clube de lazer";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(250, 24);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(128, 20);
            this.lblSalarioBruto.TabIndex = 6;
            this.lblSalarioBruto.Text = "Salario em Folha";
            // 
            // lblImpostoDeRenda
            // 
            this.lblImpostoDeRenda.AutoSize = true;
            this.lblImpostoDeRenda.Location = new System.Drawing.Point(250, 91);
            this.lblImpostoDeRenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpostoDeRenda.Name = "lblImpostoDeRenda";
            this.lblImpostoDeRenda.Size = new System.Drawing.Size(141, 20);
            this.lblImpostoDeRenda.TabIndex = 7;
            this.lblImpostoDeRenda.Text = "Imposto de Renda";
            // 
            // lblSalarioLiq
            // 
            this.lblSalarioLiq.AutoSize = true;
            this.lblSalarioLiq.Location = new System.Drawing.Point(250, 234);
            this.lblSalarioLiq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiq.Name = "lblSalarioLiq";
            this.lblSalarioLiq.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiq.TabIndex = 8;
            this.lblSalarioLiq.Text = "Salário Líquido";
            // 
            // cmbClubes
            // 
            this.cmbClubes.FormattingEnabled = true;
            this.cmbClubes.Items.AddRange(new object[] {
            "Nenhum",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cmbClubes.Location = new System.Drawing.Point(45, 257);
            this.cmbClubes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClubes.Name = "cmbClubes";
            this.cmbClubes.Size = new System.Drawing.Size(117, 28);
            this.cmbClubes.TabIndex = 3;
            // 
            // txtbSalarioInput
            // 
            this.txtbSalarioInput.Location = new System.Drawing.Point(45, 114);
            this.txtbSalarioInput.Name = "txtbSalarioInput";
            this.txtbSalarioInput.Size = new System.Drawing.Size(117, 26);
            this.txtbSalarioInput.TabIndex = 1;
            this.txtbSalarioInput.TextChanged += new System.EventHandler(this.txtbSalarioInput_TextChanged);
            // 
            // txtbImpostoDeRenda
            // 
            this.txtbImpostoDeRenda.Enabled = false;
            this.txtbImpostoDeRenda.Location = new System.Drawing.Point(254, 114);
            this.txtbImpostoDeRenda.Name = "txtbImpostoDeRenda";
            this.txtbImpostoDeRenda.Size = new System.Drawing.Size(151, 26);
            this.txtbImpostoDeRenda.TabIndex = 12;
            // 
            // txtbSalarioBruto
            // 
            this.txtbSalarioBruto.Enabled = false;
            this.txtbSalarioBruto.Location = new System.Drawing.Point(254, 47);
            this.txtbSalarioBruto.Name = "txtbSalarioBruto";
            this.txtbSalarioBruto.Size = new System.Drawing.Size(151, 26);
            this.txtbSalarioBruto.TabIndex = 13;
            // 
            // txtbSalarioLiq
            // 
            this.txtbSalarioLiq.Enabled = false;
            this.txtbSalarioLiq.Location = new System.Drawing.Point(254, 257);
            this.txtbSalarioLiq.Name = "txtbSalarioLiq";
            this.txtbSalarioLiq.Size = new System.Drawing.Size(151, 26);
            this.txtbSalarioLiq.TabIndex = 14;
            // 
            // ckbPlanoDeSaude
            // 
            this.ckbPlanoDeSaude.AutoSize = true;
            this.ckbPlanoDeSaude.Location = new System.Drawing.Point(45, 184);
            this.ckbPlanoDeSaude.Name = "ckbPlanoDeSaude";
            this.ckbPlanoDeSaude.Size = new System.Drawing.Size(141, 24);
            this.ckbPlanoDeSaude.TabIndex = 2;
            this.ckbPlanoDeSaude.Text = "Plano de Saúde";
            this.ckbPlanoDeSaude.UseVisualStyleBackColor = true;
            // 
            // dtpcDataFolha
            // 
            this.dtpcDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcDataFolha.Location = new System.Drawing.Point(45, 48);
            this.dtpcDataFolha.Name = "dtpcDataFolha";
            this.dtpcDataFolha.Size = new System.Drawing.Size(117, 26);
            this.dtpcDataFolha.TabIndex = 0;
            this.dtpcDataFolha.TabStop = false;
            // 
            // frmFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.dtpcDataFolha);
            this.Controls.Add(this.ckbPlanoDeSaude);
            this.Controls.Add(this.txtbSalarioLiq);
            this.Controls.Add(this.txtbSalarioBruto);
            this.Controls.Add(this.txtbImpostoDeRenda);
            this.Controls.Add(this.txtbSalarioInput);
            this.Controls.Add(this.cmbClubes);
            this.Controls.Add(this.lblSalarioLiq);
            this.Controls.Add(this.lblImpostoDeRenda);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblClube);
            this.Controls.Add(this.lblSalarioInput);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFolhaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSalarioInput;
        private System.Windows.Forms.Label lblClube;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblImpostoDeRenda;
        private System.Windows.Forms.Label lblSalarioLiq;
        private System.Windows.Forms.ComboBox cmbClubes;
        private System.Windows.Forms.TextBox txtbSalarioInput;
        private System.Windows.Forms.TextBox txtbImpostoDeRenda;
        private System.Windows.Forms.TextBox txtbSalarioBruto;
        private System.Windows.Forms.TextBox txtbSalarioLiq;
        private System.Windows.Forms.CheckBox ckbPlanoDeSaude;
        private System.Windows.Forms.DateTimePicker dtpcDataFolha;
    }
}