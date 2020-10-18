using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Memory;
using DiscordRPC;
using Among_Us_Shit.Pointers;
using System.Threading.Tasks;

namespace Among_Us_Shit
{
    public partial class Form1 : Form
    {
        public DiscordRpcClient client;
        public Mem m = new Mem();
        bool ProcOpen = false;



        public Form1()
        {
            InitializeComponent();
        }

        private string gameSettingsPointer(string lastOffset) => Pointer_Bases.gameSettingsBase + lastOffset;

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            client = new DiscordRpcClient("765685304438816799");
            client.Initialize();

            while (true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Doin Your Mum",
                    State = "Being Epic Hackerman",
                    Assets = new Assets()
                    {
                        LargeImageKey = "idl",
                        LargeImageText = "Cool Man"
                    }
                });
                await Task.Delay(1000);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                ProcOpen = m.OpenProcess("Among Us.exe");
                if (!ProcOpen) { Thread.Sleep(1000); continue; }
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(0);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    m.WriteMemory(gameSettingsPointer("4C"), "byte", "1");
                }
                else if (!checkBox1.Checked)
                {
                    m.WriteMemory(gameSettingsPointer("4C"), "byte", "0");
                }
            }
            catch { }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked)
                {
                    m.WriteMemory(gameSettingsPointer("4D"), "byte", "1");
                }
                else if (!checkBox2.Checked)
                {
                    m.WriteMemory(gameSettingsPointer("4D"), "byte", "0");
                }
            }
            catch { }
        }

        private void eMeetingsApply_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("30"), "int", textBox1.Text);
            }
            catch { }
        }

        private void eCooldown_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("34"), "int", textBox2.Text);
            }
            catch { }
        }

        private void dTime_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("44"), "int", textBox3.Text);
            }
            catch { }
        }

        private void vTime_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("48"), "int", textBox4.Text);
            }
            catch { }
        }

        private void pSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("14"), "float", textBox5.Text);
            }
            catch { }
        }

        private void cVision_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("18"), "float", textBox6.Text);
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("1C"), "float", textBox7.Text);
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("20"), "float", textBox8.Text);
            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Short")
                {
                    m.WriteMemory(gameSettingsPointer("40"), "int", "0");
                }

                else if (comboBox1.Text == "Normal")
                {
                    m.WriteMemory(gameSettingsPointer("40"), "int", "1");
                }

                else if (comboBox1.Text == "Long")
                {
                    m.WriteMemory(gameSettingsPointer("40"), "int", "2");
                }
            }
            catch { }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("24"), "int", textBox9.Text);
            }
            catch { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("28"), "int", textBox10.Text);
            }
            catch { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("2C"), "int", textBox11.Text);
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(Pointer_Bases.xCoordPointer, "float", textBox12.Text);
            }
            catch { }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(Pointer_Bases.yCoordPointer, "float", textBox13.Text);
            }
            catch { }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox3.Checked)
                {
                    m.WriteMemory(Pointer_Bases.rolesBase + "28", "byte", "1");
                }
                else if (!checkBox3.Checked)
                {
                    m.WriteMemory(Pointer_Bases.rolesBase + "28", "byte", "0");
                }
            }
            catch { }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox4.Checked)
                {
                    m.WriteMemory(Pointer_Bases.rolesBase + "29", "byte", "1");
                }
                else if (!checkBox4.Checked)
                {
                    m.WriteMemory(Pointer_Bases.rolesBase + "29", "byte", "0");
                }
            }
            catch { }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox6.Checked)
                {
                    m.WriteMemory(Pointer_Bases.cameraFrozenPointer, "byte", "1");
                }
                else if (!checkBox6.Checked)
                {
                    m.WriteMemory(Pointer_Bases.cameraFrozenPointer, "byte", "0");
                }
            }
            catch { }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox5.Checked)
                {
                    m.FreezeValue(Pointer_Bases.killCooldownPointer, "float", "0");
                }
                else if (!checkBox5.Checked)
                {
                    m.UnfreezeValue(Pointer_Bases.killCooldownPointer);
                }
            }
            catch { }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox7.Checked)
                {
                    m.FreezeValue(Pointer_Bases.noClip, "int", "14");
                }
                else if (!checkBox7.Checked)
                {
                    m.UnfreezeValue(Pointer_Bases.noClip);
                    m.WriteMemory(Pointer_Bases.noClip, "int", "8");
                }
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(Pointer_Bases.killCooldownPointer, "float", textBox14.Text);
            }
            catch { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(Pointer_Bases.taskListItems, "int", textBox14.Text);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "The Skeld")
                {
                    m.WriteMemory(gameSettingsPointer("10"), "int", "0");
                }

                else if (comboBox2.Text == "MIRA HQ")
                {
                    m.WriteMemory(gameSettingsPointer("10"), "int", "1");
                }

                else if (comboBox2.Text == "Polus")
                {
                    m.WriteMemory(gameSettingsPointer("10"), "int", "2");
                }
            }
            catch { }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory(gameSettingsPointer("38"), "int", textBox17.Text);
            }
            catch { }
        }
    }
}