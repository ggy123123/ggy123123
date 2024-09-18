namespace WinFormExamples
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonError = new System.Windows.Forms.Button();
            this.buttonListBox = new System.Windows.Forms.Button();
            this.buttonCheckBox = new System.Windows.Forms.Button();
            this.buttonTextBox = new System.Windows.Forms.Button();
            this.buttonHelloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonError
            // 
            this.buttonError.Location = new System.Drawing.Point(19, 160);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(170, 23);
            this.buttonError.TabIndex = 1;
            this.buttonError.Text = "错误提示示例";
            this.buttonError.UseVisualStyleBackColor = true;
            // 
            // buttonListBox
            // 
            this.buttonListBox.Location = new System.Drawing.Point(19, 123);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(170, 23);
            this.buttonListBox.TabIndex = 2;
            this.buttonListBox.Text = "ListBox和ComboBox示例";
            this.buttonListBox.UseVisualStyleBackColor = true;
            // 
            // buttonCheckBox
            // 
            this.buttonCheckBox.Location = new System.Drawing.Point(19, 86);
            this.buttonCheckBox.Name = "buttonCheckBox";
            this.buttonCheckBox.Size = new System.Drawing.Size(170, 23);
            this.buttonCheckBox.TabIndex = 3;
            this.buttonCheckBox.Text = "CheckBox和RadioButton示例";
            this.buttonCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonTextBox
            // 
            this.buttonTextBox.Location = new System.Drawing.Point(19, 49);
            this.buttonTextBox.Name = "buttonTextBox";
            this.buttonTextBox.Size = new System.Drawing.Size(170, 23);
            this.buttonTextBox.TabIndex = 4;
            this.buttonTextBox.Text = "TextBox示例";
            this.buttonTextBox.UseVisualStyleBackColor = true;
            // 
            // buttonHelloWorld
            // 
            this.buttonHelloWorld.Location = new System.Drawing.Point(19, 12);
            this.buttonHelloWorld.Name = "buttonHelloWorld";
            this.buttonHelloWorld.Size = new System.Drawing.Size(170, 23);
            this.buttonHelloWorld.TabIndex = 5;
            this.buttonHelloWorld.Text = "显示新窗体";
            this.buttonHelloWorld.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 196);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.buttonListBox);
            this.Controls.Add(this.buttonCheckBox);
            this.Controls.Add(this.buttonTextBox);
            this.Controls.Add(this.buttonHelloWorld);
            this.Name = "MainForm";
            this.Text = "WinForm示例";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Button buttonListBox;
        private System.Windows.Forms.Button buttonCheckBox;
        private System.Windows.Forms.Button buttonTextBox;
        private System.Windows.Forms.Button buttonHelloWorld;
    }
}

