namespace WindowsFormsApp1
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
            this.spellCheckTextBox1 = new ViSpelling.SpellCheckTextBox();
            this.hostedComponent1 = new System.Windows.Controls.TextBox();
            this.SuspendLayout();
            // 
            // spellCheckTextBox1
            // 
            this.spellCheckTextBox1.Location = new System.Drawing.Point(126, 118);
            this.spellCheckTextBox1.Name = "spellCheckTextBox1";
            this.spellCheckTextBox1.Size = new System.Drawing.Size(465, 24);
            this.spellCheckTextBox1.TabIndex = 0;
            this.spellCheckTextBox1.Text = "Праверка орфографии в аконных формах.";
           // this.spellCheckTextBox1.Child = this.hostedComponent1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spellCheckTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ViSpelling.SpellCheckTextBox spellCheckTextBox1;
        private System.Windows.Controls.TextBox hostedComponent1;
    }
}

