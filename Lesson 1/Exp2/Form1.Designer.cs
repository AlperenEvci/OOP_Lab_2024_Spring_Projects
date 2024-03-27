namespace _152120211106_Exp1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(48, 72);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(144, 20);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(45, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(121, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "First Number";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(45, 114);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(147, 18);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Second Number";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(48, 145);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(144, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(225, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSub.Location = new System.Drawing.Point(345, 41);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 39);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            this.btnSub.MouseEnter += new System.EventHandler(this.btnSub_MouseEnter);
            this.btnSub.MouseLeave += new System.EventHandler(this.btnSub_MouseLeave);
            // 
            // btnMulti
            // 
            this.btnMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMulti.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMulti.Location = new System.Drawing.Point(225, 114);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 39);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            this.btnMulti.MouseEnter += new System.EventHandler(this.btnMulti_MouseEnter);
            this.btnMulti.MouseLeave += new System.EventHandler(this.btnMulti_MouseLeave);
            // 
            // btnDiv
            // 
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiv.Location = new System.Drawing.Point(345, 114);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 39);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            this.btnDiv.MouseEnter += new System.EventHandler(this.btnDiv_MouseEnter);
            this.btnDiv.MouseLeave += new System.EventHandler(this.btnDiv_MouseLeave);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(311, 271);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(345, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Result of Transaction: ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(454, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_Exp1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

