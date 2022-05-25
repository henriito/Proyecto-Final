namespace WFP1AC14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonObtenerDatos = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxParcial1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxParcial2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxParcial3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObtenerDatos
            // 
            this.buttonObtenerDatos.BackColor = System.Drawing.Color.Gold;
            this.buttonObtenerDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonObtenerDatos.Location = new System.Drawing.Point(441, 507);
            this.buttonObtenerDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonObtenerDatos.Name = "buttonObtenerDatos";
            this.buttonObtenerDatos.Size = new System.Drawing.Size(156, 22);
            this.buttonObtenerDatos.TabIndex = 0;
            this.buttonObtenerDatos.Text = "Obtener Datos";
            this.buttonObtenerDatos.UseVisualStyleBackColor = false;
            this.buttonObtenerDatos.Click += new System.EventHandler(this.buttonObtenerDatos_Click);
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlumnos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(603, 0);
            this.dataGridViewAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersWidth = 51;
            this.dataGridViewAlumnos.RowTemplate.Height = 29;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(664, 540);
            this.dataGridViewAlumnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(79, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seccion";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(177, 35);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(152, 23);
            this.textBoxCarnet.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(177, 80);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(409, 23);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(177, 127);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(409, 23);
            this.textBoxCorreo.TabIndex = 9;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "PROGRAMACIÓN I",
            "PROGRAMACIÓN 2",
            "PROGRAMACIÓN 3",
            "MATEMATICA"});
            this.comboBoxClase.Location = new System.Drawing.Point(177, 175);
            this.comboBoxClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(288, 23);
            this.comboBoxClase.TabIndex = 10;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.Color.Khaki;
            this.buttonConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsulta.Location = new System.Drawing.Point(374, 34);
            this.buttonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(186, 22);
            this.buttonConsulta.TabIndex = 11;
            this.buttonConsulta.Text = "Consulta Carnet";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(177, 218);
            this.comboBoxSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(72, 23);
            this.comboBoxSeccion.TabIndex = 12;
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonCrearAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearAlumno.Location = new System.Drawing.Point(12, 387);
            this.buttonCrearAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(187, 22);
            this.buttonCrearAlumno.TabIndex = 13;
            this.buttonCrearAlumno.Text = "Crear Alumno";
            this.buttonCrearAlumno.UseVisualStyleBackColor = false;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.Location = new System.Drawing.Point(209, 387);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(187, 22);
            this.buttonActualizar.TabIndex = 14;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImportar.Location = new System.Drawing.Point(69, 481);
            this.buttonImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(82, 22);
            this.buttonImportar.TabIndex = 15;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = false;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonExportar.Location = new System.Drawing.Point(209, 481);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(82, 22);
            this.buttonExportar.TabIndex = 16;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(79, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Parcial 1";
            // 
            // textBoxParcial1
            // 
            this.textBoxParcial1.Location = new System.Drawing.Point(177, 271);
            this.textBoxParcial1.Name = "textBoxParcial1";
            this.textBoxParcial1.Size = new System.Drawing.Size(100, 23);
            this.textBoxParcial1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(79, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Parcial 2";
            // 
            // textBoxParcial2
            // 
            this.textBoxParcial2.Location = new System.Drawing.Point(177, 312);
            this.textBoxParcial2.Name = "textBoxParcial2";
            this.textBoxParcial2.Size = new System.Drawing.Size(100, 23);
            this.textBoxParcial2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(79, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Parcial 3";
            // 
            // textBoxParcial3
            // 
            this.textBoxParcial3.Location = new System.Drawing.Point(177, 349);
            this.textBoxParcial3.Name = "textBoxParcial3";
            this.textBoxParcial3.Size = new System.Drawing.Size(100, 23);
            this.textBoxParcial3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(410, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Eliminar Alumno";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1267, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParcial3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxParcial2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxParcial1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrearAlumno);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.buttonObtenerDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Consulta Tabla de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonObtenerDatos;
        private DataGridView dataGridViewAlumnos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private ComboBox comboBoxSeccion;
        private Button buttonCrearAlumno;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private Label label6;
        private TextBox textBoxParcial1;
        private Label label7;
        private TextBox textBoxParcial2;
        private Label label8;
        private TextBox textBoxParcial3;
        private Button button1;
    }
}