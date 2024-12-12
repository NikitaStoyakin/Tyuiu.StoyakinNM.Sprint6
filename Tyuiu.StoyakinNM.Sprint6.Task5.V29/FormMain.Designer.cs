namespace Tyuiu.StoyakinNM.Sprint6.Task5.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelOne_SNM = new Panel();
            groupBoxTask_SNM = new GroupBox();
            buttonOpenFile_SNM = new Button();
            buttonReference_SNM = new Button();
            buttonDone_SNM = new Button();
            textBoxTask_SNM = new TextBox();
            panelTwo_SNM = new Panel();
            groupBoxResukt_SNM = new GroupBox();
            dataGridViewResult_SNM = new DataGridView();
            panelThree_SNM = new Panel();
            chartFunction_SNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelOne_SNM.SuspendLayout();
            groupBoxTask_SNM.SuspendLayout();
            panelTwo_SNM.SuspendLayout();
            groupBoxResukt_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SNM).BeginInit();
            panelThree_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SNM).BeginInit();
            SuspendLayout();
            // 
            // panelOne_SNM
            // 
            panelOne_SNM.Controls.Add(groupBoxTask_SNM);
            panelOne_SNM.Dock = DockStyle.Top;
            panelOne_SNM.Location = new Point(0, 0);
            panelOne_SNM.Name = "panelOne_SNM";
            panelOne_SNM.Size = new Size(800, 130);
            panelOne_SNM.TabIndex = 0;
            // 
            // groupBoxTask_SNM
            // 
            groupBoxTask_SNM.Controls.Add(buttonOpenFile_SNM);
            groupBoxTask_SNM.Controls.Add(buttonReference_SNM);
            groupBoxTask_SNM.Controls.Add(buttonDone_SNM);
            groupBoxTask_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxTask_SNM.Dock = DockStyle.Fill;
            groupBoxTask_SNM.Location = new Point(0, 0);
            groupBoxTask_SNM.Name = "groupBoxTask_SNM";
            groupBoxTask_SNM.Size = new Size(800, 130);
            groupBoxTask_SNM.TabIndex = 0;
            groupBoxTask_SNM.TabStop = false;
            groupBoxTask_SNM.Text = "Условие:";
            // 
            // buttonOpenFile_SNM
            // 
            buttonOpenFile_SNM.BackColor = Color.RoyalBlue;
            buttonOpenFile_SNM.Location = new Point(594, 32);
            buttonOpenFile_SNM.Name = "buttonOpenFile_SNM";
            buttonOpenFile_SNM.Size = new Size(80, 80);
            buttonOpenFile_SNM.TabIndex = 5;
            buttonOpenFile_SNM.Text = "Открыть файл";
            buttonOpenFile_SNM.UseVisualStyleBackColor = false;
            buttonOpenFile_SNM.Click += buttonOpenFile_Click;
            // 
            // buttonReference_SNM
            // 
            buttonReference_SNM.BackColor = Color.Turquoise;
            buttonReference_SNM.Location = new Point(680, 32);
            buttonReference_SNM.Name = "buttonReference_SNM";
            buttonReference_SNM.Size = new Size(80, 80);
            buttonReference_SNM.TabIndex = 4;
            buttonReference_SNM.Text = "Справка";
            buttonReference_SNM.UseVisualStyleBackColor = false;
            buttonReference_SNM.Click += buttonReference_Click;
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.BackColor = Color.Green;
            buttonDone_SNM.Location = new Point(508, 32);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(80, 80);
            buttonDone_SNM.TabIndex = 3;
            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.UseVisualStyleBackColor = false;
            buttonDone_SNM.Click += buttonDone_Click;
            // 
            // textBoxTask_SNM
            // 
            textBoxTask_SNM.BorderStyle = BorderStyle.None;
            textBoxTask_SNM.Location = new Point(12, 22);
            textBoxTask_SNM.Multiline = true;
            textBoxTask_SNM.Name = "textBoxTask_SNM";
            textBoxTask_SNM.ReadOnly = true;
            textBoxTask_SNM.Size = new Size(422, 102);
            textBoxTask_SNM.TabIndex = 0;
            textBoxTask_SNM.Text = "Прочитать данные из файла InPutFileTask5V29.txt. Вывести в dataGridView. Вывести все числа, больше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // panelTwo_SNM
            // 
            panelTwo_SNM.Controls.Add(groupBoxResukt_SNM);
            panelTwo_SNM.Dock = DockStyle.Left;
            panelTwo_SNM.Location = new Point(0, 130);
            panelTwo_SNM.Name = "panelTwo_SNM";
            panelTwo_SNM.Size = new Size(200, 331);
            panelTwo_SNM.TabIndex = 1;
            // 
            // groupBoxResukt_SNM
            // 
            groupBoxResukt_SNM.Controls.Add(dataGridViewResult_SNM);
            groupBoxResukt_SNM.Dock = DockStyle.Fill;
            groupBoxResukt_SNM.Location = new Point(0, 0);
            groupBoxResukt_SNM.Name = "groupBoxResukt_SNM";
            groupBoxResukt_SNM.Size = new Size(200, 331);
            groupBoxResukt_SNM.TabIndex = 1;
            groupBoxResukt_SNM.TabStop = false;
            groupBoxResukt_SNM.Text = "Вывод данных:";
            // 
            // dataGridViewResult_SNM
            // 
            dataGridViewResult_SNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SNM.ColumnHeadersVisible = false;
            dataGridViewResult_SNM.Dock = DockStyle.Fill;
            dataGridViewResult_SNM.Location = new Point(3, 19);
            dataGridViewResult_SNM.Name = "dataGridViewResult_SNM";
            dataGridViewResult_SNM.ReadOnly = true;
            dataGridViewResult_SNM.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_SNM.Size = new Size(194, 309);
            dataGridViewResult_SNM.TabIndex = 0;
            // 
            // panelThree_SNM
            // 
            panelThree_SNM.Controls.Add(chartFunction_SNM);
            panelThree_SNM.Controls.Add(splitter1);
            panelThree_SNM.Dock = DockStyle.Fill;
            panelThree_SNM.Location = new Point(200, 130);
            panelThree_SNM.Name = "panelThree_SNM";
            panelThree_SNM.Size = new Size(600, 331);
            panelThree_SNM.TabIndex = 2;
            // 
            // chartFunction_SNM
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_SNM.ChartAreas.Add(chartArea2);
            chartFunction_SNM.Dock = DockStyle.Fill;
            chartFunction_SNM.Location = new Point(10, 0);
            chartFunction_SNM.Name = "chartFunction_SNM";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartFunction_SNM.Series.Add(series2);
            chartFunction_SNM.Size = new Size(590, 331);
            chartFunction_SNM.TabIndex = 1;
            chartFunction_SNM.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 331);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(panelThree_SNM);
            Controls.Add(panelTwo_SNM);
            Controls.Add(panelOne_SNM);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 29 | Стоякин Н. М.";
            panelOne_SNM.ResumeLayout(false);
            groupBoxTask_SNM.ResumeLayout(false);
            groupBoxTask_SNM.PerformLayout();
            panelTwo_SNM.ResumeLayout(false);
            groupBoxResukt_SNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SNM).EndInit();
            panelThree_SNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_SNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne_SNM;
        private GroupBox groupBoxTask_SNM;
        private Panel panelTwo_SNM;
        private GroupBox groupBoxResukt_SNM;
        private Panel panelThree_SNM;
        private Splitter splitter1;
        private Button buttonOpenFile_SNM;
        private Button buttonReference_SNM;
        private Button buttonDone_SNM;
        private TextBox textBoxTask_SNM;
        private DataGridView dataGridViewResult_SNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SNM;
    }
}
