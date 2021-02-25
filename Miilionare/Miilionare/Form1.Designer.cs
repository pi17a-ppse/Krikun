namespace Miilionare
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Question = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Money = new System.Windows.Forms.Label();
            this.Answ1 = new System.Windows.Forms.RadioButton();
            this.Answ3 = new System.Windows.Forms.RadioButton();
            this.Answ2 = new System.Windows.Forms.RadioButton();
            this.Answ4 = new System.Windows.Forms.RadioButton();
            this.Answer = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Question);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(545, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вопрос";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(17, 32);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(73, 20);
            this.Question.TabIndex = 0;
            this.Question.Text = "Вопрос?";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(30, 9);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(18, 20);
            this.Number.TabIndex = 1;
            this.Number.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Money);
            this.groupBox2.Location = new System.Drawing.Point(574, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выигрышь";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(19, 29);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(18, 20);
            this.Money.TabIndex = 0;
            this.Money.Text = "0";
            // 
            // Answ1
            // 
            this.Answ1.AutoSize = true;
            this.Answ1.Location = new System.Drawing.Point(13, 210);
            this.Answ1.Name = "Answ1";
            this.Answ1.Size = new System.Drawing.Size(88, 24);
            this.Answ1.TabIndex = 3;
            this.Answ1.TabStop = true;
            this.Answ1.Text = "Ответ 1";
            this.Answ1.UseVisualStyleBackColor = true;
            // 
            // Answ3
            // 
            this.Answ3.AutoSize = true;
            this.Answ3.Location = new System.Drawing.Point(13, 241);
            this.Answ3.Name = "Answ3";
            this.Answ3.Size = new System.Drawing.Size(84, 24);
            this.Answ3.TabIndex = 4;
            this.Answ3.TabStop = true;
            this.Answ3.Text = "Ответ3";
            this.Answ3.UseVisualStyleBackColor = true;
            // 
            // Answ2
            // 
            this.Answ2.AutoSize = true;
            this.Answ2.Location = new System.Drawing.Point(142, 210);
            this.Answ2.Name = "Answ2";
            this.Answ2.Size = new System.Drawing.Size(88, 24);
            this.Answ2.TabIndex = 5;
            this.Answ2.TabStop = true;
            this.Answ2.Text = "Ответ 2";
            this.Answ2.UseVisualStyleBackColor = true;
            // 
            // Answ4
            // 
            this.Answ4.AutoSize = true;
            this.Answ4.Location = new System.Drawing.Point(142, 240);
            this.Answ4.Name = "Answ4";
            this.Answ4.Size = new System.Drawing.Size(88, 24);
            this.Answ4.TabIndex = 6;
            this.Answ4.TabStop = true;
            this.Answ4.Text = "Ответ 4";
            this.Answ4.UseVisualStyleBackColor = true;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(307, 210);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(95, 54);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "Ответить";
            this.Answer.UseVisualStyleBackColor = true;
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(419, 210);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(154, 55);
            this.Leave.TabIndex = 8;
            this.Leave.Text = "Уйти с выигрышем";
            this.Leave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 345);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Answ4);
            this.Controls.Add(this.Answ2);
            this.Controls.Add(this.Answ3);
            this.Controls.Add(this.Answ1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Кто хочет стать миллионером?";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.RadioButton Answ1;
        private System.Windows.Forms.RadioButton Answ3;
        private System.Windows.Forms.RadioButton Answ2;
        private System.Windows.Forms.RadioButton Answ4;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Button Leave;
    }
}

