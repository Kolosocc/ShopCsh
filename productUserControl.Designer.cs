namespace Shop
{
    partial class productUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            QuanLabel = new Label();
            groupBox3 = new GroupBox();
            PriceLabel = new Label();
            ProdLabel = new Label();
            DesLabel = new Label();
            NameLabel = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(QuanLabel);
            groupBox4.Location = new Point(411, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 125);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // QuanLabel
            // 
            QuanLabel.AutoSize = true;
            QuanLabel.Location = new Point(6, 16);
            QuanLabel.Name = "QuanLabel";
            QuanLabel.Size = new Size(68, 20);
            QuanLabel.TabIndex = 0;
            QuanLabel.Text = "Quantity:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PriceLabel);
            groupBox3.Controls.Add(ProdLabel);
            groupBox3.Controls.Add(DesLabel);
            groupBox3.Controls.Add(NameLabel);
            groupBox3.Location = new Point(155, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(6, 76);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(44, 20);
            PriceLabel.TabIndex = 6;
            PriceLabel.Text = "Price:";
            // 
            // ProdLabel
            // 
            ProdLabel.AutoSize = true;
            ProdLabel.Location = new Point(6, 56);
            ProdLabel.Name = "ProdLabel";
            ProdLabel.Size = new Size(71, 20);
            ProdLabel.TabIndex = 5;
            ProdLabel.Text = "Producer:";
            // 
            // DesLabel
            // 
            DesLabel.AutoSize = true;
            DesLabel.Location = new Point(6, 36);
            DesLabel.Name = "DesLabel";
            DesLabel.Size = new Size(88, 20);
            DesLabel.TabIndex = 4;
            DesLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 16);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(6, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(143, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // productUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "productUserControl";
            Size = new Size(680, 158);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label PriceLabel;
        private Label ProdLabel;
        private Label DesLabel;
        private Label NameLabel;
        private Label QuanLabel;
    }
}
