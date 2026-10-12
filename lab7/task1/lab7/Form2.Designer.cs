namespace lab7
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
            pictureBoxMain = new PictureBox();
            pictureBoxColorSample = new PictureBox();
            lblR = new Label();
            lblG = new Label();
            lblB = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorSample).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.BackColor = SystemColors.ActiveBorder;
            pictureBoxMain.Location = new Point(129, 96);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(266, 264);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMain.TabIndex = 0;
            pictureBoxMain.TabStop = false;
            // 
            // pictureBoxColorSample
            // 
            pictureBoxColorSample.BackColor = SystemColors.ActiveBorder;
            pictureBoxColorSample.Location = new Point(421, 177);
            pictureBoxColorSample.Name = "pictureBoxColorSample";
            pictureBoxColorSample.Size = new Size(103, 64);
            pictureBoxColorSample.TabIndex = 1;
            pictureBoxColorSample.TabStop = false;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(533, 178);
            lblR.Name = "lblR";
            lblR.Size = new Size(27, 15);
            lblR.TabIndex = 2;
            lblR.Text = "Red";
            // 
            // lblG
            // 
            lblG.AutoSize = true;
            lblG.Location = new Point(533, 202);
            lblG.Name = "lblG";
            lblG.Size = new Size(38, 15);
            lblG.TabIndex = 3;
            lblG.Text = "Green";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(533, 227);
            lblB.Name = "lblB";
            lblB.Size = new Size(30, 15);
            lblB.TabIndex = 4;
            lblB.Text = "Blue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 153);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 67);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 6;
            label5.Text = "Image";
            // 
            // button1
            // 
            button1.Location = new Point(421, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Open file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOpen_Click;
            // 
            // button2
            // 
            button2.Location = new Point(502, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Save file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblB);
            Controls.Add(lblG);
            Controls.Add(lblR);
            Controls.Add(pictureBoxColorSample);
            Controls.Add(pictureBoxMain);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorSample).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMain;
        private PictureBox pictureBoxColorSample;
        private Label lblR;
        private Label lblG;
        private Label lblB;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}