namespace RecipeScraper
{
    partial class RecipeScraperTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.lbPorcent = new System.Windows.Forms.Label();
            this.progressBarBusqueda = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalRegistros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileRoute = new System.Windows.Forms.TextBox();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.cboScrapMode = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEnlaceActual = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Temporada = new System.Windows.Forms.Label();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMomentoComida = new System.Windows.Forms.ComboBox();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.cboCultura = new System.Windows.Forms.ComboBox();
            this.CboTipoPlato = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbErrorCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalRegistroEncontrados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalNodosIdentificados = new System.Windows.Forms.Label();
            this.lbTotalNodosEvaluados = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileHtmlPage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarArchivo);
            this.groupBox1.Controls.Add(this.lbPorcent);
            this.groupBox1.Controls.Add(this.progressBarBusqueda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotalRegistros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFileRoute);
            this.groupBox1.Controls.Add(this.cboFormato);
            this.groupBox1.Controls.Add(this.cboScrapMode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(470, 74);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(81, 23);
            this.btnBuscarArchivo.TabIndex = 10;
            this.btnBuscarArchivo.Text = "Buscar";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // lbPorcent
            // 
            this.lbPorcent.AutoSize = true;
            this.lbPorcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcent.Location = new System.Drawing.Point(516, 98);
            this.lbPorcent.Name = "lbPorcent";
            this.lbPorcent.Size = new System.Drawing.Size(35, 24);
            this.lbPorcent.TabIndex = 9;
            this.lbPorcent.Text = "0%";
            // 
            // progressBarBusqueda
            // 
            this.progressBarBusqueda.Location = new System.Drawing.Point(208, 101);
            this.progressBarBusqueda.Name = "progressBarBusqueda";
            this.progressBarBusqueda.Size = new System.Drawing.Size(302, 19);
            this.progressBarBusqueda.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad Registro ";
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Location = new System.Drawing.Point(125, 99);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.Size = new System.Drawing.Size(77, 20);
            this.txtTotalRegistros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ruta archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formato Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Busqueda";
            // 
            // txtFileRoute
            // 
            this.txtFileRoute.Location = new System.Drawing.Point(125, 73);
            this.txtFileRoute.Name = "txtFileRoute";
            this.txtFileRoute.Size = new System.Drawing.Size(338, 20);
            this.txtFileRoute.TabIndex = 1;
            // 
            // cboFormato
            // 
            this.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "MICRODATA",
            "JSON-LD"});
            this.cboFormato.Location = new System.Drawing.Point(125, 46);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(426, 21);
            this.cboFormato.TabIndex = 1;
            // 
            // cboScrapMode
            // 
            this.cboScrapMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScrapMode.FormattingEnabled = true;
            this.cboScrapMode.Items.AddRange(new object[] {
            "WEB",
            "LOCAL"});
            this.cboScrapMode.Location = new System.Drawing.Point(125, 19);
            this.cboScrapMode.Name = "cboScrapMode";
            this.cboScrapMode.Size = new System.Drawing.Size(426, 21);
            this.cboScrapMode.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(471, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Buscar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbEnlaceActual);
            this.groupBox2.Location = new System.Drawing.Point(5, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 42);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enlace Actual";
            // 
            // lbEnlaceActual
            // 
            this.lbEnlaceActual.AutoSize = true;
            this.lbEnlaceActual.Location = new System.Drawing.Point(8, 19);
            this.lbEnlaceActual.Name = "lbEnlaceActual";
            this.lbEnlaceActual.Size = new System.Drawing.Size(103, 13);
            this.lbEnlaceActual.TabIndex = 0;
            this.lbEnlaceActual.Text = "htttp//www.xxx.com";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Temporada);
            this.groupBox3.Controls.Add(this.cboTemporada);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboMomentoComida);
            this.groupBox3.Controls.Add(this.cboNacionalidad);
            this.groupBox3.Controls.Add(this.cboCultura);
            this.groupBox3.Controls.Add(this.CboTipoPlato);
            this.groupBox3.Location = new System.Drawing.Point(5, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 165);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // Temporada
            // 
            this.Temporada.AutoSize = true;
            this.Temporada.Location = new System.Drawing.Point(9, 130);
            this.Temporada.Name = "Temporada";
            this.Temporada.Size = new System.Drawing.Size(61, 13);
            this.Temporada.TabIndex = 12;
            this.Temporada.Text = "Temporada";
            // 
            // cboTemporada
            // 
            this.cboTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(124, 127);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(426, 21);
            this.cboTemporada.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Momento ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nacionalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cultura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo Plato";
            // 
            // cboMomentoComida
            // 
            this.cboMomentoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMomentoComida.FormattingEnabled = true;
            this.cboMomentoComida.Location = new System.Drawing.Point(124, 100);
            this.cboMomentoComida.Name = "cboMomentoComida";
            this.cboMomentoComida.Size = new System.Drawing.Size(426, 21);
            this.cboMomentoComida.TabIndex = 5;
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(124, 73);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(426, 21);
            this.cboNacionalidad.TabIndex = 4;
            // 
            // cboCultura
            // 
            this.cboCultura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCultura.FormattingEnabled = true;
            this.cboCultura.Location = new System.Drawing.Point(124, 46);
            this.cboCultura.Name = "cboCultura";
            this.cboCultura.Size = new System.Drawing.Size(426, 21);
            this.cboCultura.TabIndex = 3;
            // 
            // CboTipoPlato
            // 
            this.CboTipoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPlato.FormattingEnabled = true;
            this.CboTipoPlato.Location = new System.Drawing.Point(124, 19);
            this.CboTipoPlato.Name = "CboTipoPlato";
            this.CboTipoPlato.Size = new System.Drawing.Size(426, 21);
            this.CboTipoPlato.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIniciar);
            this.groupBox4.Location = new System.Drawing.Point(5, 442);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 41);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbErrorCount);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lbTotalRegistroEncontrados);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lbTotalNodosIdentificados);
            this.groupBox5.Controls.Add(this.lbTotalNodosEvaluados);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(5, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(554, 86);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // lbErrorCount
            // 
            this.lbErrorCount.AutoSize = true;
            this.lbErrorCount.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCount.Location = new System.Drawing.Point(140, 70);
            this.lbErrorCount.Name = "lbErrorCount";
            this.lbErrorCount.Size = new System.Drawing.Size(13, 13);
            this.lbErrorCount.TabIndex = 7;
            this.lbErrorCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Errores encontrados";
            // 
            // lbTotalRegistroEncontrados
            // 
            this.lbTotalRegistroEncontrados.AutoSize = true;
            this.lbTotalRegistroEncontrados.Location = new System.Drawing.Point(140, 49);
            this.lbTotalRegistroEncontrados.Name = "lbTotalRegistroEncontrados";
            this.lbTotalRegistroEncontrados.Size = new System.Drawing.Size(13, 13);
            this.lbTotalRegistroEncontrados.TabIndex = 5;
            this.lbTotalRegistroEncontrados.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registros encontrados";
            // 
            // lbTotalNodosIdentificados
            // 
            this.lbTotalNodosIdentificados.AutoSize = true;
            this.lbTotalNodosIdentificados.Location = new System.Drawing.Point(140, 12);
            this.lbTotalNodosIdentificados.Name = "lbTotalNodosIdentificados";
            this.lbTotalNodosIdentificados.Size = new System.Drawing.Size(13, 13);
            this.lbTotalNodosIdentificados.TabIndex = 3;
            this.lbTotalNodosIdentificados.Text = "0";
            // 
            // lbTotalNodosEvaluados
            // 
            this.lbTotalNodosEvaluados.AutoSize = true;
            this.lbTotalNodosEvaluados.Location = new System.Drawing.Point(140, 30);
            this.lbTotalNodosEvaluados.Name = "lbTotalNodosEvaluados";
            this.lbTotalNodosEvaluados.Size = new System.Drawing.Size(13, 13);
            this.lbTotalNodosEvaluados.TabIndex = 2;
            this.lbTotalNodosEvaluados.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Nodos Evaluados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Registros Identificados";
            // 
            // openFileHtmlPage
            // 
            this.openFileHtmlPage.FileName = "openFileDialog1";
            // 
            // RecipeScraperTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 495);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecipeScraperTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecipeScraperTool";
            this.Load += new System.EventHandler(this.RecipeScraperTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalRegistros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileRoute;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.ComboBox cboScrapMode;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbEnlaceActual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbPorcent;
        private System.Windows.Forms.ProgressBar progressBarBusqueda;
        private System.Windows.Forms.ComboBox cboMomentoComida;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.ComboBox cboCultura;
        private System.Windows.Forms.ComboBox CboTipoPlato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Temporada;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotalNodosIdentificados;
        private System.Windows.Forms.Label lbTotalNodosEvaluados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalRegistroEncontrados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.Label lbErrorCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileHtmlPage;
    }
}