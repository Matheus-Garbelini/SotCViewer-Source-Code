using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows;


namespace WindowsFormsApplication1
{
    public partial class ALLSKBS : Form
    {
        string export_path;
       public string result;        
        bool exit = false;
  
        
        public ALLSKBS()
        {
            InitializeComponent();
           
        }
       

        private void AllTextures_Load(object sender, EventArgs e)
        {
            
            viewin.Parent = pictureBox1;
            viewout.Parent = pictureBox1;
            if (MyGlobal.disc_version == "pal")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\pal\PAL TEXTURES.txt"));
            }
            else if (MyGlobal.disc_version == "ntsc")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\ntsc\NTSC TEXTURES.txt"));
            }
            else if (MyGlobal.disc_version == "preview")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\preview\PREVIEW TEXTURES.txt"));
            }
            else if (MyGlobal.disc_version == "psu")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\psu\PSU TEXTURES.txt"));
            }
            else if (MyGlobal.disc_version == "opm")
            {
                listBox1.Items.AddRange(File.ReadAllLines(@"resources\version_index\opm\OPM TEXTURES.txt"));

            }           
            
                       
           
        }


        bool processIsRunning(string process)
        {
            System.Diagnostics.Process[] processes =
                System.Diagnostics.Process.GetProcessesByName(process);
            foreach (System.Diagnostics.Process proc in processes)
            {
                
            }
            return (processes.Length != 0);
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
            Process.Start("imgv", listBox1.SelectedItem.ToString());
        }
        
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {        
            
                listBox1.SelectionMode = SelectionMode.One;
                exit = false;

                if (comboBox1.Text == "") { listBox1.SelectedIndex = -1;
                    comboBox1.AllowDrop = false; 
                    contain_patched = false; 
                    comboBox1.DroppedDown = false; }
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
                        if (comboBox1.Items.Count == 0) { 
                           comboBox1.Items.Add("NO MACHES!!!"); 
                           comboBox1.DroppedDown = false; }
                          
                    }
                }
                contain_patched = true; 
            try
                {
                    if (comboBox1.DroppedDown == true) { listBox1.SelectedItem = comboBox1.Text; }
                }
                catch { }
                      
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("export_path.txt"))
            {
                using (StreamReader sr = File.OpenText("export_path.txt"))
                {
                    export_path = sr.ReadLine();
                    
                }


                foreach (string item in listBox1.SelectedItems)
                {

                    StreamWriter sr = new StreamWriter("xp_fix.bat");
                    sr.WriteLine(@"set file=%1 set path=%2");
                    sr.WriteLine(@"imgv %1 -ppm");
                    sr.WriteLine(@"pnmtopng %1.ppm > %2\%1.png");
                    sr.WriteLine(@"del %1.ppm");
                    sr.Close();

                    var imgvinfo = new ProcessStartInfo("cmd");

                    imgvinfo.UseShellExecute = false;
                    imgvinfo.ErrorDialog = false;


                    imgvinfo.RedirectStandardError = true;
                    imgvinfo.RedirectStandardInput = true;
                    imgvinfo.RedirectStandardOutput = true;
                    imgvinfo.CreateNoWindow = true;
                    imgvinfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Process imgv = new Process();
                    imgv.StartInfo = imgvinfo;
                    bool processStarted = imgv.Start();
                    StreamWriter imgvWriter = imgv.StandardInput;
                    imgvWriter.WriteLine("xp_fix " + item + " " + export_path);

                    while (processIsRunning("imgv") == false) ;
                    while (File.Exists(item + ".ppm") == false) { Thread.Sleep(400); break; }
                    if (File.Exists(item + ".ppm"))
                    {
                        Thread.Sleep(150);
                        System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("imgv");
                        foreach (System.Diagnostics.Process p in process)
                        {
                            p.Kill();
                            p.WaitForExit();
                            while (processIsRunning("imgv")) ;
                            while (File.Exists(item + ".ppm")) ;
                            imgvWriter.WriteLine("exit");
                            imgv.WaitForExit();


                        }

                    }
                    try
                    {
                        System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("imgv");
                        foreach (System.Diagnostics.Process p in process)
                        {
                            p.Kill();
                            p.WaitForExit();
                            while (processIsRunning("imgv")) ;
                            while (File.Exists(item + ".ppm")) ;
                            imgvWriter.WriteLine("exit");
                            imgv.WaitForExit();


                        }
                    }
                    catch
                    {
                    }

                }
                File.Delete("xp_fix.bat");

            }
            else
            {
                MessageBox.Show("Select a folder", "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                if (dialog.SelectedPath.Length <= 3)
                {
                    export_path = dialog.SelectedPath.ToString().Remove(dialog.SelectedPath.ToString().Length - 1);
                        
                }
                else
                {
                    export_path = dialog.SelectedPath;
                }
                System.IO.File.WriteAllText(@"export_path" +
                               ".txt", export_path);
            
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
        
        string last_value;
        bool contain_patched = false;
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

        private void listBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
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
                    contextMenuStrip1.Show(this, new Point(e.X, e.Y + 60));
            }
        }


    }
}
