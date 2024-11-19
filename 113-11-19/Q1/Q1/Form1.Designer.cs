namespace Q1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtCost = new TextBox();
            btnArea = new Button();
            btnBoundary = new Button();
            btnCost = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 54);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Length of the Field:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 102);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Width of the Field";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 152);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 2;
            label3.Text = "Unit Cost of Fencing:";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(298, 46);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(120, 23);
            txtLength.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(298, 94);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(120, 23);
            txtWidth.TabIndex = 4;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(298, 144);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(120, 23);
            txtCost.TabIndex = 5;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(56, 247);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(107, 46);
            btnArea.TabIndex = 6;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnBoundary
            // 
            btnBoundary.Location = new Point(225, 247);
            btnBoundary.Name = "btnBoundary";
            btnBoundary.Size = new Size(107, 46);
            btnBoundary.TabIndex = 7;
            btnBoundary.Text = "Boundary";
            btnBoundary.UseVisualStyleBackColor = true;
            btnBoundary.Click += btnBoundary_Click;
            // 
            // btnCost
            // 
            btnCost.Location = new Point(404, 247);
            btnCost.Name = "btnCost";
            btnCost.Size = new Size(107, 46);
            btnCost.TabIndex = 8;
            btnCost.Text = "Cost";
            btnCost.UseVisualStyleBackColor = true;
            btnCost.Click += btnCost_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(552, 247);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 46);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCost);
            Controls.Add(btnBoundary);
            Controls.Add(btnArea);
            Controls.Add(txtCost);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Width of the Field";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtCost;
        private Button btnArea;
        private Button btnBoundary;
        private Button btnCost;
        private Button btnExit;
    }
}
