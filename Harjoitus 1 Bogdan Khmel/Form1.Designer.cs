namespace Harjoitus_1_Bogdan_Khmel
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
            OtsikkoLB = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe UI", 14F);
            OtsikkoLB.Location = new Point(53, 37);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(91, 38);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "label1";
            OtsikkoLB.Click += OtsikkoLB_Click;
            // 
            // button1
            // 
            button1.Location = new Point(43, 123);
            button1.Name = "button1";
            button1.Size = new Size(165, 67);
            button1.TabIndex = 1;
            button1.Text = "Vaihda teksti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(OtsikkoLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Button button1;
    }
}
