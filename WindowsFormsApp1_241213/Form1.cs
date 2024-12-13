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

            // 텍스트 박스에 메세지 출력
            textBox1_print.Text = "이것은\r\n멀티라인\r\n텍스트박스\r\n인데요.";
            // \r\n : 개행문자
            int a = 0;
            a = 999;
        }
    }
}
