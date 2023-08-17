using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;
using Microsoft.VisualBasic.Devices;
using monitor.Properties;
using Mono.Unix;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;
using Computer = LibreHardwareMonitor.Hardware.Computer;

namespace monitor
{
    public partial class Form1 : Form
    {
        private readonly Computer _computer;
        private bool _warningTripped = false;
        private bool _critTripped = false;
        private Form s;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l); // why why why why why why

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);
        [DllImport("kernel32")]
        extern static UInt64 GetTickCount64();
        public Form1()
        {
            s = new SettingsPage();
            InitializeComponent();

            _computer = new Computer
            {
                IsCpuEnabled = true
            };
            _computer.Open();

            RefreshTimer.Interval = Settings.Default.UpdateInterval;

            Settings.Default.PropertyChanged += SettingsChanged;

            RefreshTimer.Tick += TimerRefresh;
            FormClosing += (_, e) =>
            {
                Hide();
                if (!Settings.Default.AcknowledgedSystemTrayIcon)
                {
                    notifyIcon1.ShowBalloonTip(5, "Minimised to Tray", "CoreTemp is automatically minimised to the system tray when you close it. To quit, right-click the icon and click Exit.", ToolTipIcon.Info);
                    Settings.Default.AcknowledgedSystemTrayIcon = true;
                    Settings.Default.Save();
                }
                e.Cancel = true;
            };
            exitToolStripMenuItem.Click += (_, _) => Environment.Exit(0);
            SettingsButton.Click += (_, _) =>
            {
                s.Dispose();
                s = new SettingsPage();
                s.Show();
            };
            notifyIcon1.MouseClick += (_, _) =>
            {
                Show();
            };

            for (int i = 0; i < Settings.Default.GraphResolution; i++)
            {
                chart1.Series[0].Points.AddY(0);
            }
        }

        private void SettingsChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "UpdateInterval") RefreshTimer.Interval = Settings.Default.UpdateInterval;
        }

        private void TimerRefresh(object? sender, EventArgs e)
        {
            UpdateInfo();
        }

        public void UpdateInfo()
        {
            _computer.Accept(new UpdateVisitor());
            var sensor = _computer.Hardware[0].Sensors.First(s => s.SensorType == SensorType.Temperature);
            var _tempColor = sensor.Value switch
            {
                > 100 => Color.Purple,
                > 90 => Color.Red,
                > 80 => Color.OrangeRed,
                > 70 => Color.DarkOrange,
                > 60 => Color.Orange,
                > 50 => Color.Yellow,
                > 40 => Color.CornflowerBlue,
                > 20 => Color.Blue,
                > 0 => Color.DarkBlue,
            };

            if (chart1.Series[0].Points.Count == Settings.Default.GraphResolution) chart1.Series[0].Points.RemoveAt(0);
            else if (chart1.Series[0].Points.Count > Settings.Default.GraphResolution)
            {
                while (chart1.Series[0].Points.Count >= Settings.Default.GraphResolution) chart1.Series[0].Points.RemoveAt(0);
            }


            HardwareNameLabel.Text = _computer.Hardware[0].Name;
            SensorNameLabel.Text = $"Sensor: {sensor.Name}";
            TempLabel.Text = $"{Math.Round((double)sensor.Value)}℃";

            TemperatureStatus.Text = sensor.Value switch
            {
                > 100 => "WHAT ARE YOU DOING?!?!",
                > 90 => "Get a better cooler. PLEASE.",
                > 80 => "Cook something at this point",
                > 70 => "Hot",
                > 60 => "Really warm",
                > 50 => "Warm",
                > 40 => "Cool",
                > 20 => "Really chilly",
                > 0 => "Probably freezing",
            };

            StatusIcon.Image = sensor.Value switch
            {
                > 80 => Resources.ripcpu,
                > 50 => Resources.poorcpu,
                > 0 => Resources.nicecpu
            };

            tempBar.Value = (int)sensor.Value;
            TemperatureStatus.BackColor = _tempColor;

            unsafe
            {
                using (Bitmap bmp = new Bitmap(16, 16))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawRectangle(new Pen(new SolidBrush(Color.Red)), new Rectangle(new Point(14, 2), new Size(1, 12)));
                        g.DrawRectangle(new Pen(new SolidBrush(Color.White)), new Rectangle(new Point(14, 2), new Size(1, 12 - (int)((sensor.Value / 100) * 12))));
                        g.DrawString(Math.Round((double)sensor.Value).ToString(), new Font(FontFamily.GenericSansSerif, 8), new SolidBrush(_tempColor), new PointF(-2, 4));
                        if (_critTripped) g.DrawImage(Resources.critical, new RectangleF(0, 0, 8, 8));
                        else if (_warningTripped) g.DrawImage(Resources.warning, new RectangleF(0, 0, 8, 8));
                        g.Dispose();
                    }
                    IntPtr hicon = bmp.GetHicon();
                    Icon icon = Icon.FromHandle(hicon);
                    notifyIcon1.Icon = icon;
                    notifyIcon1.Text = $"{sensor.Name}: {sensor.Value}°";
                    icon.Dispose();
                    DestroyIcon(hicon); // destroy icon to prevent creating 50 billion dead handles
                }
            }

            if (sensor.Value > Settings.Default.WarningTemperature)
            {
                if (sensor.Value > Settings.Default.CriticalTemperature)
                {
                    if (!_critTripped)
                    {
                        notifyIcon1.ShowBalloonTip(10, "Warning!!!", $"Temperature exceeded critical threshold ({Settings.Default.CriticalTemperature}℃)", ToolTipIcon.Error);
                        SendMessage(tempBar.Handle, 1040, (IntPtr)2, IntPtr.Zero); // ugly ahh hack but it works
                        CritIcon.Enabled = true;
                        _critTripped = true;
                    }
                }
                else
                {
                    _critTripped = false;
                    CritIcon.Enabled = false;
                    if (!_warningTripped)
                    {
                        notifyIcon1.ShowBalloonTip(10, "Warning!", $"Temperature exceeded warning threshold ({Settings.Default.WarningTemperature}℃)", ToolTipIcon.Warning);
                        WarnIcon.Enabled = true;
                        SendMessage(tempBar.Handle, 1040, (IntPtr)3, IntPtr.Zero); // ugly ahh hack but it works
                        _warningTripped = true;
                    }
                }
            }
            else
            {
                SendMessage(tempBar.Handle, 1040, (IntPtr)1, IntPtr.Zero);
                WarnIcon.Enabled = false;
                _warningTripped = false;
            }

            int p = chart1.Series[0].Points.AddY(sensor.Value);
            chart1.Series[0].Points[p].Color = _tempColor;
        }
    }

    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }
        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }
    }
}