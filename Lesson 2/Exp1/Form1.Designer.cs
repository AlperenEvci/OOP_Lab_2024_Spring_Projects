namespace _152120211124_Lab_Exp2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxLucasNumbers = new System.Windows.Forms.TextBox();
            this.lblLucas = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.checkBoxAverage = new System.Windows.Forms.CheckBox();
            this.txtBoxArraySize = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtBoxLucasNumbers);
            this.panel1.Controls.Add(this.lblLucas);
            this.panel1.Controls.Add(this.lblAverage);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.checkBoxAverage);
            this.panel1.Controls.Add(this.txtBoxArraySize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 234);
            this.panel1.TabIndex = 14;
            // 
            // txtBoxLucasNumbers
            // 
            this.txtBoxLucasNumbers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxLucasNumbers.Location = new System.Drawing.Point(233, 60);
            this.txtBoxLucasNumbers.Multiline = true;
            this.txtBoxLucasNumbers.Name = "txtBoxLucasNumbers";
            this.txtBoxLucasNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxLucasNumbers.Size = new System.Drawing.Size(112, 132);
            this.txtBoxLucasNumbers.TabIndex = 19;
            // 
            // lblLucas
            // 
            this.lblLucas.AutoSize = true;
            this.lblLucas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLucas.Location = new System.Drawing.Point(101, 22);
            this.lblLucas.Name = "lblLucas";
            this.lblLucas.Size = new System.Drawing.Size(166, 23);
            this.lblLucas.TabIndex = 18;
            this.lblLucas.Text = "LUCAS SERIES";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAverage.Location = new System.Drawing.Point(230, 207);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(98, 18);
            this.lblAverage.TabIndex = 17;
            this.lblAverage.Text = "AVERAGE: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(14, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 39);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Generate - Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btnCalculate_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            // 
            // checkBoxAverage
            // 
            this.checkBoxAverage.AutoSize = true;
            this.checkBoxAverage.Checked = true;
            this.checkBoxAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAverage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxAverage.Location = new System.Drawing.Point(14, 98);
            this.checkBoxAverage.Name = "checkBoxAverage";
            this.checkBoxAverage.Size = new System.Drawing.Size(175, 22);
            this.checkBoxAverage.TabIndex = 15;
            this.checkBoxAverage.Text = "Calculate Average";
            this.checkBoxAverage.UseVisualStyleBackColor = true;
            this.checkBoxAverage.CheckedChanged += new System.EventHandler(this.checkBoxAverage_CheckedChanged);
            // 
            // txtBoxArraySize
            // 
            this.txtBoxArraySize.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxArraySize.Location = new System.Drawing.Point(14, 60);
            this.txtBoxArraySize.Name = "txtBoxArraySize";
            this.txtBoxArraySize.Size = new System.Drawing.Size(186, 22);
            this.txtBoxArraySize.TabIndex = 14;
            this.txtBoxArraySize.TextChanged += new System.EventHandler(this.txtBoxArraySize_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 234);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxLucasNumbers;
        private System.Windows.Forms.Label lblLucas;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox checkBoxAverage;
        private System.Windows.Forms.TextBox txtBoxArraySize;
    }
}

