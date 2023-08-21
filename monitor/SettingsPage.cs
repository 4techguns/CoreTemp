using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
            Settings.Default.Upgrade();

            GlobalComputer.Computer.Open();
            GlobalComputer.Computer.Accept(new UpdateVisitor());

            var hw = GlobalComputer.Computer.Hardware.Where(j =>
                j.Sensors.Where(s => s.SensorType == SensorType.Temperature).Count() > 0);
            DevicePicker.Items.Clear();
            DevicePicker.Items.Add("(First CPU)");
            foreach (IHardware h in hw)
                DevicePicker.Items.Add(h.Name);

            RefreshSensors();

            ReloadSettings();

            GraphResolutionField.ValueChanged += GraphResolutionField_ValueChanged;

            WarnThresholdField.ValueChanged += WarnThresholdField_ValueChanged;
            WarningThresholdSlider.ValueChanged += WarningThresholdSlider_ValueChanged;
            CritThresholdField.ValueChanged += CritThresholdField_ValueChanged;
            CritThresholdSlider.ValueChanged += CritThresholdSlider_ValueChanged;

            UpdateIntervalField.ValueChanged += UpdateIntervalField_ValueChanged;
            NotificationToggle.CheckedChanged += NotificationToggle_CheckedChanged;
            TrayIconToggle.CheckedChanged += TrayIconToggle_CheckedChanged;
            WarningIndicatorsToggle.CheckedChanged += WarningIndicatorsToggle_CheckedChanged;
            SensorPicker.SelectedValueChanged += SensorPicker_SelectedValueChanged;
            IconThemePicker.SelectedValueChanged += IconThemePicker_SelectedValueChanged;
            DevicePicker.SelectedValueChanged += DevicePicker_SelectedValueChanged;

            SaveButton.Click += SaveButton_Click;
            ResetDefaultsButton.Click += ResetDefaultsButton_Click;

        }

        private void DevicePicker_SelectedValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.DeviceToMeasure = (string)DevicePicker.SelectedItem;
        }

        private void GraphResolutionField_ValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.GraphResolution = (int)GraphResolutionField.Value;
        }

        private void IconThemePicker_SelectedValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.TrayTheme = (string)IconThemePicker.SelectedItem;
        }

        private void CritThresholdSlider_ValueChanged(object? sender, EventArgs e)
        {
            CritThresholdField.Value = CritThresholdSlider.Value;
        }

        private void WarningThresholdSlider_ValueChanged(object? sender, EventArgs e)
        {
            WarnThresholdField.Value = WarningThresholdSlider.Value;
        }

        private void ReloadSettings()
        {
            GraphResolutionField.Value = Settings.Default.GraphResolution;

            WarnThresholdField.Value = (decimal)Settings.Default.WarningTemperature;
            WarningThresholdSlider.Value = (int)Settings.Default.WarningTemperature;

            CritThresholdField.Value = (decimal)Settings.Default.CriticalTemperature;
            CritThresholdSlider.Value = (int)Settings.Default.CriticalTemperature;

            UpdateIntervalField.Value = (decimal)Settings.Default.UpdateInterval;
            NotificationToggle.Checked = Settings.Default.EnableNotifications;
            TrayIconToggle.Checked = Settings.Default.EnableTrayIcon;
            WarningIndicatorsToggle.Checked = Settings.Default.EnableWarningIndicators;
            SensorPicker.SelectedItem = Settings.Default.SensorToMeasure;
            IconThemePicker.SelectedItem = Settings.Default.TrayTheme;
            DevicePicker.SelectedItem = Settings.Default.DeviceToMeasure;

            WarnThresholdField.Enabled = WarningIndicatorsToggle.Checked;
            WarningThresholdSlider.Enabled = WarningIndicatorsToggle.Checked;
            CritThresholdField.Enabled = WarningIndicatorsToggle.Checked;
            CritThresholdSlider.Enabled = WarningIndicatorsToggle.Checked;

            IconThemePicker.Enabled = TrayIconToggle.Checked;

            if (!WarningIndicatorsToggle.Checked)
                NotificationToggle.Checked = false;
        }

        private void RefreshSensors()
        {
            var hw = GlobalComputer.Computer.Hardware;
            IHardware? n = null;
            if (Settings.Default.DeviceToMeasure == "(First CPU)")
                n = hw.First(w => w.HardwareType == HardwareType.Cpu);
            else
                n = hw.First(w => w.Name == Settings.Default.DeviceToMeasure
                && w.Sensors.Where(s => s.SensorType == SensorType.Temperature).Count() > 0);
            var tempSensors = n.Sensors.Where(s => s.SensorType == SensorType.Temperature);

            SensorPicker.Items.Clear();
            SensorPicker.Items.Add("(First Sensor)");
            foreach (ISensor sensor in tempSensors)
                SensorPicker.Items.Add(sensor.Name);
        }

        private void SensorPicker_SelectedValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.SensorToMeasure = (string)SensorPicker.SelectedItem;
        }

        private void WarningIndicatorsToggle_CheckedChanged(object? sender, EventArgs e)
        {
            Settings.Default.EnableWarningIndicators = WarningIndicatorsToggle.Checked;
            WarnThresholdField.Enabled = WarningIndicatorsToggle.Checked;
            WarningThresholdSlider.Enabled = WarningIndicatorsToggle.Checked;
            CritThresholdField.Enabled = WarningIndicatorsToggle.Checked;
            CritThresholdSlider.Enabled = WarningIndicatorsToggle.Checked;

            NotificationToggle.Enabled = WarningIndicatorsToggle.Checked;

            if (!WarningIndicatorsToggle.Checked)
                NotificationToggle.Checked = false;
        }

        private void TrayIconToggle_CheckedChanged(object? sender, EventArgs e)
        {
            Settings.Default.EnableTrayIcon = TrayIconToggle.Checked;
            IconThemePicker.Enabled = TrayIconToggle.Checked;
        }

        private void NotificationToggle_CheckedChanged(object? sender, EventArgs e)
        {
            Settings.Default.EnableNotifications = NotificationToggle.Checked;
        }

        private void UpdateIntervalField_ValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.UpdateInterval = (int)UpdateIntervalField.Value;
        }

        private void ResetDefaultsButton_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the settings to their defaults?", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Settings.Default.Reset();
                Settings.Default.Save();
                ReloadSettings();
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void CritThresholdField_ValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.CriticalTemperature = (double)CritThresholdField.Value;
            CritThresholdSlider.Value = (int)CritThresholdField.Value;
        }

        private void WarnThresholdField_ValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.WarningTemperature = (double)WarnThresholdField.Value;
            WarningThresholdSlider.Value = (int)WarnThresholdField.Value;
        }
    }
}
