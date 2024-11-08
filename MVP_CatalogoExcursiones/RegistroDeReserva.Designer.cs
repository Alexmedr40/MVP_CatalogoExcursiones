namespace MVP_CatalogoExcursiones
{
    partial class RegistroDeReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeReserva));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProcesando = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLugarPickUp = new System.Windows.Forms.ComboBox();
            this.comboBoxInfantes = new System.Windows.Forms.ComboBox();
            this.comboBoxNinos = new System.Windows.Forms.ComboBox();
            this.comboBoxAdultos = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 113);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 42);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProcesando);
            this.panel3.Controls.Add(this.btnConfirmarReserva);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxLugarPickUp);
            this.panel3.Controls.Add(this.comboBoxInfantes);
            this.panel3.Controls.Add(this.comboBoxNinos);
            this.panel3.Controls.Add(this.comboBoxAdultos);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 411);
            this.panel3.TabIndex = 3;
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(31, 358);
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(21, 20);
            this.lblProcesando.TabIndex = 20;
            this.lblProcesando.Text = "**";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarReserva.Location = new System.Drawing.Point(21, 271);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(388, 65);
            this.btnConfirmarReserva.TabIndex = 19;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = true;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lugar de Recogida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pax:";
            // 
            // comboBoxLugarPickUp
            // 
            this.comboBoxLugarPickUp.FormattingEnabled = true;
            this.comboBoxLugarPickUp.Items.AddRange(new object[] {
            "El Hotel Tal",
            "La Plaza Tal",
            "La Gasolinera Tal",
            "La Calle Tal"});
            this.comboBoxLugarPickUp.Location = new System.Drawing.Point(35, 195);
            this.comboBoxLugarPickUp.Name = "comboBoxLugarPickUp";
            this.comboBoxLugarPickUp.Size = new System.Drawing.Size(365, 28);
            this.comboBoxLugarPickUp.TabIndex = 15;
            this.comboBoxLugarPickUp.Text = "Pick Up";
            // 
            // comboBoxInfantes
            // 
            this.comboBoxInfantes.FormattingEnabled = true;
            this.comboBoxInfantes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxInfantes.Location = new System.Drawing.Point(302, 98);
            this.comboBoxInfantes.Name = "comboBoxInfantes";
            this.comboBoxInfantes.Size = new System.Drawing.Size(98, 28);
            this.comboBoxInfantes.TabIndex = 14;
            this.comboBoxInfantes.Text = "Infantes";
            // 
            // comboBoxNinos
            // 
            this.comboBoxNinos.FormattingEnabled = true;
            this.comboBoxNinos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNinos.Location = new System.Drawing.Point(200, 98);
            this.comboBoxNinos.Name = "comboBoxNinos";
            this.comboBoxNinos.Size = new System.Drawing.Size(86, 28);
            this.comboBoxNinos.TabIndex = 13;
            this.comboBoxNinos.Text = "Niños";
            // 
            // comboBoxAdultos
            // 
            this.comboBoxAdultos.FormattingEnabled = true;
            this.comboBoxAdultos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxAdultos.Location = new System.Drawing.Point(96, 98);
            this.comboBoxAdultos.Name = "comboBoxAdultos";
            this.comboBoxAdultos.Size = new System.Drawing.Size(86, 28);
            this.comboBoxAdultos.TabIndex = 12;
            this.comboBoxAdultos.Text = "Adultos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(72, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "Formulario de Reserva";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistroDeReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RegistroDeReserva";
            this.Text = "RegistroDeReserva";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProcesando;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLugarPickUp;
        private System.Windows.Forms.ComboBox comboBoxInfantes;
        private System.Windows.Forms.ComboBox comboBoxNinos;
        private System.Windows.Forms.ComboBox comboBoxAdultos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}