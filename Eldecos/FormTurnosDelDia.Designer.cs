namespace Eldecos
{
    partial class FormTurnosDelDia
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
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mntCalendario = new System.Windows.Forms.MonthCalendar();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEspecialista = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(446, 88);
            this.dgvTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 51;
            this.dgvTurnos.Size = new System.Drawing.Size(517, 219);
            this.dgvTurnos.TabIndex = 0;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellClick);
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(431, 375);
            this.cmbMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(159, 24);
            this.cmbMedicos.TabIndex = 1;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "9:00 - 9:30",
            "10:00 - 10:30",
            "11:00 - 11:30",
            "12:00 - 12:30",
            "13:00 - 13:30"});
            this.cmbHora.Location = new System.Drawing.Point(819, 375);
            this.cmbHora.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(159, 24);
            this.cmbHora.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(520, 437);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Cargar turno";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(643, 437);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "button2";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(771, 437);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "button3";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // mntCalendario
            // 
            this.mntCalendario.Location = new System.Drawing.Point(74, 100);
            this.mntCalendario.Name = "mntCalendario";
            this.mntCalendario.TabIndex = 7;
            this.mntCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntCalendario_DateChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(74, 375);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(196, 22);
            this.txtFecha.TabIndex = 8;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(624, 375);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(162, 22);
            this.txtPaciente.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(71, 356);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEspecialista
            // 
            this.lblEspecialista.AutoSize = true;
            this.lblEspecialista.Location = new System.Drawing.Point(428, 355);
            this.lblEspecialista.Name = "lblEspecialista";
            this.lblEspecialista.Size = new System.Drawing.Size(81, 16);
            this.lblEspecialista.TabIndex = 11;
            this.lblEspecialista.Text = "Especialista";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(621, 356);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(60, 16);
            this.lblPaciente.TabIndex = 12;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(816, 356);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(52, 16);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Horario";
            this.lblHorario.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormTurnosDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblEspecialista);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.mntCalendario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.dgvTurnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTurnosDelDia";
            this.Text = "FormTurnosDelDia";
            this.Load += new System.EventHandler(this.FormTurnosDelDia_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MonthCalendar mntCalendario;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEspecialista;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblHorario;
    }
}