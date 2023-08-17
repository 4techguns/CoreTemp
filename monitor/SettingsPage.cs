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

            GraphResolutionField.Value = Settings.Default.GraphResolution;
            WarnThresholdField.Value = (decimal)Settings.Default.WarningTemperature;
            CritThresholdField.Value = (decimal)Settings.Default.CriticalTemperature;
            UpdateIntervalField.Value = (decimal)Settings.Default.UpdateInterval;


            GraphResolutionField.ValueChanged += GraphResolutionField_ValueChanged;
            WarnThresholdField.ValueChanged += WarnThresholdField_ValueChanged;
            CritThresholdField.ValueChanged += CritThresholdField_ValueChanged;
            UpdateIntervalField.ValueChanged += UpdateIntervalField_ValueChanged;

            SaveButton.Click += SaveButton_Click;
            ResetDefaultsButton.Click += ResetDefaultsButton_Click;
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
                GraphResolutionField.Value = Settings.Default.GraphResolution;
                WarnThresholdField.Value = (decimal)Settings.Default.WarningTemperature;
                CritThresholdField.Value = (decimal)Settings.Default.CriticalTemperature;
                UpdateIntervalField.Value = (decimal)Settings.Default.UpdateInterval;
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
        }

        private void WarnThresholdField_ValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.WarningTemperature = (double)WarnThresholdField.Value;
        }

        private void GraphResolutionField_ValueChanged(object? sender, EventArgs e)
        {
            Settings.Default.GraphResolution = (int)GraphResolutionField.Value;
        }
    }
}
