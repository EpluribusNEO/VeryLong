using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using verylong = Form_VeryLong.CVeryLong;

namespace Form_VeryLong
{
    //Copy to buffer  -- While not working with decimals) --Пока не работает с десятичными дробями)
    delegate void btnEvent(object sender, EventArgs e);
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnEvent btnCopy = (sender, e) => {
                if(textBox_Result.Text != String.Empty){
                    Clipboard.Clear();
                    Clipboard.SetText(textBox_Result.Text);
                }

            };
            btn_Copy.Click += new System.EventHandler(btnCopy);
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            char[] first = new char[verylong.Size];
            char[] second = new char[verylong.Size];
            first = textBox_FirstValue.Text.ToCharArray();
            second = textBox_SecondValue.Text.ToCharArray();
            Array.Reverse(first);
            Array.Reverse(second);

            verylong a = new verylong(first);
            verylong b = new verylong(second);
            verylong sum = a + b;
            textBox_Result.Text = sum.ReturnVeryLongLikeStr();
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            char[] f = new char[verylong.Size];
            char[] s = new char[verylong.Size];
            f = textBox_FirstValue.Text.ToCharArray();
            s = textBox_SecondValue.Text.ToCharArray();
            Array.Reverse(f);
            Array.Reverse(s);

            verylong fir = new verylong(f);
            verylong sec = new verylong(s);
            verylong mult = fir * sec;

            textBox_Result.Text = mult.ReturnVeryLongLikeStr(); 
        }

    }
}
