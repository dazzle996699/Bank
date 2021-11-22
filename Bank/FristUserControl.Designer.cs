
namespace Bank
{
    partial class FristUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_SummCred = new System.Windows.Forms.TextBox();
            this.tB_Proc = new System.Windows.Forms.TextBox();
            this.tB_Mouth = new System.Windows.Forms.TextBox();
            this.Lb_sum = new System.Windows.Forms.Label();
            this.Lb_Proc = new System.Windows.Forms.Label();
            this.Lb_mouth = new System.Windows.Forms.Label();
            this.Lb_Result = new System.Windows.Forms.Label();
            this.bT_MonthPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_SummCred
            // 
            this.tB_SummCred.Location = new System.Drawing.Point(66, 67);
            this.tB_SummCred.Name = "tB_SummCred";
            this.tB_SummCred.Size = new System.Drawing.Size(57, 20);
            this.tB_SummCred.TabIndex = 0;
            // 
            // tB_Proc
            // 
            this.tB_Proc.Location = new System.Drawing.Point(201, 67);
            this.tB_Proc.Name = "tB_Proc";
            this.tB_Proc.Size = new System.Drawing.Size(57, 20);
            this.tB_Proc.TabIndex = 1;
            // 
            // tB_Mouth
            // 
            this.tB_Mouth.Location = new System.Drawing.Point(349, 67);
            this.tB_Mouth.Name = "tB_Mouth";
            this.tB_Mouth.Size = new System.Drawing.Size(57, 20);
            this.tB_Mouth.TabIndex = 2;
            // 
            // Lb_sum
            // 
            this.Lb_sum.AutoSize = true;
            this.Lb_sum.Location = new System.Drawing.Point(49, 42);
            this.Lb_sum.Name = "Lb_sum";
            this.Lb_sum.Size = new System.Drawing.Size(85, 13);
            this.Lb_sum.TabIndex = 3;
            this.Lb_sum.Text = "Сумма кредита";
            // 
            // Lb_Proc
            // 
            this.Lb_Proc.AutoSize = true;
            this.Lb_Proc.Location = new System.Drawing.Point(198, 42);
            this.Lb_Proc.Name = "Lb_Proc";
            this.Lb_Proc.Size = new System.Drawing.Size(50, 13);
            this.Lb_Proc.TabIndex = 4;
            this.Lb_Proc.Text = "Процент";
            // 
            // Lb_mouth
            // 
            this.Lb_mouth.AutoSize = true;
            this.Lb_mouth.Location = new System.Drawing.Point(335, 42);
            this.Lb_mouth.Name = "Lb_mouth";
            this.Lb_mouth.Size = new System.Drawing.Size(88, 13);
            this.Lb_mouth.TabIndex = 5;
            this.Lb_mouth.Text = "Кол-во месяцев";
            // 
            // Lb_Result
            // 
            this.Lb_Result.AutoSize = true;
            this.Lb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_Result.Location = new System.Drawing.Point(3, 119);
            this.Lb_Result.Name = "Lb_Result";
            this.Lb_Result.Size = new System.Drawing.Size(15, 16);
            this.Lb_Result.TabIndex = 6;
            this.Lb_Result.Text = "0";
            this.Lb_Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bT_MonthPay
            // 
            this.bT_MonthPay.Location = new System.Drawing.Point(413, 138);
            this.bT_MonthPay.Name = "bT_MonthPay";
            this.bT_MonthPay.Size = new System.Drawing.Size(75, 23);
            this.bT_MonthPay.TabIndex = 7;
            this.bT_MonthPay.Text = "button1";
            this.bT_MonthPay.UseVisualStyleBackColor = true;
            this.bT_MonthPay.Click += new System.EventHandler(this.MonthPay_Click);
            // 
            // FristUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bT_MonthPay);
            this.Controls.Add(this.Lb_Result);
            this.Controls.Add(this.Lb_mouth);
            this.Controls.Add(this.Lb_Proc);
            this.Controls.Add(this.Lb_sum);
            this.Controls.Add(this.tB_Mouth);
            this.Controls.Add(this.tB_Proc);
            this.Controls.Add(this.tB_SummCred);
            this.Name = "FristUserControl";
            this.Size = new System.Drawing.Size(561, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_SummCred;
        private System.Windows.Forms.TextBox tB_Proc;
        private System.Windows.Forms.TextBox tB_Mouth;
        private System.Windows.Forms.Label Lb_sum;
        private System.Windows.Forms.Label Lb_Proc;
        private System.Windows.Forms.Label Lb_mouth;
        private System.Windows.Forms.Label Lb_Result;
        private System.Windows.Forms.Button bT_MonthPay;
    }
}
