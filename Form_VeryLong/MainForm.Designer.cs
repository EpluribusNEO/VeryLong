namespace Form_VeryLong
{
    partial class MainForm
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
            this.textBox_FirstValue = new System.Windows.Forms.TextBox();
            this.textBox_SecondValue = new System.Windows.Forms.TextBox();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_FirstValue
            // 
            this.textBox_FirstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FirstValue.Location = new System.Drawing.Point(109, 9);
            this.textBox_FirstValue.Name = "textBox_FirstValue";
            this.textBox_FirstValue.Size = new System.Drawing.Size(623, 23);
            this.textBox_FirstValue.TabIndex = 0;
            // 
            // textBox_SecondValue
            // 
            this.textBox_SecondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SecondValue.Location = new System.Drawing.Point(109, 35);
            this.textBox_SecondValue.Name = "textBox_SecondValue";
            this.textBox_SecondValue.Size = new System.Drawing.Size(623, 23);
            this.textBox_SecondValue.TabIndex = 1;
            // 
            // btn_Sum
            // 
            this.btn_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Sum.Location = new System.Drawing.Point(109, 64);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(120, 30);
            this.btn_Sum.TabIndex = 2;
            this.btn_Sum.Text = "Sum";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Mult.Location = new System.Drawing.Point(235, 64);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Size = new System.Drawing.Size(120, 30);
            this.btn_Mult.TabIndex = 4;
            this.btn_Mult.Text = "Mult";
            this.btn_Mult.UseVisualStyleBackColor = true;
            this.btn_Mult.Click += new System.EventHandler(this.btn_Mult_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Result.Location = new System.Drawing.Point(109, 100);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Result.Size = new System.Drawing.Size(551, 23);
            this.textBox_Result.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(666, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.textBox_SecondValue);
            this.Controls.Add(this.textBox_FirstValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Very Long";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstValue;
        private System.Windows.Forms.TextBox textBox_SecondValue;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

