using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WxqUtil;

namespace WCQ
{
    public partial class Form1 : Form
    {
        private Double X_a1;
        private Double Y_a1;
        private Double Z_a1;
        private Double X_a2;
        private Double Y_a2;
        private Double Z_a2;
        private Double X_b;
        private Double Y_b;
        private Double Z_b;
        private Double X_c;
        private Double Y_c;
        private Double Z_c;
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (n % 2 == 0)
            {
                A1_x.Text = "";
                A1_y.Text = "";
                A1_z.Text = "";
                A2_x.Text = "";
                A2_y.Text = "";
                A2_z.Text = "";
                B_x.Text = "";
                B_y.Text = "";
                B_z.Text = "";
                C_x.Text = "";
                C_y.Text = "";
                C_z.Text = "";
                label8.Visible = true;
                A2_x.Enabled = false;
                A2_y.Enabled = false;
                A2_z.Enabled = false;
                B_ch.Visible = true;
                button2.Text = "计算AB范围";
                button1.Enabled = false;
                n++;
            }
            else
            {
                label8.Visible = false;
                A2_x.Enabled = true;
                A2_y.Enabled = true;
                A2_z.Enabled = true;
                B_ch.Visible = true;
                button2.Text = "偏移量模式";
                button1.Enabled = true;
                X_a1 = Convert.ToDouble(A1_x.Text);
                Y_a1 = Convert.ToDouble(A1_y.Text);
                Z_a1 = Convert.ToDouble(A1_z.Text);
                X_b = Convert.ToDouble(B_x.Text);
                Y_b = Convert.ToDouble(B_y.Text);
                Z_b = Convert.ToDouble(B_z.Text);
                X_c = Convert.ToDouble(C_x.Text);
                Y_c = Convert.ToDouble(C_y.Text);
                Z_c = Convert.ToDouble(C_z.Text);
                Double P_x= Convert.ToDouble(B_ch.Text);
                Coordinates a1 = new Coordinates() { X = X_a1, Y = Y_a1, Z = Z_a1 };
                Coordinates b = new Coordinates() { X = X_b, Y = Y_b, Z = Z_b };
                Coordinates c = new Coordinates() { X = X_c, Y = Y_c, Z = Z_c };
                GetAngle angle1 = new GetAngle(a1, b, c);//A点水平基站+B+C
                string coor = string.Format("A_水平（{0},{1},{2})   B({3},{4},{5})  C({6},{7},{8})"
                                             , a1.X, a1.Y, a1.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z);
                string length1 = string.Format("标准三角形模型： AB={0}  AC={1}  BC={2}", angle1.L_c, angle1.L_b, angle1.L_a);
                string a_ang1 = string.Format("                     角A={0}  角B={1}  角C={2}", angle1.Ang_A, angle1.Ang_B, angle1.Ang_C);
                listView1.Items.Add(coor);
                listView1.Items.Add(length1);
                listView1.Items.Add(a_ang1);
                b.Y = b.Y - P_x;
                GetAngle min = new GetAngle(a1,b,c);
                string min_coor = string.Format("A_水平（{0},{1},{2})   B({3},{4},{5})  C({6},{7},{8})"
                             , a1.X, a1.Y, a1.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z);
                string min_length1 = string.Format("极小值三角形模型： AB={0}  AC={1}  BC={2}", min.L_c, min.L_b, min.L_a);
                string min_a_ang1 = string.Format("                     角A={0}  角B={1}  角C={2}", min.Ang_A, min.Ang_B, min.Ang_C);
                listView1.Items.Add(min_coor);
                listView1.Items.Add(min_length1);
                listView1.Items.Add(min_a_ang1);
                b.Y = b.Y + 2 * P_x;
                GetAngle max = new GetAngle(a1, b, c);
                string max_coor = string.Format("A_水平（{0},{1},{2})   B({3},{4},{5})  C({6},{7},{8})"
                             , a1.X, a1.Y, a1.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z);
                string max_length1 = string.Format("极大值三角形模型： AB={0}  AC={1}  BC={2}", max.L_c, max.L_b, max.L_a);
                string max_a_ang1 = string.Format("                     角A={0}  角B={1}  角C={2}", max.Ang_A, max.Ang_B, max.Ang_C);
                listView1.Items.Add(max_coor);
                listView1.Items.Add(max_length1);
                listView1.Items.Add(max_a_ang1);
                B_ch.Text += "对应("+min.L_c+","+max.L_c+")";
                textBox1.Text = max.L_c - min.L_c + "";
                n++;
            }

        }

