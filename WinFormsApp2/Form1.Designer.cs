namespace WinFormsApp2
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
            lblPostfix = new Label();
            button1 = new Button();
            button2 = new Button();
            lblPrefix = new Label();
            txtInfix = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPostfix
            // 
            lblPostfix.AutoSize = true;
            lblPostfix.Location = new Point(17, 37);
            lblPostfix.Name = "lblPostfix";
            lblPostfix.Size = new Size(0, 20);
            lblPostfix.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(266, 277);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "POSFİX";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(501, 277);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "PREFİX";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblPrefix
            // 
            lblPrefix.AutoSize = true;
            lblPrefix.Location = new Point(17, 37);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new Size(0, 20);
            lblPrefix.TabIndex = 3;
            // 
            // txtInfix
            // 
            txtInfix.Location = new Point(266, 195);
            txtInfix.Name = "txtInfix";
            txtInfix.Size = new Size(329, 27);
            txtInfix.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblPrefix);
            panel1.Location = new Point(501, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 98);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(lblPostfix);
            panel2.Location = new Point(266, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 98);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 161);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 7;
            label1.Text = "DEĞER GİRİN:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(827, 450);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtInfix);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPostfix;
        private Button button1;
        private Button button2;
        private Label lblPrefix;
        private TextBox txtInfix;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
