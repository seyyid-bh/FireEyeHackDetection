using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace FireEyeHackDetection
{
    public partial class Form1 : Form
    {
        List<string> str = new List<string>();
        string myarch;
        string yara32;
        string yara64;
        string yararule;
        string firepath;
        string temppath;
        string listpath;
        string  pid;


        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select File Or Folder";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String myfile in openFileDialog1.FileNames)
                {
                    lstfile.Items.Add(Path.GetFullPath(myfile));
                    str.Add(myfile);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    foreach (string myfile in Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.AllDirectories))
                    {
                        lstfile.Items.Add(myfile);
                        str.Add(myfile);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            lstfile.Items.Clear();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            foreach (string s in lstfile.SelectedItems.OfType<string>().ToList())
                lstfile.Items.Remove(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                arcos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        bool checkfile(string files, string flag, string lblflag)
        {

            if (lblflag != "rule")
            {
                if (File.Exists(files))
                {
                    lbly32.Text = String.Format("File '{0}' is Find in '/yara/{0}'", flag);
                    return true;
                }
                else
                {
                    lbly32.Text = String.Format("File {0} is not Find in '/yara/{0}'", flag);
                    return false;
                }
            }
            else if(lblflag=="rule")
            {
                if (File.Exists(files))
                {
                    lblyarar.Text = String.Format("File '{0}' is Find in '/yara/{0}'", flag);
                    return true;
                }
                else
                {
                    lblyarar.Text = String.Format("File '{0}' is not Find in '/yara/{0}'", flag);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Some wrong!");
                return false;
            }
        }

        void arcos()
        {
            string osstr = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            firepath = AppDomain.CurrentDomain.BaseDirectory;
            yara32 = Path.Combine(firepath, @"yara\yara32.exe");
            yara64 = Path.Combine(firepath, @"yara\yara64.exe");
            yararule = Path.Combine(firepath, @"yara\all-yara.yar");
            temppath= Path.Combine(firepath, @"temp.dat");
            listpath = Path.Combine(firepath, @"list.txt");
            bool aexe = false;
            bool ayara = false;

            if (osstr.Contains("32"))
            {
                lblsystem.Text = "Your System Detect: 32bit";
                aexe = checkfile(yara32, "yara32.exe", "yara");
                ayara = checkfile(yararule, "all-yara.yar", "rule");
                myarch = "32";
                if (aexe && ayara == true)
                {
                    btnscn.Enabled = true;
                }
                else
                {
                    btnscn.Enabled = false;
                }
            }
            else
            {
                lblsystem.Text = "Your System Detect: 64bit";
                aexe = checkfile(yara32, "yara64.exe", "yara");
                ayara = checkfile(yara32, "all-yara.yar", "rule");
                myarch = "64";
                if (aexe && ayara == true)
                {
                    btnscn.Enabled = true;
                }
                else
                {
                    btnscn.Enabled = true;
                }
            }
            deletme(temppath);
            deletme(listpath);
        }
        void yararun()
        {
            
            System.Diagnostics.ProcessStartInfo hyp = new System.Diagnostics.ProcessStartInfo("cmd");
            hyp.RedirectStandardInput = true;
            hyp.RedirectStandardOutput = true;
            hyp.UseShellExecute = false;
            hyp.CreateNoWindow = true;
            
            // Start the procses.
            Process proc = Process.Start(hyp);

            try
            {
                if (myarch == "32")
                {
                    string argo ="\""+ yara32 + "\"" + " -c -m -g -s --scan-list " + "\"" + yararule+ "\" \"" + listpath + "\""+ ">>" + "\""+temppath + "\" && exit";
                    proc.StandardInput.WriteLine(argo);
                }
                else
                {
                    string argo ="\"" + yara64 + "\"" + " -c -m -g -s --scan-list " + "\"" + yararule + "\" \"" + listpath + "\"" + ">>" + "\"" + temppath + "\" && exit";
                    proc.StandardInput.WriteLine(argo);
                }

                // Exit the application.

                proc.StandardInput.WriteLine(@"exit");

                string output = proc.StandardOutput.ReadToEnd();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnscn_Click(object sender, EventArgs e)
        {
            
            List<string> distinct = str.Distinct().ToList();
            string mytime = "Scan Time: " + DateTime.Now.ToString("yyyy-MM-dd_hh:mm:ss");
            string pcname = "Scan System name: " + Environment.MachineName;
            string timemachine = mytime + Environment.NewLine + pcname + Environment.NewLine;
            

            try
            {
                deletme(temppath);
                File.WriteAllText(temppath, timemachine);
                File.WriteAllLines(listpath, distinct.ToArray());

                yararun();
                MessageBox.Show("Scan Complete");
                richTextBox1.Text = File.ReadAllText(temppath);
                deletme(listpath);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void deletme(string path)
        {
            if (File.Exists(path))
                {
                File.Delete(path);
            }
                
            
        }

        private void btnlstpr_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] allProc = Process.GetProcesses();
                foreach (Process p in allProc)
                {
                    lstproc.Items.Add(p.ProcessName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnscp_Click(object sender, EventArgs e)
        {
            string mytime = "Scan Time: " + DateTime.Now.ToString("yyyy-MM-dd_hh:mm:ss");
            string pcname = "Scan System name: " + Environment.MachineName;
            
            
            try
            {
                deletme(temppath);
                

                string procsel = lstproc.SelectedItem.ToString();
                Process[] allProc = Process.GetProcesses();
                
                foreach (Process p in allProc)
                {
                    if (p.ProcessName == procsel)
                    {
                        pid = p.Id.ToString();
                    }
                }
                string pname = "Process Name: "+ procsel;
                string mypid = "Process ID: "+pid;
                string timemachine = mytime + Environment.NewLine + pcname + Environment.NewLine + pname + Environment.NewLine + mypid + Environment.NewLine;
                File.WriteAllText(temppath, timemachine);
                yaraproc(pid);
                MessageBox.Show("Scan Complete");
                richTextBox1.Text = File.ReadAllText(temppath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void yaraproc(string mypid)
        {

            ProcessStartInfo hyp = new ProcessStartInfo("cmd");
            hyp.RedirectStandardInput = true;
            hyp.RedirectStandardOutput = true;
            hyp.UseShellExecute = false;
            hyp.CreateNoWindow = true;

            // Start the procses.
            Process proc = Process.Start(hyp);

            try
            {
                if (myarch == "32")
                {
                    string argo = "\"" + yara32 + "\"" + " -c -m -g -s \"" + yararule + "\" " + mypid + ">>\""+ temppath + "\" && exit";
                    proc.StandardInput.WriteLine(argo);
                }
                else
                {
                    string argo = "\"" + yara64 + "\"" + " -c -m -g -s \"" + yararule + "\" " + mypid + ">>\""+ temppath + "\" && exit";
                    proc.StandardInput.WriteLine(argo);
                }

                // Exit the application.

                proc.StandardInput.WriteLine(@"exit");

                string output = proc.StandardOutput.ReadToEnd();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            try
            {
                string rul=wc.DownloadString("https://raw.githubusercontent.com/fireeye/red_team_tool_countermeasures/master/all-yara.yar");
                File.WriteAllText(yararule,rul);
                MessageBox.Show("Update Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            Form2 aboutWindow = new Form2();
            aboutWindow.Show();
        }
    }


}
