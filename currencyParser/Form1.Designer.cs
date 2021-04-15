namespace Currencies
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
            this.usd_currency = new System.Windows.Forms.Label();
            this.eur_currency = new System.Windows.Forms.Label();
            this.usd_value = new System.Windows.Forms.Label();
            this.eur_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usd_currency
            // 
            this.usd_currency.AutoSize = true;
            this.usd_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usd_currency.Location = new System.Drawing.Point(60, 34);
            this.usd_currency.Name = "usd_currency";
            this.usd_currency.Size = new System.Drawing.Size(63, 29);
            this.usd_currency.TabIndex = 0;
            this.usd_currency.Text = "USD";
            // 
            // eur_currency
            // 
            this.eur_currency.AutoSize = true;
            this.eur_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eur_currency.Location = new System.Drawing.Point(60, 99);
            this.eur_currency.Name = "eur_currency";
            this.eur_currency.Size = new System.Drawing.Size(63, 29);
            this.eur_currency.TabIndex = 0;
            this.eur_currency.Text = "EUR";
            // 
            // usd_value
            // 
            this.usd_value.AutoSize = true;
            this.usd_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usd_value.Location = new System.Drawing.Point(184, 34);
            this.usd_value.Name = "usd_value";
            this.usd_value.Size = new System.Drawing.Size(152, 29);
            this.usd_value.TabIndex = 0;
            this.usd_value.Text = "USD_VALUE";
            // 
            // eur_value
            // 
            this.eur_value.AutoSize = true;
            this.eur_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eur_value.Location = new System.Drawing.Point(184, 99);
            this.eur_value.Name = "eur_value";
            this.eur_value.Size = new System.Drawing.Size(152, 29);
            this.eur_value.TabIndex = 0;
            this.eur_value.Text = "EUR_VALUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 165);
            this.Controls.Add(this.eur_value);
            this.Controls.Add(this.eur_currency);
            this.Controls.Add(this.usd_value);
            this.Controls.Add(this.usd_currency);
            this.Name = "Form1";
            this.Text = "Currencies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usd_currency;
        private System.Windows.Forms.Label eur_currency;
        private System.Windows.Forms.Label usd_value;
        private System.Windows.Forms.Label eur_value;
    }
}

