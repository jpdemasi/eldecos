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
            this.dgvTurnos.Location = new System.Drawing.Point(334, 72);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersWidth = 51;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(388, 178);
            this.dgvTurnos.TabIndex = 0;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellClick);
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(323, 305);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(120, 21);
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
            this.cmbHora.Location = new System.Drawing.Point(614, 305);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(120, 21);
            this.cmbHora.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(237, 352);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(326, 74);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Cargar turno";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mntCalendario
            // 
            this.mntCalendario.Location = new System.Drawing.Point(56, 81);
            this.mntCalendario.Margin = new System.Windows.Forms.Padding(7);
            this.mntCalendario.Name = "mntCalendario";
            this.mntCalendario.TabIndex = 7;
            this.mntCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntCalendario_DateChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(56, 305);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(148, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(468, 305);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(122, 20);
            this.txtPaciente.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(53, 289);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEspecialista
            // 
            this.lblEspecialista.AutoSize = true;
            this.lblEspecialista.Location = new System.Drawing.Point(321, 288);
            this.lblEspecialista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecialista.Name = "lblEspecialista";
            this.lblEspecialista.Size = new System.Drawing.Size(63, 13);
            this.lblEspecialista.TabIndex = 11;
            this.lblEspecialista.Text = "Especialista";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(466, 289);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 12;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(612, 289);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Horario";
            this.lblHorario.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormTurnosDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblEspecialista);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.mntCalendario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.dgvTurnos);
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
        private System.Windows.Forms.MonthCalendar mntCalendario;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEspecialista;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblHorario;
    }
}