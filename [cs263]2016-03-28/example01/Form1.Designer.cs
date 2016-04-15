namespace Example01
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeCatagory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.performanceTextBox = new System.Windows.Forms.TextBox();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(415, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(189, 62);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "新增員工";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idLabel.Location = new System.Drawing.Point(60, 69);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(152, 40);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "員工編號:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel.Location = new System.Drawing.Point(60, 128);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 40);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "員工姓名:";
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.baseSalaryLabel.Location = new System.Drawing.Point(60, 180);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(152, 40);
            this.baseSalaryLabel.TabIndex = 3;
            this.baseSalaryLabel.Text = "基本薪資:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idTextBox.Location = new System.Drawing.Point(218, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(160, 50);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(218, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 50);
            this.nameTextBox.TabIndex = 5;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(218, 177);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.Size = new System.Drawing.Size(160, 50);
            this.baseSalaryTextBox.TabIndex = 6;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infoRichTextBox.Location = new System.Drawing.Point(67, 345);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(678, 171);
            this.infoRichTextBox.TabIndex = 7;
            this.infoRichTextBox.Text = "";
            // 
            // employeeCatagory
            // 
            this.employeeCatagory.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.employeeCatagory.FormattingEnabled = true;
            this.employeeCatagory.Items.AddRange(new object[] {
            "一般員工",
            "業務"});
            this.employeeCatagory.Location = new System.Drawing.Point(566, 69);
            this.employeeCatagory.Name = "employeeCatagory";
            this.employeeCatagory.Size = new System.Drawing.Size(160, 43);
            this.employeeCatagory.TabIndex = 8;
            this.employeeCatagory.SelectedIndexChanged += new System.EventHandler(this.employeeCatagory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(408, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "員工類型:";
            // 
            // performanceTextBox
            // 
            this.performanceTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.performanceTextBox.Location = new System.Drawing.Point(218, 237);
            this.performanceTextBox.Name = "performanceTextBox";
            this.performanceTextBox.Size = new System.Drawing.Size(160, 50);
            this.performanceTextBox.TabIndex = 11;
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.performanceLabel.Location = new System.Drawing.Point(60, 240);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(152, 40);
            this.performanceLabel.TabIndex = 10;
            this.performanceLabel.Text = "基本薪資:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.performanceTextBox);
            this.Controls.Add(this.performanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeCatagory);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.baseSalaryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.ComboBox employeeCatagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox performanceTextBox;
        private System.Windows.Forms.Label performanceLabel;
    }
}

