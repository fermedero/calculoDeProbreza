namespace Sueldo_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txDolarVenta = new System.Windows.Forms.TextBox();
            this.btCalcularProbreza = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbActualizado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDolarCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEnLechuga = new System.Windows.Forms.Label();
            this.txSueldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProbrecito = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txDolarVenta
            // 
            this.txDolarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDolarVenta.ForeColor = System.Drawing.Color.Green;
            this.txDolarVenta.Location = new System.Drawing.Point(130, 72);
            this.txDolarVenta.Name = "txDolarVenta";
            this.txDolarVenta.Size = new System.Drawing.Size(115, 26);
            this.txDolarVenta.TabIndex = 0;
            // 
            // btCalcularProbreza
            // 
            this.btCalcularProbreza.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCalcularProbreza.FlatAppearance.BorderSize = 2;
            this.btCalcularProbreza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcularProbreza.Location = new System.Drawing.Point(202, 85);
            this.btCalcularProbreza.Name = "btCalcularProbreza";
            this.btCalcularProbreza.Size = new System.Drawing.Size(101, 37);
            this.btCalcularProbreza.TabIndex = 1;
            this.btCalcularProbreza.Text = "CALCULAR";
            this.btCalcularProbreza.UseVisualStyleBackColor = true;
            this.btCalcularProbreza.Click += new System.EventHandler(this.btCalcularProbreza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProbrecito);
            this.groupBox1.Controls.Add(this.lbActualizado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txDolarCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txDolarVenta);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COTIZACIÓN DOLAR";
            // 
            // lbActualizado
            // 
            this.lbActualizado.AutoSize = true;
            this.lbActualizado.Location = new System.Drawing.Point(12, 104);
            this.lbActualizado.Name = "lbActualizado";
            this.lbActualizado.Size = new System.Drawing.Size(81, 17);
            this.lbActualizado.TabIndex = 3;
            this.lbActualizado.Text = "Actualizado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "COMPRA";
            // 
            // txDolarCompra
            // 
            this.txDolarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDolarCompra.ForeColor = System.Drawing.Color.Green;
            this.txDolarCompra.Location = new System.Drawing.Point(130, 28);
            this.txDolarCompra.Name = "txDolarCompra";
            this.txDolarCompra.Size = new System.Drawing.Size(115, 26);
            this.txDolarCompra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(286, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "USD 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "USD 2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "POBREROMETRO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lbEnLechuga);
            this.groupBox2.Controls.Add(this.txSueldo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btCalcularProbreza);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 169);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CALCULA QUE TAN PROBRE SOS";
            // 
            // lbEnLechuga
            // 
            this.lbEnLechuga.AutoSize = true;
            this.lbEnLechuga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnLechuga.Location = new System.Drawing.Point(17, 117);
            this.lbEnLechuga.Name = "lbEnLechuga";
            this.lbEnLechuga.Size = new System.Drawing.Size(45, 17);
            this.lbEnLechuga.TabIndex = 9;
            this.lbEnLechuga.Text = "USD: ";
            // 
            // txSueldo
            // 
            this.txSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSueldo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txSueldo.Location = new System.Drawing.Point(17, 89);
            this.txSueldo.Name = "txSueldo";
            this.txSueldo.Size = new System.Drawing.Size(161, 26);
            this.txSueldo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "La miseria que gano es:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(345, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // btnProbrecito
            // 
            this.btnProbrecito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProbrecito.FlatAppearance.BorderSize = 2;
            this.btnProbrecito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbrecito.Location = new System.Drawing.Point(6, 124);
            this.btnProbrecito.Name = "btnProbrecito";
            this.btnProbrecito.Size = new System.Drawing.Size(297, 32);
            this.btnProbrecito.TabIndex = 4;
            this.btnProbrecito.Text = "Que tan mal estoy?";
            this.btnProbrecito.UseVisualStyleBackColor = true;
            this.btnProbrecito.Click += new System.EventHandler(this.btnProbrecito_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver a cotizaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(345, 220);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txDolarVenta;
        private System.Windows.Forms.Button btCalcularProbreza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDolarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbActualizado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txSueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEnLechuga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProbrecito;
        private System.Windows.Forms.Button button1;
    }
}

