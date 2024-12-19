namespace WindowsFormsApp1_241213
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_input = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.radioButton_True = new System.Windows.Forms.RadioButton();
            this.radioButton_False = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(5, 6);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(622, 21);
            this.textBox_input.TabIndex = 0;
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(642, 6);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(146, 74);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(5, 86);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(783, 352);
            this.textBox_result.TabIndex = 2;
            // 
            // radioButton_True
            // 
            this.radioButton_True.AutoSize = true;
            this.radioButton_True.Location = new System.Drawing.Point(20, 20);
            this.radioButton_True.Name = "radioButton_True";
            this.radioButton_True.Size = new System.Drawing.Size(49, 16);
            this.radioButton_True.TabIndex = 3;
            this.radioButton_True.TabStop = true;
            this.radioButton_True.Text = "True";
            this.radioButton_True.UseVisualStyleBackColor = true;
            // 
            // radioButton_False
            // 
            this.radioButton_False.AutoSize = true;
            this.radioButton_False.Location = new System.Drawing.Point(193, 20);
            this.radioButton_False.Name = "radioButton_False";
            this.radioButton_False.Size = new System.Drawing.Size(54, 16);
            this.radioButton_False.TabIndex = 4;
            this.radioButton_False.TabStop = true;
            this.radioButton_False.Text = "False";
            this.radioButton_False.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton_False);
            this.groupBox.Controls.Add(this.radioButton_True);
            this.groupBox.Location = new System.Drawing.Point(12, 31);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(313, 49);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_input);
            this.Controls.Add(textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.RadioButton radioButton_True;
        private System.Windows.Forms.RadioButton radioButton_False;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

