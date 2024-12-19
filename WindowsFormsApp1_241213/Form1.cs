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
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            // TextBox_input의 텍스트 값
            bool my_select;

            if (string.IsNullOrEmpty(textBox_input.Text)) // textBox_input.Text에 값이 없으면, 라디오 버튼을 활용
            {
                // TextBox가 비어있으면 라디오 버튼 값을 사용
                if (radioButton_True.Checked) // True 버튼이 눌려있으면
                {
                    my_select = true;
                    print_result_coin(my_select);
                }
                else // 버튼이 2개이고 True 버튼이 눌리지 않으면 False가 눌렸을 것이니까
                {
                    my_select = false;
                    print_result_coin(my_select);
                }
            }
            else // textBox_input.Text에 값이 있으면, 입력값을 활용
            {
                if (textBox_input.Text == "True" || textBox_input.Text == "False") // 입력된 값이 True, False 일때만
                {
                    my_select = Convert.ToBoolean(textBox_input.Text); // 문자열을 bool 값으로 변경 후 my_select 변수에 복사
                    print_result_coin(my_select);
                }
                else // 이상한 Text가 입력되면 다시 에러 메세지 출력
                {
                    textBox_result.Text += "올바른 결과를 입력해주세요.\r\n";
                }
                
            }
        }
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
        void print_result_coin(bool select) // 반환할 필요없고 출력만 필요한 함수이니 void 활용
        {
            textBox_result.Text += "입력하신 값은 " + select + " 입니다!" + "\r\n";
            textBox_result.Text += "동전 던지기 결과..." + "\r\n";
            string[] result_coin = new string[2];
            result_coin = coin_top_bottom(select);
            textBox_result.Text += "결과1: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
            result_coin = coin_top_bottom(select);
            textBox_result.Text += "결과2: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
            result_coin = coin_top_bottom(select);
            textBox_result.Text += "결과3: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
            result_coin = coin_top_bottom(select);
            textBox_result.Text += "결과4: " + result_coin[0] + " 동전 랜덤 수: " + result_coin[1] + "\r\n";
        }
    }
}
