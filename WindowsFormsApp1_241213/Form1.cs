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
            textBox1_print.Text = "어떤 결과가 나올까??";


        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Form1.cs에서 이 함수를 지우고
            // Design.cs 파일에서
            // this.label1.Click += new System.EventHandler(this.label1_Click) 빨간 부분을 주석처리함
        }
    }
}
