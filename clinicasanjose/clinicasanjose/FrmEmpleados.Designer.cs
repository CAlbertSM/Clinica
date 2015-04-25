namespace ClinicaSanJose
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAPantallaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btGuardarEmpleado = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaNacEmpleado = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtPApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtPNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtSApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoIdentidad = new System.Windows.Forms.TextBox();
            this.txtNoColegiado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstadocivilEmpleado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGeneroEmpleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avanzadasToolStripMenuItem,
            this.agregarNuevoEmpleadoToolStripMenuItem,
            this.regresarAPantallaPrincipalToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // avanzadasToolStripMenuItem
            // 
            this.avanzadasToolStripMenuItem.Name = "avanzadasToolStripMenuItem";
            this.avanzadasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.avanzadasToolStripMenuItem.Text = "Agregar nuevo Empleado";
            this.avanzadasToolStripMenuItem.Click += new System.EventHandler(this.avanzadasToolStripMenuItem_Click);
            // 
            // agregarNuevoEmpleadoToolStripMenuItem
            // 
            this.agregarNuevoEmpleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarEmpleadoToolStripMenuItem1,
            this.modificarDatosEmpleadoToolStripMenuItem});
            this.agregarNuevoEmpleadoToolStripMenuItem.Name = "agregarNuevoEmpleadoToolStripMenuItem";
            this.agregarNuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.agregarNuevoEmpleadoToolStripMenuItem.Text = "Avanzadas";
            // 
            // eliminarEmpleadoToolStripMenuItem1
            // 
            this.eliminarEmpleadoToolStripMenuItem1.Name = "eliminarEmpleadoToolStripMenuItem1";
            this.eliminarEmpleadoToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.eliminarEmpleadoToolStripMenuItem1.Text = "Eliminar Empleado";
            this.eliminarEmpleadoToolStripMenuItem1.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem1_Click);
            // 
            // modificarDatosEmpleadoToolStripMenuItem
            // 
            this.modificarDatosEmpleadoToolStripMenuItem.Name = "modificarDatosEmpleadoToolStripMenuItem";
            this.modificarDatosEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modificarDatosEmpleadoToolStripMenuItem.Text = "Modificar Datos Empleado";
            this.modificarDatosEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosEmpleadoToolStripMenuItem_Click);
            // 
            // regresarAPantallaPrincipalToolStripMenuItem
            // 
            this.regresarAPantallaPrincipalToolStripMenuItem.Name = "regresarAPantallaPrincipalToolStripMenuItem";
            this.regresarAPantallaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.regresarAPantallaPrincipalToolStripMenuItem.Text = "Regresar a pantalla Principal";
            this.regresarAPantallaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.regresarAPantallaPrincipalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.salirToolStripMenuItem.Text = "Búsqueda";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar...";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // btGuardarEmpleado
            // 
            this.btGuardarEmpleado.Enabled = false;
            this.btGuardarEmpleado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarEmpleado.Location = new System.Drawing.Point(610, 588);
            this.btGuardarEmpleado.Name = "btGuardarEmpleado";
            this.btGuardarEmpleado.Size = new System.Drawing.Size(109, 34);
            this.btGuardarEmpleado.TabIndex = 23;
            this.btGuardarEmpleado.Text = "Guardar";
            this.btGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btGuardarEmpleado.Click += new System.EventHandler(this.btGuardarEmpleado_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Empleados...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ClinicaSanJose.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 115);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.FechaNacEmpleado);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNoIdentidad);
            this.groupBox1.Controls.Add(this.txtNoColegiado);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbEstadocivilEmpleado);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTelEmpleado);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDireccionEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbGeneroEmpleado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEspecialidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNoEmpleado);
            this.groupBox1.Controls.Add(this.cmbTipoEmpleado);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 386);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FechaNacEmpleado
            // 
            this.FechaNacEmpleado.Location = new System.Drawing.Point(137, 191);
            this.FechaNacEmpleado.Name = "FechaNacEmpleado";
            this.FechaNacEmpleado.Size = new System.Drawing.Size(192, 23);
            this.FechaNacEmpleado.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Especialidad:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSNombreEmpleado);
            this.groupBox2.Controls.Add(this.txtPApellidoEmpleado);
            this.groupBox2.Controls.Add(this.txtPNombreEmpleado);
            this.groupBox2.Controls.Add(this.txtSApellidoEmpleado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(24, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(319, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Segundo Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSNombreEmpleado
            // 
            this.txtSNombreEmpleado.Location = new System.Drawing.Point(434, 21);
            this.txtSNombreEmpleado.Name = "txtSNombreEmpleado";
            this.txtSNombreEmpleado.Size = new System.Drawing.Size(184, 23);
            this.txtSNombreEmpleado.TabIndex = 30;
            this.txtSNombreEmpleado.TextChanged += new System.EventHandler(this.txtSNombreEmpleado_TextChanged);
            this.txtSNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSNombreEmpleado_KeyPress);
            // 
            // txtPApellidoEmpleado
            // 
            this.txtPApellidoEmpleado.Location = new System.Drawing.Point(121, 61);
            this.txtPApellidoEmpleado.Name = "txtPApellidoEmpleado";
            this.txtPApellidoEmpleado.Size = new System.Drawing.Size(184, 23);
            this.txtPApellidoEmpleado.TabIndex = 12;
            this.txtPApellidoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPApellidoEmpleado_KeyPress);
            // 
            // txtPNombreEmpleado
            // 
            this.txtPNombreEmpleado.Location = new System.Drawing.Point(121, 21);
            this.txtPNombreEmpleado.Name = "txtPNombreEmpleado";
            this.txtPNombreEmpleado.Size = new System.Drawing.Size(184, 23);
            this.txtPNombreEmpleado.TabIndex = 10;
            this.txtPNombreEmpleado.TextChanged += new System.EventHandler(this.txtPNombreEmpleado_TextChanged);
            this.txtPNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPNombreEmpleado_KeyPress);
            // 
            // txtSApellidoEmpleado
            // 
            this.txtSApellidoEmpleado.Location = new System.Drawing.Point(434, 59);
            this.txtSApellidoEmpleado.Name = "txtSApellidoEmpleado";
            this.txtSApellidoEmpleado.Size = new System.Drawing.Size(184, 23);
            this.txtSApellidoEmpleado.TabIndex = 13;
            this.txtSApellidoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSApellidoEmpleado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Apellido:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNoIdentidad
            // 
            this.txtNoIdentidad.Location = new System.Drawing.Point(489, 22);
            this.txtNoIdentidad.Name = "txtNoIdentidad";
            this.txtNoIdentidad.Size = new System.Drawing.Size(184, 23);
            this.txtNoIdentidad.TabIndex = 28;
            this.txtNoIdentidad.TextChanged += new System.EventHandler(this.txtNoIdentidad_TextChanged);
            this.txtNoIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoIdentidad_KeyPress);
            // 
            // txtNoColegiado
            // 
            this.txtNoColegiado.Location = new System.Drawing.Point(130, 53);
            this.txtNoColegiado.Name = "txtNoColegiado";
            this.txtNoColegiado.Size = new System.Drawing.Size(121, 23);
            this.txtNoColegiado.TabIndex = 26;
            this.txtNoColegiado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoColegiado_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "No. Colegiado:";
            // 
            // cmbEstadocivilEmpleado
            // 
            this.cmbEstadocivilEmpleado.FormattingEnabled = true;
            this.cmbEstadocivilEmpleado.Items.AddRange(new object[] {
            "Solter@",
            "Casad@",
            "Divorciad@"});
            this.cmbEstadocivilEmpleado.Location = new System.Drawing.Point(137, 266);
            this.cmbEstadocivilEmpleado.Name = "cmbEstadocivilEmpleado";
            this.cmbEstadocivilEmpleado.Size = new System.Drawing.Size(111, 23);
            this.cmbEstadocivilEmpleado.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Estado Civil:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtTelEmpleado
            // 
            this.txtTelEmpleado.Location = new System.Drawing.Point(459, 227);
            this.txtTelEmpleado.Name = "txtTelEmpleado";
            this.txtTelEmpleado.Size = new System.Drawing.Size(184, 23);
            this.txtTelEmpleado.TabIndex = 22;
            this.txtTelEmpleado.TextChanged += new System.EventHandler(this.txtTelEmpleado_TextChanged);
            this.txtTelEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelEmpleado_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(390, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefono:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo Empleado:";
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(139, 306);
            this.txtDireccionEmpleado.Multiline = true;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(183, 64);
            this.txtDireccionEmpleado.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Direccion:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "No.Identidad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbGeneroEmpleado
            // 
            this.cmbGeneroEmpleado.FormattingEnabled = true;
            this.cmbGeneroEmpleado.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGeneroEmpleado.Location = new System.Drawing.Point(459, 189);
            this.cmbGeneroEmpleado.Name = "cmbGeneroEmpleado";
            this.cmbGeneroEmpleado.Size = new System.Drawing.Size(184, 23);
            this.cmbGeneroEmpleado.TabIndex = 14;
            this.cmbGeneroEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbGeneroEmpleado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nacimiento:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(137, 227);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(184, 23);
            this.txtEspecialidad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genero:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(130, 22);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(121, 23);
            this.txtNoEmpleado.TabIndex = 8;
            this.txtNoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoEmpleado_KeyPress);
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Items.AddRange(new object[] {
            "Tipo 1",
            "Tipo 2"});
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(488, 56);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(185, 23);
            this.cmbTipoEmpleado.TabIndex = 9;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::ClinicaSanJose.Properties.Resources.FondoFormularios21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGuardarEmpleado);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.TextBox txtPNombreEmpleado;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtPApellidoEmpleado;
        private System.Windows.Forms.TextBox txtSApellidoEmpleado;
        private System.Windows.Forms.ComboBox cmbGeneroEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGuardarEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarAPantallaPrincipalToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNoColegiado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEstadocivilEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNoIdentidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSNombreEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker FechaNacEmpleado;
    }
}