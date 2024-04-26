using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISYNOK6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if (radioButton3.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                cylinder c = new cylinder(x, y);
                listBox1.Items.Add(c);

            }
            else if (radioButton2.Checked)
            {

                int x = Convert.ToInt32(textBox1.Text);
                cube cu = new cube(x);
                listBox1.Items.Add(cu);
            }
            else if (radioButton3.Checked)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int R = Convert.ToInt32(textBox3.Text);
                int r = Convert.ToInt32(textBox4.Text);
                pipe pip = new pipe(x, r, R);
                listBox1.Items.Add(pip);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem is cylinder)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else if (listBox1.SelectedItem is cube)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else if (listBox1.SelectedItem is pipe)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                Figura f = listBox1.Items[listBox1.SelectedIndex] as Figura;
                if (f is cube)
                {
                    label4.Text = "Это куб";
                }
                else if (f is cylinder)
                {
                    label4.Text = "Это цилиндр";
                }
                else if (f is pipe)
                {
                    label4.Text = "Это Туба";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    
    
    
    

