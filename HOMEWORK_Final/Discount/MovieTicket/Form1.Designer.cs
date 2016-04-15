namespace MovieTicket
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
            this.TicketCateComboBox = new System.Windows.Forms.ComboBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.QtyComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TicketCateLabel = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ResetBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicketCateComboBox
            // 
            this.TicketCateComboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TicketCateComboBox.FormattingEnabled = true;
            this.TicketCateComboBox.Items.AddRange(new object[] {
            "一般",
            "花旗卡",
            "學生",
            "兒童"});
            this.TicketCateComboBox.Location = new System.Drawing.Point(114, 28);
            this.TicketCateComboBox.Name = "TicketCateComboBox";
            this.TicketCateComboBox.Size = new System.Drawing.Size(372, 35);
            this.TicketCateComboBox.TabIndex = 0;
            this.TicketCateComboBox.Text = "一般";
            this.TicketCateComboBox.SelectedIndexChanged += new System.EventHandler(this.TicketCateComboBox_SelectedIndexChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultTextBox.Location = new System.Drawing.Point(55, 123);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(570, 212);
            this.ResultTextBox.TabIndex = 2;
            // 
            // QtyComboBox
            // 
            this.QtyComboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.QtyComboBox.FormattingEnabled = true;
            this.QtyComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.QtyComboBox.Location = new System.Drawing.Point(114, 82);
            this.QtyComboBox.Name = "QtyComboBox";
            this.QtyComboBox.Size = new System.Drawing.Size(183, 35);
            this.QtyComboBox.TabIndex = 0;
            this.QtyComboBox.Text = "1";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddButton.Location = new System.Drawing.Point(519, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 35);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "加入清單";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketCateLabel
            // 
            this.TicketCateLabel.AutoSize = true;
            this.TicketCateLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TicketCateLabel.Location = new System.Drawing.Point(60, 33);
            this.TicketCateLabel.Name = "TicketCateLabel";
            this.TicketCateLabel.Size = new System.Drawing.Size(48, 24);
            this.TicketCateLabel.TabIndex = 4;
            this.TicketCateLabel.Text = "票種";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.QtyLabel.Location = new System.Drawing.Point(60, 87);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(48, 24);
            this.QtyLabel.TabIndex = 4;
            this.QtyLabel.Text = "張數";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PriceTextBox.Location = new System.Drawing.Point(357, 82);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(129, 33);
            this.PriceTextBox.TabIndex = 5;
            this.PriceTextBox.Text = "0";
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PriceLabel.Location = new System.Drawing.Point(305, 87);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 24);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "票價";
            // 
            // SummaryButton
            // 
            this.SummaryButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SummaryButton.Location = new System.Drawing.Point(519, 341);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(106, 35);
            this.SummaryButton.TabIndex = 3;
            this.SummaryButton.Text = "結帳";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Visible = false;
            this.SummaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // ResetBotton
            // 
            this.ResetBotton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResetBotton.Location = new System.Drawing.Point(519, 28);
            this.ResetBotton.Name = "ResetBotton";
            this.ResetBotton.Size = new System.Drawing.Size(106, 35);
            this.ResetBotton.TabIndex = 3;
            this.ResetBotton.Text = "新客戶";
            this.ResetBotton.UseVisualStyleBackColor = true;
            this.ResetBotton.Visible = false;
            this.ResetBotton.Click += new System.EventHandler(this.ResetBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 409);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TicketCateLabel);
            this.Controls.Add(this.ResetBotton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.QtyComboBox);
            this.Controls.Add(this.TicketCateComboBox);
            this.Name = "Form1";
            this.Text = "訂票系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TicketCateComboBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ComboBox QtyComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TicketCateLabel;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ResetBotton;
    }
}

