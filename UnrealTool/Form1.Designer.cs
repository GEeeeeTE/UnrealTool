namespace UnrealTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.FunctionSettingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PropertySettingButton = new System.Windows.Forms.Button();
            this.gtPropertyCheckedListBoxControl = new GTCustomControl.GTCheckedListBoxControl();
            this.gtFunctionCheckedListBoxControl = new GTCustomControl.GTCheckedListBoxControl();
            this.FunctionGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionGroupBox
            // 
            this.FunctionGroupBox.Controls.Add(this.gtFunctionCheckedListBoxControl);
            this.FunctionGroupBox.Controls.Add(this.FunctionSettingButton);
            this.FunctionGroupBox.Location = new System.Drawing.Point(8, 56);
            this.FunctionGroupBox.Name = "FunctionGroupBox";
            this.FunctionGroupBox.Size = new System.Drawing.Size(341, 305);
            this.FunctionGroupBox.TabIndex = 0;
            this.FunctionGroupBox.TabStop = false;
            this.FunctionGroupBox.Text = "関数設定";
            // 
            // FunctionSettingButton
            // 
            this.FunctionSettingButton.Location = new System.Drawing.Point(260, 276);
            this.FunctionSettingButton.Name = "FunctionSettingButton";
            this.FunctionSettingButton.Size = new System.Drawing.Size(75, 23);
            this.FunctionSettingButton.TabIndex = 1;
            this.FunctionSettingButton.Text = "コピー";
            this.FunctionSettingButton.UseVisualStyleBackColor = true;
            this.FunctionSettingButton.Click += new System.EventHandler(this.FunctionSettingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "カテゴリー名";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(166, 31);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 19);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FunctionGroupBox);
            this.groupBox1.Controls.Add(this.CategoryTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "共通設定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gtPropertyCheckedListBoxControl);
            this.groupBox2.Controls.Add(this.PropertySettingButton);
            this.groupBox2.Location = new System.Drawing.Point(380, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "変数設定";
            // 
            // PropertySettingButton
            // 
            this.PropertySettingButton.Location = new System.Drawing.Point(260, 276);
            this.PropertySettingButton.Name = "PropertySettingButton";
            this.PropertySettingButton.Size = new System.Drawing.Size(75, 23);
            this.PropertySettingButton.TabIndex = 1;
            this.PropertySettingButton.Text = "コピー";
            this.PropertySettingButton.UseVisualStyleBackColor = true;
            this.PropertySettingButton.Click += new System.EventHandler(this.PropertySettingButton_Click);
            // 
            // gtPropertyCheckedListBoxControl
            // 
            this.gtPropertyCheckedListBoxControl.CheckLimit = 0;
            this.gtPropertyCheckedListBoxControl.FormattingEnabled = true;
            this.gtPropertyCheckedListBoxControl.Items.AddRange(new object[] {
            "エディタで編集、ブループリントで編集",
            "エディタで編集",
            "ブループリントで編集",
            "エディタで閲覧、ブループリントで閲覧",
            "エディタで閲覧",
            "ブループリントで閲覧"});
            this.gtPropertyCheckedListBoxControl.Location = new System.Drawing.Point(6, 18);
            this.gtPropertyCheckedListBoxControl.Name = "gtPropertyCheckedListBoxControl";
            this.gtPropertyCheckedListBoxControl.Size = new System.Drawing.Size(329, 200);
            this.gtPropertyCheckedListBoxControl.TabIndex = 4;
            // 
            // gtFunctionCheckedListBoxControl
            // 
            this.gtFunctionCheckedListBoxControl.CheckLimit = 0;
            this.gtFunctionCheckedListBoxControl.FormattingEnabled = true;
            this.gtFunctionCheckedListBoxControl.Items.AddRange(new object[] {
            "ブループリントで呼び出し可能",
            "ゲッター用"});
            this.gtFunctionCheckedListBoxControl.Location = new System.Drawing.Point(6, 18);
            this.gtFunctionCheckedListBoxControl.Name = "gtFunctionCheckedListBoxControl";
            this.gtFunctionCheckedListBoxControl.Size = new System.Drawing.Size(329, 200);
            this.gtFunctionCheckedListBoxControl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FunctionGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FunctionGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Button FunctionSettingButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PropertySettingButton;
        private GTCustomControl.GTCheckedListBoxControl gtFunctionCheckedListBoxControl;
        private GTCustomControl.GTCheckedListBoxControl gtPropertyCheckedListBoxControl;
    }
}

