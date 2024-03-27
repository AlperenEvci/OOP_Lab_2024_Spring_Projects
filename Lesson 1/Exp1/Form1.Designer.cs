namespace _152120211106_Lab_Exp1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(23, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(140, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "User Name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(23, 123);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(117, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Surname";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(28, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ex: Emir";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(28, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "ex : Selengil";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(232, 60);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(401, 60);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 35);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(232, 151);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 35);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(401, 151);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 35);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "Button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Location = new System.Drawing.Point(28, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 100);
            this.panel1.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(112, 37);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 32);
            this.lbl3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
    }
}

