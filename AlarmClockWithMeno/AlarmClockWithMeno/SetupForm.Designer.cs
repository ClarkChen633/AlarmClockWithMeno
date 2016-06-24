namespace AlarmClockWithMeno
{
    partial class SetupForm
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
            this.TimeGBox = new System.Windows.Forms.GroupBox();
            this.Yearlabel = new System.Windows.Forms.Label();
            this.Monlabel = new System.Windows.Forms.Label();
            this.Daylabel = new System.Windows.Forms.Label();
            this.Hourlabel = new System.Windows.Forms.Label();
            this.Minslabel = new System.Windows.Forms.Label();
            this.YearUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonUpDown = new System.Windows.Forms.NumericUpDown();
            this.DayUpDown = new System.Windows.Forms.NumericUpDown();
            this.HrUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinUpDown = new System.Windows.Forms.NumericUpDown();
            this.MsgBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.TimeGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).BeginInit();
            this.MsgBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeGBox
            // 
            this.TimeGBox.Controls.Add(this.Yearlabel);
            this.TimeGBox.Controls.Add(this.Monlabel);
            this.TimeGBox.Controls.Add(this.Daylabel);
            this.TimeGBox.Controls.Add(this.Hourlabel);
            this.TimeGBox.Controls.Add(this.Minslabel);
            this.TimeGBox.Controls.Add(this.YearUpDown);
            this.TimeGBox.Controls.Add(this.MonUpDown);
            this.TimeGBox.Controls.Add(this.DayUpDown);
            this.TimeGBox.Controls.Add(this.HrUpDown);
            this.TimeGBox.Controls.Add(this.MinUpDown);
            this.TimeGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeGBox.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeGBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.TimeGBox.Location = new System.Drawing.Point(37, 24);
            this.TimeGBox.Name = "TimeGBox";
            this.TimeGBox.Size = new System.Drawing.Size(346, 199);
            this.TimeGBox.TabIndex = 0;
            this.TimeGBox.TabStop = false;
            this.TimeGBox.Text = "TimeSetting";
            // 
            // Yearlabel
            // 
            this.Yearlabel.AutoSize = true;
            this.Yearlabel.Location = new System.Drawing.Point(237, 122);
            this.Yearlabel.Name = "Yearlabel";
            this.Yearlabel.Size = new System.Drawing.Size(30, 13);
            this.Yearlabel.TabIndex = 9;
            this.Yearlabel.Text = "Year";
            // 
            // Monlabel
            // 
            this.Monlabel.AutoSize = true;
            this.Monlabel.Location = new System.Drawing.Point(138, 123);
            this.Monlabel.Name = "Monlabel";
            this.Monlabel.Size = new System.Drawing.Size(39, 13);
            this.Monlabel.TabIndex = 8;
            this.Monlabel.Text = "Month";
            // 
            // Daylabel
            // 
            this.Daylabel.AutoSize = true;
            this.Daylabel.Location = new System.Drawing.Point(20, 123);
            this.Daylabel.Name = "Daylabel";
            this.Daylabel.Size = new System.Drawing.Size(27, 13);
            this.Daylabel.TabIndex = 7;
            this.Daylabel.Text = "Day";
            // 
            // Hourlabel
            // 
            this.Hourlabel.AutoSize = true;
            this.Hourlabel.Location = new System.Drawing.Point(216, 39);
            this.Hourlabel.Name = "Hourlabel";
            this.Hourlabel.Size = new System.Drawing.Size(32, 13);
            this.Hourlabel.TabIndex = 6;
            this.Hourlabel.Text = "Hour";
            // 
            // Minslabel
            // 
            this.Minslabel.AutoSize = true;
            this.Minslabel.Location = new System.Drawing.Point(51, 39);
            this.Minslabel.Name = "Minslabel";
            this.Minslabel.Size = new System.Drawing.Size(41, 13);
            this.Minslabel.TabIndex = 5;
            this.Minslabel.Text = "Minute";
            // 
            // YearUpDown
            // 
            this.YearUpDown.Location = new System.Drawing.Point(240, 138);
            this.YearUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.YearUpDown.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.YearUpDown.Name = "YearUpDown";
            this.YearUpDown.Size = new System.Drawing.Size(50, 23);
            this.YearUpDown.TabIndex = 4;
            this.YearUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YearUpDown.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // MonUpDown
            // 
            this.MonUpDown.Location = new System.Drawing.Point(141, 139);
            this.MonUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonUpDown.Name = "MonUpDown";
            this.MonUpDown.Size = new System.Drawing.Size(50, 23);
            this.MonUpDown.TabIndex = 3;
            this.MonUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DayUpDown
            // 
            this.DayUpDown.Location = new System.Drawing.Point(22, 138);
            this.DayUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayUpDown.Name = "DayUpDown";
            this.DayUpDown.Size = new System.Drawing.Size(50, 23);
            this.DayUpDown.TabIndex = 2;
            this.DayUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DayUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HrUpDown
            // 
            this.HrUpDown.Location = new System.Drawing.Point(218, 57);
            this.HrUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HrUpDown.Name = "HrUpDown";
            this.HrUpDown.Size = new System.Drawing.Size(50, 23);
            this.HrUpDown.TabIndex = 1;
            // 
            // MinUpDown
            // 
            this.MinUpDown.Location = new System.Drawing.Point(51, 57);
            this.MinUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinUpDown.Name = "MinUpDown";
            this.MinUpDown.Size = new System.Drawing.Size(50, 23);
            this.MinUpDown.TabIndex = 0;
            // 
            // MsgBox
            // 
            this.MsgBox.Controls.Add(this.textBox1);
            this.MsgBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.MsgBox.Location = new System.Drawing.Point(37, 249);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(346, 52);
            this.MsgBox.TabIndex = 1;
            this.MsgBox.TabStop = false;
            this.MsgBox.Text = "Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(164, 331);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 370);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.TimeGBox);
            this.Name = "SetupForm";
            this.Text = "SetupForm";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.TimeGBox.ResumeLayout(false);
            this.TimeGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).EndInit();
            this.MsgBox.ResumeLayout(false);
            this.MsgBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TimeGBox;
        private System.Windows.Forms.Label Yearlabel;
        private System.Windows.Forms.Label Monlabel;
        private System.Windows.Forms.Label Daylabel;
        private System.Windows.Forms.Label Hourlabel;
        private System.Windows.Forms.Label Minslabel;
        private System.Windows.Forms.NumericUpDown YearUpDown;
        private System.Windows.Forms.NumericUpDown MonUpDown;
        private System.Windows.Forms.NumericUpDown DayUpDown;
        private System.Windows.Forms.NumericUpDown HrUpDown;
        private System.Windows.Forms.NumericUpDown MinUpDown;
        private System.Windows.Forms.GroupBox MsgBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Savebutton;
    }
}