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
        int com_num;
        int[] score = new int[2];
        public Form1()
        {
            InitializeComponent();
            textBox_result.Text = "가위바위보 게임 시작~!\r\n";
        }

        // 가위바위보 열거형 선언
        enum RockPaperScissors
        {
            Rock,   // 0
            Paper,   // 1
            Scissors     // 2
        }

        // 선언한 열거형으로 선택 변수를 선언
        RockPaperScissors user_select;
        RockPaperScissors com_select;

        private void button_Rock_Click(object sender, EventArgs e)
        {
            PlayGame(RockPaperScissors.Rock);
        }

        private void button_Scissors_Click(object sender, EventArgs e)
        {
            PlayGame(RockPaperScissors.Scissors);
        }

        private void button_Paper_Click(object sender, EventArgs e)
        {
            PlayGame(RockPaperScissors.Paper);
        }

        int[] RockScissorsPaper_Result(RockPaperScissors user_select, RockPaperScissors com_select)
        {
            textBox_result.Text += "사용자의 선택: " + user_select + "\r\n";
            textBox_result.Text += "컴퓨터의 선택: " + com_select + "\r\n";

            if (user_select == com_select)
            {
                textBox_result.Text += "결과: 비겼습니다!\r\n\r\n";
            }
            else if (
                (user_select == RockPaperScissors.Scissors && com_select == RockPaperScissors.Paper) ||
                (user_select == RockPaperScissors.Rock && com_select == RockPaperScissors.Scissors) ||
                (user_select == RockPaperScissors.Paper && com_select == RockPaperScissors.Rock))
            {
                score[0]++;
                textBox_result.Text += "결과: 사용자가 이겼습니다!\r\n\r\n";
            }
            else
            {
                score[1]++;
                textBox_result.Text += "결과: 컴퓨터가 이겼습니다!\r\n\r\n";
            }

            // 점수 상태 출력
            textBox_result.Text += "현재 점수 -> 사용자: " + score[0].ToString() + " , 컴퓨터: " + score[1].ToString() + "\r\n";

            // 게임 종료 체크
            if (score[0] == 3 || score[1] == 3)
            {
                textBox_result.Text += "사용자의 선택: " + user_select + "\r\n";
                textBox_result.Text += "컴퓨터의 선택: " + com_select + "\r\n";
                string winner = score[0] == 3 ? "사용자" : "컴퓨터";
                textBox_result.Text += "결과: " + winner + "가 이겼습니다!\r\n\r\n";
                ResetGame(); // 게임 초기화
            }


            return score;
        }
        void ResetGame()
        {
            score[0] = 0;
            score[1] = 0;
            textBox_result.Text += "\r\n게임이 초기화되었습니다!\r\n\r\n";
        }

        void PlayGame(RockPaperScissors userChoice)
        {
            user_select = userChoice;
            com_select = ComputerSelect();
            RockScissorsPaper_Result(user_select, com_select);
        }

        RockPaperScissors ComputerSelect()
        {
            return (RockPaperScissors)randomObj.Next(0, 3); // 컴퓨터의 랜덤 수 0, 1, 2를 열거형으로 명시적 형 변환
        }
    }
}
