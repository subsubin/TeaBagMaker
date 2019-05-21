using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] SList = new string[] {"홍차", "녹차", "루이보스차", "국화차"};
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
