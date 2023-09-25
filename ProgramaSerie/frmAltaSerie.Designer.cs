namespace ProgramaSerie
{
    partial class frmAltaSerie
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstreno = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.dtpEstreno = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.pcbSerie = new System.Windows.Forms.PictureBox();
            this.btnImagenLocal = new System.Windows.Forms.Button();
            this.lblTemporadas = new System.Windows.Forms.Label();
            this.lblCapitulosTotales = new System.Windows.Forms.Label();
            this.txtbTemporadas = new System.Windows.Forms.TextBox();
            this.txtbCapitulosTotales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 71);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblEstreno
            // 
            this.lblEstreno.AutoSize = true;
            this.lblEstreno.Location = new System.Drawing.Point(41, 112);
            this.lblEstreno.Name = "lblEstreno";
            this.lblEstreno.Size = new System.Drawing.Size(97, 13);
            this.lblEstreno.TabIndex = 2;
            this.lblEstreno.Text = "Fecha de Estreno :";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(144, 28);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(200, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(144, 68);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtbDescripcion.TabIndex = 1;
            // 
            // dtpEstreno
            // 
            this.dtpEstreno.CustomFormat = "";
            this.dtpEstreno.Location = new System.Drawing.Point(144, 106);
            this.dtpEstreno.Name = "dtpEstreno";
            this.dtpEstreno.Size = new System.Drawing.Size(200, 20);
            this.dtpEstreno.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(109, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 38);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(242, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(43, 274);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 13);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero :";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(144, 271);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(200, 21);
            this.cboGenero.TabIndex = 3;
            // 
            // txtbUrlImagen
            // 
            this.txtbUrlImagen.Location = new System.Drawing.Point(144, 151);
            this.txtbUrlImagen.Name = "txtbUrlImagen";
            this.txtbUrlImagen.Size = new System.Drawing.Size(158, 20);
            this.txtbUrlImagen.TabIndex = 4;
            this.txtbUrlImagen.Leave += new System.EventHandler(this.txtbUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(41, 154);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(64, 13);
            this.lblUrlImagen.TabIndex = 10;
            this.lblUrlImagen.Text = "Url Imagen :";
            // 
            // pcbSerie
            // 
            this.pcbSerie.Location = new System.Drawing.Point(359, 28);
            this.pcbSerie.Name = "pcbSerie";
            this.pcbSerie.Size = new System.Drawing.Size(204, 264);
            this.pcbSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSerie.TabIndex = 12;
            this.pcbSerie.TabStop = false;
            // 
            // btnImagenLocal
            // 
            this.btnImagenLocal.Location = new System.Drawing.Point(308, 147);
            this.btnImagenLocal.Name = "btnImagenLocal";
            this.btnImagenLocal.Size = new System.Drawing.Size(36, 27);
            this.btnImagenLocal.TabIndex = 13;
            this.btnImagenLocal.Text = "+";
            this.btnImagenLocal.UseVisualStyleBackColor = true;
            this.btnImagenLocal.Click += new System.EventHandler(this.btnImagenLocal_Click);
            // 
            // lblTemporadas
            // 
            this.lblTemporadas.AutoSize = true;
            this.lblTemporadas.Location = new System.Drawing.Point(41, 194);
            this.lblTemporadas.Name = "lblTemporadas";
            this.lblTemporadas.Size = new System.Drawing.Size(72, 13);
            this.lblTemporadas.TabIndex = 14;
            this.lblTemporadas.Text = "Temporadas :";
            // 
            // lblCapitulosTotales
            // 
            this.lblCapitulosTotales.AutoSize = true;
            this.lblCapitulosTotales.Location = new System.Drawing.Point(41, 230);
            this.lblCapitulosTotales.Name = "lblCapitulosTotales";
            this.lblCapitulosTotales.Size = new System.Drawing.Size(94, 13);
            this.lblCapitulosTotales.TabIndex = 15;
            this.lblCapitulosTotales.Text = "Capitulos Totales :";
            // 
            // txtbTemporadas
            // 
            this.txtbTemporadas.Location = new System.Drawing.Point(144, 191);
            this.txtbTemporadas.MaxLength = 3;
            this.txtbTemporadas.Name = "txtbTemporadas";
            this.txtbTemporadas.Size = new System.Drawing.Size(200, 20);
            this.txtbTemporadas.TabIndex = 16;
            this.txtbTemporadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbTemporadas_KeyPress);
            // 
            // txtbCapitulosTotales
            // 
            this.txtbCapitulosTotales.Location = new System.Drawing.Point(144, 227);
            this.txtbCapitulosTotales.MaxLength = 4;
            this.txtbCapitulosTotales.Name = "txtbCapitulosTotales";
            this.txtbCapitulosTotales.Size = new System.Drawing.Size(200, 20);
            this.txtbCapitulosTotales.TabIndex = 17;
            this.txtbCapitulosTotales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCapitulosTotales_KeyPress);
            // 
            // frmAltaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 399);
            this.Controls.Add(this.txtbCapitulosTotales);
            this.Controls.Add(this.txtbTemporadas);
            this.Controls.Add(this.lblCapitulosTotales);
            this.Controls.Add(this.lblTemporadas);
            this.Controls.Add(this.btnImagenLocal);
            this.Controls.Add(this.pcbSerie);
            this.Controls.Add(this.txtbUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpEstreno);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblEstreno);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAltaSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.frmAltaSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstreno;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.DateTimePicker dtpEstreno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtbUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.PictureBox pcbSerie;
        private System.Windows.Forms.Button btnImagenLocal;
        private System.Windows.Forms.Label lblTemporadas;
        private System.Windows.Forms.Label lblCapitulosTotales;
        private System.Windows.Forms.TextBox txtbTemporadas;
        private System.Windows.Forms.TextBox txtbCapitulosTotales;
    }
}