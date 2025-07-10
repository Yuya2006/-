using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電卓プログラムの作成
{
    public partial class Form1 : Form
    {
        int firstnum, secondnum;//第１項目と第２項目の変数

        int i,j;//入力値の桁数をカウントする変数と演算子ボタンのon/offを管理する変数
        int hantei=0;//演算子の判定をする変数

        int currentInput=0;//現在の入力値を保持する変数

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if( i< 4)//入力値の桁数が4桁未満のときのみ
            {
                currentInput = currentInput * 10 + 0;
                label1.Text = currentInput.ToString();
                i++;
            }
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 1;
                label1.Text = currentInput.ToString();
                i++;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 2;
                label1.Text = currentInput.ToString();
                i++;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 3;
                label1.Text = currentInput.ToString();
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 4;
                label1.Text = currentInput.ToString();
                i++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 5;
                label1.Text = currentInput.ToString();
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 6;
                label1.Text = currentInput.ToString();
                i++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 7;
                label1.Text = currentInput.ToString();
                i++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 8;
                label1.Text = currentInput.ToString();
                i++;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                currentInput = currentInput * 10 + 9;
                label1.Text = currentInput.ToString();
                i++;
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            
            if (j == 0)//演算子ボタンがoffのときのみ
            {
                division.BackColor = Color.Red;
                kigou.Text = "÷";


                firstope.Text= currentInput.ToString();
                firstnum = currentInput;
                currentInput = 0;

                j = 1;//演算子ボタンをon
                i = 0;//入力値の桁数をリセット
                hantei = 1;//演算子の判定を1に設定（割り算）

            }
          

        }

        private void times_Click(object sender, EventArgs e)
        {
            if (j == 0)//演算子ボタンがoffのときのみ
            {
                times.BackColor = Color.Red;
                kigou.Text = "×";


                firstope.Text = currentInput.ToString();
                firstnum = currentInput;
                currentInput = 0;

                j = 1;//演算子ボタンをon
                i = 0;//入力値の桁数をリセット
                hantei = 2;//演算子の判定を2に設定（掛け算）

            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (j == 0)//演算子ボタンがoffのときのみ
            {

                 minus.BackColor = Color.Red;
                 kigou.Text = "－";


                 firstope.Text = currentInput.ToString();
                 firstnum = currentInput;
                 currentInput = 0;

                 j = 1;//演算子ボタンをon
                 i = 0;//入力値の桁数をリセット
                 hantei = 3;//演算子の判定を3に設定（引き算）
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (j == 0)//演算子ボタンがoffのときのみ
            {
                plus.BackColor = Color.Red;
                kigou.Text = "＋";


                firstope.Text = currentInput.ToString();
                firstnum = currentInput;
                currentInput = 0;

                j = 1;//演算子ボタンをon
                i = 0;//入力値の桁数をリセット
                hantei = 4;//演算子の判定を4に設定（足し算）

            }
     
        }

        private void equal_Click(object sender, EventArgs e)
        {
            int result;
            if (j == 1)//演算子が押されている場合のみ
            {
                secondnum = currentInput;
                if (hantei == 1)//割り算の処理
                {
                    secondope.Text = secondnum.ToString();
                    if (secondnum != 0)//ゼロ除算でない場合の処理
                    {
                        result = firstnum / secondnum;
                        Result.Text = result.ToString();
                    }
                    else if (secondnum == 0)//ゼロ除算の場合の処理
                    {
                        error.Text = "error";
                    }
                }
                else if (hantei == 2)//掛け算の処理
                {
                    result = firstnum * secondnum;
                    secondope.Text = secondnum.ToString();
                    Result.Text = result.ToString();
                }
                else if (hantei == 3)//引き算の処理
                {
                    result = firstnum - secondnum;
                    secondope.Text = secondnum.ToString();
                    Result.Text = result.ToString();
                }
                else if (hantei == 4)//足し算の処理
                {
                    result = firstnum + secondnum;
                    secondope.Text = secondnum.ToString();
                    Result.Text = result.ToString();
                }
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void kigou_Click(object sender, EventArgs e)
        {
            
        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (i >= 1)
            {
                currentInput = currentInput / 10;//現在の入力値を１桁削除
                label1.Text = currentInput.ToString();
                i--;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentInput = currentInput * -1;//符号を反転
            label1.Text = currentInput.ToString();
        }

        private void firstope_Click(object sender, EventArgs e)
        {

        }

        private void AC_Click(object sender, EventArgs e)
        {
            firstnum = 0;//第１項目をリセット
            secondnum = 0; //第２項目をリセット
            currentInput = 0;//現在の入力値をリセット
            i = 0;//入力値の桁数をリセット
            j = 0;//演算子の選択をリセット
            hantei = 0;//演算子の判定をリセット
            firstope.Text = "0";
            secondope.Text = "0";
            Result.Text = "0";
            label1.Text = "0";
            kigou.Text = "  ";
            error.Text = " ";
            division.BackColor = SystemColors.ActiveCaption;
            times.BackColor = SystemColors.ActiveCaption;
            minus.BackColor = SystemColors.ActiveCaption;
            plus.BackColor = SystemColors.ActiveCaption;
        }

        
    }
}
