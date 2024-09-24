namespace Shop
{
    partial class AddingForm
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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            QuanBox = new TextBox();
            QuanLabel = new Label();
            groupBox3 = new GroupBox();
            PriceBox = new TextBox();
            ProdBox = new TextBox();
            DescBox = new TextBox();
            NameBox = new TextBox();
            PriceLabel = new Label();
            ProdLabel = new Label();
            DesLabel = new Label();
            NameLabel = new Label();
            groupBox2 = new GroupBox();
            SelectPathButton = new Button();
            ImageBox = new TextBox();
            PictPathLabel = new Label();
            AddingButton = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(QuanBox);
            groupBox4.Controls.Add(QuanLabel);
            groupBox4.Location = new Point(518, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 143);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // QuanBox
            // 
            QuanBox.Location = new Point(105, 20);
            QuanBox.Name = "QuanBox";
            QuanBox.Size = new Size(125, 27);
            QuanBox.TabIndex = 2;
            // 
            // QuanLabel
            // 
            QuanLabel.AutoSize = true;
            QuanLabel.Location = new Point(6, 23);
            QuanLabel.Name = "QuanLabel";
            QuanLabel.Size = new Size(93, 20);
            QuanLabel.TabIndex = 1;
            QuanLabel.Text = "Количество:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PriceBox);
            groupBox3.Controls.Add(ProdBox);
            groupBox3.Controls.Add(DescBox);
            groupBox3.Controls.Add(NameBox);
            groupBox3.Controls.Add(PriceLabel);
            groupBox3.Controls.Add(ProdLabel);
            groupBox3.Controls.Add(DesLabel);
            groupBox3.Controls.Add(NameLabel);
            groupBox3.Location = new Point(262, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 143);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(56, 115);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(125, 27);
            PriceBox.TabIndex = 14;
            // 
            // ProdBox
            // 
            ProdBox.Location = new Point(133, 87);
            ProdBox.Name = "ProdBox";
            ProdBox.Size = new Size(117, 27);
            ProdBox.TabIndex = 13;
            // 
            // DescBox
            // 
            DescBox.Location = new Point(94, 57);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(125, 27);
            DescBox.TabIndex = 12;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(54, 23);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 11;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(6, 120);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(48, 20);
            PriceLabel.TabIndex = 10;
            PriceLabel.Text = "Цена:";
            // 
            // ProdLabel
            // 
            ProdLabel.AutoSize = true;
            ProdLabel.Location = new Point(6, 90);
            ProdLabel.Name = "ProdLabel";
            ProdLabel.Size = new Size(121, 20);
            ProdLabel.TabIndex = 9;
            ProdLabel.Text = "Производитель:";
            // 
            // DesLabel
            // 
            DesLabel.AutoSize = true;
            DesLabel.Location = new Point(6, 57);
            DesLabel.Name = "DesLabel";
            DesLabel.Size = new Size(82, 20);
            DesLabel.TabIndex = 8;
            DesLabel.Text = "Описание:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 23);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 20);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Имя:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SelectPathButton);
            groupBox2.Controls.Add(ImageBox);
            groupBox2.Controls.Add(PictPathLabel);
            groupBox2.Location = new Point(6, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 143);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // SelectPathButton
            // 
            SelectPathButton.Location = new Point(6, 78);
            SelectPathButton.Name = "SelectPathButton";
            SelectPathButton.Size = new Size(198, 29);
            SelectPathButton.TabIndex = 3;
            SelectPathButton.Text = "выбрать путь";
            SelectPathButton.UseVisualStyleBackColor = true;
            SelectPathButton.Click += SelectPathButton_Click;
            // 
            // ImageBox
            // 
            ImageBox.Location = new Point(6, 46);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(238, 27);
            ImageBox.TabIndex = 2;
            // 
            // PictPathLabel
            // 
            PictPathLabel.AutoSize = true;
            PictPathLabel.Location = new Point(6, 23);
            PictPathLabel.Name = "PictPathLabel";
            PictPathLabel.Size = new Size(44, 20);
            PictPathLabel.TabIndex = 2;
            PictPathLabel.Text = "Путь:";
            // 
            // AddingButton
            // 
            AddingButton.Location = new Point(12, 190);
            AddingButton.Name = "AddingButton";
            AddingButton.Size = new Size(776, 29);
            AddingButton.TabIndex = 1;
            AddingButton.Text = "Добавить";
            AddingButton.UseVisualStyleBackColor = true;
            AddingButton.Click += AddingButton_Click;
            // 
            // AddingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddingButton);
            Controls.Add(groupBox1);
            Name = "AddingForm";
            Text = "AddingForm";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label PriceLabel;
        private Label ProdLabel;
        private Label DesLabel;
        private Label NameLabel;
        private Label QuanLabel;
        private Button AddingButton;
        private TextBox ProdBox;
        private TextBox DescBox;
        private TextBox NameBox;
        private TextBox ImageBox;
        private Label PictPathLabel;
        private TextBox PriceBox;
        private TextBox QuanBox;
        private Button SelectPathButton;
    }
}