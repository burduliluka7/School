namespace WindowsFormsApp1
{
    partial class TeacherForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_teacherinfo = new System.Windows.Forms.Label();
            this.statistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GetStudentStatistics_Button = new System.Windows.Forms.Button();
            this.button_gradeGiver = new System.Windows.Forms.Button();
            this.textbox_gradenum = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_headline = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_headline = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Select";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lastname";
            this.Column4.Name = "Column4";
            // 
            // label_teacherinfo
            // 
            this.label_teacherinfo.AutoSize = true;
            this.label_teacherinfo.Location = new System.Drawing.Point(300, 9);
            this.label_teacherinfo.Name = "label_teacherinfo";
            this.label_teacherinfo.Size = new System.Drawing.Size(35, 13);
            this.label_teacherinfo.TabIndex = 1;
            this.label_teacherinfo.Text = "label1";
            // 
            // statistics
            // 
            chartArea4.Name = "ChartArea1";
            this.statistics.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.statistics.Legends.Add(legend4);
            this.statistics.Location = new System.Drawing.Point(-4, 35);
            this.statistics.Name = "statistics";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.statistics.Series.Add(series4);
            this.statistics.Size = new System.Drawing.Size(415, 222);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "chart1";
            title4.Name = "Title1";
            this.statistics.Titles.Add(title4);
            // 
            // GetStudentStatistics_Button
            // 
            this.GetStudentStatistics_Button.Location = new System.Drawing.Point(395, 25);
            this.GetStudentStatistics_Button.Name = "GetStudentStatistics_Button";
            this.GetStudentStatistics_Button.Size = new System.Drawing.Size(75, 23);
            this.GetStudentStatistics_Button.TabIndex = 3;
            this.GetStudentStatistics_Button.Text = "See stats";
            this.GetStudentStatistics_Button.UseVisualStyleBackColor = true;
            this.GetStudentStatistics_Button.Click += new System.EventHandler(this.GetStudentStatistics_Button_Click);
            // 
            // button_gradeGiver
            // 
            this.button_gradeGiver.Location = new System.Drawing.Point(16, 6);
            this.button_gradeGiver.Name = "button_gradeGiver";
            this.button_gradeGiver.Size = new System.Drawing.Size(75, 23);
            this.button_gradeGiver.TabIndex = 4;
            this.button_gradeGiver.Text = "Enter Grade:";
            this.button_gradeGiver.UseVisualStyleBackColor = true;
            this.button_gradeGiver.Click += new System.EventHandler(this.button_gradeGiver_Click);
            // 
            // textbox_gradenum
            // 
            this.textbox_gradenum.Location = new System.Drawing.Point(97, 9);
            this.textbox_gradenum.Name = "textbox_gradenum";
            this.textbox_gradenum.Size = new System.Drawing.Size(26, 20);
            this.textbox_gradenum.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(417, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 283);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_gradeGiver);
            this.tabPage1.Controls.Add(this.textbox_gradenum);
            this.tabPage1.Controls.Add(this.statistics);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_send);
            this.tabPage2.Controls.Add(this.label_description);
            this.tabPage2.Controls.Add(this.label_headline);
            this.tabPage2.Controls.Add(this.textBox_description);
            this.tabPage2.Controls.Add(this.textBox_headline);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(411, 257);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_headline
            // 
            this.textBox_headline.Location = new System.Drawing.Point(148, 17);
            this.textBox_headline.Name = "textBox_headline";
            this.textBox_headline.Size = new System.Drawing.Size(100, 20);
            this.textBox_headline.TabIndex = 0;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(17, 60);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(374, 154);
            this.textBox_description.TabIndex = 1;
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Location = new System.Drawing.Point(92, 20);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(50, 13);
            this.label_headline.TabIndex = 2;
            this.label_headline.Text = "headline:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(14, 44);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(58, 13);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "description";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(300, 220);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GetStudentStatistics_Button);
            this.Controls.Add(this.label_teacherinfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label_teacherinfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart statistics;
        private System.Windows.Forms.Button GetStudentStatistics_Button;
        private System.Windows.Forms.Button button_gradeGiver;
        private System.Windows.Forms.TextBox textbox_gradenum;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_headline;
        private System.Windows.Forms.Button button_send;
    }
}