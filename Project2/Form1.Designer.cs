namespace Project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbDataInput = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nAge = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lbHp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lbUid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(436, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbDataInput
            // 
            this.gbDataInput.Controls.Add(this.btnReset);
            this.gbDataInput.Controls.Add(this.btnDelete);
            this.gbDataInput.Controls.Add(this.btnUpdate);
            this.gbDataInput.Controls.Add(this.nAge);
            this.gbDataInput.Controls.Add(this.btnAdd);
            this.gbDataInput.Controls.Add(this.lbAge);
            this.gbDataInput.Controls.Add(this.txtHp);
            this.gbDataInput.Controls.Add(this.lbHp);
            this.gbDataInput.Controls.Add(this.txtName);
            this.gbDataInput.Controls.Add(this.lbName);
            this.gbDataInput.Controls.Add(this.txtUid);
            this.gbDataInput.Controls.Add(this.lbUid);
            this.gbDataInput.Location = new System.Drawing.Point(454, 41);
            this.gbDataInput.Name = "gbDataInput";
            this.gbDataInput.Size = new System.Drawing.Size(200, 199);
            this.gbDataInput.TabIndex = 2;
            this.gbDataInput.TabStop = false;
            this.gbDataInput.Text = "데이터 추가/수정/삭제";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(101, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "리셋";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(101, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nAge
            // 
            this.nAge.Location = new System.Drawing.Point(55, 103);
            this.nAge.Name = "nAge";
            this.nAge.Size = new System.Drawing.Size(139, 23);
            this.nAge.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(6, 106);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(31, 15);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "나이";
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(55, 74);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(139, 23);
            this.txtHp.TabIndex = 5;
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Location = new System.Drawing.Point(6, 77);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(43, 15);
            this.lbHp.TabIndex = 4;
            this.lbHp.Text = "휴대폰";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 23);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 15);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "이름";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(55, 16);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(139, 23);
            this.txtUid.TabIndex = 1;
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Location = new System.Drawing.Point(6, 19);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(43, 15);
            this.lbUid.TabIndex = 0;
            this.lbUid.Text = "아이디";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 358);
            this.Controls.Add(this.gbDataInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "데이터 매니저 v3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDataInput.ResumeLayout(false);
            this.gbDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private GroupBox gbDataInput;
        private Button btnAdd;
        private Label lbAge;
        private TextBox txtHp;
        private Label lbHp;
        private TextBox txtName;
        private Label lbName;
        private TextBox txtUid;
        private Label lbUid;
        private Button btnReset;
        private Button btnDelete;
        private Button btnUpdate;
        private NumericUpDown nAge;
    }
}