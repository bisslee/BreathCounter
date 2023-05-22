namespace Biss.BreathCounter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            TimeLabel = new Label();
            TimeInput = new TextBox();
            SeriesInput = new TextBox();
            SerieQtyLabel = new Label();
            TimerDisplay = new Label();
            SeriesDisplay = new Label();
            StartButton = new Button();
            InstructionsLabel = new Label();
            InstructionsDisplayLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            BreathTypeDisplay = new Label();
            statusStrip1 = new StatusStrip();
            AppVersionDisplay = new ToolStripStatusLabel();
            Logo = new PictureBox();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(18, 74);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(88, 20);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "Tempo(seg)";
            // 
            // TimeInput
            // 
            TimeInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeInput.Location = new Point(22, 97);
            TimeInput.Name = "TimeInput";
            TimeInput.Size = new Size(100, 29);
            TimeInput.TabIndex = 1;
            TimeInput.TextChanged += TimeInput_TextChanged;
            TimeInput.KeyPress += TimeInput_KeyPress;
            // 
            // SeriesInput
            // 
            SeriesInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SeriesInput.Location = new Point(155, 97);
            SeriesInput.Name = "SeriesInput";
            SeriesInput.Size = new Size(100, 29);
            SeriesInput.TabIndex = 3;
            SeriesInput.TextChanged += SeriesInput_TextChanged;
            SeriesInput.KeyPress += SeriesInput_KeyPress;
            // 
            // SerieQtyLabel
            // 
            SerieQtyLabel.AutoSize = true;
            SerieQtyLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SerieQtyLabel.Location = new Point(151, 74);
            SerieQtyLabel.Name = "SerieQtyLabel";
            SerieQtyLabel.Size = new Size(85, 20);
            SerieQtyLabel.TabIndex = 2;
            SerieQtyLabel.Text = "Qtde Séries";
            // 
            // TimerDisplay
            // 
            TimerDisplay.BorderStyle = BorderStyle.Fixed3D;
            TimerDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimerDisplay.Location = new Point(22, 139);
            TimerDisplay.Name = "TimerDisplay";
            TimerDisplay.Size = new Size(100, 39);
            TimerDisplay.TabIndex = 4;
            TimerDisplay.Text = "00:00";
            TimerDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SeriesDisplay
            // 
            SeriesDisplay.BorderStyle = BorderStyle.Fixed3D;
            SeriesDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SeriesDisplay.Location = new Point(155, 139);
            SeriesDisplay.Name = "SeriesDisplay";
            SeriesDisplay.Size = new Size(100, 39);
            SeriesDisplay.TabIndex = 5;
            SeriesDisplay.Text = "00";
            SeriesDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            StartButton.Enabled = false;
            StartButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(22, 237);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(233, 34);
            StartButton.TabIndex = 6;
            StartButton.Text = "Iniciar";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // InstructionsLabel
            // 
            InstructionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InstructionsLabel.Location = new Point(22, 278);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(233, 18);
            InstructionsLabel.TabIndex = 7;
            InstructionsLabel.Text = "Instruções";
            // 
            // InstructionsDisplayLabel
            // 
            InstructionsDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            InstructionsDisplayLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            InstructionsDisplayLabel.Location = new Point(22, 296);
            InstructionsDisplayLabel.Name = "InstructionsDisplayLabel";
            InstructionsDisplayLabel.Size = new Size(233, 114);
            InstructionsDisplayLabel.TabIndex = 8;
            InstructionsDisplayLabel.Text = "0ooo";
            // 
            // BreathTypeDisplay
            // 
            BreathTypeDisplay.BorderStyle = BorderStyle.Fixed3D;
            BreathTypeDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BreathTypeDisplay.Location = new Point(23, 192);
            BreathTypeDisplay.Name = "BreathTypeDisplay";
            BreathTypeDisplay.Size = new Size(232, 34);
            BreathTypeDisplay.TabIndex = 9;
            BreathTypeDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { AppVersionDisplay });
            statusStrip1.Location = new Point(0, 417);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(276, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // AppVersionDisplay
            // 
            AppVersionDisplay.Name = "AppVersionDisplay";
            AppVersionDisplay.Size = new Size(67, 17);
            AppVersionDisplay.Text = "AppVersion";
            // 
            // Logo
            // 
            Logo.BackgroundImage = Properties.Resources.logo;
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Image = Properties.Resources.logo;
            Logo.Location = new Point(23, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(67, 50);
            Logo.TabIndex = 11;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 25);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 12;
            label1.Text = "Breath Counter";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(276, 439);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(statusStrip1);
            Controls.Add(BreathTypeDisplay);
            Controls.Add(InstructionsDisplayLabel);
            Controls.Add(InstructionsLabel);
            Controls.Add(StartButton);
            Controls.Add(SeriesDisplay);
            Controls.Add(TimerDisplay);
            Controls.Add(SeriesInput);
            Controls.Add(SerieQtyLabel);
            Controls.Add(TimeInput);
            Controls.Add(TimeLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "Contador de Respirações";
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLabel;
        private TextBox TimeInput;
        private TextBox SeriesInput;
        private Label SerieQtyLabel;
        private Label TimerDisplay;
        private Label SeriesDisplay;
        private Button StartButton;
        private Label InstructionsLabel;
        private Label InstructionsDisplayLabel;
        private System.Windows.Forms.Timer timer1;
        private Label BreathTypeDisplay;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel AppVersionDisplay;
        private PictureBox Logo;
        private Label label1;
    }
}