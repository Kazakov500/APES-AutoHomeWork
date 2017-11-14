namespace APES
{
    partial class Form1
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
            this.btn_Q = new System.Windows.Forms.Button();
            this.rtb_Data = new System.Windows.Forms.RichTextBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.btn_Analysis = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_V = new System.Windows.Forms.Button();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_Z = new System.Windows.Forms.Button();
            this.btn_W = new System.Windows.Forms.Button();
            this.rtb_Graph = new System.Windows.Forms.RichTextBox();
            this.btn_Gr_X = new System.Windows.Forms.Button();
            this.btn_Gr_XVC = new System.Windows.Forms.Button();
            this.btn_Gr_XV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Gr = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd_Gr = new System.Windows.Forms.SaveFileDialog();
            this.sfd_Log = new System.Windows.Forms.SaveFileDialog();
            this.btn_Load_Data = new System.Windows.Forms.Button();
            this.btn_Save_Log = new System.Windows.Forms.Button();
            this.btn_Save_Image = new System.Windows.Forms.Button();
            this.btn_All_F = new System.Windows.Forms.Button();
            this.btn_inp_table = new System.Windows.Forms.Button();
            this.btn_RQQt = new System.Windows.Forms.Button();
            this.btn_QBAt = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Q_table = new System.Windows.Forms.Button();
            this.btn_R_table = new System.Windows.Forms.Button();
            this.btn_Z_table = new System.Windows.Forms.Button();
            this.btn_A_table = new System.Windows.Forms.Button();
            this.btn_B_table = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Q
            // 
            this.btn_Q.Location = new System.Drawing.Point(6, 48);
            this.btn_Q.Name = "btn_Q";
            this.btn_Q.Size = new System.Drawing.Size(24, 23);
            this.btn_Q.TabIndex = 0;
            this.btn_Q.Text = "Q";
            this.btn_Q.UseVisualStyleBackColor = true;
            this.btn_Q.Click += new System.EventHandler(this.btn_Q_Click);
            // 
            // rtb_Data
            // 
            this.rtb_Data.Location = new System.Drawing.Point(12, 98);
            this.rtb_Data.Name = "rtb_Data";
            this.rtb_Data.Size = new System.Drawing.Size(138, 224);
            this.rtb_Data.TabIndex = 1;
            this.rtb_Data.Text = "1 0 1\n1 1 1\n2 0 2\n2 1 2\n2 3 2\n3 1 3\n3 2 1\n3 3 1\n4 2 2\n4 3 3\n4 4 1\n5 0 3\n5 2 3\n6 0" +
    " 4\n6 4 2";
            this.rtb_Data.WordWrap = false;
            // 
            // rtb_Log
            // 
            this.rtb_Log.Location = new System.Drawing.Point(156, 99);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(238, 154);
            this.rtb_Log.TabIndex = 2;
            this.rtb_Log.Text = "";
            this.rtb_Log.WordWrap = false;
            // 
            // btn_Analysis
            // 
            this.btn_Analysis.Location = new System.Drawing.Point(6, 19);
            this.btn_Analysis.Name = "btn_Analysis";
            this.btn_Analysis.Size = new System.Drawing.Size(54, 23);
            this.btn_Analysis.TabIndex = 3;
            this.btn_Analysis.Text = "Analysis";
            this.btn_Analysis.UseVisualStyleBackColor = true;
            this.btn_Analysis.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(6, 77);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(24, 23);
            this.btn_A.TabIndex = 4;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(36, 77);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(24, 23);
            this.btn_B.TabIndex = 5;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_V
            // 
            this.btn_V.Location = new System.Drawing.Point(66, 19);
            this.btn_V.Name = "btn_V";
            this.btn_V.Size = new System.Drawing.Size(45, 23);
            this.btn_V.TabIndex = 6;
            this.btn_V.Text = "c of c";
            this.btn_V.UseVisualStyleBackColor = true;
            this.btn_V.Click += new System.EventHandler(this.btn_V_Click);
            // 
            // btn_R
            // 
            this.btn_R.Location = new System.Drawing.Point(36, 48);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(24, 23);
            this.btn_R.TabIndex = 7;
            this.btn_R.Text = "R";
            this.btn_R.UseVisualStyleBackColor = true;
            this.btn_R.Click += new System.EventHandler(this.btn_R_Click);
            // 
            // btn_Z
            // 
            this.btn_Z.Location = new System.Drawing.Point(66, 48);
            this.btn_Z.Name = "btn_Z";
            this.btn_Z.Size = new System.Drawing.Size(24, 23);
            this.btn_Z.TabIndex = 8;
            this.btn_Z.Text = "Z";
            this.btn_Z.UseVisualStyleBackColor = true;
            this.btn_Z.Click += new System.EventHandler(this.btn_Z_Click);
            // 
            // btn_W
            // 
            this.btn_W.Location = new System.Drawing.Point(93, 48);
            this.btn_W.Name = "btn_W";
            this.btn_W.Size = new System.Drawing.Size(48, 23);
            this.btn_W.TabIndex = 9;
            this.btn_W.Text = "W / V";
            this.btn_W.UseVisualStyleBackColor = true;
            this.btn_W.Click += new System.EventHandler(this.btn_W_Click);
            // 
            // rtb_Graph
            // 
            this.rtb_Graph.Location = new System.Drawing.Point(156, 259);
            this.rtb_Graph.Name = "rtb_Graph";
            this.rtb_Graph.Size = new System.Drawing.Size(238, 63);
            this.rtb_Graph.TabIndex = 10;
            this.rtb_Graph.Text = "";
            this.rtb_Graph.WordWrap = false;
            // 
            // btn_Gr_X
            // 
            this.btn_Gr_X.Location = new System.Drawing.Point(6, 19);
            this.btn_Gr_X.Name = "btn_Gr_X";
            this.btn_Gr_X.Size = new System.Drawing.Size(53, 23);
            this.btn_Gr_X.TabIndex = 11;
            this.btn_Gr_X.Text = "Gr X";
            this.btn_Gr_X.UseVisualStyleBackColor = true;
            this.btn_Gr_X.Click += new System.EventHandler(this.btn_Conn_Click);
            // 
            // btn_Gr_XVC
            // 
            this.btn_Gr_XVC.Location = new System.Drawing.Point(124, 19);
            this.btn_Gr_XVC.Name = "btn_Gr_XVC";
            this.btn_Gr_XVC.Size = new System.Drawing.Size(53, 23);
            this.btn_Gr_XVC.TabIndex = 12;
            this.btn_Gr_XVC.Text = "Gr XVC";
            this.btn_Gr_XVC.UseVisualStyleBackColor = true;
            this.btn_Gr_XVC.Click += new System.EventHandler(this.btn_Full_Click);
            // 
            // btn_Gr_XV
            // 
            this.btn_Gr_XV.Location = new System.Drawing.Point(65, 19);
            this.btn_Gr_XV.Name = "btn_Gr_XV";
            this.btn_Gr_XV.Size = new System.Drawing.Size(53, 23);
            this.btn_Gr_XV.TabIndex = 13;
            this.btn_Gr_XV.Text = "Gr XV";
            this.btn_Gr_XV.UseVisualStyleBackColor = true;
            this.btn_Gr_XV.Click += new System.EventHandler(this.btn_Gr_XV_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pb_Gr);
            this.panel1.Location = new System.Drawing.Point(12, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 285);
            this.panel1.TabIndex = 14;
            // 
            // pb_Gr
            // 
            this.pb_Gr.Location = new System.Drawing.Point(3, 3);
            this.pb_Gr.Name = "pb_Gr";
            this.pb_Gr.Size = new System.Drawing.Size(150, 122);
            this.pb_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Gr.TabIndex = 0;
            this.pb_Gr.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Data";
            this.openFileDialog1.Filter = "txt|*.txt";
            // 
            // sfd_Gr
            // 
            this.sfd_Gr.FileName = "Graph";
            this.sfd_Gr.Filter = "png|*.png";
            // 
            // sfd_Log
            // 
            this.sfd_Log.FileName = "Log";
            this.sfd_Log.Filter = "txt|*.txt";
            // 
            // btn_Load_Data
            // 
            this.btn_Load_Data.Location = new System.Drawing.Point(12, 10);
            this.btn_Load_Data.Name = "btn_Load_Data";
            this.btn_Load_Data.Size = new System.Drawing.Size(75, 23);
            this.btn_Load_Data.TabIndex = 15;
            this.btn_Load_Data.Text = "Load Data";
            this.btn_Load_Data.UseVisualStyleBackColor = true;
            this.btn_Load_Data.Click += new System.EventHandler(this.btn_Load_Data_Click);
            // 
            // btn_Save_Log
            // 
            this.btn_Save_Log.Location = new System.Drawing.Point(93, 10);
            this.btn_Save_Log.Name = "btn_Save_Log";
            this.btn_Save_Log.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Log.TabIndex = 16;
            this.btn_Save_Log.Text = "Save Log";
            this.btn_Save_Log.UseVisualStyleBackColor = true;
            this.btn_Save_Log.Click += new System.EventHandler(this.btn_Save_Log_Click);
            // 
            // btn_Save_Image
            // 
            this.btn_Save_Image.Location = new System.Drawing.Point(174, 10);
            this.btn_Save_Image.Name = "btn_Save_Image";
            this.btn_Save_Image.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Image.TabIndex = 17;
            this.btn_Save_Image.Text = "Save Graph";
            this.btn_Save_Image.UseVisualStyleBackColor = true;
            this.btn_Save_Image.Click += new System.EventHandler(this.btn_Save_Image_Click);
            // 
            // btn_All_F
            // 
            this.btn_All_F.Location = new System.Drawing.Point(12, 40);
            this.btn_All_F.Name = "btn_All_F";
            this.btn_All_F.Size = new System.Drawing.Size(44, 53);
            this.btn_All_F.TabIndex = 18;
            this.btn_All_F.Text = "GO";
            this.btn_All_F.UseVisualStyleBackColor = true;
            this.btn_All_F.Click += new System.EventHandler(this.btn_All_F_Click);
            // 
            // btn_inp_table
            // 
            this.btn_inp_table.Location = new System.Drawing.Point(66, 77);
            this.btn_inp_table.Name = "btn_inp_table";
            this.btn_inp_table.Size = new System.Drawing.Size(75, 23);
            this.btn_inp_table.TabIndex = 19;
            this.btn_inp_table.Text = "Table";
            this.btn_inp_table.UseVisualStyleBackColor = true;
            this.btn_inp_table.Click += new System.EventHandler(this.btn_inp_table_Click);
            // 
            // btn_RQQt
            // 
            this.btn_RQQt.Location = new System.Drawing.Point(78, 106);
            this.btn_RQQt.Name = "btn_RQQt";
            this.btn_RQQt.Size = new System.Drawing.Size(63, 23);
            this.btn_RQQt.TabIndex = 20;
            this.btn_RQQt.Text = "R = Q * Q\'";
            this.btn_RQQt.UseVisualStyleBackColor = true;
            this.btn_RQQt.Click += new System.EventHandler(this.btn_RQQt_Click);
            // 
            // btn_QBAt
            // 
            this.btn_QBAt.Location = new System.Drawing.Point(6, 106);
            this.btn_QBAt.Name = "btn_QBAt";
            this.btn_QBAt.Size = new System.Drawing.Size(66, 23);
            this.btn_QBAt.TabIndex = 21;
            this.btn_QBAt.Text = "Q = B * A\'";
            this.btn_QBAt.UseVisualStyleBackColor = true;
            this.btn_QBAt.Click += new System.EventHandler(this.btn_QBAt_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(6, 19);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(63, 23);
            this.btn_Excel.TabIndex = 22;
            this.btn_Excel.Text = "Table";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 312);
            this.dataGridView1.TabIndex = 23;
            // 
            // btn_Q_table
            // 
            this.btn_Q_table.Location = new System.Drawing.Point(75, 19);
            this.btn_Q_table.Name = "btn_Q_table";
            this.btn_Q_table.Size = new System.Drawing.Size(24, 23);
            this.btn_Q_table.TabIndex = 24;
            this.btn_Q_table.Text = "Q";
            this.btn_Q_table.UseVisualStyleBackColor = true;
            this.btn_Q_table.Click += new System.EventHandler(this.btn_Q_table_Click);
            // 
            // btn_R_table
            // 
            this.btn_R_table.Location = new System.Drawing.Point(105, 19);
            this.btn_R_table.Name = "btn_R_table";
            this.btn_R_table.Size = new System.Drawing.Size(24, 23);
            this.btn_R_table.TabIndex = 25;
            this.btn_R_table.Text = "R";
            this.btn_R_table.UseVisualStyleBackColor = true;
            this.btn_R_table.Click += new System.EventHandler(this.btn_R_table_Click);
            // 
            // btn_Z_table
            // 
            this.btn_Z_table.Location = new System.Drawing.Point(6, 48);
            this.btn_Z_table.Name = "btn_Z_table";
            this.btn_Z_table.Size = new System.Drawing.Size(63, 23);
            this.btn_Z_table.TabIndex = 26;
            this.btn_Z_table.Text = "Z / W / V";
            this.btn_Z_table.UseVisualStyleBackColor = true;
            this.btn_Z_table.Click += new System.EventHandler(this.btn_Z_table_Click);
            // 
            // btn_A_table
            // 
            this.btn_A_table.Location = new System.Drawing.Point(75, 48);
            this.btn_A_table.Name = "btn_A_table";
            this.btn_A_table.Size = new System.Drawing.Size(24, 23);
            this.btn_A_table.TabIndex = 29;
            this.btn_A_table.Text = "A";
            this.btn_A_table.UseVisualStyleBackColor = true;
            this.btn_A_table.Click += new System.EventHandler(this.btn_A_table_Click);
            // 
            // btn_B_table
            // 
            this.btn_B_table.Location = new System.Drawing.Point(105, 48);
            this.btn_B_table.Name = "btn_B_table";
            this.btn_B_table.Size = new System.Drawing.Size(24, 23);
            this.btn_B_table.TabIndex = 30;
            this.btn_B_table.Text = "B";
            this.btn_B_table.UseVisualStyleBackColor = true;
            this.btn_B_table.Click += new System.EventHandler(this.btn_B_table_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Analysis);
            this.groupBox1.Controls.Add(this.btn_Q);
            this.groupBox1.Controls.Add(this.btn_A);
            this.groupBox1.Controls.Add(this.btn_B);
            this.groupBox1.Controls.Add(this.btn_V);
            this.groupBox1.Controls.Add(this.btn_R);
            this.groupBox1.Controls.Add(this.btn_Z);
            this.groupBox1.Controls.Add(this.btn_W);
            this.groupBox1.Controls.Add(this.btn_QBAt);
            this.groupBox1.Controls.Add(this.btn_inp_table);
            this.groupBox1.Controls.Add(this.btn_RQQt);
            this.groupBox1.Location = new System.Drawing.Point(156, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 137);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Func";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Excel);
            this.groupBox2.Controls.Add(this.btn_Q_table);
            this.groupBox2.Controls.Add(this.btn_B_table);
            this.groupBox2.Controls.Add(this.btn_R_table);
            this.groupBox2.Controls.Add(this.btn_A_table);
            this.groupBox2.Controls.Add(this.btn_Z_table);
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 80);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table func";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Gr_X);
            this.groupBox3.Controls.Add(this.btn_Gr_XV);
            this.groupBox3.Controls.Add(this.btn_Gr_XVC);
            this.groupBox3.Location = new System.Drawing.Point(62, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 53);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rtb_Graph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_All_F);
            this.Controls.Add(this.btn_Save_Image);
            this.Controls.Add(this.btn_Save_Log);
            this.Controls.Add(this.btn_Load_Data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtb_Log);
            this.Controls.Add(this.rtb_Data);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "APES [V 2.0] [By Vadim Kazakov]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Q;
        private System.Windows.Forms.RichTextBox rtb_Data;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Button btn_Analysis;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_V;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.Button btn_Z;
        private System.Windows.Forms.Button btn_W;
        private System.Windows.Forms.RichTextBox rtb_Graph;
        private System.Windows.Forms.Button btn_Gr_X;
        private System.Windows.Forms.Button btn_Gr_XVC;
        private System.Windows.Forms.Button btn_Gr_XV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Gr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog sfd_Gr;
        private System.Windows.Forms.SaveFileDialog sfd_Log;
        private System.Windows.Forms.Button btn_Load_Data;
        private System.Windows.Forms.Button btn_Save_Log;
        private System.Windows.Forms.Button btn_Save_Image;
        private System.Windows.Forms.Button btn_All_F;
        private System.Windows.Forms.Button btn_inp_table;
        private System.Windows.Forms.Button btn_RQQt;
        private System.Windows.Forms.Button btn_QBAt;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Q_table;
        private System.Windows.Forms.Button btn_R_table;
        private System.Windows.Forms.Button btn_Z_table;
        private System.Windows.Forms.Button btn_A_table;
        private System.Windows.Forms.Button btn_B_table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

