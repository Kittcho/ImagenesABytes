namespace GuardarImagenBase64
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControlImagenes = new System.Windows.Forms.TabControl();
            this.tabPageSubir = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblRutaImagen = new System.Windows.Forms.Label();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.lblNombreImagen = new System.Windows.Forms.Label();
            this.txtNombreImagen = new System.Windows.Forms.TextBox();
            this.tabPageBajar = new System.Windows.Forms.TabPage();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.txtRutaDescarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNombresImagenes = new System.Windows.Forms.ComboBox();
            this.tabPageMostrar = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlImagenes.SuspendLayout();
            this.tabPageSubir.SuspendLayout();
            this.tabPageBajar.SuspendLayout();
            this.tabPageMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControlImagenes
            // 
            this.tabControlImagenes.Controls.Add(this.tabPageSubir);
            this.tabControlImagenes.Controls.Add(this.tabPageBajar);
            this.tabControlImagenes.Controls.Add(this.tabPageMostrar);
            this.tabControlImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlImagenes.Location = new System.Drawing.Point(0, 0);
            this.tabControlImagenes.Name = "tabControlImagenes";
            this.tabControlImagenes.SelectedIndex = 0;
            this.tabControlImagenes.Size = new System.Drawing.Size(459, 151);
            this.tabControlImagenes.TabIndex = 0;
            this.tabControlImagenes.SelectedIndexChanged += new System.EventHandler(this.tabControlImagenes_SelectedIndexChanged);
            // 
            // tabPageSubir
            // 
            this.tabPageSubir.Controls.Add(this.btnGuardar);
            this.tabPageSubir.Controls.Add(this.btnBuscar);
            this.tabPageSubir.Controls.Add(this.lblRutaImagen);
            this.tabPageSubir.Controls.Add(this.txtRutaImagen);
            this.tabPageSubir.Controls.Add(this.lblNombreImagen);
            this.tabPageSubir.Controls.Add(this.txtNombreImagen);
            this.tabPageSubir.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubir.Name = "tabPageSubir";
            this.tabPageSubir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubir.Size = new System.Drawing.Size(451, 125);
            this.tabPageSubir.TabIndex = 0;
            this.tabPageSubir.Text = "Subir Imagen";
            this.tabPageSubir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(355, 91);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblRutaImagen
            // 
            this.lblRutaImagen.AutoSize = true;
            this.lblRutaImagen.Location = new System.Drawing.Point(20, 50);
            this.lblRutaImagen.Name = "lblRutaImagen";
            this.lblRutaImagen.Size = new System.Drawing.Size(71, 13);
            this.lblRutaImagen.TabIndex = 3;
            this.lblRutaImagen.Text = "Ruta Imagen:";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaImagen.Enabled = false;
            this.txtRutaImagen.Location = new System.Drawing.Point(111, 47);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(319, 20);
            this.txtRutaImagen.TabIndex = 2;
            // 
            // lblNombreImagen
            // 
            this.lblNombreImagen.AutoSize = true;
            this.lblNombreImagen.Location = new System.Drawing.Point(20, 15);
            this.lblNombreImagen.Name = "lblNombreImagen";
            this.lblNombreImagen.Size = new System.Drawing.Size(85, 13);
            this.lblNombreImagen.TabIndex = 1;
            this.lblNombreImagen.Text = "Nombre Imagen:";
            // 
            // txtNombreImagen
            // 
            this.txtNombreImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreImagen.Enabled = false;
            this.txtNombreImagen.Location = new System.Drawing.Point(111, 12);
            this.txtNombreImagen.Name = "txtNombreImagen";
            this.txtNombreImagen.Size = new System.Drawing.Size(319, 20);
            this.txtNombreImagen.TabIndex = 0;
            // 
            // tabPageBajar
            // 
            this.tabPageBajar.Controls.Add(this.btnDescargar);
            this.tabPageBajar.Controls.Add(this.btnBuscarRuta);
            this.tabPageBajar.Controls.Add(this.txtRutaDescarga);
            this.tabPageBajar.Controls.Add(this.label2);
            this.tabPageBajar.Controls.Add(this.label1);
            this.tabPageBajar.Controls.Add(this.cbNombresImagenes);
            this.tabPageBajar.Location = new System.Drawing.Point(4, 22);
            this.tabPageBajar.Name = "tabPageBajar";
            this.tabPageBajar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBajar.Size = new System.Drawing.Size(451, 125);
            this.tabPageBajar.TabIndex = 1;
            this.tabPageBajar.Text = "Descargar Imagen";
            this.tabPageBajar.UseVisualStyleBackColor = true;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(194, 94);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(75, 23);
            this.btnDescargar.TabIndex = 5;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(359, 53);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(57, 29);
            this.btnBuscarRuta.TabIndex = 4;
            this.btnBuscarRuta.Text = "Buscar";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
            // 
            // txtRutaDescarga
            // 
            this.txtRutaDescarga.Location = new System.Drawing.Point(103, 58);
            this.txtRutaDescarga.Name = "txtRutaDescarga";
            this.txtRutaDescarga.Size = new System.Drawing.Size(250, 20);
            this.txtRutaDescarga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta a descargar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre imagen";
            // 
            // cbNombresImagenes
            // 
            this.cbNombresImagenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombresImagenes.FormattingEnabled = true;
            this.cbNombresImagenes.Location = new System.Drawing.Point(103, 22);
            this.cbNombresImagenes.Name = "cbNombresImagenes";
            this.cbNombresImagenes.Size = new System.Drawing.Size(250, 21);
            this.cbNombresImagenes.TabIndex = 0;
            // 
            // tabPageMostrar
            // 
            this.tabPageMostrar.Controls.Add(this.pictureBox1);
            this.tabPageMostrar.Location = new System.Drawing.Point(4, 22);
            this.tabPageMostrar.Name = "tabPageMostrar";
            this.tabPageMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMostrar.Size = new System.Drawing.Size(451, 125);
            this.tabPageMostrar.TabIndex = 2;
            this.tabPageMostrar.Text = "Mostrar Imagen";
            this.tabPageMostrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 151);
            this.Controls.Add(this.tabControlImagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlImagenes.ResumeLayout(false);
            this.tabPageSubir.ResumeLayout(false);
            this.tabPageSubir.PerformLayout();
            this.tabPageBajar.ResumeLayout(false);
            this.tabPageBajar.PerformLayout();
            this.tabPageMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControlImagenes;
        private System.Windows.Forms.TabPage tabPageSubir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblRutaImagen;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Label lblNombreImagen;
        private System.Windows.Forms.TextBox txtNombreImagen;
        private System.Windows.Forms.TabPage tabPageBajar;
        private System.Windows.Forms.TabPage tabPageMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNombresImagenes;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.TextBox txtRutaDescarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

