namespace Tyuiu.StoyakinNM.Sprint6.Task2.V10
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOne_SNM = new GroupBox();
            textBoxTask_SNM = new TextBox();
            groupBoxTwo_SNM = new GroupBox();
            dataGridViewOne_SNM = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBoxThree_SNM = new GroupBox();
            labelTwo_SNM = new Label();
            labelOne_SNM = new Label();
            buttonReference_SNM = new Button();
            buttonDone_SNM = new Button();
            textBoxStop_SNM = new TextBox();
            textBoxStart_SNM = new TextBox();
            chartFunction_SNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOne_SNM.SuspendLayout();
            groupBoxTwo_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOne_SNM).BeginInit();
            groupBoxThree_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOne_SNM
            // 
            groupBoxOne_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxOne_SNM.Location = new Point(12, 12);
            groupBoxOne_SNM.Name = "groupBoxOne_SNM";
            groupBoxOne_SNM.Size = new Size(570, 280);
            groupBoxOne_SNM.TabIndex = 0;
            groupBoxOne_SNM.TabStop = false;
            groupBoxOne_SNM.Text = "Условие";
            // 
            // textBoxTask_SNM
            // 
            textBoxTask_SNM.BorderStyle = BorderStyle.None;
            textBoxTask_SNM.Location = new Point(6, 22);
            textBoxTask_SNM.Multiline = true;
            textBoxTask_SNM.Name = "textBoxTask_SNM";
            textBoxTask_SNM.ReadOnly = true;
            textBoxTask_SNM.Size = new Size(558, 252);
            textBoxTask_SNM.TabIndex = 1;
            textBoxTask_SNM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxTwo_SNM
            // 
            groupBoxTwo_SNM.Controls.Add(dataGridViewOne_SNM);
            groupBoxTwo_SNM.Controls.Add(label3);
            groupBoxTwo_SNM.Location = new Point(588, 12);
            groupBoxTwo_SNM.Name = "groupBoxTwo_SNM";
            groupBoxTwo_SNM.Size = new Size(200, 428);
            groupBoxTwo_SNM.TabIndex = 1;
            groupBoxTwo_SNM.TabStop = false;
            groupBoxTwo_SNM.Text = "Вывод данных";
            // 
            // dataGridViewOne_SNM
            // 
            dataGridViewOne_SNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOne_SNM.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewOne_SNM.Location = new Point(6, 37);
            dataGridViewOne_SNM.Name = "dataGridViewOne_SNM";
            dataGridViewOne_SNM.ReadOnly = true;
            dataGridViewOne_SNM.RowHeadersVisible = false;
            dataGridViewOne_SNM.Size = new Size(188, 385);
            dataGridViewOne_SNM.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Результат:";
            // 
            // groupBoxThree_SNM
            // 
            groupBoxThree_SNM.Controls.Add(labelTwo_SNM);
            groupBoxThree_SNM.Controls.Add(labelOne_SNM);
            groupBoxThree_SNM.Controls.Add(buttonReference_SNM);
            groupBoxThree_SNM.Controls.Add(buttonDone_SNM);
            groupBoxThree_SNM.Controls.Add(textBoxStop_SNM);
            groupBoxThree_SNM.Controls.Add(textBoxStart_SNM);
            groupBoxThree_SNM.Location = new Point(12, 298);
            groupBoxThree_SNM.Name = "groupBoxThree_SNM";
            groupBoxThree_SNM.Size = new Size(570, 142);
            groupBoxThree_SNM.TabIndex = 2;
            groupBoxThree_SNM.TabStop = false;
            groupBoxThree_SNM.Text = "Ввод данных";
            // 
            // labelTwo_SNM
            // 
            labelTwo_SNM.AutoSize = true;
            labelTwo_SNM.Location = new Point(162, 51);
            labelTwo_SNM.Name = "labelTwo_SNM";
            labelTwo_SNM.Size = new Size(75, 15);
            labelTwo_SNM.TabIndex = 6;
            labelTwo_SNM.Text = "Конец шага:";
            // 
            // labelOne_SNM
            // 
            labelOne_SNM.AutoSize = true;
            labelOne_SNM.Location = new Point(6, 51);
            labelOne_SNM.Name = "labelOne_SNM";
            labelOne_SNM.Size = new Size(72, 15);
            labelOne_SNM.TabIndex = 5;
            labelOne_SNM.Text = "Старт шага:";
            // 
            // buttonReference_SNM
            // 
            buttonReference_SNM.BackColor = SystemColors.MenuHighlight;
            buttonReference_SNM.Location = new Point(328, 44);
            buttonReference_SNM.Name = "buttonReference_SNM";
            buttonReference_SNM.Size = new Size(100, 70);
            buttonReference_SNM.TabIndex = 4;
            buttonReference_SNM.Text = "Справка";
            buttonReference_SNM.UseVisualStyleBackColor = false;
            buttonReference_SNM.Click += buttonReference_Click;
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.BackColor = Color.Green;
            buttonDone_SNM.Location = new Point(434, 44);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(130, 70);
            buttonDone_SNM.TabIndex = 3;
            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.UseVisualStyleBackColor = false;
            buttonDone_SNM.Click += buttonDone_Click;
            buttonDone_SNM.MouseClick += buttonDone_MouseDown;
            buttonDone_SNM.MouseEnter += buttonDone_MouseEnter;
            buttonDone_SNM.MouseLeave += buttonDone_MouseLEave;
            // 
            // textBoxStop_SNM
            // 
            textBoxStop_SNM.Location = new Point(162, 69);
            textBoxStop_SNM.Multiline = true;
            textBoxStop_SNM.Name = "textBoxStop_SNM";
            textBoxStop_SNM.Size = new Size(150, 30);
            textBoxStop_SNM.TabIndex = 2;
            // 
            // textBoxStart_SNM
            // 
            textBoxStart_SNM.Location = new Point(6, 69);
            textBoxStart_SNM.Multiline = true;
            textBoxStart_SNM.Name = "textBoxStart_SNM";
            textBoxStart_SNM.Size = new Size(150, 30);
            textBoxStart_SNM.TabIndex = 0;
            // 
            // chartFunction_SNM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SNM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_SNM.Legends.Add(legend1);
            chartFunction_SNM.Location = new Point(800, 12);
            chartFunction_SNM.Name = "chartFunction_SNM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_SNM.Series.Add(series1);
            chartFunction_SNM.Size = new Size(331, 417);
            chartFunction_SNM.TabIndex = 3;
            chartFunction_SNM.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 441);
            Controls.Add(chartFunction_SNM);
            Controls.Add(groupBoxThree_SNM);
            Controls.Add(groupBoxTwo_SNM);
            Controls.Add(groupBoxOne_SNM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2| Вариант 10 | Стоякин Н.М.";
            groupBoxOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.PerformLayout();
            groupBoxTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOne_SNM).EndInit();
            groupBoxThree_SNM.ResumeLayout(false);
            groupBoxThree_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_SNM;
        private GroupBox groupBoxTwo_SNM;
        private GroupBox groupBoxThree_SNM;
        private TextBox textBoxTask_SNM;
        private TextBox textBoxStop_SNM;
        private TextBox textBoxStart_SNM;
        private Button buttonReference_SNM;
        private Button buttonDone_SNM;
        private Label label3;
        private Label labelTwo_SNM;
        private Label labelOne_SNM;
        private DataGridView dataGridViewOne_SNM;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SNM;
    }
}
