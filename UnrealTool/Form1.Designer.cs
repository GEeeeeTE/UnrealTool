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
            this.FunctionMacroGroupBox = new System.Windows.Forms.GroupBox();
            this.gtFunctionCheckedListBoxControl = new GTCustomControl.GTCheckedListBoxControl();
            this.FunctionSettingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UMacroGeneratorPanel = new System.Windows.Forms.Panel();
            this.StructureMacroGroupBox = new System.Windows.Forms.GroupBox();
            this.gtStructureOptionCheckedListBoxControl = new GTCustomControl.GTCheckedListBoxControl();
            this.StructureSettingButton = new System.Windows.Forms.Button();
            this.EnumeratorMacroGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumeratorTextBlockUserControl = new GTUserControl.TextBlockUserControl();
            this.AddEnumeratorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumeratorListBox = new System.Windows.Forms.ListBox();
            this.gtEnumeratorTextBoxControl = new GTCustomControl.GTTextBoxControl();
            this.gtEnumeratorOptionCheckedListBoxControl = new GTCustomControl.GTCheckedListBoxControl();
            this.EnumeratorSettingButton = new System.Windows.Forms.Button();
            this.PropertyMacroGroupBox = new System.Windows.Forms.GroupBox();
            this.gtPropertyCheckedListBoxControl = new GTCustomControl.GTCheckedListBoxControl();
            this.PropertySettingButton = new System.Windows.Forms.Button();
            this.FunctionMacroGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UMacroGeneratorPanel.SuspendLayout();
            this.StructureMacroGroupBox.SuspendLayout();
            this.EnumeratorMacroGroupBox.SuspendLayout();
            this.PropertyMacroGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionMacroGroupBox
            // 
            this.FunctionMacroGroupBox.Controls.Add(this.gtFunctionCheckedListBoxControl);
            this.FunctionMacroGroupBox.Controls.Add(this.FunctionSettingButton);
            this.FunctionMacroGroupBox.Location = new System.Drawing.Point(15, 19);
            this.FunctionMacroGroupBox.Name = "FunctionMacroGroupBox";
            this.FunctionMacroGroupBox.Size = new System.Drawing.Size(353, 305);
            this.FunctionMacroGroupBox.TabIndex = 0;
            this.FunctionMacroGroupBox.TabStop = false;
            this.FunctionMacroGroupBox.Text = "関数設定";
            // 
            // gtFunctionCheckedListBoxControl
            // 
            this.gtFunctionCheckedListBoxControl.CheckLimit = 0;
            this.gtFunctionCheckedListBoxControl.FormattingEnabled = true;
            this.gtFunctionCheckedListBoxControl.Items.AddRange(new object[] {
            "ブループリントで呼び出し可能",
            "ゲッター用",
            "C++からブループリントへイベント呼び出し(C++に実装含まない)",
            "C++からブループリントへイベント呼び出し(C++に実装含む)"});
            this.gtFunctionCheckedListBoxControl.Location = new System.Drawing.Point(6, 18);
            this.gtFunctionCheckedListBoxControl.LoopSelect = true;
            this.gtFunctionCheckedListBoxControl.Name = "gtFunctionCheckedListBoxControl";
            this.gtFunctionCheckedListBoxControl.Size = new System.Drawing.Size(329, 200);
            this.gtFunctionCheckedListBoxControl.TabIndex = 5;
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
            this.groupBox1.Controls.Add(this.UMacroGeneratorPanel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CategoryTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "共通設定";
            // 
            // UMacroGeneratorPanel
            // 
            this.UMacroGeneratorPanel.AutoScroll = true;
            this.UMacroGeneratorPanel.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.UMacroGeneratorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UMacroGeneratorPanel.Controls.Add(this.StructureMacroGroupBox);
            this.UMacroGeneratorPanel.Controls.Add(this.EnumeratorMacroGroupBox);
            this.UMacroGeneratorPanel.Controls.Add(this.FunctionMacroGroupBox);
            this.UMacroGeneratorPanel.Controls.Add(this.PropertyMacroGroupBox);
            this.UMacroGeneratorPanel.Location = new System.Drawing.Point(6, 56);
            this.UMacroGeneratorPanel.Name = "UMacroGeneratorPanel";
            this.UMacroGeneratorPanel.Size = new System.Drawing.Size(764, 305);
            this.UMacroGeneratorPanel.TabIndex = 4;
            // 
            // StructureMacroGroupBox
            // 
            this.StructureMacroGroupBox.Controls.Add(this.gtStructureOptionCheckedListBoxControl);
            this.StructureMacroGroupBox.Controls.Add(this.StructureSettingButton);
            this.StructureMacroGroupBox.Location = new System.Drawing.Point(401, 337);
            this.StructureMacroGroupBox.Name = "StructureMacroGroupBox";
            this.StructureMacroGroupBox.Size = new System.Drawing.Size(353, 305);
            this.StructureMacroGroupBox.TabIndex = 7;
            this.StructureMacroGroupBox.TabStop = false;
            this.StructureMacroGroupBox.Text = "構造体設定";
            // 
            // gtStructureOptionCheckedListBoxControl
            // 
            this.gtStructureOptionCheckedListBoxControl.CheckLimit = 0;
            this.gtStructureOptionCheckedListBoxControl.FormattingEnabled = true;
            this.gtStructureOptionCheckedListBoxControl.Location = new System.Drawing.Point(6, 18);
            this.gtStructureOptionCheckedListBoxControl.LoopSelect = true;
            this.gtStructureOptionCheckedListBoxControl.Name = "gtStructureOptionCheckedListBoxControl";
            this.gtStructureOptionCheckedListBoxControl.Size = new System.Drawing.Size(329, 200);
            this.gtStructureOptionCheckedListBoxControl.TabIndex = 5;
            // 
            // StructureSettingButton
            // 
            this.StructureSettingButton.Location = new System.Drawing.Point(260, 276);
            this.StructureSettingButton.Name = "StructureSettingButton";
            this.StructureSettingButton.Size = new System.Drawing.Size(75, 23);
            this.StructureSettingButton.TabIndex = 1;
            this.StructureSettingButton.Text = "生成";
            this.StructureSettingButton.UseVisualStyleBackColor = true;
            // 
            // EnumeratorMacroGroupBox
            // 
            this.EnumeratorMacroGroupBox.Controls.Add(this.EnumeratorTextBlockUserControl);
            this.EnumeratorMacroGroupBox.Controls.Add(this.AddEnumeratorButton);
            this.EnumeratorMacroGroupBox.Controls.Add(this.label2);
            this.EnumeratorMacroGroupBox.Controls.Add(this.EnumeratorListBox);
            this.EnumeratorMacroGroupBox.Controls.Add(this.gtEnumeratorTextBoxControl);
            this.EnumeratorMacroGroupBox.Controls.Add(this.gtEnumeratorOptionCheckedListBoxControl);
            this.EnumeratorMacroGroupBox.Controls.Add(this.EnumeratorSettingButton);
            this.EnumeratorMacroGroupBox.Location = new System.Drawing.Point(15, 330);
            this.EnumeratorMacroGroupBox.Name = "EnumeratorMacroGroupBox";
            this.EnumeratorMacroGroupBox.Size = new System.Drawing.Size(353, 305);
            this.EnumeratorMacroGroupBox.TabIndex = 6;
            this.EnumeratorMacroGroupBox.TabStop = false;
            this.EnumeratorMacroGroupBox.Text = "列挙設定";
            // 
            // EnumeratorTextBlockUserControl
            // 
            this.EnumeratorTextBlockUserControl.AutoSize = true;
            this.EnumeratorTextBlockUserControl.Location = new System.Drawing.Point(9, 260);
            this.EnumeratorTextBlockUserControl.Name = "EnumeratorTextBlockUserControl";
            this.EnumeratorTextBlockUserControl.Size = new System.Drawing.Size(209, 28);
            this.EnumeratorTextBlockUserControl.TabIndex = 10;
            this.EnumeratorTextBlockUserControl.TEXTALLOWPATTERN = GTCustomControl.GTTextBoxControl.enTEXTALLOWPATTERN.NORMAL;
            this.EnumeratorTextBlockUserControl.TextBox = "";
            this.EnumeratorTextBlockUserControl.TextLabel = "生成する列挙体名";
            // 
            // AddEnumeratorButton
            // 
            this.AddEnumeratorButton.AutoSize = true;
            this.AddEnumeratorButton.Location = new System.Drawing.Point(204, 151);
            this.AddEnumeratorButton.Name = "AddEnumeratorButton";
            this.AddEnumeratorButton.Size = new System.Drawing.Size(131, 23);
            this.AddEnumeratorButton.TabIndex = 9;
            this.AddEnumeratorButton.Text = "列挙を追加";
            this.AddEnumeratorButton.UseVisualStyleBackColor = true;
            this.AddEnumeratorButton.Click += new System.EventHandler(this.AddEnumeratorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "使用する列挙名リスト";
            // 
            // EnumeratorListBox
            // 
            this.EnumeratorListBox.FormattingEnabled = true;
            this.EnumeratorListBox.ItemHeight = 12;
            this.EnumeratorListBox.Location = new System.Drawing.Point(7, 86);
            this.EnumeratorListBox.Name = "EnumeratorListBox";
            this.EnumeratorListBox.Size = new System.Drawing.Size(191, 88);
            this.EnumeratorListBox.TabIndex = 7;
            this.EnumeratorListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommonListBox_KeyDown);
            // 
            // gtEnumeratorTextBoxControl
            // 
            this.gtEnumeratorTextBoxControl.AllowDrop = true;
            this.gtEnumeratorTextBoxControl.Location = new System.Drawing.Point(204, 86);
            this.gtEnumeratorTextBoxControl.Multiline = true;
            this.gtEnumeratorTextBoxControl.Name = "gtEnumeratorTextBoxControl";
            this.gtEnumeratorTextBoxControl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.gtEnumeratorTextBoxControl.Size = new System.Drawing.Size(131, 37);
            this.gtEnumeratorTextBoxControl.TabIndex = 6;
            // 
            // gtEnumeratorOptionCheckedListBoxControl
            // 
            this.gtEnumeratorOptionCheckedListBoxControl.CheckLimit = 0;
            this.gtEnumeratorOptionCheckedListBoxControl.FormattingEnabled = true;
            this.gtEnumeratorOptionCheckedListBoxControl.Items.AddRange(new object[] {
            "列挙の数定義を含む"});
            this.gtEnumeratorOptionCheckedListBoxControl.Location = new System.Drawing.Point(6, 18);
            this.gtEnumeratorOptionCheckedListBoxControl.LoopSelect = true;
            this.gtEnumeratorOptionCheckedListBoxControl.Name = "gtEnumeratorOptionCheckedListBoxControl";
            this.gtEnumeratorOptionCheckedListBoxControl.Size = new System.Drawing.Size(329, 46);
            this.gtEnumeratorOptionCheckedListBoxControl.TabIndex = 5;
            // 
            // EnumeratorSettingButton
            // 
            this.EnumeratorSettingButton.Location = new System.Drawing.Point(260, 276);
            this.EnumeratorSettingButton.Name = "EnumeratorSettingButton";
            this.EnumeratorSettingButton.Size = new System.Drawing.Size(75, 23);
            this.EnumeratorSettingButton.TabIndex = 1;
            this.EnumeratorSettingButton.Text = "生成";
            this.EnumeratorSettingButton.UseVisualStyleBackColor = true;
            this.EnumeratorSettingButton.Click += new System.EventHandler(this.EnumeratorSettingButton_Click);
            // 
            // PropertyMacroGroupBox
            // 
            this.PropertyMacroGroupBox.Controls.Add(this.gtPropertyCheckedListBoxControl);
            this.PropertyMacroGroupBox.Controls.Add(this.PropertySettingButton);
            this.PropertyMacroGroupBox.Location = new System.Drawing.Point(401, 19);
            this.PropertyMacroGroupBox.Name = "PropertyMacroGroupBox";
            this.PropertyMacroGroupBox.Size = new System.Drawing.Size(341, 305);
            this.PropertyMacroGroupBox.TabIndex = 2;
            this.PropertyMacroGroupBox.TabStop = false;
            this.PropertyMacroGroupBox.Text = "変数設定";
            // 
            // gtPropertyCheckedListBoxControl
            // 
            this.gtPropertyCheckedListBoxControl.CheckLimit = 1;
            this.gtPropertyCheckedListBoxControl.FormattingEnabled = true;
            this.gtPropertyCheckedListBoxControl.Items.AddRange(new object[] {
            "エディタで編集、ブループリントで編集",
            "エディタで編集",
            "ブループリントで編集",
            "エディタで閲覧、ブループリントで閲覧",
            "エディタで閲覧",
            "ブループリントで閲覧"});
            this.gtPropertyCheckedListBoxControl.Location = new System.Drawing.Point(6, 18);
            this.gtPropertyCheckedListBoxControl.LoopSelect = true;
            this.gtPropertyCheckedListBoxControl.Name = "gtPropertyCheckedListBoxControl";
            this.gtPropertyCheckedListBoxControl.Size = new System.Drawing.Size(329, 200);
            this.gtPropertyCheckedListBoxControl.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FunctionMacroGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UMacroGeneratorPanel.ResumeLayout(false);
            this.StructureMacroGroupBox.ResumeLayout(false);
            this.EnumeratorMacroGroupBox.ResumeLayout(false);
            this.EnumeratorMacroGroupBox.PerformLayout();
            this.PropertyMacroGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FunctionMacroGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Button FunctionSettingButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox PropertyMacroGroupBox;
        private System.Windows.Forms.Button PropertySettingButton;
        private GTCustomControl.GTCheckedListBoxControl gtFunctionCheckedListBoxControl;
        private GTCustomControl.GTCheckedListBoxControl gtPropertyCheckedListBoxControl;
        private System.Windows.Forms.Panel UMacroGeneratorPanel;
        private System.Windows.Forms.GroupBox StructureMacroGroupBox;
        private GTCustomControl.GTCheckedListBoxControl gtStructureOptionCheckedListBoxControl;
        private System.Windows.Forms.Button StructureSettingButton;
        private System.Windows.Forms.GroupBox EnumeratorMacroGroupBox;
        private GTCustomControl.GTCheckedListBoxControl gtEnumeratorOptionCheckedListBoxControl;
        private System.Windows.Forms.Button EnumeratorSettingButton;
        private GTCustomControl.GTTextBoxControl gtEnumeratorTextBoxControl;
        private System.Windows.Forms.Button AddEnumeratorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EnumeratorListBox;
        private GTUserControl.TextBlockUserControl EnumeratorTextBlockUserControl;
    }
}

