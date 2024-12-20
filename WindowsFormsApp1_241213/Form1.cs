using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_241213
{
    public partial class Form1 : Form
    {
        Random randomObj = new Random(); // 랜덤한 점수를 생성하기 위한 함수
        public Form1()
        {
            // Form 생성시 최초 1회만 생성됨, 따라서 여기서 코드를 짜는건 비추임
            // 초기화 하는 용도
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            int num_Student = int.Parse(textBox_input.Text); // 학생 수를 입력받아 int형 변수 num_Student에 전달함
            string name_Student;
            int score_Student;
            textBox_result.Text = "===============학생 성적표===============" + "\r\n";
            for (int i = 0; i < num_Student; i++) // 학생의 수 만큼 반복함
            {
                score_Student = randomObj.Next(0, 100); // 0~100점 사이의 랜덤한 점수를 생성함
                name_Student = "학생" + (i+1).ToString(); // "학생1~학생num_Student"까지 이름을 설정
                textBox_result.Text += make_stduent_score_text(name_Student, score_Student);
            }
        }

        string make_stduent_score_text(string name, int score)
        {
            return name + "의 점수: " + score.ToString() + "\r\n";
        }
    }
}
