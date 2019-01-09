using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFro213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// START BTN
        {
            Num1Lbl.Visible = false;
            Num2Lbl.Visible = false;
            Num3Lbl.Visible = false;
            Num4Lbl.Visible = false;
            Num5Lbl.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a,b,c,d,f;
            a = rnd.Next(1, 100);
            Num1Lbl.Text = a.ToString();
            b= rnd.Next(1, 100);
            Num2Lbl.Text = b.ToString();
            c= rnd.Next(1, 100);
            Num3Lbl.Text = c.ToString();
            d = rnd.Next(1, 100);
            Num4Lbl.Text = d.ToString();
            f= rnd.Next(1, 100);
            Num5Lbl.Text = f.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)//BUTTON 2 =FINISH BTN

        {
            int result = Check(Num1Lbl.Text, Num2Lbl.Text, Num3Lbl.Text, Num4Lbl.Text, Num5Lbl.Text);
            if (result == 5) MessageBox.Show("YOU WIN!");
            MessageBox.Show("YOU LOOSE!");
            ScoreBox.Items.Add(result.ToString());
                
        
        }
        private int Check(params string[] arr)
        {
            int Res = 0;
           // string[] Fin = new string[2];
            string []arr1 = new string[5];
            arr1[0] = textBox1.Text;
            arr1[1] = textBox2.Text;
            arr1[2] = textBox3.Text;
            arr1[3] = textBox4.Text;
            arr1[4] = textBox5.Text;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] == arr1[i])
                    Res += 1;
            }
            //Fin[0] = Res.ToString();
            
            return Res;
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure you want to leave the game?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();


        }
    }
}
