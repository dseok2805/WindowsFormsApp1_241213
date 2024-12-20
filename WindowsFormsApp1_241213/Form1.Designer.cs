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
            this.button_Rock = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Scissors = new System.Windows.Forms.Button();
            this.button_Paper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Rock
            // 
            this.button_Rock.Location = new System.Drawing.Point(12, 45);
            this.button_Rock.Name = "button_Rock";
            this.button_Rock.Size = new System.Drawing.Size(169, 50);
            this.button_Rock.TabIndex = 1;
            this.button_Rock.Text = "Rock";
            this.button_Rock.UseVisualStyleBackColor = true;
            this.button_Rock.Click += new System.EventHandler(this.button_Rock_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(12, 101);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(520, 337);
            this.textBox_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "가위, 바위, 보 중 하나를 선택해주세요!";
            // 
            // button_Scissors
            // 
            this.button_Scissors.Location = new System.Drawing.Point(187, 45);
            this.button_Scissors.Name = "button_Scissors";
            this.button_Scissors.Size = new System.Drawing.Size(162, 50);
            this.button_Scissors.TabIndex = 4;
            this.button_Scissors.Text = "Scissors";
            this.button_Scissors.UseVisualStyleBackColor = true;
            this.button_Scissors.Click += new System.EventHandler(this.button_Scissors_Click);
            // 
            // button_Paper
            // 
            this.button_Paper.Location = new System.Drawing.Point(356, 45);
            this.button_Paper.Name = "button_Paper";
            this.button_Paper.Size = new System.Drawing.Size(176, 50);
            this.button_Paper.TabIndex = 5;
            this.button_Paper.Text = "Paper";
            this.button_Paper.UseVisualStyleBackColor = true;
            this.button_Paper.Click += new System.EventHandler(this.button_Paper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.button_Paper);
            this.Controls.Add(this.button_Scissors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_Rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Rock;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Scissors;
        private System.Windows.Forms.Button button_Paper;
    }
}