        /// <summary>
        /// 计算角度，长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            X_a1 = Convert.ToDouble(A1_x.Text);
            Y_a1 = Convert.ToDouble(A1_y.Text);
            Z_a1 = Convert.ToDouble(A1_z.Text);
            X_a2 = Convert.ToDouble(A2_x.Text);
            Y_a2 = Convert.ToDouble(A2_y.Text);
            Z_a2 = Convert.ToDouble(A2_z.Text);
            X_b = Convert.ToDouble(B_x.Text);
            Y_b= Convert.ToDouble(B_y.Text);
            Z_b = Convert.ToDouble(B_z.Text);
            X_c= Convert.ToDouble(C_x.Text);
            Y_c = Convert.ToDouble(C_y.Text);
            Z_c = Convert.ToDouble(C_z.Text);
            l_ang.Visible = true;
            ang1.Visible = true;
            ang2.Visible = true;
            Coordinates a1 = new Coordinates() { X=X_a1,Y=Y_a1,Z=Z_a1};
            Coordinates a2 = new Coordinates() { X = X_a2, Y = Y_a2, Z = Z_a2 };
            Coordinates b = new Coordinates() { X = X_b, Y = Y_b, Z = Z_b };
            Coordinates c = new Coordinates() { X = X_c, Y = Y_c, Z = Z_c };
            GetAngle angle1 = new GetAngle(a1, b, c);//A点水平基站+B+C
            GetAngle angle2 = new GetAngle(a2, b, c);//A点拱顶基站+B+C
            ang1.Text = "角A="+angle1.Ang_A.ToString();
            ang2.Text = "角A="+angle2.Ang_A.ToString();
            string coor = string.Format("A_水平（{0},{1},{2})  A_拱顶（{3},{4},{5})  B({6},{7},{8})  C({9},{10},{11})"
                , a1.X, a1.Y, a1.Z, a2.X, a2.Y, a2.Z, b.X, b.Y, b.Z, c.X, c.Y, c.Z);
            string length1 = string.Format("A点水平基站三角形： AB={0}  AC={1}  BC={2}", angle1.L_c, angle1.L_b, angle1.L_a);
            string length2 = string.Format("A点拱顶基站三角形： AB={0}  AC={1}  BC={2}", angle2.L_c, angle2.L_b, angle2.L_a);
            string a_ang1 = string.Format("                     角A={0}  角B={1}  角C={2}", angle1.Ang_A, angle1.Ang_B, angle1.Ang_C);
            string a_ang2 = string.Format("                     角A={0}  角B={1}  角C={2}", angle2.Ang_A, angle2.Ang_B, angle2.Ang_C);
            listView1.Items.Add(coor);
            listView1.Items.Add(length1);
            listView1.Items.Add(a_ang1);
            listView1.Items.Add(length2);
            listView1.Items.Add(a_ang2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A1_x.Text = "";
            A1_y.Text = "";
            A1_z.Text = "";
            A2_x.Text = "";
            A2_y.Text = "";
            A2_z.Text = "";
            B_x.Text = "";
            B_y.Text = "";
            B_z.Text = "";
            C_x.Text = "";
            C_y.Text = "";
            C_z.Text = "";
            l_ang.Visible = false;
            ang1.Visible = false;
            ang2.Visible = false;
            B_ch.Visible = false;
        }
    }
}
