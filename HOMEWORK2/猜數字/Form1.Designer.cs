namespace 猜數字
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.Reset = new System.Windows.Forms.Button();
            this.AnsText = new System.Windows.Forms.TextBox();
            this.Summit = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Label();
            this.MegLabel = new System.Windows.Forms.Label();
            this.Meg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(28, 34);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnsText
            // 
            this.AnsText.Location = new System.Drawing.Point(135, 34);
            this.AnsText.Name = "AnsText";
            this.AnsText.Size = new System.Drawing.Size(100, 22);
            this.AnsText.TabIndex = 1;
            this.AnsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeys);
            // 
            // Summit
            // 
            this.Summit.Location = new System.Drawing.Point(135, 63);
            this.Summit.Name = "Summit";
            this.Summit.Size = new System.Drawing.Size(75, 23);
            this.Summit.TabIndex = 3;
            this.Summit.Text = "Summit";
            this.Summit.UseVisualStyleBackColor = true;
            this.Summit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Location = new System.Drawing.Point(30, 63);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(23, 12);
            this.Ans.TabIndex = 4;
            this.Ans.Text = "Ans";
            // 
            // MegLabel
            // 
            this.MegLabel.AutoSize = true;
            this.MegLabel.Location = new System.Drawing.Point(28, 107);
            this.MegLabel.Name = "MegLabel";
            this.MegLabel.Size = new System.Drawing.Size(44, 12);
            this.MegLabel.TabIndex = 5;
            this.MegLabel.Text = "Message";
            this.MegLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Meg
            // 
            this.Meg.Location = new System.Drawing.Point(28, 123);
            this.Meg.Multiline = true;
            this.Meg.Name = "Meg";
            this.Meg.Size = new System.Drawing.Size(207, 98);
            this.Meg.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Meg);
            this.Controls.Add(this.MegLabel);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.Summit);
            this.Controls.Add(this.AnsText);
            this.Controls.Add(this.Reset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox AnsText;
        private System.Windows.Forms.Button Summit;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.Label MegLabel;
        private System.Windows.Forms.TextBox Meg;
    }
}

