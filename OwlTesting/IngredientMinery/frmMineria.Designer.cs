namespace IngredientMinery
{
    partial class frmMineria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNuevaPalabra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtMainVocabulary = new System.Windows.Forms.TextBox();
            this.lbTotalregistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvaluarBaseDatos = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDatosOrigen = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFrencuenciaPalabras = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMarcarRegistro = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 584);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMarcarRegistro);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbTotalregistro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEvaluarBaseDatos);
            this.tabPage1.Controls.Add(this.btnEvaluar);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Identificacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(880, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 505);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNuevaPalabra);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtMainVocabulary);
            this.panel1.Location = new System.Drawing.Point(625, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 511);
            this.panel1.TabIndex = 9;
            // 
            // txtNuevaPalabra
            // 
            this.txtNuevaPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaPalabra.Location = new System.Drawing.Point(3, 435);
            this.txtNuevaPalabra.Name = "txtNuevaPalabra";
            this.txtNuevaPalabra.Size = new System.Drawing.Size(242, 29);
            this.txtNuevaPalabra.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(154, 484);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(47, 484);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtMainVocabulary
            // 
            this.txtMainVocabulary.BackColor = System.Drawing.Color.White;
            this.txtMainVocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMainVocabulary.Location = new System.Drawing.Point(0, 0);
            this.txtMainVocabulary.Multiline = true;
            this.txtMainVocabulary.Name = "txtMainVocabulary";
            this.txtMainVocabulary.ReadOnly = true;
            this.txtMainVocabulary.Size = new System.Drawing.Size(249, 429);
            this.txtMainVocabulary.TabIndex = 0;
            // 
            // lbTotalregistro
            // 
            this.lbTotalregistro.AutoSize = true;
            this.lbTotalregistro.Location = new System.Drawing.Point(92, 528);
            this.lbTotalregistro.Name = "lbTotalregistro";
            this.lbTotalregistro.Size = new System.Drawing.Size(13, 13);
            this.lbTotalregistro.TabIndex = 8;
            this.lbTotalregistro.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Registros";
            // 
            // btnEvaluarBaseDatos
            // 
            this.btnEvaluarBaseDatos.Location = new System.Drawing.Point(743, 527);
            this.btnEvaluarBaseDatos.Name = "btnEvaluarBaseDatos";
            this.btnEvaluarBaseDatos.Size = new System.Drawing.Size(154, 23);
            this.btnEvaluarBaseDatos.TabIndex = 6;
            this.btnEvaluarBaseDatos.Text = "Buscar informacion DB";
            this.btnEvaluarBaseDatos.UseVisualStyleBackColor = true;
            this.btnEvaluarBaseDatos.Click += new System.EventHandler(this.btnEvaluarBaseDatos_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(903, 527);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 5;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDatosOrigen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 514);
            this.panel4.TabIndex = 3;
            // 
            // txtDatosOrigen
            // 
            this.txtDatosOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatosOrigen.Location = new System.Drawing.Point(0, 0);
            this.txtDatosOrigen.Multiline = true;
            this.txtDatosOrigen.Name = "txtDatosOrigen";
            this.txtDatosOrigen.Size = new System.Drawing.Size(446, 514);
            this.txtDatosOrigen.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFrencuenciaPalabras);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(452, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 511);
            this.panel3.TabIndex = 2;
            // 
            // txtFrencuenciaPalabras
            // 
            this.txtFrencuenciaPalabras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFrencuenciaPalabras.Location = new System.Drawing.Point(0, 0);
            this.txtFrencuenciaPalabras.Multiline = true;
            this.txtFrencuenciaPalabras.Name = "txtFrencuenciaPalabras";
            this.txtFrencuenciaPalabras.Size = new System.Drawing.Size(171, 511);
            this.txtFrencuenciaPalabras.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 511);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 517);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1112, 38);
            this.textBox2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingredientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1112, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMarcarRegistro
            // 
            this.btnMarcarRegistro.Location = new System.Drawing.Point(984, 527);
            this.btnMarcarRegistro.Name = "btnMarcarRegistro";
            this.btnMarcarRegistro.Size = new System.Drawing.Size(126, 23);
            this.btnMarcarRegistro.TabIndex = 11;
            this.btnMarcarRegistro.Text = "Marcar Registros";
            this.btnMarcarRegistro.UseVisualStyleBackColor = true;
            this.btnMarcarRegistro.Click += new System.EventHandler(this.btnMarcarRegistro_Click);
            // 
            // frmMineria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMineria";
            this.Text = "Mineria de ingredientes";
            this.Load += new System.EventHandler(this.frmMineria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDatosOrigen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFrencuenciaPalabras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnEvaluarBaseDatos;
        private System.Windows.Forms.Label lbTotalregistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNuevaPalabra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtMainVocabulary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMarcarRegistro;
    }
}

