namespace Vistas.Formularios
{
    partial class frmMantenimientoZapatos
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
            this.tcPestañas = new System.Windows.Forms.TabControl();
            this.tbRegistrarZapatos = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAñadirImagen = new System.Windows.Forms.Button();
            this.gbProductosAlmacen = new System.Windows.Forms.GroupBox();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.pb = new System.Windows.Forms.PictureBox();
            this.gbInfoZapato = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreZapato = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreZapato = new System.Windows.Forms.Label();
            this.tbActualizarInfo = new System.Windows.Forms.TabPage();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gbProductosAlmacen2 = new System.Windows.Forms.GroupBox();
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.gbInfoZapato2 = new System.Windows.Forms.GroupBox();
            this.cbActualizar = new System.Windows.Forms.ComboBox();
            this.dtpFechaRegistro2 = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.txtNombreZapato2 = new System.Windows.Forms.TextBox();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.lblFechaRegistro2 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblNombreZapato2 = new System.Windows.Forms.Label();
            this.tcPestañas.SuspendLayout();
            this.tbRegistrarZapatos.SuspendLayout();
            this.gbProductosAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.gbInfoZapato.SuspendLayout();
            this.tbActualizarInfo.SuspendLayout();
            this.gbProductosAlmacen2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            this.gbInfoZapato2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPestañas
            // 
            this.tcPestañas.Controls.Add(this.tbRegistrarZapatos);
            this.tcPestañas.Controls.Add(this.tbActualizarInfo);
            this.tcPestañas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPestañas.Location = new System.Drawing.Point(0, 0);
            this.tcPestañas.Name = "tcPestañas";
            this.tcPestañas.SelectedIndex = 0;
            this.tcPestañas.Size = new System.Drawing.Size(1142, 582);
            this.tcPestañas.TabIndex = 0;
            // 
            // tbRegistrarZapatos
            // 
            this.tbRegistrarZapatos.Controls.Add(this.btnEliminar);
            this.tbRegistrarZapatos.Controls.Add(this.btnRegistrar);
            this.tbRegistrarZapatos.Controls.Add(this.btnAñadirImagen);
            this.tbRegistrarZapatos.Controls.Add(this.gbProductosAlmacen);
            this.tbRegistrarZapatos.Controls.Add(this.pb);
            this.tbRegistrarZapatos.Controls.Add(this.gbInfoZapato);
            this.tbRegistrarZapatos.Location = new System.Drawing.Point(4, 22);
            this.tbRegistrarZapatos.Name = "tbRegistrarZapatos";
            this.tbRegistrarZapatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistrarZapatos.Size = new System.Drawing.Size(1134, 556);
            this.tbRegistrarZapatos.TabIndex = 0;
            this.tbRegistrarZapatos.Text = "Registrar Zapatos";
            this.tbRegistrarZapatos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(914, 219);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(914, 190);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 23);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAñadirImagen
            // 
            this.btnAñadirImagen.FlatAppearance.BorderSize = 0;
            this.btnAñadirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirImagen.Location = new System.Drawing.Point(914, 150);
            this.btnAñadirImagen.Name = "btnAñadirImagen";
            this.btnAñadirImagen.Size = new System.Drawing.Size(90, 23);
            this.btnAñadirImagen.TabIndex = 12;
            this.btnAñadirImagen.Text = "Añadir Imagen";
            this.btnAñadirImagen.UseVisualStyleBackColor = true;
            // 
            // gbProductosAlmacen
            // 
            this.gbProductosAlmacen.Controls.Add(this.dgvAlmacen);
            this.gbProductosAlmacen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductosAlmacen.Location = new System.Drawing.Point(25, 285);
            this.gbProductosAlmacen.Name = "gbProductosAlmacen";
            this.gbProductosAlmacen.Size = new System.Drawing.Size(962, 249);
            this.gbProductosAlmacen.TabIndex = 8;
            this.gbProductosAlmacen.TabStop = false;
            this.gbProductosAlmacen.Text = "Productos de Almacen";
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(18, 20);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.Size = new System.Drawing.Size(929, 216);
            this.dgvAlmacen.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(832, 16);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(251, 123);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 7;
            this.pb.TabStop = false;
            // 
            // gbInfoZapato
            // 
            this.gbInfoZapato.Controls.Add(this.cbCategoria);
            this.gbInfoZapato.Controls.Add(this.dtpFechaRegistro);
            this.gbInfoZapato.Controls.Add(this.txtPrecio);
            this.gbInfoZapato.Controls.Add(this.txtNombreZapato);
            this.gbInfoZapato.Controls.Add(this.lblCategoria);
            this.gbInfoZapato.Controls.Add(this.lblFechaRegistro);
            this.gbInfoZapato.Controls.Add(this.lblPrecio);
            this.gbInfoZapato.Controls.Add(this.lblNombreZapato);
            this.gbInfoZapato.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoZapato.Location = new System.Drawing.Point(8, 6);
            this.gbInfoZapato.Name = "gbInfoZapato";
            this.gbInfoZapato.Size = new System.Drawing.Size(752, 248);
            this.gbInfoZapato.TabIndex = 6;
            this.gbInfoZapato.TabStop = false;
            this.gbInfoZapato.Text = "Info. Zapato";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(227, 209);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(333, 29);
            this.cbCategoria.TabIndex = 7;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(227, 144);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(333, 29);
            this.dtpFechaRegistro.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(227, 85);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(333, 29);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtNombreZapato
            // 
            this.txtNombreZapato.Location = new System.Drawing.Point(227, 29);
            this.txtNombreZapato.Name = "txtNombreZapato";
            this.txtNombreZapato.Size = new System.Drawing.Size(333, 29);
            this.txtNombreZapato.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(43, 212);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(93, 21);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria :";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(43, 150);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(155, 21);
            this.lblFechaRegistro.TabIndex = 2;
            this.lblFechaRegistro.Text = "Fecha de Registro :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(43, 88);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 21);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblNombreZapato
            // 
            this.lblNombreZapato.AutoSize = true;
            this.lblNombreZapato.Location = new System.Drawing.Point(43, 32);
            this.lblNombreZapato.Name = "lblNombreZapato";
            this.lblNombreZapato.Size = new System.Drawing.Size(141, 21);
            this.lblNombreZapato.TabIndex = 0;
            this.lblNombreZapato.Text = "Nombre Zapato :";
            // 
            // tbActualizarInfo
            // 
            this.tbActualizarInfo.Controls.Add(this.btnActualizarRegistro);
            this.tbActualizarInfo.Controls.Add(this.txtBuscar);
            this.tbActualizarInfo.Controls.Add(this.btnBuscar);
            this.tbActualizarInfo.Controls.Add(this.lblBuscar);
            this.tbActualizarInfo.Controls.Add(this.gbProductosAlmacen2);
            this.tbActualizarInfo.Controls.Add(this.gbInfoZapato2);
            this.tbActualizarInfo.Location = new System.Drawing.Point(4, 22);
            this.tbActualizarInfo.Name = "tbActualizarInfo";
            this.tbActualizarInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbActualizarInfo.Size = new System.Drawing.Size(1134, 556);
            this.tbActualizarInfo.TabIndex = 1;
            this.tbActualizarInfo.Text = "Actualizar Informacion";
            this.tbActualizarInfo.UseVisualStyleBackColor = true;
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.Location = new System.Drawing.Point(762, 230);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(364, 41);
            this.btnActualizarRegistro.TabIndex = 13;
            this.btnActualizarRegistro.Text = "Actualizar Registro";
            this.btnActualizarRegistro.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(762, 55);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 33);
            this.txtBuscar.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1040, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(784, 23);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(63, 22);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar";
            // 
            // gbProductosAlmacen2
            // 
            this.gbProductosAlmacen2.Controls.Add(this.dgvEdit);
            this.gbProductosAlmacen2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductosAlmacen2.Location = new System.Drawing.Point(8, 277);
            this.gbProductosAlmacen2.Name = "gbProductosAlmacen2";
            this.gbProductosAlmacen2.Size = new System.Drawing.Size(1094, 260);
            this.gbProductosAlmacen2.TabIndex = 9;
            this.gbProductosAlmacen2.TabStop = false;
            this.gbProductosAlmacen2.Text = "Productos de Almacen";
            // 
            // dgvEdit
            // 
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdit.Location = new System.Drawing.Point(18, 28);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.Size = new System.Drawing.Size(1054, 216);
            this.dgvEdit.TabIndex = 0;
            // 
            // gbInfoZapato2
            // 
            this.gbInfoZapato2.Controls.Add(this.cbActualizar);
            this.gbInfoZapato2.Controls.Add(this.dtpFechaRegistro2);
            this.gbInfoZapato2.Controls.Add(this.txtPrecio2);
            this.gbInfoZapato2.Controls.Add(this.txtNombreZapato2);
            this.gbInfoZapato2.Controls.Add(this.lblCategoria2);
            this.gbInfoZapato2.Controls.Add(this.lblFechaRegistro2);
            this.gbInfoZapato2.Controls.Add(this.lblPrecio2);
            this.gbInfoZapato2.Controls.Add(this.lblNombreZapato2);
            this.gbInfoZapato2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoZapato2.Location = new System.Drawing.Point(8, 6);
            this.gbInfoZapato2.Name = "gbInfoZapato2";
            this.gbInfoZapato2.Size = new System.Drawing.Size(736, 265);
            this.gbInfoZapato2.TabIndex = 7;
            this.gbInfoZapato2.TabStop = false;
            this.gbInfoZapato2.Text = "Info. Zapato";
            // 
            // cbActualizar
            // 
            this.cbActualizar.FormattingEnabled = true;
            this.cbActualizar.Location = new System.Drawing.Point(227, 209);
            this.cbActualizar.Name = "cbActualizar";
            this.cbActualizar.Size = new System.Drawing.Size(333, 29);
            this.cbActualizar.TabIndex = 7;
            // 
            // dtpFechaRegistro2
            // 
            this.dtpFechaRegistro2.Location = new System.Drawing.Point(227, 144);
            this.dtpFechaRegistro2.Name = "dtpFechaRegistro2";
            this.dtpFechaRegistro2.Size = new System.Drawing.Size(333, 29);
            this.dtpFechaRegistro2.TabIndex = 6;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(227, 85);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(333, 29);
            this.txtPrecio2.TabIndex = 5;
            // 
            // txtNombreZapato2
            // 
            this.txtNombreZapato2.Location = new System.Drawing.Point(227, 29);
            this.txtNombreZapato2.Name = "txtNombreZapato2";
            this.txtNombreZapato2.Size = new System.Drawing.Size(333, 29);
            this.txtNombreZapato2.TabIndex = 4;
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Location = new System.Drawing.Point(43, 212);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(93, 21);
            this.lblCategoria2.TabIndex = 3;
            this.lblCategoria2.Text = "Categoria :";
            // 
            // lblFechaRegistro2
            // 
            this.lblFechaRegistro2.AutoSize = true;
            this.lblFechaRegistro2.Location = new System.Drawing.Point(43, 150);
            this.lblFechaRegistro2.Name = "lblFechaRegistro2";
            this.lblFechaRegistro2.Size = new System.Drawing.Size(155, 21);
            this.lblFechaRegistro2.TabIndex = 2;
            this.lblFechaRegistro2.Text = "Fecha de Registro :";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(43, 88);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(66, 21);
            this.lblPrecio2.TabIndex = 1;
            this.lblPrecio2.Text = "Precio :";
            // 
            // lblNombreZapato2
            // 
            this.lblNombreZapato2.AutoSize = true;
            this.lblNombreZapato2.Location = new System.Drawing.Point(43, 32);
            this.lblNombreZapato2.Name = "lblNombreZapato2";
            this.lblNombreZapato2.Size = new System.Drawing.Size(141, 21);
            this.lblNombreZapato2.TabIndex = 0;
            this.lblNombreZapato2.Text = "Nombre Zapato :";
            // 
            // frmMantenimientoZapatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 582);
            this.Controls.Add(this.tcPestañas);
            this.Name = "frmMantenimientoZapatos";
            this.Text = "frmMantenimientoZapatos";
            this.Load += new System.EventHandler(this.frmMantenimientoZapatos_Load);
            this.tcPestañas.ResumeLayout(false);
            this.tbRegistrarZapatos.ResumeLayout(false);
            this.gbProductosAlmacen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.gbInfoZapato.ResumeLayout(false);
            this.gbInfoZapato.PerformLayout();
            this.tbActualizarInfo.ResumeLayout(false);
            this.tbActualizarInfo.PerformLayout();
            this.gbProductosAlmacen2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            this.gbInfoZapato2.ResumeLayout(false);
            this.gbInfoZapato2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPestañas;
        private System.Windows.Forms.TabPage tbRegistrarZapatos;
        private System.Windows.Forms.GroupBox gbProductosAlmacen;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.GroupBox gbInfoZapato;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreZapato;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreZapato;
        private System.Windows.Forms.TabPage tbActualizarInfo;
        private System.Windows.Forms.Button btnAñadirImagen;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gbProductosAlmacen2;
        private System.Windows.Forms.DataGridView dgvEdit;
        private System.Windows.Forms.GroupBox gbInfoZapato2;
        private System.Windows.Forms.ComboBox cbActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro2;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.TextBox txtNombreZapato2;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.Label lblFechaRegistro2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblNombreZapato2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}