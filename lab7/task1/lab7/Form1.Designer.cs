namespace lab7
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
            components = new System.ComponentModel.Container();
            centerButton = new Button();
            rotatingPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // centerButton
            // 
            centerButton.Location = new Point(354, 204);
            centerButton.Name = "centerButton";
            centerButton.Size = new Size(75, 23);
            centerButton.TabIndex = 0;
            centerButton.Text = "button1";
            centerButton.UseVisualStyleBackColor = true;
            // 
            // rotatingPanel
            // 
            rotatingPanel.BackColor = SystemColors.ActiveCaption;
            rotatingPanel.Location = new Point(343, 59);
            rotatingPanel.Name = "rotatingPanel";
            rotatingPanel.Size = new Size(98, 80);
            rotatingPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rotatingPanel);
            Controls.Add(centerButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button centerButton;
        private Panel rotatingPanel;
        private System.Windows.Forms.Timer timer1;
    }
}
