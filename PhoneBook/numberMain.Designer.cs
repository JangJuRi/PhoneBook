namespace final_test
{
    partial class numberMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datacountText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bestNumButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.worstNumButton = new System.Windows.Forms.Button();
            this.oldNumButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nowNumberText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalNumberText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 42;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(29, 194);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 362);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addButton.Location = new System.Drawing.Point(551, 33);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 66);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "연락처 추가";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editButton.Location = new System.Drawing.Point(669, 33);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 66);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "연락처 편집";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(570, 127);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 32);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchText.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchText.Location = new System.Drawing.Point(209, 127);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(340, 32);
            this.searchText.TabIndex = 0;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchText.WordWrap = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 541);
            this.label1.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(722, 559);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(57, 35);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 56);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 4);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(351, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "연락처 :";
            // 
            // datacountText
            // 
            this.datacountText.AutoSize = true;
            this.datacountText.BackColor = System.Drawing.Color.White;
            this.datacountText.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datacountText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.datacountText.Location = new System.Drawing.Point(403, 579);
            this.datacountText.Name = "datacountText";
            this.datacountText.Size = new System.Drawing.Size(14, 15);
            this.datacountText.TabIndex = 16;
            this.datacountText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(423, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "/  100";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(29, 597);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(750, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // bestNumButton
            // 
            this.bestNumButton.BackColor = System.Drawing.Color.White;
            this.bestNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bestNumButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bestNumButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bestNumButton.ForeColor = System.Drawing.Color.Black;
            this.bestNumButton.Location = new System.Drawing.Point(393, 71);
            this.bestNumButton.Name = "bestNumButton";
            this.bestNumButton.Size = new System.Drawing.Size(126, 28);
            this.bestNumButton.TabIndex = 19;
            this.bestNumButton.Text = "많이 쓰는 번호";
            this.bestNumButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bestNumButton.UseVisualStyleBackColor = false;
            this.bestNumButton.Click += new System.EventHandler(this.bestNumButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(694, 159);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(85, 32);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "새로고침";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // worstNumButton
            // 
            this.worstNumButton.BackColor = System.Drawing.Color.White;
            this.worstNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worstNumButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.worstNumButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.worstNumButton.ForeColor = System.Drawing.Color.Black;
            this.worstNumButton.Location = new System.Drawing.Point(276, 22);
            this.worstNumButton.Name = "worstNumButton";
            this.worstNumButton.Size = new System.Drawing.Size(111, 28);
            this.worstNumButton.TabIndex = 21;
            this.worstNumButton.Text = "안쓰는 번호";
            this.worstNumButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.worstNumButton.UseVisualStyleBackColor = false;
            this.worstNumButton.Click += new System.EventHandler(this.worstNumButton_Click);
            // 
            // oldNumButton
            // 
            this.oldNumButton.BackColor = System.Drawing.Color.White;
            this.oldNumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oldNumButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oldNumButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oldNumButton.ForeColor = System.Drawing.Color.Black;
            this.oldNumButton.Location = new System.Drawing.Point(276, 71);
            this.oldNumButton.Name = "oldNumButton";
            this.oldNumButton.Size = new System.Drawing.Size(111, 28);
            this.oldNumButton.TabIndex = 22;
            this.oldNumButton.Text = "오래된 번호";
            this.oldNumButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oldNumButton.UseVisualStyleBackColor = false;
            this.oldNumButton.Click += new System.EventHandler(this.oldNumButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(275, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "1년이상 연락 X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(273, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "전화 0번";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(390, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "전화 횟수 상위10개";
            // 
            // nowNumberText
            // 
            this.nowNumberText.AutoSize = true;
            this.nowNumberText.BackColor = System.Drawing.Color.White;
            this.nowNumberText.Location = new System.Drawing.Point(29, 563);
            this.nowNumberText.Name = "nowNumberText";
            this.nowNumberText.Size = new System.Drawing.Size(11, 12);
            this.nowNumberText.TabIndex = 26;
            this.nowNumberText.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(47, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "/";
            // 
            // totalNumberText
            // 
            this.totalNumberText.AutoSize = true;
            this.totalNumberText.BackColor = System.Drawing.Color.White;
            this.totalNumberText.Location = new System.Drawing.Point(59, 563);
            this.totalNumberText.Name = "totalNumberText";
            this.totalNumberText.Size = new System.Drawing.Size(11, 12);
            this.totalNumberText.TabIndex = 28;
            this.totalNumberText.Text = "0";
            // 
            // numberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 632);
            this.Controls.Add(this.totalNumberText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nowNumberText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oldNumButton);
            this.Controls.Add(this.worstNumButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.bestNumButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datacountText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "numberMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "전화번호부";
            this.Load += new System.EventHandler(this.numberMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label datacountText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bestNumButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button worstNumButton;
        private System.Windows.Forms.Button oldNumButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nowNumberText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalNumberText;
    }
}

