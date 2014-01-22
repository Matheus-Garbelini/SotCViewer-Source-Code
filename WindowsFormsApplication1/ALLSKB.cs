using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class ALLSKB : Form
    {
        public ALLSKB()
        {
            InitializeComponent();
        }

        private void ALLSKB_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(File.ReadAllLines(@"resources\ALL SKBs.txt"));
            comboBox1.AutoCompleteCustomSource.AddRange(File.ReadAllLines(@"resources\ALL SKBs.txt"));
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool contain_patched, exit;
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

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    if (comboBox1.DroppedDown == false)
                    {
                        try
                        {
                            listBox1.SelectedItem = comboBox1.Text;
                           
                        }
                        catch { }
                    }
                    else
                    {
                        comboBox1.DroppedDown = false;
                    }
                }
                catch
                {

                }
            }
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

        private void ALLSKB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        
        }

        
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string collectedText = "";

            foreach (string dd in listBox1.SelectedItems)
            {
                collectedText += dd + "\r\n";
            }
            Clipboard.SetText(collectedText);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
            {

                
                MessageBox.Show("funfou");
                
            }   
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip1.Show(this, new Point(e.X, e.Y + 60));
            }
        }
    }
}
