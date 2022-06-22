namespace CH11
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPos = new System.Windows.Forms.Label();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.btnPos = new System.Windows.Forms.Button();
            this.lbResultPos = new System.Windows.Forms.Label();
            this.lbResultHobby = new System.Windows.Forms.Label();
            this.btnHobby = new System.Windows.Forms.Button();
            this.cbHobby = new System.Windows.Forms.ComboBox();
            this.lbHobby = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.lbResultCountry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터를 공급해주는 컨트롤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ComboBox 연습";
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(12, 75);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(31, 15);
            this.lbPos.TabIndex = 2;
            this.lbPos.Text = "직급";
            // 
            // cbPos
            // 
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Location = new System.Drawing.Point(49, 72);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(121, 23);
            this.cbPos.TabIndex = 3;
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(176, 71);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 23);
            this.btnPos.TabIndex = 4;
            this.btnPos.Text = "확인";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // lbResultPos
            // 
            this.lbResultPos.AutoSize = true;
            this.lbResultPos.Location = new System.Drawing.Point(257, 75);
            this.lbResultPos.Name = "lbResultPos";
            this.lbResultPos.Size = new System.Drawing.Size(42, 15);
            this.lbResultPos.TabIndex = 5;
            this.lbResultPos.Text = "결과 : ";
            // 
            // lbResultHobby
            // 
            this.lbResultHobby.AutoSize = true;
            this.lbResultHobby.Location = new System.Drawing.Point(257, 104);
            this.lbResultHobby.Name = "lbResultHobby";
            this.lbResultHobby.Size = new System.Drawing.Size(42, 15);
            this.lbResultHobby.TabIndex = 9;
            this.lbResultHobby.Text = "결과 : ";
            // 
            // btnHobby
            // 
            this.btnHobby.Location = new System.Drawing.Point(176, 100);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(75, 23);
            this.btnHobby.TabIndex = 8;
            this.btnHobby.Text = "확인";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // cbHobby
            // 
            this.cbHobby.FormattingEnabled = true;
            this.cbHobby.Location = new System.Drawing.Point(49, 101);
            this.cbHobby.Name = "cbHobby";
            this.cbHobby.Size = new System.Drawing.Size(121, 23);
            this.cbHobby.TabIndex = 7;
            // 
            // lbHobby
            // 
            this.lbHobby.AutoSize = true;
            this.lbHobby.Location = new System.Drawing.Point(12, 104);
            this.lbHobby.Name = "lbHobby";
            this.lbHobby.Size = new System.Drawing.Size(31, 15);
            this.lbHobby.TabIndex = 6;
            this.lbHobby.Text = "취미";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ListBox 연습";
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 15;
            this.lstCountry.Location = new System.Drawing.Point(12, 159);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(158, 94);
            this.lstCountry.TabIndex = 11;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // lbResultCountry
            // 
            this.lbResultCountry.AutoSize = true;
            this.lbResultCountry.Location = new System.Drawing.Point(176, 238);
            this.lbResultCountry.Name = "lbResultCountry";
            this.lbResultCountry.Size = new System.Drawing.Size(42, 15);
            this.lbResultCountry.TabIndex = 12;
            this.lbResultCountry.Text = "결과 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "DataGridView 연습";
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(12, 292);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 25;
            this.dgvMember.Size = new System.Drawing.Size(408, 209);
            this.dgvMember.TabIndex = 14;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 513);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbResultCountry);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbResultHobby);
            this.Controls.Add(this.btnHobby);
            this.Controls.Add(this.cbHobby);
            this.Controls.Add(this.lbHobby);
            this.Controls.Add(this.lbResultPos);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbPos;
        private ComboBox cbPos;
        private Button btnPos;
        private Label lbResultPos;
        private Label lbResultHobby;
        private Button btnHobby;
        private ComboBox cbHobby;
        private Label lbHobby;
        private Label label3;
        private ListBox lstCountry;
        private Label lbResultCountry;
        private Label label4;
        private DataGridView dgvMember;
    }
}