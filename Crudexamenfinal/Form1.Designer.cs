namespace Crudexamenfinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxproduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxprovee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdescrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxpreciouni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxcomentario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewbd = new System.Windows.Forms.DataGridView();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonlimpiar = new System.Windows.Forms.Button();
            this.buttonverbd = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonconexion = new System.Windows.Forms.Button();
            this.numericUpDowncantidad = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickeringreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(963, 114);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(165, 22);
            this.textBoxid.TabIndex = 1;
            // 
            // textBoxproduct
            // 
            this.textBoxproduct.Location = new System.Drawing.Point(963, 152);
            this.textBoxproduct.Name = "textBoxproduct";
            this.textBoxproduct.Size = new System.Drawing.Size(165, 22);
            this.textBoxproduct.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1235, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de ingreso";
            // 
            // textBoxprovee
            // 
            this.textBoxprovee.Location = new System.Drawing.Point(963, 284);
            this.textBoxprovee.Name = "textBoxprovee";
            this.textBoxprovee.Size = new System.Drawing.Size(165, 22);
            this.textBoxprovee.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proveedor";
            // 
            // textBoxdescrip
            // 
            this.textBoxdescrip.Location = new System.Drawing.Point(1060, 376);
            this.textBoxdescrip.Multiline = true;
            this.textBoxdescrip.Name = "textBoxdescrip";
            this.textBoxdescrip.Size = new System.Drawing.Size(388, 197);
            this.textBoxdescrip.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1205, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(891, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = " Precio por unidad";
            this.label7.UseMnemonic = false;
            // 
            // textBoxpreciouni
            // 
            this.textBoxpreciouni.Location = new System.Drawing.Point(1008, 232);
            this.textBoxpreciouni.Name = "textBoxpreciouni";
            this.textBoxpreciouni.Size = new System.Drawing.Size(120, 22);
            this.textBoxpreciouni.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(891, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cantidad";
            // 
            // textBoxcomentario
            // 
            this.textBoxcomentario.Location = new System.Drawing.Point(1147, 204);
            this.textBoxcomentario.Multiline = true;
            this.textBoxcomentario.Name = "textBoxcomentario";
            this.textBoxcomentario.Size = new System.Drawing.Size(314, 125);
            this.textBoxcomentario.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1258, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Comentario";
            // 
            // dataGridViewbd
            // 
            this.dataGridViewbd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbd.Location = new System.Drawing.Point(12, 8);
            this.dataGridViewbd.Name = "dataGridViewbd";
            this.dataGridViewbd.RowHeadersWidth = 51;
            this.dataGridViewbd.RowTemplate.Height = 24;
            this.dataGridViewbd.Size = new System.Drawing.Size(844, 565);
            this.dataGridViewbd.TabIndex = 17;
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(867, 376);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(143, 31);
            this.buttonguardar.TabIndex = 18;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click_1);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(867, 413);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(143, 31);
            this.buttonactualizar.TabIndex = 19;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(867, 450);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(143, 31);
            this.buttoneliminar.TabIndex = 20;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonlimpiar
            // 
            this.buttonlimpiar.Location = new System.Drawing.Point(867, 487);
            this.buttonlimpiar.Name = "buttonlimpiar";
            this.buttonlimpiar.Size = new System.Drawing.Size(143, 31);
            this.buttonlimpiar.TabIndex = 21;
            this.buttonlimpiar.Text = "Limpiar";
            this.buttonlimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonverbd
            // 
            this.buttonverbd.Location = new System.Drawing.Point(867, 524);
            this.buttonverbd.Name = "buttonverbd";
            this.buttonverbd.Size = new System.Drawing.Size(140, 49);
            this.buttonverbd.TabIndex = 22;
            this.buttonverbd.Text = "Vizualizar Base de datos";
            this.buttonverbd.UseVisualStyleBackColor = true;
            this.buttonverbd.Click += new System.EventHandler(this.buttonverbd_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(894, 36);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(183, 42);
            this.buttonbuscar.TabIndex = 23;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonconexion
            // 
            this.buttonconexion.Location = new System.Drawing.Point(1248, 36);
            this.buttonconexion.Name = "buttonconexion";
            this.buttonconexion.Size = new System.Drawing.Size(183, 42);
            this.buttonconexion.TabIndex = 24;
            this.buttonconexion.Text = "Probar conexión";
            this.buttonconexion.UseVisualStyleBackColor = true;
            this.buttonconexion.Click += new System.EventHandler(this.buttonconexion_Click);
            // 
            // numericUpDowncantidad
            // 
            this.numericUpDowncantidad.Location = new System.Drawing.Point(1008, 185);
            this.numericUpDowncantidad.Name = "numericUpDowncantidad";
            this.numericUpDowncantidad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDowncantidad.TabIndex = 25;
            // 
            // dateTimePickeringreso
            // 
            this.dateTimePickeringreso.Location = new System.Drawing.Point(1208, 147);
            this.dateTimePickeringreso.Name = "dateTimePickeringreso";
            this.dateTimePickeringreso.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickeringreso.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1473, 585);
            this.Controls.Add(this.dateTimePickeringreso);
            this.Controls.Add(this.numericUpDowncantidad);
            this.Controls.Add(this.buttonconexion);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonverbd);
            this.Controls.Add(this.buttonlimpiar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.dataGridViewbd);
            this.Controls.Add(this.textBoxcomentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxdescrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxpreciouni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxprovee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxprovee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdescrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxpreciouni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxcomentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewbd;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonlimpiar;
        private System.Windows.Forms.Button buttonverbd;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttonconexion;
        private System.Windows.Forms.NumericUpDown numericUpDowncantidad;
        private System.Windows.Forms.DateTimePicker dateTimePickeringreso;
    }
}

