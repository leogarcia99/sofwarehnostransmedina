
namespace Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Laterar1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.operadores_btn = new System.Windows.Forms.Button();
            this.Registro_btn = new System.Windows.Forms.Button();
            this.principal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Laterar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Laterar1
            // 
            this.Laterar1.Controls.Add(this.button1);
            this.Laterar1.Controls.Add(this.pictureBox2);
            this.Laterar1.Controls.Add(this.operadores_btn);
            this.Laterar1.Controls.Add(this.Registro_btn);
            this.Laterar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Laterar1.Location = new System.Drawing.Point(0, 0);
            this.Laterar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Laterar1.Name = "Laterar1";
            this.Laterar1.Size = new System.Drawing.Size(1375, 84);
            this.Laterar1.TabIndex = 0;
            this.Laterar1.Paint += new System.Windows.Forms.PaintEventHandler(this.Laterar1_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(769, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Monitoreos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // operadores_btn
            // 
            this.operadores_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operadores_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.operadores_btn.FlatAppearance.BorderSize = 0;
            this.operadores_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operadores_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.operadores_btn.ForeColor = System.Drawing.Color.White;
            this.operadores_btn.Location = new System.Drawing.Point(971, 0);
            this.operadores_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operadores_btn.Name = "operadores_btn";
            this.operadores_btn.Size = new System.Drawing.Size(202, 84);
            this.operadores_btn.TabIndex = 1;
            this.operadores_btn.Text = "Operadores";
            this.operadores_btn.UseVisualStyleBackColor = true;
            this.operadores_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registro_btn
            // 
            this.Registro_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Registro_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Registro_btn.FlatAppearance.BorderSize = 0;
            this.Registro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registro_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Registro_btn.ForeColor = System.Drawing.Color.White;
            this.Registro_btn.Location = new System.Drawing.Point(1173, 0);
            this.Registro_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Registro_btn.Name = "Registro_btn";
            this.Registro_btn.Size = new System.Drawing.Size(202, 84);
            this.Registro_btn.TabIndex = 0;
            this.Registro_btn.Text = "Registro";
            this.Registro_btn.UseVisualStyleBackColor = true;
            this.Registro_btn.Click += new System.EventHandler(this.Registro_btn_Click);
            // 
            // principal
            // 
            this.principal.Controls.Add(this.pictureBox1);
            this.principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.principal.Location = new System.Drawing.Point(0, 84);
            this.principal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(1375, 632);
            this.principal.TabIndex = 1;
            this.principal.Paint += new System.Windows.Forms.PaintEventHandler(this.principal_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1375, 717);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.Laterar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmedina Hnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Laterar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Laterar1;
        private System.Windows.Forms.Button Registro_btn;
        private System.Windows.Forms.Button operadores_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel principal;
    }
}

