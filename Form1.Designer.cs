namespace Shop
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
            ProdFiltBox = new ComboBox();
            SortBox = new ComboBox();
            AddingButton = new Button();
            ExitButton = new Button();
            FindBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PreviousButton = new Button();
            NextButton = new Button();
            AddingStandartButton = new Button();
            PageLabel = new Label();
            SuspendLayout();
            // 
            // ProdFiltBox
            // 
            ProdFiltBox.FormattingEnabled = true;
            ProdFiltBox.Location = new Point(12, 12);
            ProdFiltBox.Name = "ProdFiltBox";
            ProdFiltBox.Size = new Size(340, 28);
            ProdFiltBox.TabIndex = 0;
            ProdFiltBox.SelectedIndexChanged += ProdFiltBox_SelectedIndexChanged;
            // 
            // SortBox
            // 
            SortBox.FormattingEnabled = true;
            SortBox.Location = new Point(358, 12);
            SortBox.Name = "SortBox";
            SortBox.Size = new Size(340, 28);
            SortBox.TabIndex = 1;
            SortBox.SelectedIndexChanged += SortBox_SelectedIndexChanged;
            // 
            // AddingButton
            // 
            AddingButton.Location = new Point(704, 12);
            AddingButton.Name = "AddingButton";
            AddingButton.Size = new Size(84, 28);
            AddingButton.TabIndex = 2;
            AddingButton.Text = "Добавление";
            AddingButton.UseVisualStyleBackColor = true;
            AddingButton.Click += AddingButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(704, 46);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(84, 28);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FindBox
            // 
            FindBox.Location = new Point(12, 47);
            FindBox.Name = "FindBox";
            FindBox.Size = new Size(686, 27);
            FindBox.TabIndex = 4;
            FindBox.TextChanged += FindBox_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(686, 554);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new Point(12, 640);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(94, 29);
            PreviousButton.TabIndex = 6;
            PreviousButton.Text = "<";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(604, 640);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 29);
            NextButton.TabIndex = 7;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // AddingStandartButton
            // 
            AddingStandartButton.Location = new Point(704, 80);
            AddingStandartButton.Name = "AddingStandartButton";
            AddingStandartButton.Size = new Size(84, 110);
            AddingStandartButton.TabIndex = 8;
            AddingStandartButton.Text = "Добавить стандартные файлы";
            AddingStandartButton.UseVisualStyleBackColor = true;
            AddingStandartButton.Click += AddingStandartButton_Click;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Location = new Point(302, 649);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(50, 20);
            PageLabel.TabIndex = 9;
            PageLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 681);
            Controls.Add(PageLabel);
            Controls.Add(AddingStandartButton);
            Controls.Add(NextButton);
            Controls.Add(PreviousButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(FindBox);
            Controls.Add(ExitButton);
            Controls.Add(AddingButton);
            Controls.Add(SortBox);
            Controls.Add(ProdFiltBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ProdFiltBox;
        private ComboBox SortBox;
        private Button AddingButton;
        private Button ExitButton;
        private TextBox FindBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button PreviousButton;
        private Button NextButton;
        private Button AddingStandartButton;
        private Label PageLabel;
    }
}
