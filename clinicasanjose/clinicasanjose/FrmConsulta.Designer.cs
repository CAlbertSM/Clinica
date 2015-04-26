namespace ClinicaSanJose
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btVerDatosPaciente = new System.Windows.Forms.Button();
            this.btVerHistorial = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCrearPrescripcion = new System.Windows.Forms.Button();
            this.btVerPrescripcion = new System.Windows.Forms.Button();
            this.lblAccion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTemperatura = new System.Windows.Forms.MaskedTextBox();
            this.txtPresion = new System.Windows.Forms.MaskedTextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Empleado:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(306, 210);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 15);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "12/12/2014";
            this.lblFecha.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(133, 210);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(35, 15);
            this.lblCodigoEmpleado.TabIndex = 20;
            this.lblCodigoEmpleado.Text = "0001";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.salirToolStripMenuItem.Text = "Regresar a menú principal...";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Enabled = false;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(62, 586);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(168, 31);
            this.btGuardar.TabIndex = 22;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btVerDatosPaciente
            // 
            this.btVerDatosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerDatosPaciente.Location = new System.Drawing.Point(233, 586);
            this.btVerDatosPaciente.Name = "btVerDatosPaciente";
            this.btVerDatosPaciente.Size = new System.Drawing.Size(168, 31);
            this.btVerDatosPaciente.TabIndex = 23;
            this.btVerDatosPaciente.Text = "Ver datos del paciente";
            this.btVerDatosPaciente.UseVisualStyleBackColor = true;
            this.btVerDatosPaciente.Click += new System.EventHandler(this.btVerDatosPaciente_Click_1);
            // 
            // btVerHistorial
            // 
            this.btVerHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerHistorial.Location = new System.Drawing.Point(407, 586);
            this.btVerHistorial.Name = "btVerHistorial";
            this.btVerHistorial.Size = new System.Drawing.Size(168, 31);
            this.btVerHistorial.TabIndex = 24;
            this.btVerHistorial.Text = "Ver historial del paciente";
            this.btVerHistorial.UseVisualStyleBackColor = true;
            this.btVerHistorial.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(581, 586);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(168, 31);
            this.btEliminar.TabIndex = 28;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCrearPrescripcion
            // 
            this.btCrearPrescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrearPrescripcion.Location = new System.Drawing.Point(20, 265);
            this.btCrearPrescripcion.Name = "btCrearPrescripcion";
            this.btCrearPrescripcion.Size = new System.Drawing.Size(168, 31);
            this.btCrearPrescripcion.TabIndex = 29;
            this.btCrearPrescripcion.Text = "Crear Prescripcion";
            this.btCrearPrescripcion.UseVisualStyleBackColor = true;
            this.btCrearPrescripcion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVerPrescripcion
            // 
            this.btVerPrescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerPrescripcion.Location = new System.Drawing.Point(190, 265);
            this.btVerPrescripcion.Name = "btVerPrescripcion";
            this.btVerPrescripcion.Size = new System.Drawing.Size(168, 31);
            this.btVerPrescripcion.TabIndex = 30;
            this.btVerPrescripcion.Text = "Ver Prescripcion";
            this.btVerPrescripcion.UseVisualStyleBackColor = true;
            this.btVerPrescripcion.Click += new System.EventHandler(this.btVerPrescripcion_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.BackColor = System.Drawing.Color.Transparent;
            this.lblAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(36, 171);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(360, 25);
            this.lblAccion.TabIndex = 32;
            this.lblAccion.Text = "Buscar el Expediente de la Consulta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ClinicaSanJose.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 115);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNoExpediente);
            this.groupBox3.Controls.Add(this.txtNombrePaciente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 92);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°Expediente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Paciente:";
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Enabled = false;
            this.txtNoExpediente.Location = new System.Drawing.Point(134, 23);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(100, 21);
            this.txtNoExpediente.TabIndex = 14;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Enabled = false;
            this.txtNombrePaciente.Location = new System.Drawing.Point(134, 58);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(167, 21);
            this.txtNombrePaciente.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Controls.Add(this.btVerPrescripcion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btCrearPrescripcion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtProblema);
            this.groupBox2.Controls.Add(this.txtDiagnostico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 319);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "Observacion:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(91, 175);
            this.txtObservacion.MaxLength = 20;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(247, 62);
            this.txtObservacion.TabIndex = 20;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Problema:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Diagnostico:";
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(91, 26);
            this.txtProblema.MaxLength = 400;
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(247, 72);
            this.txtProblema.TabIndex = 16;
            this.txtProblema.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(91, 104);
            this.txtDiagnostico.MaxLength = 400;
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(247, 62);
            this.txtDiagnostico.TabIndex = 17;
            this.txtDiagnostico.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTemperatura);
            this.groupBox1.Controls.Add(this.txtPresion);
            this.groupBox1.Controls.Add(this.txtEstatura);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signos Vitales";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(115, 155);
            this.txtTemperatura.Mask = "99.99";
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 21);
            this.txtTemperatura.TabIndex = 9;
            this.txtTemperatura.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(115, 124);
            this.txtPresion.Mask = "000/000";
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(100, 21);
            this.txtPresion.TabIndex = 8;
            this.txtPresion.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(115, 92);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(100, 21);
            this.txtEstatura.TabIndex = 5;
            this.txtEstatura.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(115, 61);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 21);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Temperatura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Presion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Estatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Peso:";
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ClinicaSanJose.Properties.Resources.FondoFormularios23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 629);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btVerHistorial);
            this.Controls.Add(this.btVerDatosPaciente);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lblCodigoEmpleado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.Button btVerDatosPaciente;
        private System.Windows.Forms.Button btVerHistorial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btCrearPrescripcion;
        private System.Windows.Forms.Button btVerPrescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccion;
        internal System.Windows.Forms.TextBox txtEstatura;
        internal System.Windows.Forms.TextBox txtPeso;
        internal System.Windows.Forms.TextBox txtNoExpediente;
        internal System.Windows.Forms.TextBox txtNombrePaciente;
        internal System.Windows.Forms.TextBox txtProblema;
        internal System.Windows.Forms.TextBox txtDiagnostico;
        internal System.Windows.Forms.TextBox txtObservacion;
        internal System.Windows.Forms.MaskedTextBox txtTemperatura;
        internal System.Windows.Forms.MaskedTextBox txtPresion;
        internal System.Windows.Forms.Button btGuardar;
        internal System.Windows.Forms.Button btEliminar;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Label lblCodigoEmpleado;
    }
}