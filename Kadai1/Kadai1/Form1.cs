using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai1
{
    public partial class Form1 : Form
    {
        int x;
        string type = null;
        int y;

        string sx;
        string sy;

        int mNum = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            x = 0;
            type = null;
            y = 0;
            sx = null;
            sy = null;
            this.numBox.Text = "0";
            tax10Box.Text = "0";
            tax8Box.Text = "0";
            taxAnsBox.Text = "0";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "0";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "0";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "0";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "0";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "1";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "1";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "1";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "1";
                    this.numBox.Text = sy;
                }
            }
            //if (type == null)
            //{
            //    sx += "1";
            //    this.numBox.Text = sx;
            //}
            //else
            //{
            //    //sx = numBox.Text;
            //    sy += "1";
            //    this.numBox.Text = sy;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "2";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "2";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "2";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "2";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "3";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "3";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "3";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "3";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "4";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "4";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "4";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "4";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "5";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "5";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "5";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "5";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "6";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "6";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "6";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "6";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "7";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "7";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "7";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "7";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "8";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "8";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "8";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "8";
                    this.numBox.Text = sy;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                if (sx == "0")
                {
                    sx = "9";
                    this.numBox.Text = sx;
                }
                else
                {

                    sx += "9";
                    this.numBox.Text = sx;
                }
            }
            else
            {
                if (sy == "0")
                {
                    sy = "9";
                    this.numBox.Text = sy;
                }
                else
                {

                    sy += "9";
                    this.numBox.Text = sy;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                type = "add";
            }
            else
            {
                buttonAns_Click(sender, e);
                type = "add";
            }

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                type = "sub";
            }
            else
            {
                buttonAns_Click(sender, e);
                type = "sub";
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                type = "mult";
            }
            else
            {
                buttonAns_Click(sender, e);
                type = "mult";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
                type = "div";
            }
            else
            {
                buttonAns_Click(sender, e);
                type = "div";
            }
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(sx, out x);
            bool success2 = int.TryParse(sy, out y);

            double ans;

            if (success && success2)
            {


                switch (type)
                {
                    case "add":
                        ans = x + y;
                        this.numBox.Text = ans.ToString();
                        sx = ans.ToString();
                        sy = null;
                        break;
                    case "sub":
                        ans = x - y;
                        this.numBox.Text = ans.ToString();
                        sx = ans.ToString();
                        sy = null;
                        break;
                    case "mult":
                        ans = x * y;
                        this.numBox.Text = ans.ToString();
                        sx = ans.ToString();
                        sy = null;
                        break;
                    case "div":
                        ans = (double)x / y;
                        this.numBox.Text = ans.ToString();
                        sx = ans.ToString();
                        sy = null;
                        break;


                }

            }
        }

        private void labelTax10_Click(object sender, EventArgs e)
        {
            int boxNum;
            bool success = int.TryParse(this.numBox.Text, out boxNum);

            double ans;

            if (success)
            {
                ans = boxNum * 1.1;
                tax10Box.Text = ans.ToString();
            }
        }

        private void labelTax8_Click(object sender, EventArgs e)
        {
            int boxNum;
            bool success = int.TryParse(this.numBox.Text, out boxNum);

            double ans;

            if (success)
            {
                ans = boxNum * 1.08;
                tax8Box.Text = ans.ToString();
            }
        }

        private void tax10Button_Click(object sender, EventArgs e)
        {
            int boxNum;
            bool success = int.TryParse(this.numBox.Text, out boxNum);

            double ans;

            if (success)
            {
                ans = boxNum * 1.1;
                tax10Box.Text = ans.ToString();
            }
        }

        private void tax8Button_Click(object sender, EventArgs e)
        {
            int boxNum;
            bool success = int.TryParse(this.numBox.Text, out boxNum);

            double ans;

            if (success)
            {
                ans = boxNum * 1.08;
                tax8Box.Text = ans.ToString();
            }
        }

        private void TaxTypeSelected(object sender, EventArgs e)
        {
            string a = taxType.Text;
            int boxNum;
            bool success;
            double ans;

            switch (a)
            {
                case "税込10％":

                    success = int.TryParse(this.numBox.Text, out boxNum);


                    if (success)
                    {
                        ans = boxNum * 1.1;
                        taxAnsBox.Text = ans.ToString();
                    }

                    break;
                case "税込8％":

                    success = int.TryParse(this.numBox.Text, out boxNum);


                    if (success)
                    {
                        ans = boxNum * 1.08;
                        taxAnsBox.Text = ans.ToString();
                    }
                    break;
                case "税抜10％":

                    success = int.TryParse(this.numBox.Text, out boxNum);


                    if (success)
                    {
                        ans = boxNum / 1.1;
                        taxAnsBox.Text = ans.ToString();
                    }

                    break;
                case "税抜8％":

                    success = int.TryParse(this.numBox.Text, out boxNum);



                    if (success)
                    {
                        ans = boxNum / 1.08;
                        taxAnsBox.Text = ans.ToString();
                    }
                    break;
                    //case "":
                    //    break;
                    //case "":
                    //    break;
            }
        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {
            decBox.Text = numBox.Text;
        }

        private void decBox_TextChanged(object sender, EventArgs e)
        {
            int dec;
            bool success = int.TryParse(decBox.Text, out dec);

            List<int> binList = new List<int>();
            int bin;
            List<int> octList = new List<int>();
            int oct;
            List<string> hexList = new List<string>();
            int hex;

            int decB = dec;
            string binS = null;

            int decO = dec;
            string octS = null;

            int decH = dec;
            string hexS = null;
            string hexAF = null;

            if (success)
            {

                //binの計算
                while (true)
                {
                    binList.Insert(0, decB % 2);
                    decB /= 2;
                    if (decB == 0)
                    {
                        foreach (int num in binList)
                        {
                            binS += num;
                        }
                        binBox.Text = binS;

                        break;
                    }
                }

                //octの計算
                while (true)
                {
                    octList.Insert(0, decO % 8);
                    decO /= 8;
                    if (decO == 0)
                    {
                        foreach (int num in octList)
                        {
                            octS += num;
                        }
                        octBox.Text = octS;

                        break;
                    }
                }

                //hexの計算

                while (true)
                {
                    int hhh = decH % 16;

                    if(hhh < 10)
                    {
                        hexAF = hhh.ToString();
                    }
                    else
                    {
                        switch (hhh)
                        {
                            case 10:
                                hexAF = "A";
                                break;
                            case 11:
                                hexAF = "B";
                                break;
                            case 12:
                                hexAF = "C";
                                break;
                            case 13:
                                hexAF = "D";
                                break;
                            case 14:
                                hexAF = "E";
                                break;
                            case 15:
                                hexAF = "F";
                                break;


                        }
                    }
                
                    hexList.Insert(0, hexAF);
                    decH /= 16;


                    if (decH == 0)
                    {
                        foreach (string af in hexList)
                        {
                            hexS += af;
                        }
                        hexBox.Text = hexS;
                        break;
                    }
                }

            }
        }

        private void mc_Click(object sender, EventArgs e)
        {
            mNum = 0;
            mAns.Text = mNum.ToString();
        }
        private void mr_Click(object sender, EventArgs e)
        {
            if (type == null)
            {
               

                    sx = mNum.ToString();
                    this.numBox.Text = sx;
        
            }
            else
            {
               

                    sy = mNum.ToString();
                    this.numBox.Text = sy;
                
            }
        }
        private void mPlus_Click(object sender, EventArgs e)
        {
            mNum += int.Parse(this.numBox.Text);
        }

        private void mMinus_Click(object sender, EventArgs e)
        {
            mNum -= int.Parse(this.numBox.Text);
        }

        private void ms_Click(object sender, EventArgs e)
        {
            mNum = int.Parse(this.numBox.Text);
        }



        private void m_Click(object sender, EventArgs e)
        {
            mAns.Text = mNum.ToString();
        }
    }
}
