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
            InitializeComponent();
            string[] result_coin = new string[2];
            result_coin = coin_top_bottom(true);
            textBox1_print.Text += "결과1: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
            result_coin = coin_top_bottom(true);
            textBox1_print.Text += "결과2: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
            result_coin = coin_top_bottom(false);
            textBox1_print.Text += "결과3: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
            result_coin = coin_top_bottom(false);
            textBox1_print.Text += "결과4: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";

        }
        /*
        1. 동전 던지기(앞 면 또는 뒷 면) 함수를 작성
            1. 함수 이름을 적당하게 짓기
            2. 출력 자료형은 bool
            3. 입력은 bool형 1개
            4. “난수 생성”을 검색하여 난수 생성 방법을 학습하고 int형 난수를 생성
            5. 생성된 난수와 % 연산을 이용, 연산 결과로 0 또는 1만 값이 나오도록 작성
            6. 입력 값과 연산 결과를 비교하여 둘이 같으면 true를 반환, 다르면 false를 반환
                1. 1=true, 0=false라고 가정
        2. 함수에 true 또는 false를 입력하고 반환된 결과에 따라 “승리” 또는 “패배”로 TextBox에 표시
        */
        string[] coin_top_bottom(bool pick)
        {
            int randomValue = randomObj.Next(0, 20); // 0~20 사이의 난수를 생성함
            int result;
            string[] result_array = new string[2];

            // 난수를 0 또는 1로 변환
            if (randomValue % 2 == 1) // 난수의 나머지가 1이면 즉, 홀수면
            {
                result = 1; // 1을 반환함
            }
            else // 난수의 나머지가 0이면 즉, 짝수면
            {
                result = 0; // 0을 반환함       
            }

            result_array[1] = randomValue.ToString();

            // 사용자 입력과 동전 던지기를 비교하여 결과를 반환함
            if (((pick == true) & (result == 1)) || ((pick == false) & (result == 0)))
            {
                result_array[0] = "승리";
                return result_array;
            }
            else 
            {
                result_array[0] = "패배";
                return result_array;
            }
        }

    }
}
