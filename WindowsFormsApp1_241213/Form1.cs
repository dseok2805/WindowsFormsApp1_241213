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
        Random randomObj = new Random();
        public Form1()
        {
            // Form 생성시 최초 1회만 생성됨, 따라서 여기서 코드를 짜는건 비추임
            // 초기화 하는 용도
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string message = textBox_input.Text; // textBox_input.Text를 string형 message 변수로 전달
            // true 옵션은 대소문자를 구별하지 않겠다는 뜻
            Day day_input = InputCheck(message); // message를 Day형 변수로 변환하기 위해 InputCheck 함수로 전달
            switch (day_input) // switch의 입력으로 Day형 변수 day_input를 받음
            {
                case Day.monday:
                    textBox_result.Text = "하, 왜 오늘 월요일이야";
                    break;

                case Day.tuesday:
                    textBox_result.Text = "하, 왜 아직 화요일이야, 야구나 보자!";
                    break;

                case Day.wednesday:
                    textBox_result.Text = "하, 왜 아직 수요일이야, 야구나 보자!";
                    break;

                case Day.thusday:
                    textBox_result.Text = "하, 왜 아직 목요일이야, 오늘은 야구보고 이혼숙려캠프 보자!";
                    break;

                case Day.friday:
                    textBox_result.Text = "와! 오늘 금요일이네 늦게 자고 늦게 일어나야지!";
                    break;

                case Day.saturday:
                    textBox_result.Text = "와! 오늘 토요일이네 내일도 늦게 일어나야지!";
                    break;

                case Day.sunday:
                    textBox_result.Text = "하, 내일 왜 월요일이야";
                    break;

                default: // 사용자가 요일 이외의 문자열을 입력하면 오류를 출력함
                    textBox_result.Text = "올바른 요일을 입력해주세영";
                    break;
            }
        }

        enum Day // 요일을 enum 형 변수로 지정함
        {
            monday, // 0
            tuesday, // 1
            wednesday, // 2
            thusday, // 3
            friday, // 4
            saturday, // 5
            sunday, // 6
            fail // 7, 잘못 입력된 모든 경우를 여기로 변환
        }

        Day InputCheck(string message) // message를 Day형 변수로 바꿈
        {
            switch (message)
            {
                case "monday":
                    return Day.monday;
                case "tuesday":
                    return Day.tuesday;
                case "wednesday":
                    return Day.wednesday;
                case "thusday":
                    return Day.thusday;
                case "friday":
                    return Day.friday;
                case "saturday":
                    return Day.saturday;
                case "sunday":
                    return Day.sunday;
                default: // 요일이 아닌 다른 입력이 들어왔을 경우
                    return Day.fail;

            }
        }
    }
}
