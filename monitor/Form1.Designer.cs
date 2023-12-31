﻿namespace monitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RefreshTimer = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            CritIcon = new ToolStripStatusLabel();
            WarnIcon = new ToolStripStatusLabel();
            notifyIcon1 = new NotifyIcon(components);
            TrayContextMenu = new ContextMenuStrip(components);
            coreTempAlphaV1ToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            HardwareNameLabel = new Label();
            SensorNameLabel = new Label();
            TempLabel = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            SettingsButton = new Button();
            TemperatureStatus = new Label();
            tempBar = new ProgressBar();
            StatusIcon = new Panel();
            statusStrip1.SuspendLayout();
            TrayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // RefreshTimer
            // 
            RefreshTimer.Enabled = true;
            RefreshTimer.Interval = 1250;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Items.AddRange(new ToolStripItem[] { CritIcon, WarnIcon });
            statusStrip1.Location = new Point(0, 387);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(759, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // CritIcon
            // 
            CritIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CritIcon.Enabled = false;
            CritIcon.Image = Properties.Resources.critical;
            CritIcon.Name = "CritIcon";
            CritIcon.Padding = new Padding(4);
            CritIcon.Size = new Size(24, 24);
            // 
            // WarnIcon
            // 
            WarnIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WarnIcon.Enabled = false;
            WarnIcon.Image = Properties.Resources.warning;
            WarnIcon.Name = "WarnIcon";
            WarnIcon.Padding = new Padding(4);
            WarnIcon.Size = new Size(24, 24);
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = TrayContextMenu;
            notifyIcon1.Text = "TempMonitor";
            notifyIcon1.Visible = true;
            // 
            // TrayContextMenu
            // 
            TrayContextMenu.Items.AddRange(new ToolStripItem[] { coreTempAlphaV1ToolStripMenuItem, exitToolStripMenuItem });
            TrayContextMenu.Name = "TrayContextMenu";
            TrayContextMenu.Size = new Size(153, 48);
            // 
            // coreTempAlphaV1ToolStripMenuItem
            // 
            coreTempAlphaV1ToolStripMenuItem.Enabled = false;
            coreTempAlphaV1ToolStripMenuItem.Name = "coreTempAlphaV1ToolStripMenuItem";
            coreTempAlphaV1ToolStripMenuItem.Size = new Size(152, 22);
            coreTempAlphaV1ToolStripMenuItem.Text = "CoreTemp v3.5";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.cross;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(152, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // HardwareNameLabel
            // 
            HardwareNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HardwareNameLabel.Location = new Point(359, 12);
            HardwareNameLabel.Name = "HardwareNameLabel";
            HardwareNameLabel.Size = new Size(388, 28);
            HardwareNameLabel.TabIndex = 3;
            HardwareNameLabel.Text = "HardwareNameLabel";
            HardwareNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SensorNameLabel
            // 
            SensorNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SensorNameLabel.Location = new Point(359, 40);
            SensorNameLabel.Name = "SensorNameLabel";
            SensorNameLabel.Size = new Size(388, 30);
            SensorNameLabel.TabIndex = 4;
            SensorNameLabel.Text = "Sensor: (...)";
            SensorNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TempLabel
            // 
            TempLabel.AutoSize = true;
            TempLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TempLabel.Location = new Point(82, 12);
            TempLabel.Name = "TempLabel";
            TempLabel.Size = new Size(73, 45);
            TempLabel.TabIndex = 5;
            TempLabel.Text = "...℃";
            TempLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.Control;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Temperature";
            chartArea1.BackColor = SystemColors.ControlDark;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(12, 99);
            chart1.Margin = new Padding(0);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 6;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.MarkerColor = Color.Black;
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(735, 288);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(672, 73);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(75, 23);
            SettingsButton.TabIndex = 8;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // TemperatureStatus
            // 
            TemperatureStatus.Location = new Point(182, 12);
            TemperatureStatus.Name = "TemperatureStatus";
            TemperatureStatus.Size = new Size(128, 45);
            TemperatureStatus.TabIndex = 9;
            TemperatureStatus.Text = "???";
            TemperatureStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tempBar
            // 
            tempBar.Location = new Point(82, 66);
            tempBar.Name = "tempBar";
            tempBar.Size = new Size(228, 10);
            tempBar.Style = ProgressBarStyle.Continuous;
            tempBar.TabIndex = 10;
            tempBar.Value = 20;
            // 
            // StatusIcon
            // 
            StatusIcon.Location = new Point(12, 12);
            StatusIcon.Name = "StatusIcon";
            StatusIcon.Size = new Size(64, 64);
            StatusIcon.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 416);
            Controls.Add(StatusIcon);
            Controls.Add(tempBar);
            Controls.Add(TemperatureStatus);
            Controls.Add(SettingsButton);
            Controls.Add(chart1);
            Controls.Add(TempLabel);
            Controls.Add(SensorNameLabel);
            Controls.Add(HardwareNameLabel);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CoreTemp";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TrayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer RefreshTimer;
        private StatusStrip statusStrip1;
        private NotifyIcon notifyIcon1;
        private Label HardwareNameLabel;
        private Label SensorNameLabel;
        private Label TempLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button SettingsButton;
        private ContextMenuStrip TrayContextMenu;
        private ToolStripMenuItem coreTempAlphaV1ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripStatusLabel WarnIcon;
        private ToolStripStatusLabel CritIcon;
        private Label TemperatureStatus;
        private ProgressBar tempBar;
        private Panel StatusIcon;
    }
}