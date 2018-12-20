using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            listBox1.Visible = false;
            comboBox1.Items.Add("Россия");
            comboBox1.Items.Add("Италия");
            comboBox2.Items.Add("Москва");
            comboBox2.Items.Add("Рим");
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Профиль еще не создан");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin")
            {
                panel1.Visible = false;
                panel3.Visible = true;
                listBox1.Text = "Здесь будут отображены варианты размещения";
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = true;
                listBox1.Text = "Здесь будут отображены варианты размещения";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Text = "Здесь будут отображены варианты размещения";
        }
    }
}
