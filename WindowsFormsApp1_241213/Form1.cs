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

            // 10칸 크기의 문자열 배열을 선언함
            string[] myArray = new string[10];

            // IndexOf() 활용
            string str1 = "동해 물과 백두산이";
            // textBox1_print.Text = str1.IndexOf("백두산").ToString() + "\r\n"; -> "백두산" 이라는 배열의 시작지점인 6이 출력됨
            myArray[0] = str1.IndexOf("백두산").ToString();

            // LastIndexOf() 활용
            string str2 = "토요일에 먹는 토마토";
            // textBox1_print.Text = str2.LastIndexOf("토").ToString() + "\r\n"; -> 뒤에서부터 찾기에 마지막 "토"의 위치인 10이 출력됨
            myArray[1] = str2.LastIndexOf("토").ToString();

            // Contains() 활용
            string str3 = "질서 있는 퇴장";
            // textBox1_print.Text = str3.Contains("퇴") + "\r\n"; -> str3 문자열에 "퇴" 라는 문자열이 존재하기에 True가 출력됨
            myArray[2] = str3.Contains("퇴").ToString();

            // Replace() 활용
            string str4 = "그 사람의 그림자는 그랬다.";
            str4 = str4.Replace("그", "이"); // Replace(바꾸고 싶은 문자, 바꿀 문자)
            // textBox1_print.Text = str4 + "\r\n"; // 그 사람의 그림자는 그랬다. -> 이 사람의 이림자는 이랬다. 로 변경되어 출력됨
            myArray[3] = str4;

            // Insert() 활용
            string str5 = "삼성 갤럭시";
            str5 = str5.Insert(str5.IndexOf(" "), "애플"); // Insert(삽입 인덱스, 삽입할 문자)
            // textBox1_print.Text = str5 + "\r\n"; // 삼성애플 갤럭시로 출력됨
            myArray[4] = str5;

            // Remove() 활용
            string str6 = "오늘은 왠지 더 배고프다";
            str6 = str6.Remove(str6.IndexOf("더"), 1); // Remove(삭제할 시작 인덱스, 삭제할 글자 수)
            // textBox1_print.Text = str6 + "\r\n"; //  오늘은 왠지  배고프다 로 출력됨
            myArray[5] = str6;

            // split() 활용
            string str7 = "이름, 나이, 전화번호";
            string[] tempArray = str7.Split(','); // 3칸의 배열이 생성될 것임
            // 기존 배열에 하나씩 할당
            myArray[6] = tempArray[0];
            myArray[7] = tempArray[1]; // _나이
            myArray[8] = tempArray[2]; // _전화번호 띄워쓰기가 같이 저장됨 그렇게 안되려면 "이름,나이,전화번호" 이렇게 저장하면 됨

            // SubString() 활용
            string str8 = "우리 나라 만세";
            // textBox1_print.Text = str8.Substring(str8.IndexOf("나라"), 2) + "\r\n"; // Substring(시작 인덱스, 문자열 갯수)
            myArray[9] = str8.Substring(str8.IndexOf("나라"), 2);

            for (int i = 0; i < myArray.Length; i++)
            {
                textBox1_print.Text += myArray[i] + "\r\n";
            }
        }
    }
}
