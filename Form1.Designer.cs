namespace Caculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_A = new System.Windows.Forms.TextBox();
            this.txb_B = new System.Windows.Forms.TextBox();
            this.txb_KQ = new System.Windows.Forms.TextBox();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // txb_A
            // 
            this.txb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_A.Location = new System.Drawing.Point(195, 30);
            this.txb_A.Name = "txb_A";
            this.txb_A.Size = new System.Drawing.Size(161, 30);
            this.txb_A.TabIndex = 3;
            // 
            // txb_B
            // 
            this.txb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_B.Location = new System.Drawing.Point(195, 77);
            this.txb_B.Name = "txb_B";
            this.txb_B.Size = new System.Drawing.Size(161, 30);
            this.txb_B.TabIndex = 4;
            // 
            // txb_KQ
            // 
            this.txb_KQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_KQ.Location = new System.Drawing.Point(195, 125);
            this.txb_KQ.Name = "txb_KQ";
            this.txb_KQ.Size = new System.Drawing.Size(161, 30);
            this.txb_KQ.TabIndex = 5;
            // 
            // btn_Cong
            // 
            this.btn_Cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cong.Location = new System.Drawing.Point(323, 213);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(119, 46);
            this.btn_Cong.TabIndex = 6;
            this.btn_Cong.Text = "Cộng";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tru.Location = new System.Drawing.Point(184, 213);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(119, 46);
            this.btn_Tru.TabIndex = 7;
            this.btn_Tru.Text = "Trừ";
            this.btn_Tru.UseVisualStyleBackColor = true;
            this.btn_Tru.Click += new System.EventHandler(this.btn_Tru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 306);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.txb_KQ);
            this.Controls.Add(this.txb_B);
            this.Controls.Add(this.txb_A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_A;
        private System.Windows.Forms.TextBox txb_B;
        private System.Windows.Forms.TextBox txb_KQ;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Button btn_Tru;
    }
}

