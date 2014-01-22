using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
   
    public partial class Main : Form
    {
        
        string programpath = Application.StartupPath;
        bool pathed = false;
        
       
       
        
        public Main()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            nomad_link.Links[0].LinkData = "http://nomads-sotc-blog.blogspot.com.au/2011/04/welcome-to-nomads-shadow-of-colossus.html";
            
            linkLabel1.Links[0].LinkData = "http://blackbirdsotc.blogspot.com.br/";
        
            linkLabel2.Links[0].LinkData = "http://www.youtube.com/user/wwwarea";
            
            fyle_system_group.Parent = pictureBox1;


            groupBox1.Parent = pictureBox1;
                  
           
               
                    try
                    {

                        using (StreamReader sr = File.OpenText("path_saved.txt"))
                        {
                            

                            sotc_path.Text = sr.ReadLine();
                                                        
                                FileInfo f = new FileInfo(sotc_path.Text + @"\NICO.DAT");
                                long nico = f.Length / 1000000;
                                

                                if (File.Exists(sotc_path.Text + @"\XAB"))
                                {
                                    if (File.Exists(@"index\nico.dat.index"))
                                    {
                                        FileInfo c = new FileInfo(@"index\nico.dat.index");
                                        long index = c.Length / 1000;
                                        if (index >= 480 && index <= 484) { ;}
                                        else
                                        {
                                            MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                            var processStartInfo = new ProcessStartInfo("cmd");

                                            processStartInfo.UseShellExecute = false;
                                            processStartInfo.ErrorDialog = false;

                                            processStartInfo.RedirectStandardError = true;
                                            processStartInfo.RedirectStandardInput = true;
                                            processStartInfo.RedirectStandardOutput = true;
                                            processStartInfo.CreateNoWindow = true;

                                            Process process = new Process();
                                            process.StartInfo = processStartInfo;
                                            bool processStarted = process.Start();

                                            File.WriteAllBytes(@"index/index", Properties.Resources.index_pal);
                                            File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_pal);
                                            File.WriteAllBytes(@"index/xab.index", Properties.Resources.xab);
                                            File.WriteAllBytes(@"index/xac.index", Properties.Resources.xac);
                                            StreamWriter inputWriter = process.StandardInput;
                                            inputWriter.WriteLine("cd index");
                                            inputWriter.WriteLine("index_pal " + sotc_path.Text);
                                            inputWriter.WriteLine("exit");
                                            process.WaitForExit();
                                            MessageBox.Show("PAL disc Found\nChanging complete!!", "Changed");
                                        }
                                    
                                    }
                                    else
                                    {
                                        MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                        var processStartInfo = new ProcessStartInfo("cmd");

                                        processStartInfo.UseShellExecute = false;
                                        processStartInfo.ErrorDialog = false;

                                        processStartInfo.RedirectStandardError = true;
                                        processStartInfo.RedirectStandardInput = true;
                                        processStartInfo.RedirectStandardOutput = true;
                                        processStartInfo.CreateNoWindow = true;

                                        Process process = new Process();
                                        process.StartInfo = processStartInfo;
                                        bool processStarted = process.Start();

                                        File.WriteAllBytes(@"index/index", Properties.Resources.index_pal);
                                        File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_pal);
                                        File.WriteAllBytes(@"index/xab.index", Properties.Resources.xab);
                                        File.WriteAllBytes(@"index/xac.index", Properties.Resources.xac);
                                        StreamWriter inputWriter = process.StandardInput;
                                        inputWriter.WriteLine("cd index");
                                        inputWriter.WriteLine("index_pal " + sotc_path.Text);
                                        inputWriter.WriteLine("exit");
                                        process.WaitForExit();
                                        MessageBox.Show("PAL disc Found\nChanging complete!!", "Changed");
                                    }
                                    
                                    label_disc_type.ForeColor = Color.Green;
                                    label_disc_type.Text = "PAL";
                                    MyGlobal.disc_version = "pal";
                                }
                                else
                                {
                                    if (nico > 2668)
                                    {
                                        if (File.Exists(@"index\nico.dat.index")==true)
                                        {
                                            FileInfo c = new FileInfo(@"index\nico.dat.index");
                                            long index = c.Length / 1000;
                                            if (index >= 1350 && index <= 1352) { }
                                            else
                                            {
                                                MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                var processStartInfo = new ProcessStartInfo("cmd");

                                                processStartInfo.UseShellExecute = false;
                                                processStartInfo.ErrorDialog = false;

                                                processStartInfo.RedirectStandardError = true;
                                                processStartInfo.RedirectStandardInput = true;
                                                processStartInfo.RedirectStandardOutput = true;
                                                processStartInfo.CreateNoWindow = true;

                                                Process process = new Process();
                                                process.StartInfo = processStartInfo;
                                                bool processStarted = process.Start();

                                                File.WriteAllBytes(@"index/index", Properties.Resources.index_preview);
                                                File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_preview);
                                                StreamWriter inputWriter = process.StandardInput;
                                                inputWriter.WriteLine("cd index");
                                                inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                inputWriter.WriteLine("exit");
                                                process.WaitForExit();
                                                MessageBox.Show("PREVIEW disc Found\nChanging complete!!", "Changed");
                                            }

                                        }
                                        else if (File.Exists(@"index\nico.dat.index")==false){
                                            MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                            var processStartInfo = new ProcessStartInfo("cmd");

                                            processStartInfo.UseShellExecute = false;
                                            processStartInfo.ErrorDialog = false;

                                            processStartInfo.RedirectStandardError = true;
                                            processStartInfo.RedirectStandardInput = true;
                                            processStartInfo.RedirectStandardOutput = true;
                                            processStartInfo.CreateNoWindow = true;

                                            Process process = new Process();
                                            process.StartInfo = processStartInfo;
                                            bool processStarted = process.Start();

                                            File.WriteAllBytes(@"index/index", Properties.Resources.index_preview);
                                            File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_preview);
                                            StreamWriter inputWriter = process.StandardInput;
                                            inputWriter.WriteLine("cd index");
                                            inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                            inputWriter.WriteLine("exit");
                                            process.WaitForExit();
                                            MessageBox.Show("PREVIEW disc Found\nChanging complete!!", "Changed");
                                        }
                                       
                                        MyGlobal.disc_version = "preview";
                                        label_disc_type.ForeColor = Color.Green;
                                        label_disc_type.Text = "Preview";
                                        MyGlobal.disc_version = "preview";
                                    }
                                    else
                                    {
                                        if (nico < 700)
                                        {
                                            if (nico < 685)
                                            {
                                                if (File.Exists(@"index\nico.dat.index"))
                                                {
                                                    FileInfo c = new FileInfo(@"index\nico.dat.index");
                                                    long index = c.Length / 1000;
                                                    if (index >= 378 && index <= 381) { ;}
                                                    else
                                                    {
                                                        MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                        var processStartInfo = new ProcessStartInfo("cmd");

                                                        processStartInfo.UseShellExecute = false;
                                                        processStartInfo.ErrorDialog = false;

                                                        processStartInfo.RedirectStandardError = true;
                                                        processStartInfo.RedirectStandardInput = true;
                                                        processStartInfo.RedirectStandardOutput = true;
                                                        processStartInfo.CreateNoWindow = true;

                                                        Process process = new Process();
                                                        process.StartInfo = processStartInfo;
                                                        bool processStarted = process.Start();

                                                        File.WriteAllBytes(@"index/index", Properties.Resources.index_opm);
                                                        File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_opm);
                                                        StreamWriter inputWriter = process.StandardInput;
                                                        inputWriter.WriteLine("cd index");
                                                        inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                        inputWriter.WriteLine("exit");
                                                        process.WaitForExit();
                                                        MessageBox.Show("OPM disc Found\nChanging complete!!", "Changed");
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                    var processStartInfo = new ProcessStartInfo("cmd");

                                                    processStartInfo.UseShellExecute = false;
                                                    processStartInfo.ErrorDialog = false;

                                                    processStartInfo.RedirectStandardError = true;
                                                    processStartInfo.RedirectStandardInput = true;
                                                    processStartInfo.RedirectStandardOutput = true;
                                                    processStartInfo.CreateNoWindow = true;

                                                    Process process = new Process();
                                                    process.StartInfo = processStartInfo;
                                                    bool processStarted = process.Start();

                                                    File.WriteAllBytes(@"index/index", Properties.Resources.index_opm);
                                                    File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_opm);
                                                    StreamWriter inputWriter = process.StandardInput;
                                                    inputWriter.WriteLine("cd index");
                                                    inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                    inputWriter.WriteLine("exit");
                                                    process.WaitForExit();
                                                    MessageBox.Show("OPM disc Found\nChanging complete!!", "Changed");
                                                }
                                                MyGlobal.disc_version = "opm";
                                                label_disc_type.ForeColor = Color.Green;
                                                label_disc_type.Text = "OPM Demo";
                                                MyGlobal.disc_version = "opm";
                                            }
                                            else
                                            {
                                                if (File.Exists(@"index\nico.dat.index"))
                                                {
                                                    FileInfo c = new FileInfo(@"index\nico.dat.index");
                                                    long index = c.Length / 1000;
                                                    if (index >= 382 && index <= 386) { ;}
                                                    else
                                                    {
                                                        MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                        var processStartInfo = new ProcessStartInfo("cmd");

                                                        processStartInfo.UseShellExecute = false;
                                                        processStartInfo.ErrorDialog = false;

                                                        processStartInfo.RedirectStandardError = true;
                                                        processStartInfo.RedirectStandardInput = true;
                                                        processStartInfo.RedirectStandardOutput = true;
                                                        processStartInfo.CreateNoWindow = true;

                                                        Process process = new Process();
                                                        process.StartInfo = processStartInfo;
                                                        bool processStarted = process.Start();

                                                        File.WriteAllBytes(@"index/index", Properties.Resources.index_psu);
                                                        File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_psu);
                                                        StreamWriter inputWriter = process.StandardInput;
                                                        inputWriter.WriteLine("cd index");
                                                        inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                        inputWriter.WriteLine("exit");
                                                        process.WaitForExit();
                                                        MessageBox.Show("PSU disc Found\nChanging complete!!", "Changed");
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                    var processStartInfo = new ProcessStartInfo("cmd");

                                                    processStartInfo.UseShellExecute = false;
                                                    processStartInfo.ErrorDialog = false;

                                                    processStartInfo.RedirectStandardError = true;
                                                    processStartInfo.RedirectStandardInput = true;
                                                    processStartInfo.RedirectStandardOutput = true;
                                                    processStartInfo.CreateNoWindow = true;

                                                    Process process = new Process();
                                                    process.StartInfo = processStartInfo;
                                                    bool processStarted = process.Start();

                                                    File.WriteAllBytes(@"index/index", Properties.Resources.index_psu);
                                                    File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_psu);
                                                    StreamWriter inputWriter = process.StandardInput;
                                                    inputWriter.WriteLine("cd index");
                                                    inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                    inputWriter.WriteLine("exit");
                                                    process.WaitForExit();
                                                    MessageBox.Show("PSU disc Found\nChanging complete!!", "Changed");
                                                }
                                                MyGlobal.disc_version = "psu";
                                                label_disc_type.ForeColor = Color.Green;
                                                label_disc_type.Text = "PSU Demo";
                                                MyGlobal.disc_version = "psu";
                                            }
                                        }
                                        else
                                        {
                                            if (File.Exists(@"index\nico.dat.index"))
                                            {
                                                FileInfo c = new FileInfo(@"index\nico.dat.index");
                                                long index = c.Length / 1000;
                                                if (index >= 1250 && index <= 1258) { ;}
                                                else
                                                {
                                                    MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                    var processStartInfo = new ProcessStartInfo("cmd");

                                                    processStartInfo.UseShellExecute = false;
                                                    processStartInfo.ErrorDialog = false;

                                                    processStartInfo.RedirectStandardError = true;
                                                    processStartInfo.RedirectStandardInput = true;
                                                    processStartInfo.RedirectStandardOutput = true;
                                                    processStartInfo.CreateNoWindow = true;

                                                    Process process = new Process();
                                                    process.StartInfo = processStartInfo;
                                                    bool processStarted = process.Start();

                                                    File.WriteAllBytes(@"index/index", Properties.Resources.index_ntsc);
                                                    File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_ntsc);
                                                    StreamWriter inputWriter = process.StandardInput;
                                                    inputWriter.WriteLine("cd index");
                                                    inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                    inputWriter.WriteLine("exit");
                                                    process.WaitForExit();
                                                    MessageBox.Show("NTSC disc Found\nChanging complete!!", "Changed");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Found a different game version on the previously choosen path.\nThe Viewer will refresh now, click OK and wait a moment.");
                                                var processStartInfo = new ProcessStartInfo("cmd");

                                                processStartInfo.UseShellExecute = false;
                                                processStartInfo.ErrorDialog = false;

                                                processStartInfo.RedirectStandardError = true;
                                                processStartInfo.RedirectStandardInput = true;
                                                processStartInfo.RedirectStandardOutput = true;
                                                processStartInfo.CreateNoWindow = true;

                                                Process process = new Process();
                                                process.StartInfo = processStartInfo;
                                                bool processStarted = process.Start();

                                                File.WriteAllBytes(@"index/index", Properties.Resources.index_ntsc);
                                                File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_ntsc);
                                                StreamWriter inputWriter = process.StandardInput;
                                                inputWriter.WriteLine("cd index");
                                                inputWriter.WriteLine("index_ntsc " + sotc_path.Text);
                                                inputWriter.WriteLine("exit");
                                                process.WaitForExit();
                                                MessageBox.Show("NTSC disc Found\nChanging complete!!", "Changed");
                                            }
                                            MyGlobal.disc_version = "ntsc";
                                            label_disc_type.ForeColor = Color.Green;
                                            label_disc_type.Text = "NTSC";
                                            MyGlobal.disc_version = "ntsc";
                                        }
                                        }
                                }
                            }
                        }
                    
                    catch
                    {

                        sotc_path.Text = "Select a path";
                        
                        
                       

                    }
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void colossusin_MouseEnter(object sender, EventArgs e)
        {
            colossusout.Visible = true;
            
        }

        private void wanderin_MouseEnter(object sender, EventArgs e)
        {
            wanderout.Visible = true;
        }

        private void miscin_MouseEnter(object sender, EventArgs e)
        {
            miscout.Visible = true;
        }

        private void creditsin_MouseEnter(object sender, EventArgs e)
        {
            creditsout.Visible = true;
        }

        private void colossusout_MouseLeave(object sender, EventArgs e)
        {
            colossusout.Visible = false;
        }

        private void wanderout_MouseLeave(object sender, EventArgs e)
        {
            wanderout.Visible = false;
        }

        private void miscout_MouseLeave(object sender, EventArgs e)
        {
            miscout.Visible = false;
        }

        private void creditsout_MouseLeave(object sender, EventArgs e)
        {
            creditsout.Visible = false;
        }

        private void colossusout_Click(object sender, EventArgs e)
        {
            ColossusForm CF = new ColossusForm();
            CF.Visible = true;
         
            
        }

        private void creditsout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks a lot to NOMAD, this GUI wouldn't be done without his help\nGUI created by MATHEUS EDUARDO GARBELINI\nConsole OpenGL NTO Viewer created by YOUMOOSTC\nThanks HEXDREL to his support\nWWWArea for his beta tester support", "Credits");
        }

       
        private void sotc_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           if(sotc_path.SelectedItem.ToString() == "Browse")
           {
               if (pathed == true)
               {
                   
                   sotc_path.Items.RemoveAt(0);
               }
               var dialog = new FolderBrowserDialog();
               var result = dialog.ShowDialog();
               if (result == DialogResult.OK)
               {

                   if (dialog.SelectedPath.Length <= 3)
                   {
                       sotc_path.Items.Insert(0, dialog.SelectedPath.Remove(dialog.SelectedPath.Length - 1, 1));
                   }
                   else
                   {
                       sotc_path.Items.Insert(0, dialog.SelectedPath);
                   }
                   sotc_path.SelectedIndex = 0;


                   if (File.Exists(sotc_path.SelectedItem.ToString() + @"\NICO.DAT"))
                   {
                       sotc_path.Text = ".....";
                       path_state.ForeColor = Color.DarkRed;
                       path_state.Text = "CHANGING...";
                       path_state.Visible = true;

                       var processStartInfo = new ProcessStartInfo("cmd");

                       processStartInfo.UseShellExecute = false;
                       processStartInfo.ErrorDialog = false;

                       processStartInfo.RedirectStandardError = true;
                       processStartInfo.RedirectStandardInput = true;
                       processStartInfo.RedirectStandardOutput = true;
                       processStartInfo.CreateNoWindow = true;

                       Process process = new Process();
                       process.StartInfo = processStartInfo;
                       bool processStarted = process.Start();




                       if (File.Exists(sotc_path.SelectedItem.ToString() + @"\XAB"))
                       {

                           File.WriteAllBytes(@"index/index", Properties.Resources.index_pal);
                           File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_pal);
                           File.WriteAllBytes(@"index/xab.index", Properties.Resources.xab);
                           File.WriteAllBytes(@"index/xac.index", Properties.Resources.xac);
                           StreamWriter inputWriter = process.StandardInput;
                           inputWriter.WriteLine("cd index");
                           inputWriter.WriteLine("index_pal " + sotc_path.SelectedItem.ToString());
                           inputWriter.WriteLine("exit");
                           process.WaitForExit();
                           MessageBox.Show("PAL disc Found\nChanging complete!!", "Changed");
                           MyGlobal.disc_version = "pal";
                           label_disc_type.ForeColor = Color.Green;
                           label_disc_type.Text = "PAL";
                       }
                       else
                       {
                           FileInfo nico = new FileInfo(sotc_path.SelectedItem.ToString() + @"\NICO.DAT");
                           long tamanho = nico.Length / 1000000;

                           if (tamanho > 2700)
                           {
                               path_state.ForeColor = Color.DarkRed;
                               path_state.Text = "CHANGING...";
                               path_state.Visible = true;
                               File.WriteAllBytes(@"index/index", Properties.Resources.index_preview);
                               File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_preview);
                               StreamWriter inputWriter = process.StandardInput;
                               inputWriter.WriteLine("cd index");
                               inputWriter.WriteLine("index_ntsc " + sotc_path.SelectedItem.ToString());
                               inputWriter.WriteLine("exit");
                               process.WaitForExit();
                               MessageBox.Show("PREVIEW disc Found\nChanging complete!!", "Changed");
                               MyGlobal.disc_version = "preview";
                               label_disc_type.ForeColor = Color.Green;
                               label_disc_type.Text = "Preview";
                           }
                           else
                           {
                               if (tamanho < 700)
                               {
                                   if (tamanho < 685)
                                   {
                                       path_state.ForeColor = Color.DarkRed;
                                       path_state.Text = "CHANGING...";
                                       path_state.Visible = true;
                                       File.WriteAllBytes(@"index/index", Properties.Resources.index_opm);
                                       File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_opm);
                                       StreamWriter inputWriter = process.StandardInput;
                                       inputWriter.WriteLine("cd index");
                                       inputWriter.WriteLine("index_ntsc " + sotc_path.SelectedItem.ToString());
                                       inputWriter.WriteLine("exit");
                                       process.WaitForExit();
                                       MessageBox.Show("OPM DEMO disc Found\nChanging complete!!", "Changed");
                                       MyGlobal.disc_version = "opm";
                                       label_disc_type.ForeColor = Color.Green;
                                       label_disc_type.Text = "OPM Demo";

                                   }
                                   else
                                   {
                                       path_state.ForeColor = Color.DarkRed;
                                       path_state.Text = "CHANGING...";
                                       path_state.Visible = true;
                                       File.WriteAllBytes(@"index/index", Properties.Resources.index_psu);
                                       File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_psu);
                                       StreamWriter inputWriter = process.StandardInput;
                                       inputWriter.WriteLine("cd index");
                                       inputWriter.WriteLine("index_ntsc " + sotc_path.SelectedItem.ToString());
                                       inputWriter.WriteLine("exit");
                                       process.WaitForExit();
                                       MessageBox.Show("PSU DEMO disc Found\nChanging complete!!", "Changed");
                                       MyGlobal.disc_version = "psu";
                                       label_disc_type.ForeColor = Color.Green;
                                       label_disc_type.Text = "PSU Demo";

                                   }

                               }
                               else
                               {

                                   path_state.ForeColor = Color.DarkRed;
                                   path_state.Text = "CHANGING...";
                                   path_state.Visible = true;
                                   File.WriteAllBytes(@"index/index", Properties.Resources.index_ntsc);
                                   File.WriteAllBytes(@"index/nico.dat.index", Properties.Resources.nico_dat_ntsc);
                                   StreamWriter inputWriter = process.StandardInput;
                                   inputWriter.WriteLine("cd index");
                                   inputWriter.WriteLine("index_ntsc " + sotc_path.SelectedItem.ToString());
                                   inputWriter.WriteLine("exit");
                                   process.WaitForExit();
                                   MessageBox.Show("NTSC disc Found\nChanging complete!!", "Changed");
                                   MyGlobal.disc_version = "ntsc";
                                   label_disc_type.ForeColor = Color.Green;
                                   label_disc_type.Text = "NTSC";
                               }
                           }
                       }




                       process.WaitForExit();

                       System.IO.File.WriteAllText(@"path_saved" +
                        ".txt", sotc_path.SelectedItem.ToString());
                       pathed = true;
                       path_state.ForeColor = Color.Green;
                       path_state.Text = "CHANGED!!!";
                   }
                   else
                   {
                       MessageBox.Show("Shadow of the Colossus data not found", "ERROR");

                   }
               }
               else
               {
                   pathed = false;
               }
                   
                   
              
           }
           
              
    
        }

        private void nomad_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("3D_Model.obj"))
            {
                Process.Start("explorer", "3D_Model.obj");
            }
            else
            {
                MessageBox.Show("No OBJ 3D file found!!","ERROR");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void miscout_Click(object sender, EventArgs e)
        {
            Misc CF = new Misc();
            CF.Visible = true;
        }

        private void wanderout_Click(object sender, EventArgs e)
        {
            Advanced CF = new Advanced();
            CF.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Number of resources listed for each version:\n |-----PAL-------|\n Models: 5241   \n Animation: 2642\n Textures: 1580 \n SKBs: 48       \n TOTAL: 9511    \n |-----NTSC------|\n Models: 5239   \n Animation: 2626\n Textures: 1399 \n SKBs: 48       \n TOTAL: 9312    \n |----PREVIEW----|\n Models: 6418   \n Animation: 2470\n Textures: 1383 \n SKBs: 48       \n TOTAL: 10319   \n |------OPM-----|\n Models: 834   \n Animation: 948\n Textures: 633 \n SKBs: 18      \n TOTAL: 2433   \n |------PSU-----|\n Models: 838   \n Animation: 944\n Textures: 639 \n SKBs: 18      \n TOTAL: 2438   \n \n Each game version has different quantity of resources listed due to the viewer\n offset index script compatibility be limited. To get a maximum of resources\n listed, use SotC PAL version. To get beta extra models, use PREVIEW version.\n", "GAME DISK VERSION STATS");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
        
        
    }
}
