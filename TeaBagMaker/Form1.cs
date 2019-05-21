using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int CountOrgNum = 0;
        string[] SList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++) {
                this.CList.Items.Add(SList[i]);
            }
            this.orgStr = lblResult.Text;
            if (CList.Items.Count > 0)
                this.CList.SelectedIndex = 0;
        }

        private void CList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CList.Text != "")
                this.lblResult.Text = orgStr + this.CList.Text;

            if (this.lblResult.Text == "선택 : 홍차")
                this.lbTView.Text = "2분";
            else if (this.lblResult.Text == "선택 : 녹차")
                this.lbTView.Text = "3분";
            else if (this.lblResult.Text == "선택 : 루이보스차")
                this.lbTView.Text = "5분";
            else if (this.lblResult.Text == "선택 : 국화차")
                this.lbTView.Text = "2분";
            //MessageBox.Show(lblResult.Text, "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        /*private bool IntCheck()
        {
            if (Information.IsNumeric(this.textNum.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("숫자를 입력하세요~", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }*/

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.textNum.ReadOnly = false;
                this.textNum.Text = "";
                MessageBox.Show("펑!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountOrgNum--;
                this.CountDown.Text = Convert.ToString(CountOrgNum);
            }

        }
    }
}
