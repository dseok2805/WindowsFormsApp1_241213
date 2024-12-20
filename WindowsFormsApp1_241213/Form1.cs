﻿using System;
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
        string user_select;
        string com_select;
        int com_num;
        int[] score = new int[2];
        public Form1()
        {
            InitializeComponent();
            textBox_result.Text = "가위바위보 게임 시작~!\r\n";
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            com_num = randomObj.Next(0, 3); // 컴퓨터의 선택은 0, 1, 2

            // 컴퓨터의 선택을 string으로 변환
            if (com_num == 0) // 컴퓨터의 선택이 0이면
            {
                com_select = "바위";
            }
            else if (com_num == 1) // 컴퓨터의 선택이 1이면
            {
                com_select = "가위";
            }
            else // 컴퓨터의 선택이 2면
            {
                com_select = "보";
            }

            // 사용자의 선택을 string으로 변환
            if (radioButton_Rock.Checked) // 사용자가 바위 버튼을 선택했으면
            {
                user_select = "바위";
            }
            else if (radioButton_Scissors.Checked) // 사용자가 가위 버튼을 선택했으면
            {
                user_select = "가위";
            }
            else // 사용자가 보 버튼을 선택했으면
            {
                user_select = "보";
            }

            while ((score[0] < 3) && (score[1] < 3)) // 사용자, 컴퓨터의 점수가 3점이 되면 반복문은 끝남
            {
                score = RockScissorsPaper_Result(user_select, com_select);
            }
            string winner = score[0] == 3 ? "사용자" : "컴퓨터"; // 누가 3점이 되었는지 판별함
            textBox_result.Text += "결과: " + winner + "가 이겼습니다!\r\n\r\n";
            ResetGame(); // 게임 초기화
        }

        int[] RockScissorsPaper_Result(string user_select, string com_select)
        {
            textBox_result.Text += "사용자의 선택: " + user_select + "\r\n";
            textBox_result.Text += "컴퓨터의 선택: " + com_select + "\r\n";

            // 가위바위보 결과 계산
            if (user_select == com_select)
            {
                textBox_result.Text += "결과: 비겼습니다!\r\n\r\n";
            }
            else if ((user_select == "가위" && com_select == "보") || (user_select == "바위" && com_select == "가위") || (user_select == "보" && com_select == "바위"))
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


            return score;
        }
        void ResetGame()
        {
            score[0] = 0;
            score[1] = 0;
            textBox_result.Text += "\r\n게임이 초기화되었습니다!\r\n\r\n";
        }
    }
}
