namespace Eldecos
{
    partial class FormTurno
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
            this.txtBusquedaPaciente = new System.Windows.Forms.TextBox();
            this.txtBusquedaMedico = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnSalirTurno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaPaciente
            // 
            this.txtBusquedaPaciente.Location = new System.Drawing.Point(76, 351);
            this.txtBusquedaPaciente.Name = "txtBusquedaPaciente";
            this.txtBusquedaPaciente.Size = new System.Drawing.Size(176, 20);
            this.txtBusquedaPaciente.TabIndex = 0;
            // 
            // txtBusquedaMedico
            // 
            this.txtBusquedaMedico.Location = new System.Drawing.Point(271, 351);
            this.txtBusquedaMedico.Name = "txtBusquedaMedico";
            this.txtBusquedaMedico.Size = new System.Drawing.Size(176, 20);
            this.txtBusquedaMedico.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 25);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "lblFecha";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(466, 350);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(192, 21);
            this.cmbHora.TabIndex = 3;
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Location = new System.Drawing.Point(465, 396);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(112, 29);
            this.btnAsignarTurno.TabIndex = 4;
            this.btnAsignarTurno.Text = "Cargar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            // 
            // btnSalirTurno
            // 
            this.btnSalirTurno.Location = new System.Drawing.Point(617, 396);
            this.btnSalirTurno.Name = "btnSalirTurno";
            this.btnSalirTurno.Size = new System.Drawing.Size(112, 29);
            this.btnSalirTurno.TabIndex = 5;
            this.btnSalirTurno.Text = "Salir";
            this.btnSalirTurno.UseVisualStyleBackColor = true;
            this.btnSalirTurno.Click += new System.EventHandler(this.btnSalirTurno_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 228);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalirTurno);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtBusquedaMedico);
            this.Controls.Add(this.txtBusquedaPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTurno";
            this.Text = "FormTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaPaciente;
        private System.Windows.Forms.TextBox txtBusquedaMedico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Button btnSalirTurno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}