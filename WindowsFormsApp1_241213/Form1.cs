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
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            // textBox_input.Text의 문자열을
            // textBox_result.Text로 복사
            textBox_result.Text = textBox_input.Text;
        }
    }
}
