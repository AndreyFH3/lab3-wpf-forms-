namespace lab_3._1
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
            this.hoverButton1 = new lab_3._1.HoverButton();
            this.hoverButtonCircle1 = new lab_3._1.HoverButtonCircle();
            this.SuspendLayout();
            // 
            // hoverButton1
            // 
            this.hoverButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hoverButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.White;
            this.hoverButton1.Location = new System.Drawing.Point(12, 12);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(694, 515);
            this.hoverButton1.TabIndex = 0;
            this.hoverButton1.Text = "Click ME";
            this.hoverButton1.UseVisualStyleBackColor = false;
            // 
            // hoverButtonCircle1
            // 
            this.hoverButtonCircle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButtonCircle1.ForeColor = System.Drawing.Color.White;
            this.hoverButtonCircle1.Location = new System.Drawing.Point(712, 12);
            this.hoverButtonCircle1.Name = "hoverButtonCircle1";
            this.hoverButtonCircle1.Size = new System.Drawing.Size(694, 515);
            this.hoverButtonCircle1.TabIndex = 1;
            this.hoverButtonCircle1.Text = "I\'m unusual!!";
            this.hoverButtonCircle1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 538);
            this.Controls.Add(this.hoverButtonCircle1);
            this.Controls.Add(this.hoverButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButton hoverButton1;
        private HoverButtonCircle hoverButtonCircle1;
    }
}

