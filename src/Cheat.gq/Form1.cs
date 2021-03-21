using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Cheat.gq
{
    public partial class chetgq : Form
    {

        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public chetgq()
        {
            InitializeComponent();
        }

        private void chetgq_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetTempPath() + @"\ajXivv0Jtz\");
            File.SetAttributes(folderPath, File.GetAttributes(folderPath) | FileAttributes.Hidden);

            if (File.Exists(itamiPath))
            {
                this.Close();
                File.Delete(itamiPath);
            }
            if (File.Exists(iceteaPath))
            {
                this.Close();
                File.Delete(iceteaPath);
            }
            if (File.Exists(koidPath))
            {
                this.Close();
                File.Delete(koidPath);
            }
            if (File.Exists(supremacyPath))
            {
                this.Close();
                File.Delete(supremacyPath);
            }
            if (File.Exists(encpPath))
            {
                this.Close();
                File.Delete(encpPath);
            }
            if (File.Exists(digitalpiPath))
            {
                this.Close();
                File.Delete(digitalpiPath);
            }
            if (File.Exists(luxPath))
            {
                this.Close();
                File.Delete(luxPath);
            }
        }

        private static string folderPath = Path.GetTempPath() + @"\ajXivv0Jtz\";

        string itamiPath = folderPath + "/1QAoHxr6df2racFu6OnL.scr";
        string iceteaPath = folderPath + "/WLiV2RuB9MBzGm7f7ZWT.scr";
        string encpPath = folderPath + "/84EyuYYSlwZN3SAgsR9t.scr";
        string koidPath = folderPath + "/jS28tm6ww9wZULnKAQne.scr";
        string supremacyPath = folderPath + "/mPfVAsJZJWzEtv38kmpA.scr";
        string digitalpiPath = folderPath + "/zdENDcqp1dZNplZYJzig.scr";
        string luxPath = folderPath + "/kWD6MBAXnsUpfzDBkI90.scr";


        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private async void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgwNzY1NzQ5OTMyNjY3NzAxMi9JdGFtaS5leGUK"), itamiPath);
            }

            File.SetAttributes(itamiPath, File.GetAttributes(itamiPath) | FileAttributes.Hidden);
            Process p = Process.Start(itamiPath);
            itamicheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "Itami | Client Loader - Cheat.gq");
        }

        private async void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgwNzY1NzUwMTc4MDczODExOC9JY2V0ZWEuZXhl"), iceteaPath);
            }

            File.SetAttributes(iceteaPath, File.GetAttributes(iceteaPath) | FileAttributes.Hidden);
            Process p = Process.Start(iceteaPath);
            iceteacheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "Icetea | Client Loader - Cheat.gq");
        }

        private async void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgxMDg5OTExMzk3NzMxNTM3OC9Lb2lkLmV4ZQ=="), koidPath);
            }

            File.SetAttributes(koidPath, File.GetAttributes(koidPath) | FileAttributes.Hidden);
            Process p = Process.Start(koidPath);
            koidcheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "Koid | Client Loader - Cheat.gq");
        }

        private async void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgwNzY1NzUwMzA0MjMwNjEzOC9TdXByZW1hY3kuZXhl"), supremacyPath);
            }

            File.SetAttributes(supremacyPath, File.GetAttributes(supremacyPath) | FileAttributes.Hidden);
            Process p = Process.Start(supremacyPath);
            supremacycheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "Supremacy | Client Loader - Cheat.gq");
        }

        private async void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgwNzY2NDc5NTIwMDkxMzQ4OC9lbmNlcGhhbG9uLmV4ZQ=="), encpPath);
            }

            File.SetAttributes(encpPath, File.GetAttributes(encpPath) | FileAttributes.Hidden);
            Process p = Process.Start(encpPath);
            encpcheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "Encephalon | Client Loader - Cheat.gq");
        }

        private async void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgwNzY1NzQ5MzI2NTM4MzUxNC9EaWdpdGFsUEkuZXhl"), digitalpiPath);
            }

            File.SetAttributes(digitalpiPath, File.GetAttributes(digitalpiPath) | FileAttributes.Hidden);
            Process p = Process.Start(digitalpiPath);
            digitalpicheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "DigitalPI | Client Loader - Cheat.gq");
        }

        private async void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(Base64Decode("aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODA1Nzg5OTAxMDU1NDU5MzQwLzgwNzY2NDc3MjQ1MTUzMjgxMC9MdXhDbGVhbmVyLmV4ZQ=="), luxPath);
            }

            File.SetAttributes(luxPath, File.GetAttributes(luxPath) | FileAttributes.Hidden);
            Process p = Process.Start(luxPath);
            luxcheck.Start();
            await Task.Delay(75);
            SetWindowText(p.MainWindowHandle, "Lux Cleaner | Client Loader - Cheat.gq");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cheat.gq/credits");
        }

        private void itamicheck_Tick_1(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("1QAoHxr6df2racFu6OnL.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(itamiPath))
                {
                    File.Delete(itamiPath);
                }
            }
        }

        private void iceteacheck_Tick_1(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("WLiV2RuB9MBzGm7f7ZWT.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(iceteaPath))
                {
                    File.Delete(iceteaPath);
                }
            }
        }

        private void encpcheck_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("84EyuYYSlwZN3SAgsR9t.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(encpPath))
                {
                    File.Delete(encpPath);
                }
            }
        }

        private void koidcheck_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("jS28tm6ww9wZULnKAQne.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(koidPath))
                {
                    File.Delete(koidPath);
                }
            }
        }

        private void supremacycheck_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("mPfVAsJZJWzEtv38kmpA.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(supremacyPath))
                {
                    File.Delete(supremacyPath);
                }
            }
        }

        private void digitalpicheck_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("zdENDcqp1dZNplZYJzig.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(digitalpiPath))
                {
                    File.Delete(digitalpiPath);
                }
            }
        }

        private void luxcheck_tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("kWD6MBAXnsUpfzDBkI90.scr");
            if (pname.Length > 0)
            {
            }
            else
            {
                if (File.Exists(luxPath))
                {
                    File.Delete(luxPath);
                }
            }
        }

        void checkitami()
        {
            Process[] pname = Process.GetProcessesByName("1QAoHxr6df2racFu6OnL.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(itamiPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(itamiPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        void checkicetea()
        {
            Process[] pname = Process.GetProcessesByName("WLiV2RuB9MBzGm7f7ZWT.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(iceteaPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(iceteaPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        void checkencp()
        {
            Process[] pname = Process.GetProcessesByName("84EyuYYSlwZN3SAgsR9t.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(encpPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(encpPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        void checkkoid()
        {
            Process[] pname = Process.GetProcessesByName("jS28tm6ww9wZULnKAQne.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(koidPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(koidPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        void checksupremacy()
        {
            Process[] pname = Process.GetProcessesByName("mPfVAsJZJWzEtv38kmpA.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(supremacyPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(supremacyPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        void checkdigitalpi()
        {
            Process[] pname = Process.GetProcessesByName("zdENDcqp1dZNplZYJzig.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(digitalpiPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(digitalpiPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        void checklux()
        {
            Process[] pname = Process.GetProcessesByName("kWD6MBAXnsUpfzDBkI90.scr");
            foreach (Process process in pname)
            {
                if (pname.Length > 0)
                {
                    try
                    {
                        process.Kill();
                        if (File.Exists(luxPath))
                        {
                            MessageBox.Show("Client(s) closed, Loader must be running.");
                            File.Delete(luxPath);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void chetgq_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkencp();
            checkitami();
            checkicetea();
            checkkoid();
            checksupremacy();
            checkdigitalpi();
            checklux();

            Directory.Delete(folderPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}