namespace CS_Week01_25017050_MyBusinessCard
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("바탕", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(391, 92);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 1;
            label1.Text = "안정찬";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("돋움체", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(391, 182);
            label2.Name = "label2";
            label2.Size = new Size(389, 33);
            label2.TabIndex = 2;
            label2.Text = "수원대 컴퓨터SW 25학번";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(391, 260);
            label3.Name = "label3";
            label3.Size = new Size(314, 37);
            label3.TabIndex = 3;
            label3.Text = "jngchn0612@gmail.com";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 20F);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(391, 441);
            button1.Name = "button1";
            button1.Size = new Size(219, 58);
            button1.TabIndex = 4;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(57, 441);
            button2.Name = "button2";
            button2.Size = new Size(200, 57);
            button2.TabIndex = 5;
            button2.Text = "사진변경";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(391, 341);
            button3.Name = "button3";
            button3.Size = new Size(201, 58);
            button3.TabIndex = 6;
            button3.Text = "GitHub";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 538);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
