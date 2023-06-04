namespace ControleFinanceiro
{
    partial class HomeView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.dataGridReceitas = new System.Windows.Forms.DataGridView();
            this.dataGridDespesas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonAddReceita = new System.Windows.Forms.ToolStripButton();
            this.buttonAddDespesa = new System.Windows.Forms.ToolStripButton();
            this.buttonUpdate = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.searchTextField = new System.Windows.Forms.ToolStripTextBox();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.labelEntradas = new System.Windows.Forms.Label();
            this.labelSaidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridReceitas
            // 
            this.dataGridReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceitas.Location = new System.Drawing.Point(22, 68);
            this.dataGridReceitas.Name = "dataGridReceitas";
            this.dataGridReceitas.RowTemplate.Height = 25;
            this.dataGridReceitas.Size = new System.Drawing.Size(500, 324);
            this.dataGridReceitas.TabIndex = 0;
            // 
            // dataGridDespesas
            // 
            this.dataGridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDespesas.Location = new System.Drawing.Point(570, 68);
            this.dataGridDespesas.Name = "dataGridDespesas";
            this.dataGridDespesas.RowTemplate.Height = 25;
            this.dataGridDespesas.Size = new System.Drawing.Size(500, 324);
            this.dataGridDespesas.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAddReceita,
            this.buttonAddDespesa,
            this.buttonUpdate,
            this.buttonDelete,
            this.searchTextField,
            this.buttonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1110, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonAddReceita
            // 
            this.buttonAddReceita.AccessibleDescription = "Botão para adicionar nova receita";
            this.buttonAddReceita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddReceita.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddReceita.Image")));
            this.buttonAddReceita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddReceita.Name = "buttonAddReceita";
            this.buttonAddReceita.Size = new System.Drawing.Size(24, 24);
            this.buttonAddReceita.Text = "toolStripButton1";
            this.buttonAddReceita.Click += new System.EventHandler(this.buttonAddReceita_Click);
            // 
            // buttonAddDespesa
            // 
            this.buttonAddDespesa.AccessibleDescription = "Botão para adicionar nova despesa";
            this.buttonAddDespesa.AccessibleName = "buttonAddDespesa";
            this.buttonAddDespesa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddDespesa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddDespesa.Image")));
            this.buttonAddDespesa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddDespesa.Name = "buttonAddDespesa";
            this.buttonAddDespesa.Size = new System.Drawing.Size(24, 24);
            this.buttonAddDespesa.Text = "toolStripButton1";
            this.buttonAddDespesa.Click += new System.EventHandler(this.buttonAddDespesa_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(24, 24);
            this.buttonUpdate.Text = "toolStripButton1";
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(24, 24);
            this.buttonDelete.Text = "toolStripButton1";
            // 
            // searchTextField
            // 
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.Size = new System.Drawing.Size(100, 27);
            // 
            // buttonSearch
            // 
            this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(24, 24);
            this.buttonSearch.Text = "toolStripButton1";
            // 
            // labelEntradas
            // 
            this.labelEntradas.AutoSize = true;
            this.labelEntradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradas.Location = new System.Drawing.Point(22, 41);
            this.labelEntradas.Name = "labelEntradas";
            this.labelEntradas.Size = new System.Drawing.Size(76, 21);
            this.labelEntradas.TabIndex = 3;
            this.labelEntradas.Text = "Entradas";
            // 
            // labelSaidas
            // 
            this.labelSaidas.AutoSize = true;
            this.labelSaidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidas.Location = new System.Drawing.Point(570, 41);
            this.labelSaidas.Name = "labelSaidas";
            this.labelSaidas.Size = new System.Drawing.Size(59, 21);
            this.labelSaidas.TabIndex = 4;
            this.labelSaidas.Text = "Saidas";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 507);
            this.Controls.Add(this.labelSaidas);
            this.Controls.Add(this.labelEntradas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridDespesas);
            this.Controls.Add(this.dataGridReceitas);
            this.Name = "HomeView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridReceitas;
        private DataGridView dataGridDespesas;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonAddReceita;
        private ToolStripButton buttonAddDespesa;
        private ToolStripButton buttonUpdate;
        private ToolStripButton buttonDelete;
        private ToolStripTextBox searchTextField;
        private ToolStripButton buttonSearch;
        private Label labelEntradas;
        private Label labelSaidas;
    }
}