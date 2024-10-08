namespace tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = (Image)resources.GetObject("ptxback.Image");
            ptxback.Location = new Point(43, 24);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(502, 706);
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            ptxback.Click += pictureBox1_Click;
            // 
            // ptxfront
            // 
            ptxfront.Image = (Image)resources.GetObject("ptxfront.Image");
            ptxfront.Location = new Point(719, 24);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(499, 706);
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(147, 786);
            button1.Name = "button1";
            button1.Size = new Size(247, 137);
            button1.TabIndex = 2;
            button1.Text = "背面";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(881, 773);
            button2.Name = "button2";
            button2.Size = new Size(247, 137);
            button2.TabIndex = 3;
            button2.Text = "正面";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(522, 992);
            button3.Name = "button3";
            button3.Size = new Size(289, 134);
            button3.TabIndex = 4;
            button3.Text = "離開";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 1163);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "翻牌";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
