namespace Task1_2
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
            this._buttonResult = new System.Windows.Forms.Button();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _buttonResult
            // 
            this._buttonResult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonResult.Location = new System.Drawing.Point(64, 174);
            this._buttonResult.Name = "_buttonResult";
            this._buttonResult.Size = new System.Drawing.Size(619, 82);
            this._buttonResult.TabIndex = 0;
            this._buttonResult.Text = "Click for me";
            this._buttonResult.UseVisualStyleBackColor = true;
            this._buttonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // _textBoxName
            // 
            this._textBoxName.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxName.Location = new System.Drawing.Point(263, 97);
            this._textBoxName.Multiline = true;
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(228, 55);
            this._textBoxName.TabIndex = 1;
            this._textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this._buttonResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonResult;
        private System.Windows.Forms.TextBox _textBoxName;
    }
}

