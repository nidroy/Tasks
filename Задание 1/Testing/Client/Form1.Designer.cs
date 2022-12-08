namespace Client
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
            this.Question = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendAnswer = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(13, 53);
            this.Question.Margin = new System.Windows.Forms.Padding(4);
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(400, 29);
            this.Question.TabIndex = 1;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(13, 130);
            this.Answer.Margin = new System.Windows.Forms.Padding(4);
            this.Answer.Name = "Answer";
            this.Answer.PlaceholderText = "Ваш ответ на вопрос";
            this.Answer.Size = new System.Drawing.Size(400, 29);
            this.Answer.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(13, 90);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(400, 32);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Ответ";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(400, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Вопрос";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendAnswer
            // 
            this.SendAnswer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendAnswer.Location = new System.Drawing.Point(13, 166);
            this.SendAnswer.Name = "SendAnswer";
            this.SendAnswer.Size = new System.Drawing.Size(400, 32);
            this.SendAnswer.TabIndex = 5;
            this.SendAnswer.Text = "Отправить ответ";
            this.SendAnswer.UseVisualStyleBackColor = true;
            this.SendAnswer.Click += new System.EventHandler(this.SendAnswer_Click);
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Restart.Location = new System.Drawing.Point(13, 204);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(400, 32);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "Перезапустить тест";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 246);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.SendAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Question);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Тестировщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Question;
        private TextBox Answer;
        private TextBox textBox4;
        private TextBox textBox1;
        private Button SendAnswer;
        private Button Restart;
    }
}