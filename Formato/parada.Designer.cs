
namespace Formato
{
    partial class parada
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parada));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_txt = new System.Windows.Forms.TextBox();
            this.hora_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ubicacion_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accion_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.motivo_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.evolucion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultado_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.observaciones_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Baseparo = new System.Windows.Forms.DataGridView();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btn_motivo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Baseparo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportar accion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // fecha_txt
            // 
            this.fecha_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.fecha_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fecha_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_txt.ForeColor = System.Drawing.Color.White;
            this.fecha_txt.Location = new System.Drawing.Point(139, 90);
            this.fecha_txt.Name = "fecha_txt";
            this.fecha_txt.Size = new System.Drawing.Size(317, 35);
            this.fecha_txt.TabIndex = 2;
            this.fecha_txt.TextChanged += new System.EventHandler(this.fecha_txt_TextChanged);
            // 
            // hora_txt
            // 
            this.hora_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.hora_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hora_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_txt.ForeColor = System.Drawing.Color.White;
            this.hora_txt.Location = new System.Drawing.Point(139, 143);
            this.hora_txt.Name = "hora_txt";
            this.hora_txt.Size = new System.Drawing.Size(317, 35);
            this.hora_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora";
            // 
            // ubicacion_txt
            // 
            this.ubicacion_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ubicacion_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ubicacion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacion_txt.ForeColor = System.Drawing.Color.White;
            this.ubicacion_txt.Location = new System.Drawing.Point(139, 200);
            this.ubicacion_txt.Name = "ubicacion_txt";
            this.ubicacion_txt.Size = new System.Drawing.Size(317, 35);
            this.ubicacion_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ubicacion";
            // 
            // accion_txt
            // 
            this.accion_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.accion_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accion_txt.ForeColor = System.Drawing.Color.White;
            this.accion_txt.Location = new System.Drawing.Point(139, 282);
            this.accion_txt.Name = "accion_txt";
            this.accion_txt.Size = new System.Drawing.Size(317, 35);
            this.accion_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Accion reportada";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // motivo_txt
            // 
            this.motivo_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.motivo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo_txt.ForeColor = System.Drawing.Color.White;
            this.motivo_txt.FormattingEnabled = true;
            this.motivo_txt.Items.AddRange(new object[] {
            "Descanso",
            "Uso de WC",
            "Falla Mecanica",
            "Consumo de alimentos/Bebida",
            "Imprevisto en la carretera"});
            this.motivo_txt.Location = new System.Drawing.Point(139, 364);
            this.motivo_txt.Name = "motivo_txt";
            this.motivo_txt.Size = new System.Drawing.Size(317, 37);
            this.motivo_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Motivo de accion";
            // 
            // evolucion
            // 
            this.evolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.evolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.evolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evolucion.ForeColor = System.Drawing.Color.White;
            this.evolucion.Location = new System.Drawing.Point(139, 420);
            this.evolucion.Name = "evolucion";
            this.evolucion.Size = new System.Drawing.Size(317, 35);
            this.evolucion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Evolucion";
            // 
            // resultado_txt
            // 
            this.resultado_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.resultado_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_txt.ForeColor = System.Drawing.Color.White;
            this.resultado_txt.Location = new System.Drawing.Point(139, 504);
            this.resultado_txt.Name = "resultado_txt";
            this.resultado_txt.Size = new System.Drawing.Size(317, 35);
            this.resultado_txt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Resultado final";
            // 
            // observaciones_txt
            // 
            this.observaciones_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.observaciones_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observaciones_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observaciones_txt.ForeColor = System.Drawing.Color.White;
            this.observaciones_txt.Location = new System.Drawing.Point(139, 574);
            this.observaciones_txt.Name = "observaciones_txt";
            this.observaciones_txt.Size = new System.Drawing.Size(317, 35);
            this.observaciones_txt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Observaciones";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(139, 634);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(317, 49);
            this.btn_guardar.TabIndex = 64;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Baseparo
            // 
            this.Baseparo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Baseparo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Baseparo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Baseparo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Baseparo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Baseparo.Location = new System.Drawing.Point(486, 108);
            this.Baseparo.Name = "Baseparo";
            this.Baseparo.RowHeadersWidth = 62;
            this.Baseparo.RowTemplate.Height = 28;
            this.Baseparo.Size = new System.Drawing.Size(893, 365);
            this.Baseparo.TabIndex = 65;
            this.Baseparo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BaseFormatos_CellContentClick);
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_motivo
            // 
            this.btn_motivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btn_motivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_motivo.ForeColor = System.Drawing.Color.White;
            this.btn_motivo.Location = new System.Drawing.Point(486, 479);
            this.btn_motivo.Name = "btn_motivo";
            this.btn_motivo.Size = new System.Drawing.Size(234, 49);
            this.btn_motivo.TabIndex = 66;
            this.btn_motivo.Text = "editar";
            this.btn_motivo.UseVisualStyleBackColor = false;
            this.btn_motivo.Click += new System.EventHandler(this.btn_motivo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(726, 479);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(240, 49);
            this.btn_cancelar.TabIndex = 67;
            this.btn_cancelar.Text = "Eliminar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(475, 634);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 49);
            this.button2.TabIndex = 68;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // parada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1414, 705);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_motivo);
            this.Controls.Add(this.Baseparo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.observaciones_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultado_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.evolucion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.motivo_txt);
            this.Controls.Add(this.accion_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ubicacion_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hora_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "parada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paro";
            this.Load += new System.EventHandler(this.parada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Baseparo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fecha_txt;
        private System.Windows.Forms.TextBox hora_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ubicacion_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accion_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox motivo_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox evolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultado_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox observaciones_txt;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.DataGridView Baseparo;
        private System.Windows.Forms.Timer tiempo;
        public System.Windows.Forms.Button btn_motivo;
        public System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button button2;
    }
}