namespace monitor
{
    partial class SettingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            GraphResolutionField = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            WarnThresholdField = new NumericUpDown();
            CritThresholdField = new NumericUpDown();
            label3 = new Label();
            SaveButton = new Button();
            label5 = new Label();
            UpdateIntervalField = new NumericUpDown();
            ResetDefaultsButton = new Button();
            NotificationSettingsGroup = new GroupBox();
            CritThresholdSlider = new TrackBar();
            WarningThresholdSlider = new TrackBar();
            WarningIndicatorsToggle = new CheckBox();
            NotificationToggle = new CheckBox();
            TrayIconToggle = new CheckBox();
            MeasurementSettingsGroup = new GroupBox();
            label6 = new Label();
            SensorPicker = new ComboBox();
            TrayIconSettingsGroup = new GroupBox();
            IconThemePicker = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            label8 = new Label();
            DevicePicker = new ComboBox();
            colorDialog1 = new ColorDialog();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)GraphResolutionField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarnThresholdField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CritThresholdField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateIntervalField).BeginInit();
            NotificationSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CritThresholdSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarningThresholdSlider).BeginInit();
            MeasurementSettingsGroup.SuspendLayout();
            TrayIconSettingsGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GraphResolutionField
            // 
            GraphResolutionField.Location = new Point(235, 42);
            GraphResolutionField.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            GraphResolutionField.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            GraphResolutionField.Name = "GraphResolutionField";
            GraphResolutionField.Size = new Size(131, 23);
            GraphResolutionField.TabIndex = 0;
            toolTip1.SetToolTip(GraphResolutionField, "How much data points are allowed on the temperature graph");
            GraphResolutionField.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Graph Resolution";
            toolTip1.SetToolTip(label1, "How much data points are allowed on the temperature graph");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 2;
            label2.Text = "Warning Temperature Threshold";
            toolTip1.SetToolTip(label2, "The temperature at which a warning message will be shown.");
            // 
            // WarnThresholdField
            // 
            WarnThresholdField.DecimalPlaces = 1;
            WarnThresholdField.Location = new Point(126, 102);
            WarnThresholdField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            WarnThresholdField.Name = "WarnThresholdField";
            WarnThresholdField.Size = new Size(62, 23);
            WarnThresholdField.TabIndex = 3;
            toolTip1.SetToolTip(WarnThresholdField, "The temperature at which a warning message will be shown.");
            WarnThresholdField.ValueChanged += WarnThresholdField_ValueChanged;
            // 
            // CritThresholdField
            // 
            CritThresholdField.DecimalPlaces = 1;
            CritThresholdField.Location = new Point(126, 167);
            CritThresholdField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            CritThresholdField.Name = "CritThresholdField";
            CritThresholdField.Size = new Size(62, 23);
            CritThresholdField.TabIndex = 4;
            toolTip1.SetToolTip(CritThresholdField, "The temperature at which a critical message will be shown.");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 140);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 5;
            label3.Text = "Critical Temperature Threshold";
            toolTip1.SetToolTip(label3, "The temperature at which a critical message will be shown.");
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 310);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 24);
            label5.Name = "label5";
            label5.Size = new Size(164, 15);
            label5.TabIndex = 9;
            label5.Text = "Update Interval (milliseconds)";
            toolTip1.SetToolTip(label5, "How much time the program should wait (in milliseconds) before the temperature information is refreshed");
            // 
            // UpdateIntervalField
            // 
            UpdateIntervalField.Location = new Point(38, 42);
            UpdateIntervalField.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            UpdateIntervalField.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpdateIntervalField.Name = "UpdateIntervalField";
            UpdateIntervalField.Size = new Size(131, 23);
            UpdateIntervalField.TabIndex = 10;
            toolTip1.SetToolTip(UpdateIntervalField, "How much time the program should wait (in milliseconds) before the temperature information is refreshed");
            UpdateIntervalField.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ResetDefaultsButton
            // 
            ResetDefaultsButton.Location = new Point(93, 310);
            ResetDefaultsButton.Name = "ResetDefaultsButton";
            ResetDefaultsButton.Size = new Size(75, 23);
            ResetDefaultsButton.TabIndex = 11;
            ResetDefaultsButton.Text = "Reset";
            ResetDefaultsButton.UseVisualStyleBackColor = true;
            // 
            // NotificationSettingsGroup
            // 
            NotificationSettingsGroup.Controls.Add(CritThresholdSlider);
            NotificationSettingsGroup.Controls.Add(WarningThresholdSlider);
            NotificationSettingsGroup.Controls.Add(WarningIndicatorsToggle);
            NotificationSettingsGroup.Controls.Add(NotificationToggle);
            NotificationSettingsGroup.Controls.Add(label2);
            NotificationSettingsGroup.Controls.Add(WarnThresholdField);
            NotificationSettingsGroup.Controls.Add(label3);
            NotificationSettingsGroup.Controls.Add(CritThresholdField);
            NotificationSettingsGroup.Location = new Point(12, 94);
            NotificationSettingsGroup.Name = "NotificationSettingsGroup";
            NotificationSettingsGroup.Size = new Size(199, 208);
            NotificationSettingsGroup.TabIndex = 13;
            NotificationSettingsGroup.TabStop = false;
            NotificationSettingsGroup.Text = "Warnings";
            // 
            // CritThresholdSlider
            // 
            CritThresholdSlider.Location = new Point(12, 158);
            CritThresholdSlider.Maximum = 150;
            CritThresholdSlider.Name = "CritThresholdSlider";
            CritThresholdSlider.Size = new Size(104, 45);
            CritThresholdSlider.TabIndex = 10;
            CritThresholdSlider.TickFrequency = 25;
            CritThresholdSlider.TickStyle = TickStyle.TopLeft;
            toolTip1.SetToolTip(CritThresholdSlider, "The temperature at which a critical message will be shown.");
            // 
            // WarningThresholdSlider
            // 
            WarningThresholdSlider.Location = new Point(12, 92);
            WarningThresholdSlider.Maximum = 150;
            WarningThresholdSlider.Name = "WarningThresholdSlider";
            WarningThresholdSlider.Size = new Size(104, 45);
            WarningThresholdSlider.TabIndex = 9;
            WarningThresholdSlider.TickFrequency = 25;
            WarningThresholdSlider.TickStyle = TickStyle.TopLeft;
            toolTip1.SetToolTip(WarningThresholdSlider, "The temperature at which a warning message will be shown.");
            // 
            // WarningIndicatorsToggle
            // 
            WarningIndicatorsToggle.AutoSize = true;
            WarningIndicatorsToggle.Location = new Point(16, 47);
            WarningIndicatorsToggle.Name = "WarningIndicatorsToggle";
            WarningIndicatorsToggle.Size = new Size(164, 19);
            WarningIndicatorsToggle.TabIndex = 8;
            WarningIndicatorsToggle.Text = "Enable Warning Indicators";
            toolTip1.SetToolTip(WarningIndicatorsToggle, "When enabled, displays warning/critical indicators.");
            WarningIndicatorsToggle.UseVisualStyleBackColor = true;
            // 
            // NotificationToggle
            // 
            NotificationToggle.AutoSize = true;
            NotificationToggle.Location = new Point(16, 22);
            NotificationToggle.Name = "NotificationToggle";
            NotificationToggle.Size = new Size(132, 19);
            NotificationToggle.TabIndex = 6;
            NotificationToggle.Text = "Enable Notifications";
            toolTip1.SetToolTip(NotificationToggle, "When enabled, displays a toast/balloon notification when a warning/critical notification is triggered.");
            NotificationToggle.UseVisualStyleBackColor = true;
            // 
            // TrayIconToggle
            // 
            TrayIconToggle.AutoSize = true;
            TrayIconToggle.Location = new Point(10, 22);
            TrayIconToggle.Name = "TrayIconToggle";
            TrayIconToggle.Size = new Size(61, 19);
            TrayIconToggle.TabIndex = 7;
            TrayIconToggle.Text = "Enable";
            toolTip1.SetToolTip(TrayIconToggle, resources.GetString("TrayIconToggle.ToolTip"));
            TrayIconToggle.UseVisualStyleBackColor = true;
            // 
            // MeasurementSettingsGroup
            // 
            MeasurementSettingsGroup.Controls.Add(label1);
            MeasurementSettingsGroup.Controls.Add(GraphResolutionField);
            MeasurementSettingsGroup.Controls.Add(label5);
            MeasurementSettingsGroup.Controls.Add(UpdateIntervalField);
            MeasurementSettingsGroup.Location = new Point(12, 12);
            MeasurementSettingsGroup.Name = "MeasurementSettingsGroup";
            MeasurementSettingsGroup.Size = new Size(387, 76);
            MeasurementSettingsGroup.TabIndex = 14;
            MeasurementSettingsGroup.TabStop = false;
            MeasurementSettingsGroup.Text = "Measurement Settings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 58);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Sensor";
            toolTip1.SetToolTip(label6, "What device sensor the program should measure");
            // 
            // SensorPicker
            // 
            SensorPicker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SensorPicker.AutoCompleteSource = AutoCompleteSource.ListItems;
            SensorPicker.FormattingEnabled = true;
            SensorPicker.Items.AddRange(new object[] { "(First Sensor)" });
            SensorPicker.Location = new Point(51, 54);
            SensorPicker.MaxDropDownItems = 32;
            SensorPicker.Name = "SensorPicker";
            SensorPicker.Size = new Size(121, 23);
            SensorPicker.TabIndex = 11;
            toolTip1.SetToolTip(SensorPicker, "What device sensor the program should measure");
            // 
            // TrayIconSettingsGroup
            // 
            TrayIconSettingsGroup.Controls.Add(IconThemePicker);
            TrayIconSettingsGroup.Controls.Add(label7);
            TrayIconSettingsGroup.Controls.Add(TrayIconToggle);
            TrayIconSettingsGroup.Location = new Point(217, 94);
            TrayIconSettingsGroup.Name = "TrayIconSettingsGroup";
            TrayIconSettingsGroup.Size = new Size(182, 103);
            TrayIconSettingsGroup.TabIndex = 15;
            TrayIconSettingsGroup.TabStop = false;
            TrayIconSettingsGroup.Text = "Tray Icon";
            // 
            // IconThemePicker
            // 
            IconThemePicker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            IconThemePicker.AutoCompleteSource = AutoCompleteSource.ListItems;
            IconThemePicker.FormattingEnabled = true;
            IconThemePicker.Items.AddRange(new object[] { "Horizontal", "Horizontal Light", "Vertical", "Vertical Light", "Combined", "Combined Light", "Text", "Text Light", "Icon" });
            IconThemePicker.Location = new Point(10, 65);
            IconThemePicker.MaxDropDownItems = 32;
            IconThemePicker.Name = "IconThemePicker";
            IconThemePicker.Size = new Size(162, 23);
            IconThemePicker.TabIndex = 13;
            toolTip1.SetToolTip(IconThemePicker, "What the style of the tray icon should be.");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 8;
            label7.Text = "Theme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 314);
            label4.Name = "label4";
            label4.Size = new Size(198, 15);
            label4.TabIndex = 16;
            label4.Text = "Hover above a setting for more info.";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 0;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 100;
            toolTip1.UseAnimation = false;
            toolTip1.UseFading = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 31);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 14;
            label8.Text = "Device";
            toolTip1.SetToolTip(label8, "What device the program should use for measuring");
            // 
            // DevicePicker
            // 
            DevicePicker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DevicePicker.AutoCompleteSource = AutoCompleteSource.ListItems;
            DevicePicker.FormattingEnabled = true;
            DevicePicker.Items.AddRange(new object[] { "(First Sensor)" });
            DevicePicker.Location = new Point(51, 27);
            DevicePicker.MaxDropDownItems = 32;
            DevicePicker.Name = "DevicePicker";
            DevicePicker.Size = new Size(121, 23);
            DevicePicker.TabIndex = 13;
            toolTip1.SetToolTip(DevicePicker, "What device the program should use for measuring");
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(DevicePicker);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(SensorPicker);
            groupBox1.Location = new Point(217, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 99);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sensors";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 340);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(TrayIconSettingsGroup);
            Controls.Add(MeasurementSettingsGroup);
            Controls.Add(NotificationSettingsGroup);
            Controls.Add(ResetDefaultsButton);
            Controls.Add(SaveButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsPage";
            Text = "SettingsPage";
            ((System.ComponentModel.ISupportInitialize)GraphResolutionField).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarnThresholdField).EndInit();
            ((System.ComponentModel.ISupportInitialize)CritThresholdField).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateIntervalField).EndInit();
            NotificationSettingsGroup.ResumeLayout(false);
            NotificationSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CritThresholdSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarningThresholdSlider).EndInit();
            MeasurementSettingsGroup.ResumeLayout(false);
            MeasurementSettingsGroup.PerformLayout();
            TrayIconSettingsGroup.ResumeLayout(false);
            TrayIconSettingsGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown GraphResolutionField;
        private Label label1;
        private Label label2;
        private NumericUpDown WarnThresholdField;
        private NumericUpDown CritThresholdField;
        private Label label3;
        private Button SaveButton;
        private Label label5;
        private NumericUpDown UpdateIntervalField;
        private Button ResetDefaultsButton;
        private GroupBox NotificationSettingsGroup;
        private CheckBox NotificationToggle;
        private GroupBox MeasurementSettingsGroup;
        private CheckBox WarningIndicatorsToggle;
        private CheckBox TrayIconToggle;
        private Label label6;
        private ComboBox SensorPicker;
        private TrackBar WarningThresholdSlider;
        private TrackBar CritThresholdSlider;
        private GroupBox TrayIconSettingsGroup;
        private Label label4;
        private ToolTip toolTip1;
        private Label label7;
        private ColorDialog colorDialog1;
        private ComboBox IconThemePicker;
        private GroupBox groupBox1;
        private Label label8;
        private ComboBox DevicePicker;
    }
}