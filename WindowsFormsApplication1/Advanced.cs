using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                    listBox1.SelectedItem = comboBox1.Text;
                
            }
            catch
            {

            }
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;
           
            groupBox5.Parent = pictureBox1;
            groupBox2.Parent = pictureBox1;
            groupBox3.Parent = pictureBox1;
            groupBox4.Parent = pictureBox1;
            
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("resources/ALL MODELS.txt"));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("resources/ALL ANIMATIONS.txt"));
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("resources/ALL TEXTURES.txt"));
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("resources/ALL SKBs.txt"));
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + listBox1.SelectedItem.ToString() + " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-slice ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-index ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-base ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-sstep ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-dbones ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-novbo ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-multitex ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-skb ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-mipmaps ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-connect ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox5.Visible = true;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-index ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-base ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-level ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "-ppm ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DORMIN USAGE\n Usage: dormin [options] model.nmo [animation.anb ...]\n -slice <path>          of file/dir to slice data to\n -index <path>          to index\n -base <directory>      base\n -sstep <float>         slerp step\n -dbones                print names of the bones\n -novbo                 do not use vertex buffer objects\n -multitex              use mutlipass texturing\n -skb <name>            use specified skb instead of guessing\n -mipmaps               use mipmaps\n -connect <parent:bone> connect following to the specified parent models bone\n -help                  Display this list of options\n \n IMGV USAGE\n -index  <path> to index\n -base   <directory> base\n -level  <level> mipmap level\n -ppm    dump ppm\n -help   Display this list of options","HELP");
        }

        bool exit, contain_patched;
        string last_value;
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {


            listBox1.SelectionMode = SelectionMode.One;
            exit = false;

            if (comboBox1.Text == "")
            {
                listBox1.SelectedIndex = -1;
                comboBox1.AllowDrop = false;
                contain_patched = false;
                comboBox1.DroppedDown = false;
            }
            else
            {
                comboBox1.AllowDrop = true;
                if (contain_patched)
                {
                    last_value = comboBox1.Text;
                    comboBox1.Items.Clear();
                    comboBox1.Text = last_value;
                    comboBox1.SelectionStart = comboBox1.MaxLength;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.StartsWith(comboBox1.Text))
                    {
                        comboBox1.DroppedDown = true;
                        comboBox1.Items.Add(item);
                        exit = true;
                    }

                }

                if (exit == false)
                {

                    foreach (string item in listBox1.Items)
                    {
                        if (item.Contains(comboBox1.Text))
                        {
                            comboBox1.DroppedDown = true;
                            comboBox1.Items.Add(item);
                        }

                    }
                    if (comboBox1.Items.Count == 0)
                    {
                        comboBox1.Items.Add("NO MACHES!!!");
                        comboBox1.DroppedDown = false;
                    }

                }
            }
            contain_patched = true;
            try
            {
                if (comboBox1.DroppedDown == true) { listBox1.SelectedItem = comboBox1.Text; }
            }
            catch { }
         
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "") { MessageBox.Show("Insert an argument", "ERROR"); }
            else
            {
                if (radioButton1.Checked)
                {
                    Process.Start("dormin", richTextBox1.Text);
                }
                if (radioButton2.Checked)
                {
                    Process.Start("imgv", richTextBox1.Text);
                }
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
