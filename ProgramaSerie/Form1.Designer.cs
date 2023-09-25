namespace ProgramaSerie
{
    partial class frmSeries
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
            this.dgvSeries = new System.Windows.Forms.DataGridView();
            this.pbSeries = new System.Windows.Forms.PictureBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtbFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtbFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTemporadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeries
            // 
            this.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSeries.Location = new System.Drawing.Point(21, 103);
            this.dgvSeries.MultiSelect = false;
            this.dgvSeries.Name = "dgvSeries";
            this.dgvSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeries.Size = new System.Drawing.Size(599, 287);
            this.dgvSeries.TabIndex = 0;
            this.dgvSeries.SelectionChanged += new System.EventHandler(this.dgvSeries_SelectionChanged);
            // 
            // pbSeries
            // 
            this.pbSeries.Location = new System.Drawing.Point(626, 103);
            this.pbSeries.Name = "pbSeries";
            this.pbSeries.Size = new System.Drawing.Size(211, 287);
            this.pbSeries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSeries.TabIndex = 1;
            this.pbSeries.TabStop = false;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("ROG Fonts", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(14, 9);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(184, 42);
            this.lblSeries.TabIndex = 2;
            this.lblSeries.Text = "Series";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 397);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 35);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(125, 397);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 35);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(320, 396);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(141, 35);
            this.btnEliminarFisico.TabIndex = 5;
            this.btnEliminarFisico.Text = "Eliminar Físico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(479, 396);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(141, 35);
            this.btnEliminarLogico.TabIndex = 6;
            this.btnEliminarLogico.Text = "Eliminar Lógico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.Location = new System.Drawing.Point(18, 78);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(83, 15);
            this.lblFiltroRapido.TabIndex = 7;
            this.lblFiltroRapido.Text = "Filtro Rapido :";
            // 
            // txtbFiltroRapido
            // 
            this.txtbFiltroRapido.Location = new System.Drawing.Point(107, 78);
            this.txtbFiltroRapido.Name = "txtbFiltroRapido";
            this.txtbFiltroRapido.Size = new System.Drawing.Size(140, 20);
            this.txtbFiltroRapido.TabIndex = 8;
            this.txtbFiltroRapido.TextChanged += new System.EventHandler(this.txtbFiltroRapido_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(18, 453);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(46, 13);
            this.lblCampo.TabIndex = 9;
            this.lblCampo.Text = "Campo :";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(212, 453);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(45, 13);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio :";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(407, 453);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(86, 13);
            this.lblFiltroAvanzado.TabIndex = 11;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado :";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(77, 448);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 12;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(271, 448);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 13;
            // 
            // txtbFiltroAvanzado
            // 
            this.txtbFiltroAvanzado.Location = new System.Drawing.Point(499, 449);
            this.txtbFiltroAvanzado.MaximumSize = new System.Drawing.Size(121, 20);
            this.txtbFiltroAvanzado.MinimumSize = new System.Drawing.Size(121, 20);
            this.txtbFiltroAvanzado.Name = "txtbFiltroAvanzado";
            this.txtbFiltroAvanzado.Size = new System.Drawing.Size(121, 20);
            this.txtbFiltroAvanzado.TabIndex = 14;
            this.txtbFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFiltroAvanzado_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(649, 441);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 32);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTemporadas
            // 
            this.btnTemporadas.Location = new System.Drawing.Point(627, 397);
            this.btnTemporadas.Name = "btnTemporadas";
            this.btnTemporadas.Size = new System.Drawing.Size(210, 35);
            this.btnTemporadas.TabIndex = 16;
            this.btnTemporadas.Text = "Temporadas";
            this.btnTemporadas.UseVisualStyleBackColor = true;
            // 
            // frmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.Controls.Add(this.btnTemporadas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtbFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.pbSeries);
            this.Controls.Add(this.dgvSeries);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(817, 550);
            this.Name = "frmSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series";
            this.Load += new System.EventHandler(this.frmSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeries;
        private System.Windows.Forms.PictureBox pbSeries;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtbFiltroRapido;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtbFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTemporadas;
    }
}

