namespace Alquilar
{
    partial class Alquilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alquilar));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoPersona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.ValorKM = new System.Windows.Forms.Label();
            this.txtValorKM = new System.Windows.Forms.TextBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cedula Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca: ";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(91, 101);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(149, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Placa: ";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(91, 38);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(149, 20);
            this.txtPlaca.TabIndex = 10;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(476, 36);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(149, 20);
            this.txtCedula.TabIndex = 12;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(476, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "TipoPersona: ";
            // 
            // txtTipoPersona
            // 
            this.txtTipoPersona.Location = new System.Drawing.Point(476, 154);
            this.txtTipoPersona.Name = "txtTipoPersona";
            this.txtTipoPersona.Size = new System.Drawing.Size(149, 20);
            this.txtTipoPersona.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kilometraje: ";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(91, 150);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(149, 20);
            this.txtKilometraje.TabIndex = 17;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(91, 252);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(655, 229);
            this.dataGridViewResult.TabIndex = 19;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(626, 223);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(120, 23);
            this.buttonCalcular.TabIndex = 20;
            this.buttonCalcular.Text = "Calcular Precio";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // ValorKM
            // 
            this.ValorKM.AutoSize = true;
            this.ValorKM.Location = new System.Drawing.Point(22, 223);
            this.ValorKM.Name = "ValorKM";
            this.ValorKM.Size = new System.Drawing.Size(53, 13);
            this.ValorKM.TabIndex = 22;
            this.ValorKM.Text = "ValorKM: ";
            // 
            // txtValorKM
            // 
            this.txtValorKM.Location = new System.Drawing.Point(91, 216);
            this.txtValorKM.Name = "txtValorKM";
            this.txtValorKM.Size = new System.Drawing.Size(149, 20);
            this.txtValorKM.TabIndex = 21;
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(340, 217);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(133, 20);
            this.dateFecha.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(362, 497);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 24);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_registro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registro.Location = new System.Drawing.Point(106, 497);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(134, 24);
            this.btn_registro.TabIndex = 25;
            this.btn_registro.Text = "Registro de Alquiler";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Presionar Enter para cargar datos del vehiculo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Presionar Enter para cargar datos del Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Datos del Vehiculo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(487, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Datos del Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Datos del Alquiler";
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(610, 497);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(120, 23);
            this.Btn_Volver.TabIndex = 32;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Alquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 533);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.ValorKM);
            this.Controls.Add(this.txtValorKM);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoPersona);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Name = "Alquilar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoPersona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label ValorKM;
        private System.Windows.Forms.TextBox txtValorKM;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Volver;
    }
}

