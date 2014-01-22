using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace WindowsFormsApplication1
{
    
    
    public partial class ColossusForm : Form
    {
        string models;
        string animations = "";
        
        public ColossusForm()
        {
            InitializeComponent();
            
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
        
        private void ColossusForm_Load(object sender, EventArgs e)
        {
           
            viewout.Parent = pictureBox1;
            viewin.Parent = pictureBox1;
            label_colossus.Parent = pictureBox1;
            if (MyGlobal.disc_version == ("opm"))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("minotaur_A.nmo");
            }
             if (MyGlobal.disc_version == ("psu"))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("minotaur_A.nmo");
            }
           

        }
        
        private void viewin_MouseEnter(object sender, EventArgs e)
        {
            viewout.Visible = true;
      
        }

        private void viewout_MouseLeave(object sender, EventArgs e)
        {
            viewout.Visible = false;
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Enabled = true;            
            animations = "";
            if (listBox1.SelectedItem != null)
            {

                listBox2.Items.Clear();
                if (listBox1.SelectedItem.ToString() != "minotaur_B_hige.nmo")
                {
                    try
                    {
                        listBox2.Items.AddRange(File.ReadAllLines(@"resources\colossus_animations\" +
                            listBox1.SelectedItem.ToString().Remove(listBox1.SelectedItem.ToString().Length - 3) + "txt"));
                    }
                    catch
                    {
                        listBox2.Items.Add(listBox1.SelectedItem.ToString().Remove(listBox1.SelectedItem.ToString().Length - 3)
                            + "txt");
                        listBox2.Items.Add("not found in resorces/colossus_anamations/ path");
                    }
                }
                else
                {
                    listBox2.Items.Add("No available animation");

                }
            }
            
        }
               
            
        
    
        private void viewout_Click(object sender, EventArgs e)
        {
            animations = "";
            models = listBox1.SelectedItem.ToString();
            try
            {
                if (models == null)
                {
                    MessageBox.Show("Choose a Colossus");
                }
                 
                else
                {
                    foreach (string anim_item in listBox2.SelectedItems)
                    {
                        animations = animations + " " + anim_item;
                    }
                    var imgvinfo = new ProcessStartInfo("cmd");

                    Process.Start("dormin", "-mipmaps -multitex " + models + " " + animations);
                    
                
                }
                
               
                            
            }
            catch
            {
                MessageBox.Show("dormin.exe não encontrado");
            }
        

        
   
            
        }

        

     

       

        private void select_animation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool exit, contain_patched;
        string last_value;
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.One;
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
                if (select_colossus.Checked)
                {
                    foreach (string item in listBox1.Items)
                    {
                        if (item.StartsWith(comboBox1.Text))
                        {
                            comboBox1.DroppedDown = true;
                            comboBox1.Items.Add(item);
                            exit = true;
                        }

                    }
                }
                else
                {
                    foreach (string item in listBox2.Items)
                    {
                        if (item.StartsWith(comboBox1.Text))
                        {
                            comboBox1.DroppedDown = true;
                            comboBox1.Items.Add(item);
                            exit = true;
                        }

                    }
                }

                if (exit == false)
                {
                    if (select_colossus.Checked)
                    {
                        foreach (string item in listBox1.Items)
                        {
                            if (item.Contains(comboBox1.Text))
                            {
                                comboBox1.DroppedDown = true;
                                comboBox1.Items.Add(item);
                            }

                        }
                    }
                    else
                    {
                        foreach (string item in listBox2.Items)
                        {
                            if (item.Contains(comboBox1.Text))
                            {
                                comboBox1.DroppedDown = true;
                                comboBox1.Items.Add(item);
                            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (select_colossus.Checked)
                {
                    listBox1.SelectedItem = comboBox1.Text;
                }
                else
                {
                    listBox2.SelectedItem = comboBox1.Text;
                }
                }
            catch
            {

            }
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
                            viewout_Click(sender, e);
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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (comboBox1.DroppedDown == false)
            {
                try
                {

                    viewout_Click(sender, e);
                }
                catch { }
            }
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip1.Show(this, new Point(e.X, e.Y + 85));
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void listBox2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Close();
                    contextMenuStrip2.Show(this, new Point(e.X + 250, e.Y + 85));
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string collectedText = "";


            foreach (string dd in listBox2.SelectedItems)
            {
                collectedText += dd + "\r\n";
            }
            Clipboard.SetText(collectedText);
            
            
            
        }

        private void select_colossus_CheckedChanged(object sender, EventArgs e)
        {

        }

    

       

        
    }
}