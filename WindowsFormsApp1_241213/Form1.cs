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
            // Ctrl + K + C
            // Ctrl + K + U 한꺼번에 주석 처리 가능
            // # region, #endregion 활용해 묶을 수 있음
            string keyword = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            string str1 = keyword.Remove(keyword.IndexOf("-")); // 멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. 

            // IndexOf() 또는 LastIndexOf()를 사용하여 단어를 검색하고,
            // SubString() 또는 Remove() 그리고 Split()을 사용하여 “얼마나”, “천천히”, “가는지” 세 개 단어로 나누어 배열의 요소에 각각 저장
            // 1. 얼마나 천천히 가는지는 으로 빼내기
            string str2 = keyword.Remove(0, keyword.IndexOf("얼마나")); // 얼마나 천천히 가는지는 중요하지 않다. -공자
            str2 = str2.Remove(str2.IndexOf("중요")); // 얼마나 천천히 가는지는 
            str2 = str2.Remove(str2.LastIndexOf("는")); // 얼마나 천천히 가는지
            string[] splitArray = str2.Split(' '); // 공백을 기준으로 3칸의 배열이 생성될 것임
            // 기존 배열에 하나씩 할당
            string[] split_str2 = new string[3];
            split_str2[0] = splitArray[0]; // 얼마나
            split_str2[1] = splitArray[1]; // 천천히
            split_str2[2] = splitArray[2]; // 가는지


            // “.”과 “-”를 제거하고, 모든 공백 문자를 “,”로 바꾸기
            string str3 = keyword.Remove(keyword.IndexOf("."), 1); // 멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다 -공자
            str3 = str3.Remove(str3.IndexOf("-"), 1); // 멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다 공자
            str3 = str3.Replace(" ", ","); // 멈추지,않는,한,얼마나,천천히,가는지는,중요하지,않다,공자

            textBox1_print.Text += str1 + "\r\n";
            textBox1_print.Text += split_str2[0] + "\r\n";
            textBox1_print.Text += split_str2[1] + "\r\n";
            textBox1_print.Text += split_str2[2] + "\r\n";
            textBox1_print.Text += str3;
        }

    }
}
