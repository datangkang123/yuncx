namespace yuncx
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            usernameinput = new MaskedTextBox();
            passwordinput = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(321, 348);
            button1.Name = "button1";
            button1.Size = new Size(212, 58);
            button1.TabIndex = 0;
            button1.Text = "登  录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 170);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 1;
            label1.Text = "用户名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 264);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 2;
            label2.Text = "密码";
            // 
            // usernameinput
            // 
            usernameinput.Location = new Point(321, 167);
            usernameinput.Name = "usernameinput";
            usernameinput.Size = new Size(252, 38);
            usernameinput.TabIndex = 3;
            // 
            // passwordinput
            // 
            passwordinput.Location = new Point(321, 257);
            passwordinput.Name = "passwordinput";
            passwordinput.Size = new Size(252, 38);
            passwordinput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(231, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 57);
            label3.TabIndex = 5;
            label3.Text = "极速查询填报系统";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 490);
            Controls.Add(label3);
            Controls.Add(passwordinput);
            Controls.Add(usernameinput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "用户登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private MaskedTextBox usernameinput;
        private MaskedTextBox passwordinput;
        private Label label3;
    }
}
