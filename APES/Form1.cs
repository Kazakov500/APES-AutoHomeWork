using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APES
{
    public partial class Form1 : Form
    {
        List<int[]> el_l = new List<int[]>();

        int[,] A;
        int[,] B;
        int[,] Q;
        int[,] R;

        List<int> W = new List<int>();
        List<int> Z = new List<int>();
        List<int> V2 = new List<int>();

        int[] V;

        public Form1()
        {
            InitializeComponent();
        }

        private int Max_V()
        {
            int max = -1;
            foreach (var item in el_l)
                if (item[0] > max) max = item[0];
            return max;
        }

        private int Max_X()
        {
            int max = -1;
            foreach (var item in el_l)
                if (item[1] > max) max = item[1];
            return max;
        }

        private int Max_C()
        {
            int max = -1;
            foreach (var item in el_l)
                if (item[2] > max) max = item[2];
            return max;
        }

        private int count_C()
        {
            return el_l.Count;
        }

        private void Create_V()
        {
            int X = Max_X() + 1;
            V = new int[X];

            foreach (var item in el_l)
            {
                V[item[1]]++;
            }

            rtb_Log.Text += "[count of connections] = \n";
            for (int i = 0; i < V.Length; i++)
            {
                rtb_Log.Text += V[i].ToString() + " ";
            }
            rtb_Log.Text += "\n";
        }

        private void swap(ref int x, ref int y)
        {
            int b = x;
            x = y;
            y = b;
        }

        private int[,] Transp_Matrix(int[,] M)
        {
       

            int[,] M_t = new int[M.GetLength(1), M.GetLength(0)];

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M_t[j, i] = M[i, j];
                }
            }

            return M_t;

        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            int max_V_ = Max_V()+1;
            int max_X_ = Max_X()+1;

            Q = new int[max_X_, max_V_];

            for (int i = 0; i < el_l.Count; i++)
            {
                Q[el_l[i][1], el_l[i][0]] = 1;
            }

            rtb_Log.Text += "Q = \n";

            for (int i = 0; i < max_X_; i++)
            {
                for (int j = 0; j < max_V_; j++)
                {
                    rtb_Log.Text += Q[i, j] + " "; 
                }
                rtb_Log.Text += "\n";
            }
            rtb_Log.Text += "\n";
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            foreach (var line in rtb_Data.Lines)
            {
                int[] elements = new int[3];
                string[] el = line.Split(new char[] { ' ' });
                //for (int i = 0; i < 3; i++)
                //    elements[i] = Convert.ToInt32(el[i]);

                elements[0] = Convert.ToInt32(el[0]) - 1; // V
                elements[1] = Convert.ToInt32(el[1]); // X
                elements[2] = Convert.ToInt32(el[2]) - 1; // C

                el_l.Add(elements);
            }
        }

        private int C_index(int x)
        {
            int ind = 0;
            for (int i = 0; i < x; i++)
            {
                ind += V[i];
            }
            //if (ind != 0) ind++;
            return ind;
        }


        private void btn_A_Click(object sender, EventArgs e)
        {
            int max_V_ = Max_V() + 1;
            int max_C_ = count_C();
            A = new int[max_V_, max_C_];

            for (int i = 0; i < el_l.Count; i++)
            {
                int ind_ = C_index(el_l[i][1]);
                int ind2 = ind_ + el_l[i][2];
                A[el_l[i][0],  ind2] = 1;
            }



            rtb_Log.Text += "A = \n";
            for (int i = 0; i < max_V_; i++)
            {
                for (int j = 0; j < max_C_; j++)
                {
                    rtb_Log.Text += A[i, j] + " ";
                }
                rtb_Log.Text += "\n";
            }
            rtb_Log.Text += "\n";

        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            int max_X_ = Max_X() + 1;
            int max_C_ = count_C();
            B = new int[max_X_, max_C_];

            for (int i = 0; i < el_l.Count; i++)
            {
                int ind_ = C_index(el_l[i][1]);
                int ind2 = ind_ + el_l[i][2];

                B[ el_l[i][1], ind2 ] = 1;
            }





            rtb_Log.Text += "B = \n";
            for (int i = 0; i < max_X_; i++)
            {
                for (int j = 0; j < max_C_; j++)
                {
                    rtb_Log.Text += B[i, j] + " ";
                }
                rtb_Log.Text += "\n";
            }
            rtb_Log.Text += "\n";
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            Create_V();
            rtb_Log.Text += "\n";
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            int max_X_ = Max_X() + 1;
            int max_V_ = Max_V() + 1;

            R = new int[max_X_, max_X_];

            for (int x = 0; x < max_X_; x++)
            {
                for (int v = 0; v < max_V_; v++)
                {
                    if (Q[x, v] == 1 )
                    {
                        for (int xx = 0; xx < max_X_; xx++)
                        {
                            if(xx != x)
                            {
                                if (Q[xx, v] == 1) R[x, xx]++;
                            }
                        }
                    }
                }
            }


            rtb_Log.Text += "R = \n";
            for (int i = 0; i < max_X_; i++)
            {
                for (int j = 0; j < max_X_; j++)
                {
                    rtb_Log.Text += R[i, j] + " ";
                }
                rtb_Log.Text += "\n";
            }
            rtb_Log.Text += "\n";


        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            int max_X_ = Max_X() + 1;

            for (int i = 0; i < max_X_; i++)
            {
                for (int j = 0; j < max_X_; j++)
                {
                    if(i != j)
                        if (R[i, j] >= 1) W.Add(R[i, j]);
                }
                V2.Add(W.Count);
            }

            rtb_Log.Text += "W = \n";
            foreach (var item in W)
            {
                rtb_Log.Text += item.ToString() + " ";
            }
            rtb_Log.Text += "\n\n";
            rtb_Log.Text += "V = \n";
            foreach (var item in V2)
            {
                rtb_Log.Text += item.ToString() + " ";
            }
            rtb_Log.Text += "\n\n";
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            int max_X_ = Max_X() + 1;

            for (int i = 0; i < max_X_; i++)
            {
                for (int j = 0; j < max_X_; j++)
                {
                    if (R[i, j] >= 1) Z.Add(j);
                }
            }


            rtb_Log.Text += "Z = \n";
            foreach (var item in Z)
            {
                rtb_Log.Text += item.ToString() + " ";
            }
            rtb_Log.Text += "\n\n";
        }

        private void btn_Conn_Click(object sender, EventArgs e)
        {
            rtb_Graph.Clear();

            rtb_Graph.Text += "graph G{\n";

            int max_X_ = Max_X() + 1;

            for (int i = 0; i < max_X_; i++)
            {
                for (int j = i+1; j < max_X_; j++)
                {
                    /*for (int k = 0; k < R[i, j]; k++)
                    {

                    }*/
                    if (R[i, j] == 1) rtb_Graph.Text += "X" + i.ToString() + " -- X" + j.ToString() + ";\n";
                    else if (R[i, j] > 1) rtb_Graph.Text += "X" + i.ToString() + " -- X" + j.ToString() + " [ label = \"" + R[i, j].ToString() + "\" ];\n";

                }
            }

            rtb_Graph.Text += "}";

            rtb_Graph.SaveFile("Gr_X.dot", RichTextBoxStreamType.PlainText);
            Process.Start("dot.exe", "-T png Gr_X.dot -o Gr_X.png");
            Thread.Sleep(1000);
            pb_Gr.Load("Gr_X.png");

        }

        private void btn_Full_Click(object sender, EventArgs e)
        {
            rtb_Graph.Clear();

            rtb_Graph.Text += "graph G{\n";

            int max_X_ = Max_X() + 1;
            int max_V_ = Max_V() + 1;
            int max_C_ = count_C();


            foreach (var item in el_l)
            {
                //rtb_Graph.Text += "V" + item[0].ToString() + " -- x" + item[1].ToString() + " -- C" + item[1].ToString() + item[2].ToString() + ";\n";
                //rtb_Graph.Text += "X" + item[1].ToString() + " -- C" + item[1].ToString() + item[2].ToString() + ";\n";
                //rtb_Graph.Text += "C" + item[1].ToString() + item[2].ToString() + " -> V" + item[0].ToString() + ";\n";
                //rtb_Graph.Text += "C" + item[1].ToString() + item[2].ToString() + "V" + item[0].ToString() + ";\n";

                rtb_Graph.Text += "X" + item[1].ToString() +
                                " -- C" + item[1].ToString() + (item[2]+1).ToString() +
                                " -- V" + (item[0]+1).ToString() + ";\n";

            }

            rtb_Graph.Text += "}";

            rtb_Graph.SaveFile("Gr_XVC.dot", RichTextBoxStreamType.PlainText);
            Process.Start("dot.exe", "-T png Gr_XVC.dot -o Gr_XVC.png");
            Thread.Sleep(1000);
            pb_Gr.Load("Gr_XVC.png");
        }

        private void btn_Gr_XV_Click(object sender, EventArgs e)
        {
            rtb_Graph.Clear();

            rtb_Graph.Text += "graph G{\n";

            int max_X_ = Max_X() + 1;
            int max_V_ = Max_V() + 1;


            foreach (var item in el_l)
            {

                rtb_Graph.Text += "X" + item[1].ToString() +
                                " -- V" + (item[0]+1).ToString() + ";\n";

            }

            rtb_Graph.Text += "}";


            rtb_Graph.SaveFile("Gr_XV.dot", RichTextBoxStreamType.PlainText);
            Process.Start("dot.exe", "-T png Gr_XV.dot -o Gr_XV.png");
            Thread.Sleep(1000);
            pb_Gr.Load("Gr_XV.png");
        }

        private void btn_Load_Data_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Load the contents of the file into the RichTextBox.
                rtb_Data.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btn_Save_Log_Click(object sender, EventArgs e)
        {
            if (sfd_Log.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Load the contents of the file into the RichTextBox.
                rtb_Log.SaveFile(sfd_Log.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btn_Save_Image_Click(object sender, EventArgs e)
        {
            if (sfd_Gr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Load the contents of the file into the RichTextBox.
                pb_Gr.Image.Save(sfd_Gr.FileName);
            }
        }

        private void btn_All_F_Click(object sender, EventArgs e)
        {
            el_l = new List<int[]>();

            A = null;
            B = null;
            Q = null;
            R = null;

            W = new List<int>();
            Z = new List<int>();
            V2 = new List<int>();

            int[] V = null;

            rtb_Log.Clear();




            btn_Analysis.PerformClick();

            btn_inp_table.PerformClick();

            btn_V.PerformClick();
            btn_Q.PerformClick();
            btn_R.PerformClick();
            btn_Z.PerformClick();
            btn_W.PerformClick();
            btn_A.PerformClick();
            btn_B.PerformClick();

            //-----

            rtb_Log.Text += "Checking matrix\n\n";

            btn_QBAt.PerformClick();
            btn_RQQt.PerformClick();
            
        }

        private void btn_inp_table_Click(object sender, EventArgs e)
        {
            List < string[] > L = new List<string[]>();
            for (int i = 0; i < Max_V()+1; i++)
            {
                L.Add(new string[3]);
            }

            foreach (var item in el_l)
            {
                L[item[0]][0] = "V"+ (item[0]+1).ToString();
                L[item[0]][1] += "X" + (item[1]).ToString() + " ";
                L[item[0]][2] += "C" + (item[1]).ToString() + (item[2]+1).ToString() + " ";
            }

            foreach (var item in L)
            {
                rtb_Log.Text += item[0] + " | " + item[1] + " | " + item[2] + "\n";
            }

            rtb_Log.Text += "\n";
        }

        private void btn_RQQt_Click(object sender, EventArgs e)
        {
            int[,] Q_t = Transp_Matrix(Q);//new int[Q.Length, Q.Length];


            int col = Q_t.GetLength(0);
            int row = Q_t.GetLength(1);

            int[,] R_til = new int[row, row];


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    for (int k = 0; k < col; k++)
                    {
                        R_til[i, j] += Q[i, k] * Q_t[k, j];
                    }
                }
            }




            rtb_Log.Text += "R = Q * Q' = \n";
            for (int i = 0; i < R_til.GetLength(0); i++)
            {
                for (int j = 0; j < R_til.GetLength(1); j++)
                {
                    rtb_Log.Text += R_til[i, j] + " ";
                }
                rtb_Log.Text += "\n";
            }
            rtb_Log.Text += "\n";
        }

        private void btn_QBAt_Click(object sender, EventArgs e)
        {
            int[,] A_t = Transp_Matrix(A);//new int[Q.Length, Q.Length];


            int colAt = A_t.GetLength(0);
            int rowAt = A_t.GetLength(1);

            int colB = B.GetLength(0);
            int rowB = B.GetLength(1);

            int[,] Q_til = new int[colB, rowAt];


            for (int i = 0; i < colB; i++)
            {
                for (int j = 0; j < rowAt; j++)
                {
                    for (int k = 0; k < colAt; k++)
                    {
                        Q_til[i, j] += B[i, k] * A_t[k, j];
                    }
                }
            }




            rtb_Log.Text += "Q = B * A' = \n";
            for (int i = 0; i < Q_til.GetLength(0); i++)
            {
                for (int j = 0; j < Q_til.GetLength(1); j++)
                {
                    rtb_Log.Text += Q_til[i, j] + " ";
                }
                rtb_Log.Text += "\n";
            }
            rtb_Log.Text += "\n";
        }





        private void btn_Excel_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            List<string[]> L = new List<string[]>();
            for (int i = 0; i < Max_V() + 1; i++)
            {
                L.Add(new string[3]);
            }

            foreach (var item in el_l)
            {
                L[item[0]][0] = "V" + (item[0] + 1).ToString();
                L[item[0]][1] += "X" + (item[1]).ToString() + " ";
                L[item[0]][2] += "C" + (item[1]).ToString() + (item[2]+1).ToString() + " ";
            }



            rtb_Log.Text += "\n";
            //
            dataGridView1.Columns.Add("V", "V");
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("C", "C");



            foreach (var item in L)
            {
                this.dataGridView1.Rows.Add(item[0], item[1], item[2]);
            }

            //this.dataGridView1.Rows.Add("V1", "X0", "C00");
            //this.dataGridView1.Rows.Add("V2", "X1", "C11");
            //this.dataGridView1.Rows.Insert(0, "one", "two", "three", "four");
        }

        private void btn_Q_table_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int i = 1; i < Q.GetLength(1)+1; i++)
            {
                dataGridView1.Columns.Add("V"+i.ToString(), "V" + i.ToString());
            }

            for (int i = 0; i < Q.GetLength(0); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "X"+i.ToString();
                for (int j = 0; j < Q.GetLength(1); j++)
                {
                    row.Cells[j].Value = Q[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_R_table_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            int[,] M = R;

            for (int i = 0; i < M.GetLength(1); i++)
            {
                dataGridView1.Columns.Add("X" + i.ToString(), "X" + i.ToString());
            }

            for (int i = 0; i < M.GetLength(0); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "X" + i.ToString();
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    row.Cells[j].Value = M[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void btn_A_table_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            int[,] M = A;

            /*for (int i = 0; i < M.GetLength(1); i++)
            {
                dataGridView1.Columns.Add("C" + i.ToString(), "C" + i.ToString());
            }*/

            foreach (var item in el_l)
            {
                dataGridView1.Columns.Add("C" + item[1].ToString() + item[2].ToString(), "C" + item[1].ToString() + item[2].ToString());

            }

            for (int i = 0; i < M.GetLength(0); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "V" + i.ToString();
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    row.Cells[j].Value = M[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void btn_B_table_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            int[,] M = B;

            foreach (var item in el_l)
            {
                dataGridView1.Columns.Add("C" + item[1].ToString() + item[2].ToString(), "C" + item[1].ToString() + item[2].ToString());

            }

            for (int i = 0; i < M.GetLength(0); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "X" + i.ToString();
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    row.Cells[j].Value = M[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void btn_Z_table_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;


            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

            for (int i = 0; i < Z.Count; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), " ");
                //dataGridView1.Rows[0].Cells[i].Style.ForeColor = Color.Green;
                //DataGridViewCell Cell = new DataGridViewTextBoxCell();
                //Cell.Value = i.ToString();

                //row.Cells.Add(Cell);
            }

            DataGridViewRow row = new DataGridViewRow();
            row.HeaderCell.Value = "Num";
            for (int i = 0; i < Z.Count; i++)
            {
                DataGridViewCell Cell = new DataGridViewTextBoxCell();
                Cell.Value = (i+1).ToString();

                row.Cells.Add(Cell);  
            }
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.HeaderCell.Value = "Z";
            for (int i = 0; i < Z.Count; i++)
            {
                DataGridViewCell Cell = new DataGridViewTextBoxCell();
                Cell.Value = Z[i].ToString();

                row.Cells.Add(Cell);
            }
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.HeaderCell.Value = "W";
            for (int i = 0; i < Z.Count; i++)
            {
                DataGridViewCell Cell = new DataGridViewTextBoxCell();
                Cell.Value = W[i].ToString();

                row.Cells.Add(Cell);
            }
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.HeaderCell.Value = " ";
            int buff = 0;
            int X = 0;
            foreach (var item in V2)
            {
                for (int i = buff; i < item; i++)
                {
                    DataGridViewCell Cell = new DataGridViewTextBoxCell();
                    Cell.Value = "X" + X.ToString();

                    row.Cells.Add(Cell);
                }
                X++;
                buff = item;
            }

            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.HeaderCell.Value = " ";
            


            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.HeaderCell.Value = "V";
            foreach (var item in V2)
            {

                DataGridViewCell Cell = new DataGridViewTextBoxCell();
                Cell.Value = item.ToString();

                row.Cells.Add(Cell);

            }
            dataGridView1.Rows.Add(row);

            for (int i = 0; i < V2.Count; i++)
            {
                dataGridView1.Rows[0].Cells[V2[i] - 1].Style.BackColor = Color.Green;
                dataGridView1.Rows[1].Cells[V2[i] - 1].Style.BackColor = Color.Green;
                dataGridView1.Rows[2].Cells[V2[i] - 1].Style.BackColor = Color.Green;
                dataGridView1.Rows[3].Cells[V2[i] - 1].Style.BackColor = Color.Green;
            }

        }

        private void btn_W_table_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
digraph G{
Рождение->Юность->Зрелость->Старость->Смерть;
Юность->Смерть;
Зрелость->Смерть;
}*/

//dot -Tpng a.dot -o a.png