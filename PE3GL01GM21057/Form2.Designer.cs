namespace PE3GL01GM21057
{
    partial class Form2
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
            this.buttonAgregarManzana = new System.Windows.Forms.Button();
            this.buttonAgregarPera = new System.Windows.Forms.Button();
            this.buttonCodigoCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodigoCompra = new System.Windows.Forms.TextBox();
            this.textBoxCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAgregarManzana
            // 
            this.buttonAgregarManzana.Location = new System.Drawing.Point(10, 53);
            this.buttonAgregarManzana.Name = "buttonAgregarManzana";
            this.buttonAgregarManzana.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarManzana.TabIndex = 0;
            this.buttonAgregarManzana.Text = "Agregar";
            this.buttonAgregarManzana.UseVisualStyleBackColor = true;
            this.buttonAgregarManzana.Click += new System.EventHandler(this.buttonAgregarManzana_Click);
            // 
            // buttonAgregarPera
            // 
            this.buttonAgregarPera.Location = new System.Drawing.Point(107, 53);
            this.buttonAgregarPera.Name = "buttonAgregarPera";
            this.buttonAgregarPera.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarPera.TabIndex = 1;
            this.buttonAgregarPera.Text = "Agregar";
            this.buttonAgregarPera.UseVisualStyleBackColor = true;
            this.buttonAgregarPera.Click += new System.EventHandler(this.buttonAgregarPera_Click);
            // 
            // buttonCodigoCompra
            // 
            this.buttonCodigoCompra.Location = new System.Drawing.Point(21, 199);
            this.buttonCodigoCompra.Name = "buttonCodigoCompra";
            this.buttonCodigoCompra.Size = new System.Drawing.Size(128, 23);
            this.buttonCodigoCompra.TabIndex = 2;
            this.buttonCodigoCompra.Text = "Imprimir Compra";
            this.buttonCodigoCompra.UseVisualStyleBackColor = true;
            this.buttonCodigoCompra.Click += new System.EventHandler(this.buttonCodigoCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manzana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "$1.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "$2.00";
            // 
            // textBoxCodigoCompra
            // 
            this.textBoxCodigoCompra.Location = new System.Drawing.Point(155, 115);
            this.textBoxCodigoCompra.Name = "textBoxCodigoCompra";
            this.textBoxCodigoCompra.Size = new System.Drawing.Size(100, 23);
            this.textBoxCodigoCompra.TabIndex = 9;
            // 
            // textBoxCodigoEmpleado
            // 
            this.textBoxCodigoEmpleado.Location = new System.Drawing.Point(155, 159);
            this.textBoxCodigoEmpleado.Name = "textBoxCodigoEmpleado";
            this.textBoxCodigoEmpleado.Size = new System.Drawing.Size(100, 23);
            this.textBoxCodigoEmpleado.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese Codigo empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingrese Codigo Cliente";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 244);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodigoEmpleado);
            this.Controls.Add(this.textBoxCodigoCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCodigoCompra);
            this.Controls.Add(this.buttonAgregarPera);
            this.Controls.Add(this.buttonAgregarManzana);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAgregarManzana;
        private Button buttonAgregarPera;
        private Button buttonCodigoCompra;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBoxCodigoCompra;
        private TextBox textBoxCodigoEmpleado;
        private Label label3;
        private Label label6;
    }
}