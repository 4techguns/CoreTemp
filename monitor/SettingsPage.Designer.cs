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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)GraphResolutionField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarnThresholdField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CritThresholdField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateIntervalField).BeginInit();
            SuspendLayout();
            // 
            // GraphResolutionField
            // 
            GraphResolutionField.Location = new Point(194, 12);
            GraphResolutionField.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            GraphResolutionField.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GraphResolutionField.Name = "GraphResolutionField";
            GraphResolutionField.Size = new Size(162, 23);
            GraphResolutionField.TabIndex = 0;
            GraphResolutionField.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Graph Resolution";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 2;
            label2.Text = "Warning Temperature Threshold";
            // 
            // WarnThresholdField
            // 
            WarnThresholdField.DecimalPlaces = 1;
            WarnThresholdField.Location = new Point(194, 41);
            WarnThresholdField.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            WarnThresholdField.Name = "WarnThresholdField";
            WarnThresholdField.Size = new Size(162, 23);
            WarnThresholdField.TabIndex = 3;
            // 
            // CritThresholdField
            // 
            CritThresholdField.DecimalPlaces = 1;
            CritThresholdField.Location = new Point(194, 70);
            CritThresholdField.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            CritThresholdField.Name = "CritThresholdField";
            CritThresholdField.Size = new Size(162, 23);
            CritThresholdField.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 5;
            label3.Text = "Critical Temperature Threshold";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 317);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 9;
            label5.Text = "Update Interval (ms)";
            // 
            // UpdateIntervalField
            // 
            UpdateIntervalField.Location = new Point(194, 99);
            UpdateIntervalField.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            UpdateIntervalField.Name = "UpdateIntervalField";
            UpdateIntervalField.Size = new Size(162, 23);
            UpdateIntervalField.TabIndex = 10;
            UpdateIntervalField.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ResetDefaultsButton
            // 
            ResetDefaultsButton.Location = new Point(281, 317);
            ResetDefaultsButton.Name = "ResetDefaultsButton";
            ResetDefaultsButton.Size = new Size(75, 23);
            ResetDefaultsButton.TabIndex = 11;
            ResetDefaultsButton.Text = "Reset";
            ResetDefaultsButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(344, 51);
            label4.TabIndex = 12;
            label4.Text = "All changes are automatically applied, but won't be persisted unless you click Save";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 352);
            Controls.Add(label4);
            Controls.Add(ResetDefaultsButton);
            Controls.Add(UpdateIntervalField);
            Controls.Add(label5);
            Controls.Add(SaveButton);
            Controls.Add(label3);
            Controls.Add(CritThresholdField);
            Controls.Add(WarnThresholdField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GraphResolutionField);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsPage";
            Text = "SettingsPage";
            ((System.ComponentModel.ISupportInitialize)GraphResolutionField).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarnThresholdField).EndInit();
            ((System.ComponentModel.ISupportInitialize)CritThresholdField).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateIntervalField).EndInit();
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
        private Label label4;
    }
}