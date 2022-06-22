using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지박스1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "메시지박스2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두개의 버튼을 갖는 메시지박스", "메시지박스3",MessageBoxButtons.YesNo);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("세개의 버튼을 갖는 메시지박스", "메시지박스4",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "결과 : " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "결과 : " + txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            lbHp.Text = "결과 : " + txtHp.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };
            List<string> fruits = new List<string>();
            foreach(CheckBox chb in chbFruits)
            {
                if(chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }
            lbResultFruit.Text = "선택한 과일 : " + String.Join(", ", fruits);
        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                lbResultSex.Text = "결과 : " + rbMale.Text;
            else
                lbResultSex.Text = "결과 : " + rbFemale.Text;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (rb1st.Checked)
                lbResultGrade.Text = "결과 : " + rb1st.Text;
            else if (rb2nd.Checked)
                lbResultGrade.Text = "결과 : " + rb2nd.Text;
            else if (rb3rd.Checked)
                lbResultGrade.Text = "결과 : " + rb3rd.Text;
            else if (rb4th.Checked)
                lbResultGrade.Text = "결과 : " + rb4th.Text;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
