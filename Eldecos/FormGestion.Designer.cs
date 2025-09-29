using MiProyecto.ControlesPersonalizados;


namespace Eldecos
{
    
    partial class FormGestion
    {
   
        private System.ComponentModel.IContainer components = null;

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
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTelefonos = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCargarPacientes = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.lblLinea = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlApp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRecepcion = new MiProyecto.ControlesPersonalizados.TabControlSinTabs();
            this.tbTurnos = new System.Windows.Forms.TabPage();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flpDias = new System.Windows.Forms.FlowLayoutPanel();
            this.tbFichas = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMailPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.tbMedicos = new System.Windows.Forms.TabPage();
            this.tbNum = new System.Windows.Forms.TabPage();
            this.pnlOpciones.SuspendLayout();
            this.pnlApp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbRecepcion.SuspendLayout();
            this.tbTurnos.SuspendLayout();
            this.tbFichas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlOpciones.Controls.Add(this.btnSalir);
            this.pnlOpciones.Controls.Add(this.btnTelefonos);
            this.pnlOpciones.Controls.Add(this.btnMedicos);
            this.pnlOpciones.Controls.Add(this.btnCargarPacientes);
            this.pnlOpciones.Controls.Add(this.btnTurnos);
            this.pnlOpciones.Controls.Add(this.lblLinea);
            this.pnlOpciones.Controls.Add(this.pnlLogo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(168, 881);
            this.pnlOpciones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(3, 768);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 92);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTelefonos
            // 
            this.btnTelefonos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTelefonos.FlatAppearance.BorderSize = 0;
            this.btnTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefonos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefonos.ForeColor = System.Drawing.Color.White;
            this.btnTelefonos.Location = new System.Drawing.Point(0, 597);
            this.btnTelefonos.Name = "btnTelefonos";
            this.btnTelefonos.Size = new System.Drawing.Size(168, 165);
            this.btnTelefonos.TabIndex = 4;
            this.btnTelefonos.Text = "Teléfonos";
            this.btnTelefonos.UseVisualStyleBackColor = true;
            this.btnTelefonos.Click += new System.EventHandler(this.btnTelefonos_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.Location = new System.Drawing.Point(0, 432);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(168, 165);
            this.btnMedicos.TabIndex = 3;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnCargarPacientes
            // 
            this.btnCargarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarPacientes.FlatAppearance.BorderSize = 0;
            this.btnCargarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPacientes.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnCargarPacientes.Location = new System.Drawing.Point(0, 267);
            this.btnCargarPacientes.Name = "btnCargarPacientes";
            this.btnCargarPacientes.Size = new System.Drawing.Size(168, 165);
            this.btnCargarPacientes.TabIndex = 2;
            this.btnCargarPacientes.Text = "Ficha Pacientes";
            this.btnCargarPacientes.UseVisualStyleBackColor = true;
            this.btnCargarPacientes.Click += new System.EventHandler(this.btnCargarPacientes_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.White;
            this.btnTurnos.Location = new System.Drawing.Point(0, 102);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(168, 165);
            this.btnTurnos.TabIndex = 1;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(-3, 105);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(181, 13);
            this.lblLinea.TabIndex = 0;
            this.lblLinea.Text = "----------------------------------------------------------";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Eldecos.Properties.Resources.Logo_Eldecos;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(168, 102);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlApp
            // 
            this.pnlApp.Controls.Add(this.panel1);
            this.pnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApp.Location = new System.Drawing.Point(168, 0);
            this.pnlApp.Name = "pnlApp";
            this.pnlApp.Size = new System.Drawing.Size(1183, 881);
            this.pnlApp.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbRecepcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 881);
            this.panel1.TabIndex = 0;
            // 
            // tbRecepcion
            // 
            this.tbRecepcion.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbRecepcion.Controls.Add(this.tbTurnos);
            this.tbRecepcion.Controls.Add(this.tbFichas);
            this.tbRecepcion.Controls.Add(this.tbMedicos);
            this.tbRecepcion.Controls.Add(this.tbNum);
            this.tbRecepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecepcion.Location = new System.Drawing.Point(0, 0);
            this.tbRecepcion.Name = "tbRecepcion";
            this.tbRecepcion.SelectedIndex = 0;
            this.tbRecepcion.Size = new System.Drawing.Size(1183, 881);
            this.tbRecepcion.TabIndex = 1;
            // 
            // tbTurnos
            // 
            this.tbTurnos.Controls.Add(this.lblMes);
            this.tbTurnos.Controls.Add(this.btnSiguiente);
            this.tbTurnos.Controls.Add(this.btnAnterior);
            this.tbTurnos.Controls.Add(this.label14);
            this.tbTurnos.Controls.Add(this.label13);
            this.tbTurnos.Controls.Add(this.label12);
            this.tbTurnos.Controls.Add(this.label11);
            this.tbTurnos.Controls.Add(this.label10);
            this.tbTurnos.Controls.Add(this.label9);
            this.tbTurnos.Controls.Add(this.label8);
            this.tbTurnos.Controls.Add(this.flpDias);
            this.tbTurnos.Location = new System.Drawing.Point(4, 25);
            this.tbTurnos.Name = "tbTurnos";
            this.tbTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tbTurnos.Size = new System.Drawing.Size(1175, 852);
            this.tbTurnos.TabIndex = 0;
            this.tbTurnos.UseVisualStyleBackColor = true;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(1009, 64);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(40, 29);
            this.lblMes.TabIndex = 10;
            this.lblMes.Text = "---";
            this.lblMes.UseMnemonic = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(846, 686);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(67, 31);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Sig >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(767, 686);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(70, 31);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "< Ant";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(812, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Sábado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(681, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Viernes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(558, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Jueves";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(418, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Miercoles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Martes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lunes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Domingo";
            // 
            // flpDias
            // 
            this.flpDias.AutoScroll = true;
            this.flpDias.Location = new System.Drawing.Point(39, 80);
            this.flpDias.Name = "flpDias";
            this.flpDias.Size = new System.Drawing.Size(883, 590);
            this.flpDias.TabIndex = 0;
            // 
            // tbFichas
            // 
            this.tbFichas.Controls.Add(this.label7);
            this.tbFichas.Controls.Add(this.btnBuscar);
            this.tbFichas.Controls.Add(this.lblBuscar);
            this.tbFichas.Controls.Add(this.txtBuscar);
            this.tbFichas.Controls.Add(this.label6);
            this.tbFichas.Controls.Add(this.txtDni);
            this.tbFichas.Controls.Add(this.dgvPacientes);
            this.tbFichas.Controls.Add(this.bntEliminar);
            this.tbFichas.Controls.Add(this.btnModificar);
            this.tbFichas.Controls.Add(this.btnAgregar);
            this.tbFichas.Controls.Add(this.label5);
            this.tbFichas.Controls.Add(this.label4);
            this.tbFichas.Controls.Add(this.label3);
            this.tbFichas.Controls.Add(this.label2);
            this.tbFichas.Controls.Add(this.label1);
            this.tbFichas.Controls.Add(this.txtMailPaciente);
            this.tbFichas.Controls.Add(this.txtTelefonoPaciente);
            this.tbFichas.Controls.Add(this.txtDireccionPaciente);
            this.tbFichas.Controls.Add(this.txtApellidoPaciente);
            this.tbFichas.Controls.Add(this.txtNombrePaciente);
            this.tbFichas.Location = new System.Drawing.Point(4, 25);
            this.tbFichas.Name = "tbFichas";
            this.tbFichas.Padding = new System.Windows.Forms.Padding(3);
            this.tbFichas.Size = new System.Drawing.Size(1175, 852);
            this.tbFichas.TabIndex = 1;
            this.tbFichas.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(642, 73);
            this.label7.TabIndex = 19;
            this.label7.Text = "Listado de pacientes";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(80, 541);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 38);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(77, 499);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(89, 13);
            this.lblBuscar.TabIndex = 17;
            this.lblBuscar.Text = "Buscar pacientes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(80, 515);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(117, 20);
            this.txtBuscar.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(669, 638);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(94, 20);
            this.txtDni.TabIndex = 14;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(243, 122);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(822, 460);
            this.dgvPacientes.TabIndex = 13;
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(753, 726);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(117, 38);
            this.bntEliminar.TabIndex = 12;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(606, 726);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 38);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(459, 726);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 38);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(867, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 622);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txtMailPaciente
            // 
            this.txtMailPaciente.Location = new System.Drawing.Point(868, 638);
            this.txtMailPaciente.Name = "txtMailPaciente";
            this.txtMailPaciente.Size = new System.Drawing.Size(94, 20);
            this.txtMailPaciente.TabIndex = 4;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(768, 638);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(94, 20);
            this.txtTelefonoPaciente.TabIndex = 3;
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Location = new System.Drawing.Point(569, 638);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(94, 20);
            this.txtDireccionPaciente.TabIndex = 2;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(469, 638);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(94, 20);
            this.txtApellidoPaciente.TabIndex = 1;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(369, 638);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(94, 20);
            this.txtNombrePaciente.TabIndex = 0;
            // 
            // tbMedicos
            // 
            this.tbMedicos.Location = new System.Drawing.Point(4, 25);
            this.tbMedicos.Name = "tbMedicos";
            this.tbMedicos.Size = new System.Drawing.Size(1175, 852);
            this.tbMedicos.TabIndex = 2;
            this.tbMedicos.UseVisualStyleBackColor = true;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(4, 25);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(1175, 852);
            this.tbNum.TabIndex = 3;
            this.tbNum.UseVisualStyleBackColor = true;
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 881);
            this.Controls.Add(this.pnlApp);
            this.Controls.Add(this.pnlOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGestion";
            this.Text = "Gestión de turnos y pacientes";
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlApp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbRecepcion.ResumeLayout(false);
            this.tbTurnos.ResumeLayout(false);
            this.tbTurnos.PerformLayout();
            this.tbFichas.ResumeLayout(false);
            this.tbFichas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlApp;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCargarPacientes;
        private System.Windows.Forms.Button btnTelefonos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.TabControl tbRecepcion;

         //private Eldecos.TabControlSinTabs tbRecepcion;
        private TabControlSinTabs tbRecepcion;


        //private TabControlSinEncabezado tbRecepcion;

        private System.Windows.Forms.TabPage tbTurnos;
        private System.Windows.Forms.TabPage tbFichas;
        private System.Windows.Forms.TabPage tbMedicos;
        private System.Windows.Forms.TabPage tbNum;
        private System.Windows.Forms.Button bntEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMailPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flpDias;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblMes;
    }
}