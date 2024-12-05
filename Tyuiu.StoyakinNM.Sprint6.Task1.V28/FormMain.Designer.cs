namespace Tyuiu.StoyakinNM.Sprint6.Task1.V28
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
            groupBoxOne_SNM = new GroupBox();
            textBoxTask_SNM = new TextBox();
            groupBoxTwo_SNM = new GroupBox();
            labelThree_SNM = new Label();
            textBoxResult_SNM = new TextBox();
            groupBoxThree_SNM = new GroupBox();
            labelTwo_SNM = new Label();
            labelOne_SNM = new Label();
            buttonDone_SNM = new Button();
            buttonReference_SNM = new Button();
            textBoxStop_SNM = new TextBox();
            textBoxStart_SNM = new TextBox();
            pictureBox1 = new PictureBox();
            groupBoxOne_SNM.SuspendLayout();
            groupBoxTwo_SNM.SuspendLayout();
            groupBoxThree_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOne_SNM
            // 
            groupBoxOne_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxOne_SNM.Location = new Point(12, 12);
            groupBoxOne_SNM.Name = "groupBoxOne_SNM";
            groupBoxOne_SNM.Size = new Size(532, 140);
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
            textBoxTask_SNM.Size = new Size(526, 112);
            textBoxTask_SNM.TabIndex = 0;
            textBoxTask_SNM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxTwo_SNM
            // 
            groupBoxTwo_SNM.Controls.Add(labelThree_SNM);
            groupBoxTwo_SNM.Controls.Add(textBoxResult_SNM);
            groupBoxTwo_SNM.Location = new Point(550, 12);
            groupBoxTwo_SNM.Name = "groupBoxTwo_SNM";
            groupBoxTwo_SNM.Size = new Size(238, 426);
            groupBoxTwo_SNM.TabIndex = 1;
            groupBoxTwo_SNM.TabStop = false;
            groupBoxTwo_SNM.Text = "Вывод данных";
            // 
            // labelThree_SNM
            // 
            labelThree_SNM.AutoSize = true;
            labelThree_SNM.Location = new Point(6, 23);
            labelThree_SNM.Name = "labelThree_SNM";
            labelThree_SNM.Size = new Size(63, 15);
            labelThree_SNM.TabIndex = 1;
            labelThree_SNM.Text = "Результат:";
            // 
            // textBoxResult_SNM
            // 
            textBoxResult_SNM.BorderStyle = BorderStyle.None;
            textBoxResult_SNM.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SNM.Location = new Point(6, 41);
            textBoxResult_SNM.Multiline = true;
            textBoxResult_SNM.Name = "textBoxResult_SNM";
            textBoxResult_SNM.ReadOnly = true;
            textBoxResult_SNM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SNM.Size = new Size(226, 379);
            textBoxResult_SNM.TabIndex = 0;
            // 
            // groupBoxThree_SNM
            // 
            groupBoxThree_SNM.Controls.Add(labelTwo_SNM);
            groupBoxThree_SNM.Controls.Add(labelOne_SNM);
            groupBoxThree_SNM.Controls.Add(buttonDone_SNM);
            groupBoxThree_SNM.Controls.Add(buttonReference_SNM);
            groupBoxThree_SNM.Controls.Add(textBoxStop_SNM);
            groupBoxThree_SNM.Controls.Add(textBoxStart_SNM);
            groupBoxThree_SNM.Location = new Point(12, 320);
            groupBoxThree_SNM.Name = "groupBoxThree_SNM";
            groupBoxThree_SNM.Size = new Size(532, 118);
            groupBoxThree_SNM.TabIndex = 2;
            groupBoxThree_SNM.TabStop = false;
            groupBoxThree_SNM.Text = "Ввод данных";
            // 
            // labelTwo_SNM
            // 
            labelTwo_SNM.AutoSize = true;
            labelTwo_SNM.Location = new Point(162, 38);
            labelTwo_SNM.Name = "labelTwo_SNM";
            labelTwo_SNM.Size = new Size(75, 15);
            labelTwo_SNM.TabIndex = 5;
            labelTwo_SNM.Text = "Конец шага:";
            // 
            // labelOne_SNM
            // 
            labelOne_SNM.AutoSize = true;
            labelOne_SNM.Location = new Point(6, 38);
            labelOne_SNM.Name = "labelOne_SNM";
            labelOne_SNM.Size = new Size(72, 15);
            labelOne_SNM.TabIndex = 4;
            labelOne_SNM.Text = "Старт шага:";
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.BackColor = Color.ForestGreen;
            buttonDone_SNM.Location = new Point(399, 38);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(127, 57);
            buttonDone_SNM.TabIndex = 3;
            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.UseVisualStyleBackColor = false;
            buttonDone_SNM.Click += buttonDone_Click;
            // 
            // buttonReference_SNM
            // 
            buttonReference_SNM.BackColor = SystemColors.Highlight;
            buttonReference_SNM.Location = new Point(318, 38);
            buttonReference_SNM.Name = "buttonReference_SNM";
            buttonReference_SNM.Size = new Size(75, 57);
            buttonReference_SNM.TabIndex = 2;
            buttonReference_SNM.Text = "Справка";
            buttonReference_SNM.UseVisualStyleBackColor = false;
            buttonReference_SNM.Click += buttonReference_Click;
            // 
            // textBoxStop_SNM
            // 
            textBoxStop_SNM.Location = new Point(162, 56);
            textBoxStop_SNM.Multiline = true;
            textBoxStop_SNM.Name = "textBoxStop_SNM";
            textBoxStop_SNM.Size = new Size(150, 26);
            textBoxStop_SNM.TabIndex = 1;
            // 
            // textBoxStart_SNM
            // 
            textBoxStart_SNM.Location = new Point(6, 56);
            textBoxStart_SNM.Multiline = true;
            textBoxStart_SNM.Name = "textBoxStart_SNM";
            textBoxStart_SNM.Size = new Size(150, 26);
            textBoxStart_SNM.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок1;
            pictureBox1.Location = new Point(12, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 156);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxThree_SNM);
            Controls.Add(groupBoxTwo_SNM);
            Controls.Add(groupBoxOne_SNM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 28 | Стоякин Н.М.";
            groupBoxOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.PerformLayout();
            groupBoxTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.PerformLayout();
            groupBoxThree_SNM.ResumeLayout(false);
            groupBoxThree_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_SNM;
        private TextBox textBoxTask_SNM;
        private GroupBox groupBoxTwo_SNM;
        private TextBox textBoxResult_SNM;
        private GroupBox groupBoxThree_SNM;
        private Button buttonDone_SNM;
        private Button buttonReference_SNM;
        private TextBox textBoxStop_SNM;
        private TextBox textBoxStart_SNM;
        private PictureBox pictureBox1;
        private Label labelTwo_SNM;
        private Label labelOne_SNM;
        private Label labelThree_SNM;
    }
}
