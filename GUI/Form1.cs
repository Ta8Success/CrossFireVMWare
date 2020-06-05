using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputSimulator;
using System.Management;
using System.Threading;
using System.Diagnostics;

namespace GUI
{
    public partial class Form1 : Form
    {
        public static Boolean FormAlive { get; set; } = false;
        public static Boolean WalkedToBot { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxDebug.Enabled = false;
            checkBoxDebug.Visible = false;

            radioWin7.Checked = true;
            FormAlive = true;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Process regeditProcess = Process.Start("regedit.exe", "/s UAC.dll");
            regeditProcess.WaitForExit();

            if (radioWin10.Checked == false && radioWin7.Checked == false)
            {
                MessageBox.Show(this, "No OS selected", "Error: select OS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioWin7.Checked == true)
            {
                Process process = new Process();
                process.StartInfo.FileName = "psexec.exe";
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = $@"-i -s -d {Environment.CurrentDirectory}\BypassRunner.exe -win7";
                process.Start();
            }
            else if (radioWin10.Checked == true)
            {
                Process process = new Process();
                process.StartInfo.FileName = "psexec.exe";
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = $@"-i -s -d {Environment.CurrentDirectory}\BypassRunner.exe -win10";
                process.Start();
            }
            buttonPatch.Text = "Patched";
            buttonPatch.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAlive = false;
            if (radioWin7.Checked == true)
            {
                Process process = new Process();
                process.StartInfo.FileName = "psexec.exe";
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = $@"-i -s -d {Environment.CurrentDirectory}\BypassRunner.exe -unpatch7";
                process.Start();
                process.WaitForExit();
            }
            else if (radioWin10.Checked == true)
            {
                Process process = new Process();
                process.StartInfo.FileName = "psexec.exe";
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = $@"-i -s -d {Environment.CurrentDirectory}\BypassRunner.exe -unpatch10";
                process.Start();
                process.WaitForExit();
            }
            foreach (var process in Process.GetProcessesByName("GUI"))
            {
                process.Kill();
            }
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            buttonStart.Text = "Running ...";
            buttonStart.Enabled = false;

            new Thread(() =>
            {
                while (FormAlive)
                {
                    new System.Threading.ManualResetEvent(false).WaitOne(200);
                    if (checkBoxAutoReady.Checked == true)
                    {
                        Rectangle readyBtn = OptImageSearch.FindCoods("Ready_Button.png", new Rectangle(0, 0, 1279, 800));
                        if (readyBtn.Width > 0 || readyBtn.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(new Point(515,180), 55); // Joining BlackList
                            InputSimulator.MouseAPI.Main.LeftClick(readyBtn.Center(), 55); // Going Ready
                        }
                        Rectangle okBtn = OptImageSearch.FindCoods("OK_Button.png", new Rectangle(0, 0, 1279, 800));
                        if (okBtn.Width > 0 || okBtn.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn.Center(), 55);
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn.Center(), 55);
                        }
                        Rectangle okBtn2 = OptImageSearch.FindCoods("OK_Button_2.png", new Rectangle(0, 0, 1279, 800));
                        if (okBtn2.Width > 0 || okBtn2.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn2.Center(), 55);
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn2.Center(), 55);
                        }
                        Rectangle archievBtn = OptImageSearch.FindCoods("Achievement_Button.png", new Rectangle(0, 0, 1279, 800));
                        if (archievBtn.Width > 0 || archievBtn.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn.Center(), 55);
                        }
                    }

                    if (checkBoxStart.Checked == true)
                    {
                        Rectangle okBtn = OptImageSearch.FindCoods("OK_Button.png", new Rectangle(0, 0, 1279, 800));
                        if (okBtn.Width > 0 || okBtn.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn.Center(), 55);
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn.Center(), 55);
                        }
                        Rectangle okBtn2 = OptImageSearch.FindCoods("OK_Button_2.png", new Rectangle(0, 0, 1279, 800));
                        if (okBtn2.Width > 0 || okBtn2.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn2.Center(), 55);
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn2.Center(), 55);
                        }
                        Rectangle archievBtn = OptImageSearch.FindCoods("Achievement_Button.png", new Rectangle(0, 0, 1279, 800));
                        if (archievBtn.Width > 0 || archievBtn.Height > 0)
                        {
                            InputSimulator.MouseAPI.Main.LeftClick(okBtn.Center(), 55);
                        }
                        Rectangle startBtn = OptImageSearch.FindCoods("Start_Button.png", new Rectangle(0, 0, 1279, 800));
                        if (startBtn.Width > 0 || startBtn.Height > 0)
                        {
                            WalkedToBot = false;
                            int startDelay = int.TryParse(comboBoxStartDelay.Text, out startDelay) ? startDelay : 10000;
                            KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.RETURN);
                            KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.RETURN);
                            new System.Threading.ManualResetEvent(false).WaitOne(startDelay);
                            InputSimulator.MouseAPI.Main.LeftClick(new Point(870,195), 55);
                            InputSimulator.MouseAPI.Main.LeftClick(startBtn.Center(), 55);
                            InputSimulator.MouseAPI.Main.LeftClick(startBtn.Center(), 55);
                        }
                    }

                    if (checkBoxFarm.Checked == true)
                    {
                        Rectangle ingame = OptImageSearch.FindCoods("Ingame_GR.png", new Rectangle(0, 0, 1279, 800));
                        if (ingame.Width > 0 || ingame.Height > 0)
                        {
                            if (WalkedToBot == false)
                            {
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_3);       // Change to Knife
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_A, 6666);     // Base Wall Left
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_D, 1999);     // Base Middle -> LOS Doors
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_W, 5555);     // Walking to Doors
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_A, 500);      // Make Sure to hit Hole
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_W, 15555);    // Walking trough Doors
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_D, 6666);     // Walking to Red-White
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_A, 1000);     // Walking to Base Entry Middle
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_W, 2222);     // Walking to First Corner
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_D, 1111);     // Walking to Right Wall
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_W, 2222);     // Walking to Bots Face
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.KEY_S, 199);       // Stepping a little back
                                switch (comboBoxWeapon.Text)
                                {
                                    case "Primary":
                                        KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_1);
                                        break;

                                    case "Secondary":
                                        KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_2);
                                        break;

                                    case "Knife":
                                        KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_3);
                                        break;
                                }
                                if (textBoxHeadPos.Text.Contains(","))
                                {
                                    String[] coords = textBoxHeadPos.Text.Split(',');
                                    int[] coordsInt = Array.ConvertAll(coords, s => int.Parse(s));
                                    if (coordsInt.Length >= 2)
                                    {
                                        MouseAPI.Only.OMouseDrag(coordsInt[0], coordsInt[1]);
                                    }
                                }

                                if (checkBoxSniper.Checked == true)
                                {
                                    MouseAPIEX.RightClick();
                                    new System.Threading.ManualResetEvent(false).WaitOne(1000);
                                    MouseAPIEX.RightClick();
                                }
                                WalkedToBot = true;
                            }
                            else if (WalkedToBot == true)
                            {
                                Int32 shootDelay = 2500;
                                Int32.TryParse(textBoxShootDelay.Text, out shootDelay);
                                new System.Threading.ManualResetEvent(false).WaitOne(shootDelay);
                                switch (comboBoxWeapon.Text)
                                {
                                    case "Primary":
                                        MouseAPIEX.OLeftClick();
                                        break;

                                    case "Secondary":
                                        MouseAPIEX.OLeftClick();
                                        break;

                                    case "Knife":
                                        MouseAPIEX.RightClick();
                                        break;
                                }
                                KeyboardAPI.HoldKey(KeyboardAPI.ScanCodeShort.F5, 55);          // Spam Chat
                            }
                        }
                    }

                    if (checkBoxAntiAFK.Checked == true || checkBoxDeathRun.Checked == true)
                    {
                        Rectangle ingame = OptImageSearch.FindCoods("Ingame_BL.png", new Rectangle(0, 0, 1279, 800));
                        if (ingame.Width > 0 || ingame.Height > 0)
                        {
                            if (checkBoxDeathRun.Checked == true)
                            {
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_3);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_A);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_3);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_S);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_3);
                            }
                            else if (checkBoxAntiAFK.Checked == true)
                            {
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_3);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.F5);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_F);
                                KeyboardAPI.Send(KeyboardAPI.ScanCodeShort.KEY_2);
                            }
                        }
                    }
                }
            }).Start();
        }
    }
}
