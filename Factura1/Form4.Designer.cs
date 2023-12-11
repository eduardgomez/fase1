namespace Factura1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            View1 = new DataGridView();
            button3 = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Totalcompra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)View1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(84, 344);
            button2.Name = "button2";
            button2.Size = new Size(115, 37);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(538, 344);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 6;
            button1.Text = "Imprimir factura";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 110);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 8;
            label1.Text = "Celular";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(482, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(324, 110);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 10;
            label2.Text = "Codigo del producto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(482, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 23);
            textBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(382, 58);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 12;
            label3.Text = "Cantidad";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 23);
            textBox4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 58);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 14;
            label4.Text = "Precio";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(689, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(99, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(283, 12);
            label5.Name = "label5";
            label5.Size = new Size(223, 28);
            label5.TabIndex = 17;
            label5.Text = "FACTURA ELECTRONICA";
            // 
            // View1
            // 
            View1.BackgroundColor = SystemColors.Control;
            View1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            View1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Precio, Cantidad, Total, Celular, Nombre, Totalcompra });
            View1.GridColor = SystemColors.Info;
            View1.Location = new Point(44, 167);
            View1.Name = "View1";
            View1.RowTemplate.Height = 25;
            View1.Size = new Size(744, 150);
            View1.TabIndex = 18;
            View1.CellContentClick += View1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(312, 344);
            button3.Name = "button3";
            button3.Size = new Size(115, 37);
            button3.TabIndex = 19;
            button3.Text = "Comprar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Totalcompra
            // 
            Totalcompra.HeaderText = "Totalcompra";
            Totalcompra.Name = "Totalcompra";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(View1);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)View1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private DataGridView View1;
        private Button button3;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Totalcompra;
    }
}