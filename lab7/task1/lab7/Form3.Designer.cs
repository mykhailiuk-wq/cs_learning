namespace lab7
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            btnColor = new Button();
            numSize = new NumericUpDown();
            comboBoxType = new ComboBox();
            btnDraw = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(77, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 313);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(485, 252);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(93, 21);
            btnColor.TabIndex = 1;
            btnColor.Text = "Select color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // numSize
            // 
            numSize.Location = new Point(485, 145);
            numSize.Name = "numSize";
            numSize.Size = new Size(120, 23);
            numSize.TabIndex = 2;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(485, 214);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 3;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(485, 281);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 21);
            btnDraw.TabIndex = 4;
            btnDraw.Text = "Add shape";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 187);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Shape";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 117);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "Size";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDraw);
            Controls.Add(comboBoxType);
            Controls.Add(numSize);
            Controls.Add(btnColor);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnColor;
        private NumericUpDown numSize;
        private ComboBox comboBoxType;
        private Button btnDraw;
        private Label label1;
        private Label label2;
    }
}