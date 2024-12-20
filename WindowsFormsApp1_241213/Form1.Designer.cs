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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton_Rock = new System.Windows.Forms.RadioButton();
            this.radioButton_Scissors = new System.Windows.Forms.RadioButton();
            this.radioButton_Paper = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(398, 45);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(169, 50);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(12, 101);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(555, 337);
            this.textBox_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "가위, 바위, 보 중 하나를 선택해주세요!";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton_Paper);
            this.groupBox.Controls.Add(this.radioButton_Scissors);
            this.groupBox.Controls.Add(this.radioButton_Rock);
            this.groupBox.Location = new System.Drawing.Point(14, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(378, 59);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Select";
            // 
            // radioButton_Rock
            // 
            this.radioButton_Rock.AutoSize = true;
            this.radioButton_Rock.Location = new System.Drawing.Point(20, 25);
            this.radioButton_Rock.Name = "radioButton_Rock";
            this.radioButton_Rock.Size = new System.Drawing.Size(51, 16);
            this.radioButton_Rock.TabIndex = 0;
            this.radioButton_Rock.TabStop = true;
            this.radioButton_Rock.Text = "Rock";
            this.radioButton_Rock.UseVisualStyleBackColor = true;
            // 
            // radioButton_Scissors
            // 
            this.radioButton_Scissors.AutoSize = true;
            this.radioButton_Scissors.Location = new System.Drawing.Point(141, 25);
            this.radioButton_Scissors.Name = "radioButton_Scissors";
            this.radioButton_Scissors.Size = new System.Drawing.Size(73, 16);
            this.radioButton_Scissors.TabIndex = 1;
            this.radioButton_Scissors.TabStop = true;
            this.radioButton_Scissors.Text = "Scissors";
            this.radioButton_Scissors.UseVisualStyleBackColor = true;
            // 
            // radioButton_Paper
            // 
            this.radioButton_Paper.AutoSize = true;
            this.radioButton_Paper.Location = new System.Drawing.Point(276, 25);
            this.radioButton_Paper.Name = "radioButton_Paper";
            this.radioButton_Paper.Size = new System.Drawing.Size(56, 16);
            this.radioButton_Paper.TabIndex = 2;
            this.radioButton_Paper.TabStop = true;
            this.radioButton_Paper.Text = "Paper";
            this.radioButton_Paper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_input);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButton_Paper;
        private System.Windows.Forms.RadioButton radioButton_Scissors;
        private System.Windows.Forms.RadioButton radioButton_Rock;
    }
}

