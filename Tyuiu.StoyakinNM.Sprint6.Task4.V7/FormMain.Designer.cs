namespace Tyuiu.StoyakinNM.Sprint6.Task4.V7
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_SNM = new GroupBox();
            textBoxTask_SNM = new TextBox();
            groupBoxResult_SNM = new GroupBox();
            textBoxResult_SNM = new TextBox();
            chartFunction_SNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxData_SNM = new GroupBox();
            labelTwo_SNM = new Label();
            labelOne_SNM = new Label();
            buttonDone_SNM = new Button();
            buttonSave_SNM = new Button();
            buttonReference_SNM = new Button();
            textBoxStart_SNM = new TextBox();
            textBoxStop_SNM = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            splitter1 = new Splitter();
            groupBoxTask_SNM.SuspendLayout();
            groupBoxResult_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SNM).BeginInit();
            groupBoxData_SNM.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SNM
            // 
            groupBoxTask_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxTask_SNM.Dock = DockStyle.Fill;
            groupBoxTask_SNM.Location = new Point(0, 0);
            groupBoxTask_SNM.Name = "groupBoxTask_SNM";
            groupBoxTask_SNM.Size = new Size(829, 115);
            groupBoxTask_SNM.TabIndex = 0;
            groupBoxTask_SNM.TabStop = false;
            groupBoxTask_SNM.Text = "Условие";
            // 
            // textBoxTask_SNM
            // 
            textBoxTask_SNM.BorderStyle = BorderStyle.None;
            textBoxTask_SNM.Dock = DockStyle.Left;
            textBoxTask_SNM.Location = new Point(3, 19);
            textBoxTask_SNM.Multiline = true;
            textBoxTask_SNM.Name = "textBoxTask_SNM";
            textBoxTask_SNM.ReadOnly = true;
            textBoxTask_SNM.Size = new Size(332, 93);
            textBoxTask_SNM.TabIndex = 0;
            textBoxTask_SNM.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. Резльтат вывести в textBox. Построить график функции и сохранить в файл OutPutFileTask4V7.txt";
            // 
            // groupBoxResult_SNM
            // 
            groupBoxResult_SNM.Controls.Add(textBoxResult_SNM);
            groupBoxResult_SNM.Dock = DockStyle.Fill;
            groupBoxResult_SNM.Location = new Point(0, 0);
            groupBoxResult_SNM.Name = "groupBoxResult_SNM";
            groupBoxResult_SNM.Size = new Size(235, 336);
            groupBoxResult_SNM.TabIndex = 1;
            groupBoxResult_SNM.TabStop = false;
            groupBoxResult_SNM.Text = "Вывод";
            // 
            // textBoxResult_SNM
            // 
            textBoxResult_SNM.BorderStyle = BorderStyle.None;
            textBoxResult_SNM.Dock = DockStyle.Fill;
            textBoxResult_SNM.Location = new Point(3, 19);
            textBoxResult_SNM.Multiline = true;
            textBoxResult_SNM.Name = "textBoxResult_SNM";
            textBoxResult_SNM.ReadOnly = true;
            textBoxResult_SNM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SNM.Size = new Size(229, 314);
            textBoxResult_SNM.TabIndex = 1;
            textBoxResult_SNM.TextChanged += textBoxResult_SNM_TextChanged;
            // 
            // chartFunction_SNM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SNM.ChartAreas.Add(chartArea1);
            chartFunction_SNM.Dock = DockStyle.Fill;
            chartFunction_SNM.Location = new Point(0, 0);
            chartFunction_SNM.Name = "chartFunction_SNM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction_SNM.Series.Add(series1);
            chartFunction_SNM.Size = new Size(594, 336);
            chartFunction_SNM.TabIndex = 2;
            chartFunction_SNM.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_SNM.Titles.Add(title1);
            // 
            // groupBoxData_SNM
            // 
            groupBoxData_SNM.Controls.Add(labelTwo_SNM);
            groupBoxData_SNM.Controls.Add(labelOne_SNM);
            groupBoxData_SNM.Controls.Add(buttonDone_SNM);
            groupBoxData_SNM.Controls.Add(buttonSave_SNM);
            groupBoxData_SNM.Controls.Add(buttonReference_SNM);
            groupBoxData_SNM.Controls.Add(textBoxStart_SNM);
            groupBoxData_SNM.Controls.Add(textBoxStop_SNM);
            groupBoxData_SNM.Dock = DockStyle.Right;
            groupBoxData_SNM.Location = new Point(374, 0);
            groupBoxData_SNM.Name = "groupBoxData_SNM";
            groupBoxData_SNM.Size = new Size(455, 115);
            groupBoxData_SNM.TabIndex = 3;
            groupBoxData_SNM.TabStop = false;
            groupBoxData_SNM.Text = "Ввод данных";
            // 
            // labelTwo_SNM
            // 
            labelTwo_SNM.AutoSize = true;
            labelTwo_SNM.Location = new Point(112, 29);
            labelTwo_SNM.Name = "labelTwo_SNM";
            labelTwo_SNM.Size = new Size(75, 15);
            labelTwo_SNM.TabIndex = 7;
            labelTwo_SNM.Text = "Конец шага:";
            // 
            // labelOne_SNM
            // 
            labelOne_SNM.AutoSize = true;
            labelOne_SNM.Location = new Point(6, 29);
            labelOne_SNM.Name = "labelOne_SNM";
            labelOne_SNM.Size = new Size(72, 15);
            labelOne_SNM.TabIndex = 6;
            labelOne_SNM.Text = "Старт шага:";
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.BackColor = Color.Green;
            buttonDone_SNM.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone_SNM.Location = new Point(228, 37);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(60, 40);
            buttonDone_SNM.TabIndex = 5;
            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.UseVisualStyleBackColor = false;
            buttonDone_SNM.Click += buttonDone_Click;
            // 
            // buttonSave_SNM
            // 
            buttonSave_SNM.BackColor = SystemColors.MenuHighlight;
            buttonSave_SNM.Location = new Point(294, 37);
            buttonSave_SNM.Name = "buttonSave_SNM";
            buttonSave_SNM.Size = new Size(60, 40);
            buttonSave_SNM.TabIndex = 4;
            buttonSave_SNM.Text = "Сохранить";
            buttonSave_SNM.UseVisualStyleBackColor = false;
            buttonSave_SNM.Click += buttonSave_Click;
            // 
            // buttonReference_SNM
            // 
            buttonReference_SNM.BackColor = SystemColors.ActiveCaption;
            buttonReference_SNM.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReference_SNM.Location = new Point(360, 37);
            buttonReference_SNM.Name = "buttonReference_SNM";
            buttonReference_SNM.Size = new Size(60, 40);
            buttonReference_SNM.TabIndex = 3;
            buttonReference_SNM.Text = "Справка";
            buttonReference_SNM.UseVisualStyleBackColor = false;
            buttonReference_SNM.Click += buttonReference_Click;
            // 
            // textBoxStart_SNM
            // 
            textBoxStart_SNM.Location = new Point(6, 47);
            textBoxStart_SNM.Multiline = true;
            textBoxStart_SNM.Name = "textBoxStart_SNM";
            textBoxStart_SNM.Size = new Size(100, 23);
            textBoxStart_SNM.TabIndex = 1;
            // 
            // textBoxStop_SNM
            // 
            textBoxStop_SNM.Location = new Point(112, 47);
            textBoxStop_SNM.Multiline = true;
            textBoxStop_SNM.Name = "textBoxStop_SNM";
            textBoxStop_SNM.Size = new Size(100, 23);
            textBoxStop_SNM.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxData_SNM);
            panel1.Controls.Add(groupBoxTask_SNM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 115);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxResult_SNM);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 336);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartFunction_SNM);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(235, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 336);
            panel3.TabIndex = 6;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(235, 115);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 336);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 451);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(845, 490);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4| Вариант 7 | Стоякин Н.М.";
            groupBoxTask_SNM.ResumeLayout(false);
            groupBoxTask_SNM.PerformLayout();
            groupBoxResult_SNM.ResumeLayout(false);
            groupBoxResult_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SNM).EndInit();
            groupBoxData_SNM.ResumeLayout(false);
            groupBoxData_SNM.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SNM;
        private GroupBox groupBoxResult_SNM;
        private TextBox textBoxTask_SNM;
        private TextBox textBoxResult_SNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SNM;
        private GroupBox groupBoxData_SNM;
        private TextBox textBoxStart_SNM;
        private TextBox textBoxStop_SNM;
        private Label labelTwo_SNM;
        private Label labelOne_SNM;
        private Button buttonDone_SNM;
        private Button buttonSave_SNM;
        private Button buttonReference_SNM;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
    }
}
