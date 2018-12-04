namespace AntColonyTSP
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.mousePositionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pointsAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.initPheromoneUpDown = new System.Windows.Forms.NumericUpDown();
            this.remainingPheromoneUpDown = new System.Windows.Forms.NumericUpDown();
            this.cyclesUpDown = new System.Windows.Forms.NumericUpDown();
            this.alfaUpDown = new System.Windows.Forms.NumericUpDown();
            this.betaUpDown = new System.Windows.Forms.NumericUpDown();
            this.Q3UpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.Q2UpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Q1UpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.initPheromoneUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainingPheromoneUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q3UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q1UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel.BackgroundImage = global::AntColonyTSP.Properties.Resources.polska;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 500);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // mousePositionLabel
            // 
            this.mousePositionLabel.AutoSize = true;
            this.mousePositionLabel.Location = new System.Drawing.Point(617, 67);
            this.mousePositionLabel.Name = "mousePositionLabel";
            this.mousePositionLabel.Size = new System.Drawing.Size(0, 13);
            this.mousePositionLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(533, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pointsAmountLabel
            // 
            this.pointsAmountLabel.AutoSize = true;
            this.pointsAmountLabel.Location = new System.Drawing.Point(617, 88);
            this.pointsAmountLabel.Name = "pointsAmountLabel";
            this.pointsAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.pointsAmountLabel.TabIndex = 3;
            this.pointsAmountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mouse position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Points:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(530, 45);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Length:";
            // 
            // lengthValueLabel
            // 
            this.lengthValueLabel.AutoSize = true;
            this.lengthValueLabel.Location = new System.Drawing.Point(620, 45);
            this.lengthValueLabel.Name = "lengthValueLabel";
            this.lengthValueLabel.Size = new System.Drawing.Size(0, 13);
            this.lengthValueLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alfa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Beta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Q3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Init pheromone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cycles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Remaining pheromone:";
            // 
            // initPheromoneUpDown
            // 
            this.initPheromoneUpDown.Location = new System.Drawing.Point(653, 241);
            this.initPheromoneUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.initPheromoneUpDown.Name = "initPheromoneUpDown";
            this.initPheromoneUpDown.Size = new System.Drawing.Size(63, 20);
            this.initPheromoneUpDown.TabIndex = 14;
            this.initPheromoneUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.initPheromoneUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // remainingPheromoneUpDown
            // 
            this.remainingPheromoneUpDown.Location = new System.Drawing.Point(653, 267);
            this.remainingPheromoneUpDown.Name = "remainingPheromoneUpDown";
            this.remainingPheromoneUpDown.Size = new System.Drawing.Size(63, 20);
            this.remainingPheromoneUpDown.TabIndex = 15;
            this.remainingPheromoneUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.remainingPheromoneUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cyclesUpDown
            // 
            this.cyclesUpDown.Location = new System.Drawing.Point(653, 293);
            this.cyclesUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cyclesUpDown.Name = "cyclesUpDown";
            this.cyclesUpDown.Size = new System.Drawing.Size(63, 20);
            this.cyclesUpDown.TabIndex = 16;
            this.cyclesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cyclesUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // alfaUpDown
            // 
            this.alfaUpDown.Location = new System.Drawing.Point(653, 319);
            this.alfaUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.alfaUpDown.Name = "alfaUpDown";
            this.alfaUpDown.Size = new System.Drawing.Size(63, 20);
            this.alfaUpDown.TabIndex = 17;
            this.alfaUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.alfaUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betaUpDown
            // 
            this.betaUpDown.Location = new System.Drawing.Point(653, 345);
            this.betaUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betaUpDown.Name = "betaUpDown";
            this.betaUpDown.Size = new System.Drawing.Size(63, 20);
            this.betaUpDown.TabIndex = 18;
            this.betaUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betaUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Q3UpDown
            // 
            this.Q3UpDown.Location = new System.Drawing.Point(653, 437);
            this.Q3UpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Q3UpDown.Name = "Q3UpDown";
            this.Q3UpDown.Size = new System.Drawing.Size(63, 20);
            this.Q3UpDown.TabIndex = 19;
            this.Q3UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Q3UpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "%";
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(620, 136);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Q2UpDown
            // 
            this.Q2UpDown.Location = new System.Drawing.Point(653, 411);
            this.Q2UpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Q2UpDown.Name = "Q2UpDown";
            this.Q2UpDown.Size = new System.Drawing.Size(63, 20);
            this.Q2UpDown.TabIndex = 24;
            this.Q2UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Q2UpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Q2:";
            // 
            // Q1UpDown
            // 
            this.Q1UpDown.Location = new System.Drawing.Point(653, 385);
            this.Q1UpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Q1UpDown.Name = "Q1UpDown";
            this.Q1UpDown.Size = new System.Drawing.Size(63, 20);
            this.Q1UpDown.TabIndex = 26;
            this.Q1UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Q1UpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Q1:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "cycle",
            "density",
            "quantity"});
            this.listBox.Location = new System.Drawing.Point(533, 166);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(97, 43);
            this.listBox.TabIndex = 27;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 520);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Q1UpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Q2UpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Q3UpDown);
            this.Controls.Add(this.betaUpDown);
            this.Controls.Add(this.alfaUpDown);
            this.Controls.Add(this.cyclesUpDown);
            this.Controls.Add(this.remainingPheromoneUpDown);
            this.Controls.Add(this.initPheromoneUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthValueLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointsAmountLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mousePositionLabel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Mrówkowy Komiwojażer";
            ((System.ComponentModel.ISupportInitialize)(this.initPheromoneUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainingPheromoneUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q3UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q1UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label mousePositionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pointsAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label lengthValueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown initPheromoneUpDown;
        private System.Windows.Forms.NumericUpDown remainingPheromoneUpDown;
        private System.Windows.Forms.NumericUpDown cyclesUpDown;
        private System.Windows.Forms.NumericUpDown alfaUpDown;
        private System.Windows.Forms.NumericUpDown betaUpDown;
        private System.Windows.Forms.NumericUpDown Q3UpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.NumericUpDown Q2UpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Q1UpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox;
    }
}

