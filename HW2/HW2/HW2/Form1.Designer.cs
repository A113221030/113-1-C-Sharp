namespace HW2
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
            txtPurchaseAmount = new TextBox();
            btnCalculatePoints = new Button();
            lblPoints = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 48);
            label1.Name = "label1";
            label1.Size = new Size(388, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter Monthly Purchase Amount:";
            // 
            // txtPurchaseAmount
            // 
            txtPurchaseAmount.Location = new Point(76, 127);
            txtPurchaseAmount.Name = "txtPurchaseAmount";
            txtPurchaseAmount.Size = new Size(105, 38);
            txtPurchaseAmount.TabIndex = 1;
            // 
            // btnCalculatePoints
            // 
            btnCalculatePoints.Location = new Point(67, 214);
            btnCalculatePoints.Name = "btnCalculatePoints";
            btnCalculatePoints.Size = new Size(148, 54);
            btnCalculatePoints.TabIndex = 2;
            btnCalculatePoints.Text = "Calculate Points";
            btnCalculatePoints.UseVisualStyleBackColor = true;
            btnCalculatePoints.Click += btnCalculatePoints_Click;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(76, 315);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(217, 30);
            lblPoints.TabIndex = 3;
            lblPoints.Text = "Points Awarded: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPoints);
            Controls.Add(btnCalculatePoints);
            Controls.Add(txtPurchaseAmount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPurchaseAmount;
        private Button btnCalculatePoints;
        private Label lblPoints;
    }
}
