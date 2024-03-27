namespace Lab_Week2_Exp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxArraySize = new System.Windows.Forms.TextBox();
            this.checkBoxAverage = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblFib = new System.Windows.Forms.Label();
            this.txtBoxFibonacciNumbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxArraySize
            // 
            this.txtBoxArraySize.Location = new System.Drawing.Point(43, 96);
            this.txtBoxArraySize.Name = "txtBoxArraySize";
            this.txtBoxArraySize.Size = new System.Drawing.Size(136, 20);
            this.txtBoxArraySize.TabIndex = 0;
            this.txtBoxArraySize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxAverage
            // 
            this.checkBoxAverage.AutoSize = true;
            this.checkBoxAverage.Checked = true;
            this.checkBoxAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAverage.Location = new System.Drawing.Point(43, 134);
            this.checkBoxAverage.Name = "checkBoxAverage";
            this.checkBoxAverage.Size = new System.Drawing.Size(113, 17);
            this.checkBoxAverage.TabIndex = 1;
            this.checkBoxAverage.Text = "Calculate Average";
            this.checkBoxAverage.UseVisualStyleBackColor = true;
            this.checkBoxAverage.CheckedChanged += new System.EventHandler(this.checkBoxAverage_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 172);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Generate-Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAverage.Location = new System.Drawing.Point(210, 210);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(64, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "AVERAGE: ";
            // 
            // lblFib
            // 
            this.lblFib.AutoSize = true;
            this.lblFib.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFib.Location = new System.Drawing.Point(72, 54);
            this.lblFib.Name = "lblFib";
            this.lblFib.Size = new System.Drawing.Size(217, 23);
            this.lblFib.TabIndex = 6;
            this.lblFib.Text = "FIBONACCI SERIES";
            // 
            // txtBoxFibonacciNumbers
            // 
            this.txtBoxFibonacciNumbers.Location = new System.Drawing.Point(213, 96);
            this.txtBoxFibonacciNumbers.Multiline = true;
            this.txtBoxFibonacciNumbers.Name = "txtBoxFibonacciNumbers";
            this.txtBoxFibonacciNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxFibonacciNumbers.Size = new System.Drawing.Size(112, 99);
            this.txtBoxFibonacciNumbers.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 266);
            this.Controls.Add(this.txtBoxFibonacciNumbers);
            this.Controls.Add(this.lblFib);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.checkBoxAverage);
            this.Controls.Add(this.txtBoxArraySize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxArraySize;
        private System.Windows.Forms.CheckBox checkBoxAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFib;
        private System.Windows.Forms.TextBox txtBoxFibonacciNumbers;
    }
}

