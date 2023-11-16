namespace WindowsFormsApp1
{
    partial class trueform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.gestbut = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaptcha = new System.Windows.Forms.TextBox();
            this.lbC1 = new System.Windows.Forms.Label();
            this.lbC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnter.Location = new System.Drawing.Point(44, 165);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "entr";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gestbut
            // 
            this.gestbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.gestbut.Location = new System.Drawing.Point(170, 165);
            this.gestbut.Name = "gestbut";
            this.gestbut.Size = new System.Drawing.Size(75, 23);
            this.gestbut.TabIndex = 1;
            this.gestbut.Text = "gest";
            this.gestbut.UseVisualStyleBackColor = false;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tbLogin.Location = new System.Drawing.Point(109, 29);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tbPassword.Location = new System.Drawing.Point(109, 65);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // tbCaptcha
            // 
            this.tbCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tbCaptcha.Location = new System.Drawing.Point(120, 123);
            this.tbCaptcha.Name = "tbCaptcha";
            this.tbCaptcha.Size = new System.Drawing.Size(36, 20);
            this.tbCaptcha.TabIndex = 7;
            // 
            // lbC1
            // 
            this.lbC1.AutoSize = true;
            this.lbC1.Location = new System.Drawing.Point(47, 123);
            this.lbC1.Name = "lbC1";
            this.lbC1.Size = new System.Drawing.Size(35, 13);
            this.lbC1.TabIndex = 8;
            this.lbC1.Text = "label3";
            this.lbC1.Visible = false;
            // 
            // lbC2
            // 
            this.lbC2.AutoSize = true;
            this.lbC2.Location = new System.Drawing.Point(67, 123);
            this.lbC2.Name = "lbC2";
            this.lbC2.Size = new System.Drawing.Size(35, 13);
            this.lbC2.TabIndex = 9;
            this.lbC2.Text = "label4";
            this.lbC2.Visible = false;
            // 
            // trueform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 200);
            this.Controls.Add(this.lbC2);
            this.Controls.Add(this.lbC1);
            this.Controls.Add(this.tbCaptcha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.gestbut);
            this.Controls.Add(this.btnEnter);
            this.Name = "trueform";
            this.Text = "SPORT";
            this.Load += new System.EventHandler(this.trueform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button gestbut;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaptcha;
        private System.Windows.Forms.Label lbC1;
        private System.Windows.Forms.Label lbC2;
    }
}

