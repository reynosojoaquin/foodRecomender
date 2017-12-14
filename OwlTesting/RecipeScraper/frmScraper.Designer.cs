namespace RecipeScraper
{
    partial class frmScraper
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileHtmlPage = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CboTipoPlato = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.cboMomentoComida = new System.Windows.Forms.ComboBox();
            this.cboCultura = new System.Windows.Forms.ComboBox();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarAchivo = new System.Windows.Forms.Button();
            this.txtFileRoute = new System.Windows.Forms.TextBox();
            this.cboScrapMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalRegistros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbErrorCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEnlaceActual = new System.Windows.Forms.Label();
            this.lbTotalNodosEvaluados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalNodosIdentificados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalRegistroEncontrados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPorcent = new System.Windows.Forms.Label();
            this.progressBarBusqueda = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtErrorLog = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(534, 13);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(127, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Recuperar Data";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIniciar);
            this.groupBox3.Location = new System.Drawing.Point(2, 619);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 42);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // openFileHtmlPage
            // 
            this.openFileHtmlPage.FileName = "openFileHtmlPage";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 613);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scraper";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CboTipoPlato);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.cboNacionalidad);
            this.groupBox7.Controls.Add(this.cboMomentoComida);
            this.groupBox7.Controls.Add(this.cboCultura);
            this.groupBox7.Controls.Add(this.cboTemporada);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(3, 444);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(520, 137);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // CboTipoPlato
            // 
            this.CboTipoPlato.FormattingEnabled = true;
            this.CboTipoPlato.Items.AddRange(new object[] {
            "Desayuno",
            "Comida",
            "Merienda",
            "Cena",
            "Postre"});
            this.CboTipoPlato.Location = new System.Drawing.Point(94, 107);
            this.CboTipoPlato.Name = "CboTipoPlato";
            this.CboTipoPlato.Size = new System.Drawing.Size(420, 21);
            this.CboTipoPlato.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tipo Plato";
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Items.AddRange(new object[] {
            "Español",
            "Chino",
            "Dominicano",
            "Americano",
            "Indu"});
            this.cboNacionalidad.Location = new System.Drawing.Point(94, 40);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(420, 21);
            this.cboNacionalidad.TabIndex = 10;
            // 
            // cboMomentoComida
            // 
            this.cboMomentoComida.FormattingEnabled = true;
            this.cboMomentoComida.Items.AddRange(new object[] {
            "Entradas",
            "Plato fuerte",
            "Postres",
            "Bebidas"});
            this.cboMomentoComida.Location = new System.Drawing.Point(94, 18);
            this.cboMomentoComida.Name = "cboMomentoComida";
            this.cboMomentoComida.Size = new System.Drawing.Size(420, 21);
            this.cboMomentoComida.TabIndex = 9;
            // 
            // cboCultura
            // 
            this.cboCultura.FormattingEnabled = true;
            this.cboCultura.Items.AddRange(new object[] {
            "Musulmana",
            "Budistas",
            "Vegetariana",
            "Vegana"});
            this.cboCultura.Location = new System.Drawing.Point(94, 62);
            this.cboCultura.Name = "cboCultura";
            this.cboCultura.Size = new System.Drawing.Size(420, 21);
            this.cboCultura.TabIndex = 8;
            // 
            // cboTemporada
            // 
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Items.AddRange(new object[] {
            "Invierno",
            "Otoño",
            "Verano",
            "Primavera"});
            this.cboTemporada.Location = new System.Drawing.Point(94, 84);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(420, 21);
            this.cboTemporada.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Temporada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cultura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nacionalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Momento Comida";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(530, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(128, 523);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Criterios a evaluar";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 118);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(108, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Momento Comida";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 98);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Tipo Plato";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 79);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Temporada";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Cultura";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Nacionalidad";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Tabla  Nutricional";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cboFormato);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.cboScrapMode);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTotalRegistros);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(2, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 276);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Formato";
            // 
            // cboFormato
            // 
            this.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "MICRODATA",
            "JSONLD"});
            this.cboFormato.Location = new System.Drawing.Point(136, 42);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(382, 21);
            this.cboFormato.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarAchivo);
            this.groupBox5.Controls.Add(this.txtFileRoute);
            this.groupBox5.Location = new System.Drawing.Point(4, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(512, 64);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Local Data";
            // 
            // btnBuscarAchivo
            // 
            this.btnBuscarAchivo.Location = new System.Drawing.Point(434, 23);
            this.btnBuscarAchivo.Name = "btnBuscarAchivo";
            this.btnBuscarAchivo.Size = new System.Drawing.Size(72, 23);
            this.btnBuscarAchivo.TabIndex = 9;
            this.btnBuscarAchivo.Text = "File";
            this.btnBuscarAchivo.UseVisualStyleBackColor = true;
            this.btnBuscarAchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileRoute
            // 
            this.txtFileRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFileRoute.Location = new System.Drawing.Point(6, 25);
            this.txtFileRoute.Name = "txtFileRoute";
            this.txtFileRoute.ReadOnly = true;
            this.txtFileRoute.Size = new System.Drawing.Size(422, 20);
            this.txtFileRoute.TabIndex = 8;
            // 
            // cboScrapMode
            // 
            this.cboScrapMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScrapMode.FormattingEnabled = true;
            this.cboScrapMode.Items.AddRange(new object[] {
            "Web Crawler",
            "Local Data"});
            this.cboScrapMode.Location = new System.Drawing.Point(136, 14);
            this.cboScrapMode.Name = "cboScrapMode";
            this.cboScrapMode.Size = new System.Drawing.Size(382, 21);
            this.cboScrapMode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modo";
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Location = new System.Drawing.Point(134, 250);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.Size = new System.Drawing.Size(77, 20);
            this.txtTotalRegistros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Registros a Buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbErrorCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lbTotalNodosEvaluados);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbTotalNodosIdentificados);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbTotalRegistroEncontrados);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 109);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lbErrorCount
            // 
            this.lbErrorCount.AutoSize = true;
            this.lbErrorCount.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCount.Location = new System.Drawing.Point(134, 62);
            this.lbErrorCount.Name = "lbErrorCount";
            this.lbErrorCount.Size = new System.Drawing.Size(13, 13);
            this.lbErrorCount.TabIndex = 12;
            this.lbErrorCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Errores";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbEnlaceActual);
            this.panel1.Location = new System.Drawing.Point(9, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 25);
            this.panel1.TabIndex = 10;
            // 
            // lbEnlaceActual
            // 
            this.lbEnlaceActual.AutoSize = true;
            this.lbEnlaceActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnlaceActual.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbEnlaceActual.Location = new System.Drawing.Point(3, 2);
            this.lbEnlaceActual.Name = "lbEnlaceActual";
            this.lbEnlaceActual.Size = new System.Drawing.Size(50, 16);
            this.lbEnlaceActual.TabIndex = 9;
            this.lbEnlaceActual.Text = "Enlace";
            // 
            // lbTotalNodosEvaluados
            // 
            this.lbTotalNodosEvaluados.AutoSize = true;
            this.lbTotalNodosEvaluados.Location = new System.Drawing.Point(134, 45);
            this.lbTotalNodosEvaluados.Name = "lbTotalNodosEvaluados";
            this.lbTotalNodosEvaluados.Size = new System.Drawing.Size(13, 13);
            this.lbTotalNodosEvaluados.TabIndex = 8;
            this.lbTotalNodosEvaluados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Nodos evaluados";
            // 
            // lbTotalNodosIdentificados
            // 
            this.lbTotalNodosIdentificados.AutoSize = true;
            this.lbTotalNodosIdentificados.Location = new System.Drawing.Point(134, 11);
            this.lbTotalNodosIdentificados.Name = "lbTotalNodosIdentificados";
            this.lbTotalNodosIdentificados.Size = new System.Drawing.Size(13, 13);
            this.lbTotalNodosIdentificados.TabIndex = 6;
            this.lbTotalNodosIdentificados.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Nodos Identificados";
            // 
            // lbTotalRegistroEncontrados
            // 
            this.lbTotalRegistroEncontrados.AutoSize = true;
            this.lbTotalRegistroEncontrados.Location = new System.Drawing.Point(134, 28);
            this.lbTotalRegistroEncontrados.Name = "lbTotalRegistroEncontrados";
            this.lbTotalRegistroEncontrados.Size = new System.Drawing.Size(13, 13);
            this.lbTotalRegistroEncontrados.TabIndex = 4;
            this.lbTotalRegistroEncontrados.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total recetas registradas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbPorcent);
            this.groupBox1.Controls.Add(this.progressBarBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(623, 15);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(26, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPorcent
            // 
            this.lbPorcent.AutoSize = true;
            this.lbPorcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcent.Location = new System.Drawing.Point(598, 15);
            this.lbPorcent.Name = "lbPorcent";
            this.lbPorcent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPorcent.Size = new System.Drawing.Size(21, 24);
            this.lbPorcent.TabIndex = 1;
            this.lbPorcent.Text = "0";
            this.lbPorcent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarBusqueda
            // 
            this.progressBarBusqueda.Location = new System.Drawing.Point(7, 16);
            this.progressBarBusqueda.Name = "progressBarBusqueda";
            this.progressBarBusqueda.Size = new System.Drawing.Size(569, 23);
            this.progressBarBusqueda.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Error Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClearLog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 40);
            this.panel3.TabIndex = 1;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(591, 7);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 0;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtErrorLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 436);
            this.panel2.TabIndex = 0;
            // 
            // txtErrorLog
            // 
            this.txtErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrorLog.Location = new System.Drawing.Point(0, 0);
            this.txtErrorLog.Multiline = true;
            this.txtErrorLog.Name = "txtErrorLog";
            this.txtErrorLog.Size = new System.Drawing.Size(655, 436);
            this.txtErrorLog.TabIndex = 1;
            // 
            // frmScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 664);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmScraper";
            this.Text = "Recipe Data Scraper";
            this.Load += new System.EventHandler(this.frmScraper_Load);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileHtmlPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox CboTipoPlato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.ComboBox cboMomentoComida;
        private System.Windows.Forms.ComboBox cboCultura;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuscarAchivo;
        private System.Windows.Forms.TextBox txtFileRoute;
        private System.Windows.Forms.ComboBox cboScrapMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbErrorCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEnlaceActual;
        private System.Windows.Forms.Label lbTotalNodosEvaluados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalNodosIdentificados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalRegistroEncontrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbPorcent;
        private System.Windows.Forms.ProgressBar progressBarBusqueda;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtErrorLog;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboFormato;
    }
}

