namespace Tyuiu.StoyakinNM.Sprint6.Task3.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxOne_SNM = new GroupBox();
            textBoxTask_SNM = new TextBox();
            dataGridViewOne_SNM = new DataGridView();
            groupBoxTwo_SNM = new GroupBox();
            buttonReference_SNM = new Button();
            buttonDone_SNM = new Button();
            labelOne_SNM = new Label();
            textBoxResult_SNM = new TextBox();
            groupBoxOne_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOne_SNM).BeginInit();
            groupBoxTwo_SNM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOne_SNM
            // 
            groupBoxOne_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxOne_SNM.Controls.Add(dataGridViewOne_SNM);
            groupBoxOne_SNM.Location = new Point(12, 12);
            groupBoxOne_SNM.Name = "groupBoxOne_SNM";
            groupBoxOne_SNM.Size = new Size(570, 426);
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
            textBoxTask_SNM.Size = new Size(297, 398);
            textBoxTask_SNM.TabIndex = 1;
            textBoxTask_SNM.Text = resources.GetString("textBoxTask_SNM.Text");
            // 
            // dataGridViewOne_SNM
            // 
            dataGridViewOne_SNM.AccessibleRole = AccessibleRole.IpAddress;
            dataGridViewOne_SNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOne_SNM.Location = new Point(309, 100);
            dataGridViewOne_SNM.Name = "dataGridViewOne_SNM";
            dataGridViewOne_SNM.RowHeadersVisible = false;
            dataGridViewOne_SNM.ShowCellErrors = false;
            dataGridViewOne_SNM.Size = new Size(250, 250);
            dataGridViewOne_SNM.TabIndex = 0;
            // 
            // groupBoxTwo_SNM
            // 
            groupBoxTwo_SNM.Controls.Add(textBoxResult_SNM);
            groupBoxTwo_SNM.Controls.Add(buttonReference_SNM);
            groupBoxTwo_SNM.Controls.Add(buttonDone_SNM);
            groupBoxTwo_SNM.Controls.Add(labelOne_SNM);
            groupBoxTwo_SNM.Location = new Point(588, 12);
            groupBoxTwo_SNM.Name = "groupBoxTwo_SNM";
            groupBoxTwo_SNM.Size = new Size(200, 426);
            groupBoxTwo_SNM.TabIndex = 1;
            groupBoxTwo_SNM.TabStop = false;
            groupBoxTwo_SNM.Text = "Вывод данных";
            // 
            // buttonReference_SNM
            // 
            buttonReference_SNM.Location = new Point(29, 397);
            buttonReference_SNM.Name = "buttonReference_SNM";
            buttonReference_SNM.Size = new Size(40, 25);
            buttonReference_SNM.TabIndex = 3;
            buttonReference_SNM.Text = "?";
            buttonReference_SNM.UseVisualStyleBackColor = true;
            buttonReference_SNM.Click += buttonReference_Click;
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.Location = new Point(94, 397);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(100, 25);
            buttonDone_SNM.TabIndex = 2;
            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.UseVisualStyleBackColor = true;
            buttonDone_SNM.Click += buttonDone_Click;
            // 
            // labelOne_SNM
            // 
            labelOne_SNM.AutoSize = true;
            labelOne_SNM.Location = new Point(6, 30);
            labelOne_SNM.Name = "labelOne_SNM";
            labelOne_SNM.Size = new Size(63, 15);
            labelOne_SNM.TabIndex = 1;
            labelOne_SNM.Text = "Результат:";
            // 
            // textBoxResult_SNM
            // 
            textBoxResult_SNM.Location = new Point(6, 48);
            textBoxResult_SNM.Multiline = true;
            textBoxResult_SNM.Name = "textBoxResult_SNM";
            textBoxResult_SNM.ReadOnly = true;
            textBoxResult_SNM.Size = new Size(188, 343);
            textBoxResult_SNM.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTwo_SNM);
            Controls.Add(groupBoxOne_SNM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2| Вариант 10 | Стоякин Н.М.";
            Load += FormMain_Load;
            groupBoxOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOne_SNM).EndInit();
            groupBoxTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_SNM;
        private TextBox textBoxTask_SNM;
        private DataGridView dataGridViewOne_SNM;
        private GroupBox groupBoxTwo_SNM;
        private Button buttonReference_SNM;
        private Button buttonDone_SNM;
        private Label labelOne_SNM;
        private TextBox textBoxResult_SNM;
    }
}
