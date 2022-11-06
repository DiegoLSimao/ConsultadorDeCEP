namespace ConsultaCEP
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.tlsFerramentas = new System.Windows.Forms.ToolStrip();
            this.tlsbtnSelecionar = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnFechar = new System.Windows.Forms.ToolStripSplitButton();
            this.grvDados = new System.Windows.Forms.DataGridView();
            this.tslProgresso = new System.Windows.Forms.ToolStripLabel();
            this.tlsFerramentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsFerramentas
            // 
            this.tlsFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnSelecionar,
            this.tlsbtnFechar,
            this.tslProgresso});
            this.tlsFerramentas.Location = new System.Drawing.Point(0, 0);
            this.tlsFerramentas.Name = "tlsFerramentas";
            this.tlsFerramentas.Size = new System.Drawing.Size(1149, 25);
            this.tlsFerramentas.TabIndex = 0;
            this.tlsFerramentas.Text = "toolStrip1";
            // 
            // tlsbtnSelecionar
            // 
            this.tlsbtnSelecionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnSelecionar.Image = global::ConsultaCEP.Properties.Resources.save;
            this.tlsbtnSelecionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnSelecionar.Name = "tlsbtnSelecionar";
            this.tlsbtnSelecionar.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnSelecionar.Text = "toolStripButton1";
            this.tlsbtnSelecionar.Click += new System.EventHandler(this.tlsbtnSelecionar_Click);
            // 
            // tlsbtnFechar
            // 
            this.tlsbtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnFechar.Image = global::ConsultaCEP.Properties.Resources.close;
            this.tlsbtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnFechar.Name = "tlsbtnFechar";
            this.tlsbtnFechar.Size = new System.Drawing.Size(32, 22);
            this.tlsbtnFechar.Text = "toolStripSplitButton1";
            this.tlsbtnFechar.ButtonClick += new System.EventHandler(this.tlsbtnFechar_ButtonClick);
            // 
            // grvDados
            // 
            this.grvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDados.Location = new System.Drawing.Point(13, 28);
            this.grvDados.Name = "grvDados";
            this.grvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDados.Size = new System.Drawing.Size(1124, 372);
            this.grvDados.TabIndex = 2;
            // 
            // tslProgresso
            // 
            this.tslProgresso.Name = "tslProgresso";
            this.tslProgresso.Size = new System.Drawing.Size(59, 22);
            this.tslProgresso.Text = "progresso";
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 412);
            this.Controls.Add(this.grvDados);
            this.Controls.Add(this.tlsFerramentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar";
            this.Text = "Buscar";
            this.tlsFerramentas.ResumeLayout(false);
            this.tlsFerramentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsFerramentas;
        private System.Windows.Forms.ToolStripButton tlsbtnSelecionar;
        private System.Windows.Forms.ToolStripSplitButton tlsbtnFechar;
        private System.Windows.Forms.DataGridView grvDados;
        private System.Windows.Forms.ToolStripLabel tslProgresso;
    }
}