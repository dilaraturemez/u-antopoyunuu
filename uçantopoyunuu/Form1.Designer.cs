namespace uçantopoyunuu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kontrol = new Button();
            ball = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Fuchsia;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(26, 503);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 192, 255);
            label2.Location = new Point(45, 25);
            label2.Name = "label2";
            label2.Size = new Size(584, 25);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(790, 75);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.BackColor = Color.Fuchsia;
            label4.Location = new Point(603, 25);
            label4.Name = "label4";
            label4.Size = new Size(26, 508);
            label4.TabIndex = 0;
            // 
            // kontrol
            // 
            kontrol.BackColor = Color.Yellow;
            kontrol.Location = new Point(287, 484);
            kontrol.Name = "kontrol";
            kontrol.Size = new Size(116, 29);
            kontrol.TabIndex = 3;
            kontrol.UseVisualStyleBackColor = false;
            kontrol.MouseMove += kontrol_MouseMove;
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(250, 131);
            ball.Name = "ball";
            ball.Size = new Size(29, 29);
            ball.TabIndex = 4;
            ball.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(723, 75);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 602);
            Controls.Add(button1);
            Controls.Add(ball);
            Controls.Add(kontrol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button kontrol;
        private Button ball;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}