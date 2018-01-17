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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbTraducciones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalIngredientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNuevaPalabra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMainVocabulary = new System.Windows.Forms.TextBox();
            this.MnModificarBaseConocimiento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTotalregistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDatosOrigen = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFrencuenciaPalabras = new System.Windows.Forms.TextBox();
            this.CmAgregarPalabraBc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.lbRegistroEncontrados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.chkModify = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgDatosClasificacion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cboClassOf = new System.Windows.Forms.ComboBox();
            this.btnViewFile = new System.Windows.Forms.Button();
            this.btnMigrar = new System.Windows.Forms.Button();
            this.btnBuscarDataOwl = new System.Windows.Forms.Button();
            this.lbRegistroEncontradosOwl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgOwlData = new System.Windows.Forms.DataGridView();
            this.recetaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredienteIDValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredienteValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassOfValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarIngrediente = new System.Windows.Forms.Button();
            this.btnTraducirIngredientes = new System.Windows.Forms.Button();
            this.btnTraducir = new System.Windows.Forms.Button();
            this.btnEvaluarBaseDatos = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnMarcarRegistro = new System.Windows.Forms.Button();
            this.RecipeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredienteDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubClassOfCurrentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubClassOf = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MnModificarBaseConocimiento.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CmAgregarPalabraBc.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosClasificacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwlData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 584);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbTraducciones);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lbTotalIngredientes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbTotalregistro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Identificacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbTraducciones
            // 
            this.lbTraducciones.AutoSize = true;
            this.lbTraducciones.Location = new System.Drawing.Point(314, 529);
            this.lbTraducciones.Name = "lbTraducciones";
            this.lbTraducciones.Size = new System.Drawing.Size(13, 13);
            this.lbTraducciones.TabIndex = 18;
            this.lbTraducciones.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Traducciones";
            // 
            // lbTotalIngredientes
            // 
            this.lbTotalIngredientes.AutoSize = true;
            this.lbTotalIngredientes.Location = new System.Drawing.Point(209, 528);
            this.lbTotalIngredientes.Name = "lbTotalIngredientes";
            this.lbTotalIngredientes.Size = new System.Drawing.Size(13, 13);
            this.lbTotalIngredientes.TabIndex = 14;
            this.lbTotalIngredientes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingredientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNuevaPalabra);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtMainVocabulary);
            this.panel1.Location = new System.Drawing.Point(625, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 507);
            this.panel1.TabIndex = 9;
            // 
            // txtNuevaPalabra
            // 
            this.txtNuevaPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaPalabra.Location = new System.Drawing.Point(3, 446);
            this.txtNuevaPalabra.Name = "txtNuevaPalabra";
            this.txtNuevaPalabra.Size = new System.Drawing.Size(249, 29);
            this.txtNuevaPalabra.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(160, 481);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMainVocabulary
            // 
            this.txtMainVocabulary.BackColor = System.Drawing.Color.White;
            this.txtMainVocabulary.ContextMenuStrip = this.MnModificarBaseConocimiento;
            this.txtMainVocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMainVocabulary.Location = new System.Drawing.Point(0, 0);
            this.txtMainVocabulary.Multiline = true;
            this.txtMainVocabulary.Name = "txtMainVocabulary";
            this.txtMainVocabulary.ReadOnly = true;
            this.txtMainVocabulary.Size = new System.Drawing.Size(255, 440);
            this.txtMainVocabulary.TabIndex = 0;
            // 
            // MnModificarBaseConocimiento
            // 
            this.MnModificarBaseConocimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.MnModificarBaseConocimiento.Name = "MnModificarBaseConocimiento";
            this.MnModificarBaseConocimiento.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
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
            this.txtDatosOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDatosOrigen.Location = new System.Drawing.Point(0, 0);
            this.txtDatosOrigen.Multiline = true;
            this.txtDatosOrigen.Name = "txtDatosOrigen";
            this.txtDatosOrigen.Size = new System.Drawing.Size(446, 508);
            this.txtDatosOrigen.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFrencuenciaPalabras);
            this.panel3.Location = new System.Drawing.Point(452, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 511);
            this.panel3.TabIndex = 2;
            // 
            // txtFrencuenciaPalabras
            // 
            this.txtFrencuenciaPalabras.ContextMenuStrip = this.CmAgregarPalabraBc;
            this.txtFrencuenciaPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrencuenciaPalabras.Location = new System.Drawing.Point(3, 2);
            this.txtFrencuenciaPalabras.Multiline = true;
            this.txtFrencuenciaPalabras.Name = "txtFrencuenciaPalabras";
            this.txtFrencuenciaPalabras.Size = new System.Drawing.Size(164, 505);
            this.txtFrencuenciaPalabras.TabIndex = 1;
            // 
            // CmAgregarPalabraBc
            // 
            this.CmAgregarPalabraBc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CmAgregarPalabraBc.Name = "CmAgregarPalabraBc";
            this.CmAgregarPalabraBc.Size = new System.Drawing.Size(117, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem1.Text = "Agregar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 517);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(880, 38);
            this.textBox2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBuscarRegistros);
            this.tabPage3.Controls.Add(this.lbRegistroEncontrados);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnGuardarCambios);
            this.tabPage3.Controls.Add(this.chkModify);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(886, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clasificacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.Location = new System.Drawing.Point(642, 523);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(117, 26);
            this.btnBuscarRegistros.TabIndex = 5;
            this.btnBuscarRegistros.Text = "Buscar Data";
            this.btnBuscarRegistros.UseVisualStyleBackColor = true;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // lbRegistroEncontrados
            // 
            this.lbRegistroEncontrados.AutoSize = true;
            this.lbRegistroEncontrados.Location = new System.Drawing.Point(241, 503);
            this.lbRegistroEncontrados.Name = "lbRegistroEncontrados";
            this.lbRegistroEncontrados.Size = new System.Drawing.Size(13, 13);
            this.lbRegistroEncontrados.TabIndex = 4;
            this.lbRegistroEncontrados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registros Encontrados";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(763, 523);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(117, 26);
            this.btnGuardarCambios.TabIndex = 2;
            this.btnGuardarCambios.Text = "Guardar Clasificacion";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // chkModify
            // 
            this.chkModify.AutoSize = true;
            this.chkModify.Location = new System.Drawing.Point(12, 500);
            this.chkModify.Name = "chkModify";
            this.chkModify.Size = new System.Drawing.Size(106, 17);
            this.chkModify.TabIndex = 1;
            this.chkModify.Text = "Modificar valores";
            this.chkModify.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgDatosClasificacion);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgDatosClasificacion
            // 
            this.dgDatosClasificacion.AllowUserToAddRows = false;
            this.dgDatosClasificacion.AllowUserToDeleteRows = false;
            this.dgDatosClasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatosClasificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDatosClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosClasificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecipeID,
            this.RecipeName,
            this.ingredienteID,
            this.IngredienteDescripcion,
            this.SubClassOfCurrentValue,
            this.SubClassOf});
            this.dgDatosClasificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDatosClasificacion.Location = new System.Drawing.Point(3, 16);
            this.dgDatosClasificacion.Name = "dgDatosClasificacion";
            this.dgDatosClasificacion.RowHeadersVisible = false;
            this.dgDatosClasificacion.Size = new System.Drawing.Size(868, 463);
            this.dgDatosClasificacion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cboClassOf);
            this.tabPage2.Controls.Add(this.btnViewFile);
            this.tabPage2.Controls.Add(this.btnMigrar);
            this.tabPage2.Controls.Add(this.btnBuscarDataOwl);
            this.tabPage2.Controls.Add(this.lbRegistroEncontradosOwl);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 558);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Owl data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "SubClassOf";
            // 
            // cboClassOf
            // 
            this.cboClassOf.FormattingEnabled = true;
            this.cboClassOf.Location = new System.Drawing.Point(666, 480);
            this.cboClassOf.Name = "cboClassOf";
            this.cboClassOf.Size = new System.Drawing.Size(210, 21);
            this.cboClassOf.TabIndex = 6;
            // 
            // btnViewFile
            // 
            this.btnViewFile.Location = new System.Drawing.Point(666, 526);
            this.btnViewFile.Name = "btnViewFile";
            this.btnViewFile.Size = new System.Drawing.Size(96, 23);
            this.btnViewFile.TabIndex = 5;
            this.btnViewFile.Text = "View Owl File";
            this.btnViewFile.UseVisualStyleBackColor = true;
            this.btnViewFile.Click += new System.EventHandler(this.btnViewFile_Click);
            // 
            // btnMigrar
            // 
            this.btnMigrar.Location = new System.Drawing.Point(764, 526);
            this.btnMigrar.Name = "btnMigrar";
            this.btnMigrar.Size = new System.Drawing.Size(112, 23);
            this.btnMigrar.TabIndex = 4;
            this.btnMigrar.Text = "Migrar Data To Owl";
            this.btnMigrar.UseVisualStyleBackColor = true;
            this.btnMigrar.Click += new System.EventHandler(this.btnMigrar_Click);
            // 
            // btnBuscarDataOwl
            // 
            this.btnBuscarDataOwl.Location = new System.Drawing.Point(589, 526);
            this.btnBuscarDataOwl.Name = "btnBuscarDataOwl";
            this.btnBuscarDataOwl.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDataOwl.TabIndex = 3;
            this.btnBuscarDataOwl.Text = "Buscar Data";
            this.btnBuscarDataOwl.UseVisualStyleBackColor = true;
            this.btnBuscarDataOwl.Click += new System.EventHandler(this.btnBuscarDataOwl_Click);
            // 
            // lbRegistroEncontradosOwl
            // 
            this.lbRegistroEncontradosOwl.AutoSize = true;
            this.lbRegistroEncontradosOwl.Location = new System.Drawing.Point(122, 477);
            this.lbRegistroEncontradosOwl.Name = "lbRegistroEncontradosOwl";
            this.lbRegistroEncontradosOwl.Size = new System.Drawing.Size(13, 13);
            this.lbRegistroEncontradosOwl.TabIndex = 2;
            this.lbRegistroEncontradosOwl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registro encontrados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgOwlData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 471);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dgOwlData
            // 
            this.dgOwlData.AllowUserToAddRows = false;
            this.dgOwlData.AllowUserToDeleteRows = false;
            this.dgOwlData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOwlData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgOwlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOwlData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recetaID,
            this.dataGridViewTextBoxColumn2,
            this.ingredienteIDValue,
            this.ingredienteValue,
            this.ClassOfValue});
            this.dgOwlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOwlData.Location = new System.Drawing.Point(3, 16);
            this.dgOwlData.Name = "dgOwlData";
            this.dgOwlData.RowHeadersVisible = false;
            this.dgOwlData.Size = new System.Drawing.Size(874, 452);
            this.dgOwlData.TabIndex = 1;
            // 
            // recetaID
            // 
            this.recetaID.DataPropertyName = "recipeID";
            this.recetaID.HeaderText = "Receta ID";
            this.recetaID.Name = "recetaID";
            this.recetaID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "recipeName";
            this.dataGridViewTextBoxColumn2.FillWeight = 350F;
            this.dataGridViewTextBoxColumn2.HeaderText = "R Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ingredienteIDValue
            // 
            this.ingredienteIDValue.DataPropertyName = "ingredienteID";
            this.ingredienteIDValue.FillWeight = 90F;
            this.ingredienteIDValue.HeaderText = "Ingrediente ID";
            this.ingredienteIDValue.Name = "ingredienteIDValue";
            this.ingredienteIDValue.ReadOnly = true;
            this.ingredienteIDValue.Visible = false;
            // 
            // ingredienteValue
            // 
            this.ingredienteValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredienteValue.DataPropertyName = "ingredienteDescripcion";
            this.ingredienteValue.FillWeight = 350F;
            this.ingredienteValue.HeaderText = "Ingrediente Descripcioon";
            this.ingredienteValue.Name = "ingredienteValue";
            this.ingredienteValue.ReadOnly = true;
            // 
            // ClassOfValue
            // 
            this.ClassOfValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassOfValue.DataPropertyName = "classof";
            this.ClassOfValue.FillWeight = 150F;
            this.ClassOfValue.HeaderText = "SubClassOf";
            this.ClassOfValue.Name = "ClassOfValue";
            this.ClassOfValue.ReadOnly = true;
            this.ClassOfValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassOfValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Limite";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(54, 518);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRegistrarIngrediente);
            this.panel2.Controls.Add(this.btnTraducirIngredientes);
            this.panel2.Controls.Add(this.txtLimit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTraducir);
            this.panel2.Controls.Add(this.btnEvaluarBaseDatos);
            this.panel2.Controls.Add(this.btnEvaluar);
            this.panel2.Controls.Add(this.btnMarcarRegistro);
            this.panel2.Location = new System.Drawing.Point(896, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 552);
            this.panel2.TabIndex = 10;
            // 
            // btnRegistrarIngrediente
            // 
            this.btnRegistrarIngrediente.Location = new System.Drawing.Point(1, 158);
            this.btnRegistrarIngrediente.Name = "btnRegistrarIngrediente";
            this.btnRegistrarIngrediente.Size = new System.Drawing.Size(154, 23);
            this.btnRegistrarIngrediente.TabIndex = 18;
            this.btnRegistrarIngrediente.Text = "R. Ingrediente Principal";
            this.btnRegistrarIngrediente.UseVisualStyleBackColor = true;
            this.btnRegistrarIngrediente.Click += new System.EventHandler(this.btnRegistrarIngrediente_Click);
            // 
            // btnTraducirIngredientes
            // 
            this.btnTraducirIngredientes.Location = new System.Drawing.Point(3, 129);
            this.btnTraducirIngredientes.Name = "btnTraducirIngredientes";
            this.btnTraducirIngredientes.Size = new System.Drawing.Size(154, 23);
            this.btnTraducirIngredientes.TabIndex = 17;
            this.btnTraducirIngredientes.Text = "Traducir ingredientes";
            this.btnTraducirIngredientes.UseVisualStyleBackColor = true;
            this.btnTraducirIngredientes.Click += new System.EventHandler(this.btnTraducirIngredientes_Click);
            // 
            // btnTraducir
            // 
            this.btnTraducir.Location = new System.Drawing.Point(3, 100);
            this.btnTraducir.Name = "btnTraducir";
            this.btnTraducir.Size = new System.Drawing.Size(154, 23);
            this.btnTraducir.TabIndex = 12;
            this.btnTraducir.Text = "Traducir registros Receta";
            this.btnTraducir.UseVisualStyleBackColor = true;
            this.btnTraducir.Click += new System.EventHandler(this.btnTraducir_Click);
            // 
            // btnEvaluarBaseDatos
            // 
            this.btnEvaluarBaseDatos.Location = new System.Drawing.Point(3, 13);
            this.btnEvaluarBaseDatos.Name = "btnEvaluarBaseDatos";
            this.btnEvaluarBaseDatos.Size = new System.Drawing.Size(154, 23);
            this.btnEvaluarBaseDatos.TabIndex = 6;
            this.btnEvaluarBaseDatos.Text = "Buscar informacion DB";
            this.btnEvaluarBaseDatos.UseVisualStyleBackColor = true;
            this.btnEvaluarBaseDatos.Click += new System.EventHandler(this.btnEvaluarBaseDatos_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(3, 42);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(154, 23);
            this.btnEvaluar.TabIndex = 5;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnMarcarRegistro
            // 
            this.btnMarcarRegistro.Location = new System.Drawing.Point(3, 71);
            this.btnMarcarRegistro.Name = "btnMarcarRegistro";
            this.btnMarcarRegistro.Size = new System.Drawing.Size(154, 23);
            this.btnMarcarRegistro.TabIndex = 11;
            this.btnMarcarRegistro.Text = "Marcar Registros";
            this.btnMarcarRegistro.UseVisualStyleBackColor = true;
            this.btnMarcarRegistro.Click += new System.EventHandler(this.btnMarcarRegistro_Click);
            // 
            // RecipeID
            // 
            this.RecipeID.DataPropertyName = "recipeID";
            this.RecipeID.HeaderText = "Receta ID";
            this.RecipeID.Name = "RecipeID";
            this.RecipeID.Visible = false;
            // 
            // RecipeName
            // 
            this.RecipeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RecipeName.DataPropertyName = "recipeName";
            this.RecipeName.FillWeight = 350F;
            this.RecipeName.HeaderText = "R Nombre";
            this.RecipeName.Name = "RecipeName";
            // 
            // ingredienteID
            // 
            this.ingredienteID.DataPropertyName = "ingredienteID";
            this.ingredienteID.FillWeight = 90F;
            this.ingredienteID.HeaderText = "Ingrediente ID";
            this.ingredienteID.Name = "ingredienteID";
            this.ingredienteID.Visible = false;
            // 
            // IngredienteDescripcion
            // 
            this.IngredienteDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IngredienteDescripcion.DataPropertyName = "ingredienteDescripcion";
            this.IngredienteDescripcion.FillWeight = 350F;
            this.IngredienteDescripcion.HeaderText = "Ingrediente Descripcioon";
            this.IngredienteDescripcion.Name = "IngredienteDescripcion";
            // 
            // SubClassOfCurrentValue
            // 
            this.SubClassOfCurrentValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubClassOfCurrentValue.DataPropertyName = "ClassOf";
            this.SubClassOfCurrentValue.FillWeight = 150F;
            this.SubClassOfCurrentValue.HeaderText = "valor Actual";
            this.SubClassOfCurrentValue.Name = "SubClassOfCurrentValue";
            this.SubClassOfCurrentValue.ReadOnly = true;
            // 
            // SubClassOf
            // 
            this.SubClassOf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubClassOf.DataPropertyName = "subClassOf";
            this.SubClassOf.FillWeight = 150F;
            this.SubClassOf.HeaderText = "SubClassOf";
            this.SubClassOf.Name = "SubClassOf";
            // 
            // frmMineria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "frmMineria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mineria de ingredientes";
            this.Load += new System.EventHandler(this.frmMineria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MnModificarBaseConocimiento.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CmAgregarPalabraBc.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosClasificacion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOwlData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDatosOrigen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFrencuenciaPalabras;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnEvaluarBaseDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNuevaPalabra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMainVocabulary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMarcarRegistro;
        private System.Windows.Forms.ContextMenuStrip MnModificarBaseConocimiento;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CmAgregarPalabraBc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgDatosClasificacion;
        private System.Windows.Forms.Label lbTraducciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalIngredientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalregistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chkModify;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lbRegistroEncontrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.Button btnBuscarDataOwl;
        private System.Windows.Forms.Label lbRegistroEncontradosOwl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMigrar;
        private System.Windows.Forms.DataGridView dgOwlData;
        private System.Windows.Forms.Button btnViewFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboClassOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredienteIDValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredienteValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassOfValue;
        private System.Windows.Forms.Button btnTraducirIngredientes;
        private System.Windows.Forms.Button btnRegistrarIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredienteDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubClassOfCurrentValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn SubClassOf;
    }
}

