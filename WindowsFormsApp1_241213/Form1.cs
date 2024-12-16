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
            InitializeComponent();
            // byte, short, int, float, double, decimal 변수를 선언함
            byte whos_back_num = 47;
            short above_year_fa = -1;
            int fa_year = 4;
            decimal fa_money_won = 3_600_000_000m;
            float ops_2024 = 0.861f;
            double avg_2024 = 0.3027295285;

            textBox1_print.Text += (whos_back_num.GetType() + " " + "whos_back_num: " + whos_back_num + "번\r\n");
            textBox1_print.Text += (above_year_fa.GetType() + " " + "above_year_fa: " + above_year_fa + "년\r\n");
            textBox1_print.Text += (fa_year.GetType() + " " + "fa_year: " + fa_year + "년\r\n");
            textBox1_print.Text += (fa_money_won.GetType() + " " + "fa_money_won: " + fa_money_won + "원\r\n");
            textBox1_print.Text += (ops_2024.GetType() + " " + "ops_2024: " + ops_2024 + "\r\n");
            textBox1_print.Text += (avg_2024.GetType() + " " + "avg_2024: " + avg_2024 + "\r\n");
        }
    }
}
