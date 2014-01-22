using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class ALLMODELS : Form
    {
        string models = "";
        string animations = "";
        string place_list = "";
        
        public ALLMODELS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        
        private void ALLMODELS_Load(object sender, EventArgs e)
        {
            
            
            viewin.Parent = pictureBox1;
            viewout.Parent = pictureBox1;
           
           

            if (MyGlobal.disc_version == "pal")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\pal\PAL MODELS.txt"));
                listBox2.Items.AddRange(File.ReadAllLines(@"resources\version_index\pal\PAL ANIMATIONS.txt"));
            }
            else if (MyGlobal.disc_version == "ntsc")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\ntsc\NTSC MODELS.txt"));
                listBox2.Items.AddRange(File.ReadAllLines(@"resources\version_index\ntsc\NTSC ANIMATIONS.txt"));
            }
            else if (MyGlobal.disc_version == "preview")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\preview\PREVIEW MODELS.txt"));
                listBox2.Items.AddRange(File.ReadAllLines(@"resources\version_index\preview\PREVIEW ANIMATIONS.txt"));
            }
            else if (MyGlobal.disc_version == "psu")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\psu\PSU MODELS.txt"));
                listBox2.Items.AddRange(File.ReadAllLines(@"resources\version_index\psu\PSU ANIMATIONS.txt"));
            }
            else if (MyGlobal.disc_version == "opm")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\opm\OPM MODELS.txt"));
                listBox2.Items.AddRange(File.ReadAllLines(@"resources\version_index\opm\OPM ANIMATIONS.txt"));
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (select_model.Checked)
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

        private void viewout_MouseLeave(object sender, EventArgs e)
        {
            viewout.Visible = false;
            viewin.Visible = true;
        }

        private void viewin_MouseEnter(object sender, EventArgs e)
        {
            viewin.Visible = false;
            viewout.Visible = true;
        }

        private void viewout_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count < 2)
                {
                    models = listBox1.SelectedItem.ToString();
                    foreach (string animation in listBox2.SelectedItems)
                    {
                        animations = animations + " " + animation;
                    }
                    Process.Start("dormin", "-mipmaps -multitex " + models + " " + animations);
                }
                else
                {

                    place_list = "dormin -mipmaps -multitex ";
                    foreach (string listms in listBox1.SelectedItems)
                    {
                        place_list = place_list + listms + " -connect Bone_KAO nmo/";
                    }
                    place_list = place_list.Remove(place_list.Length - 23);
                    StreamWriter sr = new StreamWriter("multiple_selection.bat");
                    sr.WriteLine(place_list);
                    sr.WriteLine("del multiple_selection.bat");
                    sr.Close();
                    Process.Start("multiple_selection.bat");

                }
            }
            catch
            {
                MessageBox.Show("Select a model", "ERROR");
            }
        }
        


        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void select_model_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();            
        }

        private void select_animation_CheckedChanged(object sender, EventArgs e)
        {
            
            comboBox1.Items.Clear();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
           
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool exit, contain_patched;
        string last_value;
        private void comboBox1_TextUpdate_1(object sender, EventArgs e)
        {

            if (select_model.Checked)
            {
                listBox1.SelectionMode = SelectionMode.One;
            }
            else
            {
                listBox2.SelectionMode = SelectionMode.One;
            }
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
                if (select_model.Checked)
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
                    if (select_model.Checked)
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





        private void comboBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    if (comboBox1.DroppedDown == false)
                    {
                        try
                        {
                            if (select_model.Checked)
                            {
                                listBox1.SelectedItem = comboBox1.Text;
                            }
                            else
                            {
                                listBox2.SelectedItem = comboBox1.Text;
                            }
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

        private void listBox2_Enter(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
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
        }

        private void listBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
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
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip1.Show(this, new Point(e.X + 7, e.Y + 85));
            }
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string collectedText = "";

            foreach (string dd in listBox2.SelectedItems)
            {
                collectedText += dd + "\r\n";
            }
            Clipboard.SetText(collectedText);
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip2.Show(this, new Point(e.X + 290, e.Y + 85));
            }
        }


       

       
    }
}
