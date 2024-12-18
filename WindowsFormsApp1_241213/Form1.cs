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
        public Form1()
        {
            InitializeComponent();
            int a = 10;
            int b = 3;
            int[] result = new int[2];
            result = cal(a, b);
            textBox1_print.Text += a + " 나누기 " + b + "의 결과\r\n";
            textBox1_print.Text += "몫: " + result[0] + ", 나머지: " + result[1];

        }
        // 함수 구현
        //1. int형 숫자 두 개를 입력 받기
        //2. 첫 번째 입력 값을 두 번째 입력 값으로 나눔
        //3. 나눠진 값은 배열의 첫 번째 요소에 저장
        //4. 나머지 값은 배열의 두 번째 요소에 저장
        //5. 위 배열을 반환
        int[] cal(int x, int y) // int로 선언 후 int 배열을 반환하려면 에러가 뜸, int[] 형으로 선언해야함
                              // CS0029 cannot implicitly convert type int to int
        {
            int[] cal_array = new int[2];
            cal_array[0] = x / y;
            cal_array[1] = x % y;
            return cal_array;
        }
    }
}
