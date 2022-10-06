using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateLabel();
        }

        private void CreateLabel()
        {
            Label label = new Label();
            Image image = Properties.Resources.Blog_Baku;
            label.Size=new Size(image.Size.Width, image.Size.Height);

            label.Image=image;
            this.Size = label.Size;

            this.Controls.Add(label);
        }
        public bool HasClicked { get; set; } = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="admin")
            {
                label2.Text = "User name is not correct";
                label2.ForeColor=Color.Red;
            }
            else
            {
                label2.Text = String.Empty;
            }

            if (textBox2.Text != "admin")
            {
                label3.Text = "Password is not correct";
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.Text = String.Empty;
            }








            //HasClicked=!HasClicked;
            //if (HasClicked)
            //    textBox1.PasswordChar = '\0';
            //else textBox1.PasswordChar = '*';
            //MessageBox.Show(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int len=textBox1.Text.Length;
            //if (len < 10)
            //{
            //    label1.Text = "Your pass is so weak";
            //    label1.ForeColor = Color.Red;
            //}
            //else if(len < 15)
            //{
            //    label1.Text = "Your pass is normal";
            //    label1.ForeColor = Color.Yellow;
            //}
            //else if (len > 15 && len < 22 )
            //{
            //    label1.Text = "Your pass is very normal";
            //    label1.ForeColor = Color.Orange;
            //}
            //else if(len>15 && textBox1.Text.Contains("_"))
            //{
            //    label1.Text = "Your pass is strong";
            //    label1.ForeColor = Color.SpringGreen;
            //}
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Email")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text=String.Empty;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == String.Empty)
            {
                textBox1.Text = "Email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == String.Empty)
            {
                textBox1.Text = "Email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Email")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = String.Empty;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == String.Empty)
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Password")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = String.Empty;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == String.Empty)
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Password")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = String.Empty;
            }
        }

        
    }
}
