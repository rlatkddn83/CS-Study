using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<User> users = DBAccess.Instance.SelectUsers();

            // 데이터그리드뷰 데이터 공급
            dataGridView1.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = (decimal) nAge.Value;

            DBAccess.Instance.InsertUser(uid, name, hp, age);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rnum = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rnum];

            string name = row.Cells[1].Value.ToString();

            txtName.Text=name;
            txtUid.Text= row.Cells[0].Value.ToString();
            txtHp.Text= row.Cells[2].Value.ToString();
            nAge.Value = (int) row.Cells[3].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<User> users = DBAccess.Instance.SelectUsers();

            // 데이터그리드뷰 데이터 공급
            dataGridView1.DataSource = users;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = (decimal)nAge.Value;

            DBAccess.Instance.UpdateUser(uid, name, hp, age);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();

            DBAccess.Instance.DeleteUser(uid);

        }
    }
}