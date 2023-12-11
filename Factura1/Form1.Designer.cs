namespace Factura1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 34);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 0;
            label1.Text = "FACTURA ELECTRONICA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 241);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "NUEVO REGISTRO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 241);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 2;
            label3.Text = "USUARIO REGISTRADO";
            // 
            // button1
            // 
            button1.Location = new Point(146, 190);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 3;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(521, 190);
            button2.Name = "button2";
            button2.Size = new Size(115, 37);
            button2.TabIndex = 4;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.factura;
            pictureBox1.Location = new Point(321, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(540, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(678, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(99, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(312, 324);
            button3.Name = "button3";
            button3.Size = new Size(182, 37);
            button3.TabIndex = 9;
            button3.Text = "Generar compra";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button3;
    }
}