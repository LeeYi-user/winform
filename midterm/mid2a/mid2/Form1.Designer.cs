﻿
namespace mid2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(121, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "x = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 36F);
            this.label2.Location = new System.Drawing.Point(121, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "y =       x^10 -       x^5 +       x";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox1.Location = new System.Drawing.Point(207, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 36);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox2.Location = new System.Drawing.Point(207, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 36);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox3.Location = new System.Drawing.Point(404, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 36);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox4.Location = new System.Drawing.Point(595, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 36);
            this.textBox4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}

