namespace Press_Operations
{
    partial class BlowPressOperations
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
            comboBox1 = new ComboBox();
            MaterialType = new Label();
            Pressure = new TextBox();
            PressureLabel = new Label();
            checkedListBox1 = new CheckedListBox();
            EmbossLabel = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aluminum .098", "Aluminum .128", "Steel .098", "Steel .128" });
            comboBox1.Location = new Point(12, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MaterialType
            // 
            MaterialType.AutoSize = true;
            MaterialType.Location = new Point(12, 26);
            MaterialType.Name = "MaterialType";
            MaterialType.Size = new Size(50, 15);
            MaterialType.TabIndex = 1;
            MaterialType.Text = "Material";
            // 
            // Pressure
            // 
            Pressure.Location = new Point(12, 100);
            Pressure.Name = "Pressure";
            Pressure.ReadOnly = true;
            Pressure.Size = new Size(100, 23);
            Pressure.TabIndex = 2;
            Pressure.TabStop = false;
            // 
            // PressureLabel
            // 
            PressureLabel.AutoSize = true;
            PressureLabel.Location = new Point(12, 82);
            PressureLabel.Name = "PressureLabel";
            PressureLabel.Size = new Size(78, 15);
            PressureLabel.TabIndex = 3;
            PressureLabel.Text = "Pressure - PSI";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "501", "502", "50c" });
            checkedListBox1.Location = new Point(157, 44);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(56, 58);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // EmbossLabel
            // 
            EmbossLabel.AutoSize = true;
            EmbossLabel.Location = new Point(156, 23);
            EmbossLabel.Name = "EmbossLabel";
            EmbossLabel.Size = new Size(48, 15);
            EmbossLabel.TabIndex = 5;
            EmbossLabel.Text = "Emboss";
            // 
            // BlowPressOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmbossLabel);
            Controls.Add(checkedListBox1);
            Controls.Add(PressureLabel);
            Controls.Add(Pressure);
            Controls.Add(MaterialType);
            Controls.Add(comboBox1);
            Name = "BlowPressOperations";
            Text = "Blow Press Operations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label MaterialType;
        private TextBox Pressure;
        private Label PressureLabel;
        private CheckedListBox checkedListBox1;
        private Label EmbossLabel;
    }
}
