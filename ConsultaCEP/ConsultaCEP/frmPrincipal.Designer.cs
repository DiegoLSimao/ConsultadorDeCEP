namespace ConsultaCEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grbCEP = new System.Windows.Forms.GroupBox();
            this.lblTempoConsulta = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtSiafi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtIbge = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblSiafi = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblIBGE = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExportarTxt = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.grbCEP.SuspendLayout();
            this.grbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCEP
            // 
            this.grbCEP.Controls.Add(this.lblTempoConsulta);
            this.grbCEP.Controls.Add(this.txtCEP);
            this.grbCEP.Location = new System.Drawing.Point(15, 12);
            this.grbCEP.Name = "grbCEP";
            this.grbCEP.Size = new System.Drawing.Size(159, 65);
            this.grbCEP.TabIndex = 1;
            this.grbCEP.TabStop = false;
            this.grbCEP.Text = "CEP";
            // 
            // lblTempoConsulta
            // 
            this.lblTempoConsulta.AutoSize = true;
            this.lblTempoConsulta.Location = new System.Drawing.Point(6, 42);
            this.lblTempoConsulta.Name = "lblTempoConsulta";
            this.lblTempoConsulta.Size = new System.Drawing.Size(16, 13);
            this.lblTempoConsulta.TabIndex = 8;
            this.lblTempoConsulta.Text = "...";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 19);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(135, 20);
            this.txtCEP.TabIndex = 0;
            this.txtCEP.ValidatingType = typeof(int);
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.txtComplemento);
            this.grbResultado.Controls.Add(this.txtSiafi);
            this.grbResultado.Controls.Add(this.txtGia);
            this.grbResultado.Controls.Add(this.txtIbge);
            this.grbResultado.Controls.Add(this.txtDDD);
            this.grbResultado.Controls.Add(this.txtEstado);
            this.grbResultado.Controls.Add(this.txtCidade);
            this.grbResultado.Controls.Add(this.txtBairro);
            this.grbResultado.Controls.Add(this.txtEndereco);
            this.grbResultado.Controls.Add(this.lblSiafi);
            this.grbResultado.Controls.Add(this.lblGia);
            this.grbResultado.Controls.Add(this.lblDDD);
            this.grbResultado.Controls.Add(this.lblIBGE);
            this.grbResultado.Controls.Add(this.lblComplemento);
            this.grbResultado.Controls.Add(this.lblEstado);
            this.grbResultado.Controls.Add(this.lblBairro);
            this.grbResultado.Controls.Add(this.lblCidade);
            this.grbResultado.Controls.Add(this.lblEndereco);
            this.grbResultado.Location = new System.Drawing.Point(18, 83);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(347, 190);
            this.grbResultado.TabIndex = 2;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(198, 71);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(143, 20);
            this.txtComplemento.TabIndex = 17;
            // 
            // txtSiafi
            // 
            this.txtSiafi.Location = new System.Drawing.Point(240, 149);
            this.txtSiafi.Name = "txtSiafi";
            this.txtSiafi.Size = new System.Drawing.Size(101, 20);
            this.txtSiafi.TabIndex = 16;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(133, 149);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(101, 20);
            this.txtGia.TabIndex = 15;
            // 
            // txtIbge
            // 
            this.txtIbge.Location = new System.Drawing.Point(23, 149);
            this.txtIbge.Name = "txtIbge";
            this.txtIbge.Size = new System.Drawing.Size(101, 20);
            this.txtIbge.TabIndex = 14;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(240, 110);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(101, 20);
            this.txtDDD.TabIndex = 13;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(128, 110);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(106, 20);
            this.txtEstado.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(21, 110);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(101, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(21, 71);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(168, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(21, 32);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(320, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // lblSiafi
            // 
            this.lblSiafi.AutoSize = true;
            this.lblSiafi.Location = new System.Drawing.Point(241, 133);
            this.lblSiafi.Name = "lblSiafi";
            this.lblSiafi.Size = new System.Drawing.Size(27, 13);
            this.lblSiafi.TabIndex = 8;
            this.lblSiafi.Text = "Siafi";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(133, 133);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(23, 13);
            this.lblGia.TabIndex = 7;
            this.lblGia.Text = "Gia";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(237, 94);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 6;
            this.lblDDD.Text = "DDD";
            // 
            // lblIBGE
            // 
            this.lblIBGE.AutoSize = true;
            this.lblIBGE.Location = new System.Drawing.Point(20, 133);
            this.lblIBGE.Name = "lblIBGE";
            this.lblIBGE.Size = new System.Drawing.Size(32, 13);
            this.lblIBGE.TabIndex = 5;
            this.lblIBGE.Text = "IBGE";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(195, 55);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(39, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Compl.";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(125, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(18, 55);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(18, 94);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(18, 16);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(194, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(170, 42);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar CEP";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExportarTxt
            // 
            this.btnExportarTxt.Location = new System.Drawing.Point(21, 292);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(84, 28);
            this.btnExportarTxt.TabIndex = 4;
            this.btnExportarTxt.Text = "Exportar";
            this.btnExportarTxt.UseVisualStyleBackColor = true;
            this.btnExportarTxt.Click += new System.EventHandler(this.btnExportarTxt_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(111, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 28);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(195, 292);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(82, 28);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Informação";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(283, 293);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(76, 27);
            this.btnConsultas.TabIndex = 7;
            this.btnConsultas.Text = "Consultados";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExportarTxt);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.grbCEP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Consulta CEP - Diego de Lima Simão";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grbCEP.ResumeLayout(false);
            this.grbCEP.PerformLayout();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbCEP;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.Label lblSiafi;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblIBGE;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExportarTxt;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtSiafi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtIbge;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Label lblTempoConsulta;
    }
}

