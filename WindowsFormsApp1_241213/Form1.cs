using System;
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
            InitializeComponent(); // 창을 생성하는 소스코드, 메모리상에서 데이터로만 생성됨
            // Program.cs에서 윈도우에서 볼 수 있도록 창을 띄워줌
            // MessageBox.Show("하하하하하핳하"); // 메세지박스를 출력할 수 있음

            //// \r\n : 개행문자
            //int a = 0; // int 형 a 변수를 선언함
            //a = 47; // a 변수를 변경함

            //string msg = "안녕";
            //msg = "dseok";

            // 텍스트 박스에 메세지 출력
            textBox1_print.Text += "어떤 결과가 나올까??\r\n";
            // 다음 줄에 어떻게 표시하지?? -> 해결 완료

            double sample; // 변수를 선언함
            sample = 1.421; // 선언한 변수를 사용할 때는 자료형을 붙이지 않음
            double sample2 = 1.444; // 변수 초기화, 선언과 동시에 변수를 초기화함
            // 초기화: 비어있는 변수에 처음으로 값이 들어가는 상황
            textBox1_print.Text += sample.ToString();
            // ToString: 문자열로 변환하는 함수
            textBox1_print.Text += "\r\n";
            textBox1_print.Text += sample2.ToString();
            // Text라는 변수는 String형으로 이미 선언되어있음


        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Form1.cs에서 이 함수를 지우고
            // Design.cs 파일에서
            // this.label1.Click += new System.EventHandler(this.label1_Click) 빨간 부분을 주석처리함
        }
    }
}
