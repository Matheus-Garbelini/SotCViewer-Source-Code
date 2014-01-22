using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;



namespace WindowsFormsApplication1
{
    public partial class Misc : Form
    {
        string place_list;
        public static string list_path = @"resources\RELEVANT STUFF.txt";
        string animation;
        
        public Misc()
        {
            InitializeComponent();
            var listbox = new ListBox();
            listbox.Dock = DockStyle.Fill;
            listbox.SelectionMode = SelectionMode.MultiSimple;
            this.Controls.Add(listbox);

            foreach (var color in Enum.GetNames(typeof(System.TypeCode)))
                listbox.Items.Add(color);

            for (int i = 0; i < listbox.Items.Count; i++)
            {
                string name = (string)listbox.Items[i];
                if (name.StartsWith("U"))
                    listbox.SetSelected(i, true);
            }
        }

        private void button_single_Click(object sender, EventArgs e)
        {
            try
            {


                if (listBox1.SelectedItem.ToString() == "-------------------------------------------")
                {
                    MessageBox.Show("Select a valid model");
                }
                if (listBox1.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Select just one model");

                }
                else
                {

                    if (listBox1.SelectedItem.ToString().EndsWith(".nto"))
                    {
                        Process.Start("imgv", listBox1.SelectedItem.ToString());
                    }
                    else
                    {
                        Process.Start("dormin", "-mipmaps -multitex " + listBox1.SelectedItem.ToString());
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Select a Model","ERROR");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (listBox1.SelectedItems.Count > 1)
                {
                    
                        place_list = "dormin -mipmaps -multitex ";
                        foreach (string listms in listBox1.SelectedItems)
                        {
                            place_list = place_list + listms + " -connect Bone_KAO nmo/";
                        }
                        place_list = place_list.Remove(place_list.Length - 23);
                        StreamWriter sr = new StreamWriter("multiple_selection.bat");
                        sr.WriteLine(place_list);
                        sr.Close();
                        Process.Start("multiple_selection.bat");
                    
                }
                else
                {
                    if (listBox1.SelectedItem.ToString().EndsWith(".nto"))
                    {

                        Process.Start("imgv", listBox1.SelectedItem.ToString());
                    }
                    else
                    {
                        Process.Start("dormin", "-mipmaps -multitex " + 
                        listBox1.SelectedItem.ToString() + " " + animation);
                    }
                }
            }
        }

        private void list_misc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void viewin_Click(object sender, EventArgs e)
        {

        }

        private void viewin_MouseEnter(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Visible = false;
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
        
        private void Misc_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(File.ReadAllLines(list_path));
            comboBox2.AutoCompleteCustomSource.AddRange(File.ReadAllLines(@"resources\ALL ANIMATIONS.txt"));
            
            groupBox2.Parent = pictureBox1;
            button1.Parent = pictureBox1;
            viewin.Parent = pictureBox1;


        }

        private void list_misc_Enter(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
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
                            button1_Click(sender, e);

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

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            
                 animation = comboBox2.Text;



        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                animation = comboBox2.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ALLSKBS at = new ALLSKBS();
            at.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            ALLSKB ask = new ALLSKB();
            ask.Show();
            this.Close();
            
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ALLMODELS am = new ALLMODELS();
            am.Show();
            this.Close();
            
            
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

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip1.Show(this, new Point(e.X+ 390 , e.Y + 30));
            }
        } 
    
    }
}
