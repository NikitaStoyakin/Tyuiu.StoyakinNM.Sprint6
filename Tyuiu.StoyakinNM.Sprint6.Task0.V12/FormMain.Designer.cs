namespace Tyuiu.StoyakinNM.Sprint6.Task0.V12
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
            pictureBoxFormula_SNM = new PictureBox();
            buttonDone_SNM = new Button();
            textBoxVarA_SNM = new TextBox();
            textBoxResult_SNM = new TextBox();
            groupBoxTwo_SNM = new GroupBox();
            label1 = new Label();
            groupBoxThree_SNM = new GroupBox();
            label3 = new Label();
            buttonHelp_SNM = new Button();
            groupBoxOne_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SNM).BeginInit();
            groupBoxTwo_SNM.SuspendLayout();
            groupBoxThree_SNM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOne_SNM
            // 
            groupBoxOne_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxOne_SNM.Controls.Add(pictureBoxFormula_SNM);
            groupBoxOne_SNM.Location = new Point(12, 12);
            groupBoxOne_SNM.Name = "groupBoxOne_SNM";
            groupBoxOne_SNM.Size = new Size(776, 249);
            groupBoxOne_SNM.TabIndex = 0;
            groupBoxOne_SNM.TabStop = false;
            groupBoxOne_SNM.Text = "Условие";
            // 
            // textBoxTask_SNM
            // 
            textBoxTask_SNM.Location = new Point(6, 22);
            textBoxTask_SNM.Multiline = true;
            textBoxTask_SNM.Name = "textBoxTask_SNM";
            textBoxTask_SNM.ReadOnly = true;
            textBoxTask_SNM.Size = new Size(384, 221);
            textBoxTask_SNM.TabIndex = 0;
            textBoxTask_SNM.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_SNM
            // 
            pictureBoxFormula_SNM.Image = Properties.Resources.Снимок;
            pictureBoxFormula_SNM.Location = new Point(417, 22);
            pictureBoxFormula_SNM.Name = "pictureBoxFormula_SNM";
            pictureBoxFormula_SNM.Size = new Size(304, 161);
            pictureBoxFormula_SNM.TabIndex = 1;
            pictureBoxFormula_SNM.TabStop = false;
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.Location = new Point(646, 391);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(142, 47);
            buttonDone_SNM.TabIndex = 2;
            buttonDone_SNM.Text = "Выполнить";
            buttonDone_SNM.UseVisualStyleBackColor = true;
            buttonDone_SNM.Click += buttonDone_Click;
            // 
            // textBoxVarA_SNM
            // 
            textBoxVarA_SNM.Location = new Point(30, 48);
            textBoxVarA_SNM.Name = "textBoxVarA_SNM";
            textBoxVarA_SNM.Size = new Size(150, 23);
            textBoxVarA_SNM.TabIndex = 5;
            // 
            // textBoxResult_SNM
            // 
            textBoxResult_SNM.Location = new Point(40, 48);
            textBoxResult_SNM.Name = "textBoxResult_SNM";
            textBoxResult_SNM.ReadOnly = true;
            textBoxResult_SNM.Size = new Size(180, 23);
            textBoxResult_SNM.TabIndex = 6;
            // 
            // groupBoxTwo_SNM
            // 
            groupBoxTwo_SNM.Controls.Add(label1);
            groupBoxTwo_SNM.Controls.Add(textBoxVarA_SNM);
            groupBoxTwo_SNM.Location = new Point(12, 267);
            groupBoxTwo_SNM.Name = "groupBoxTwo_SNM";
            groupBoxTwo_SNM.Size = new Size(506, 171);
            groupBoxTwo_SNM.TabIndex = 7;
            groupBoxTwo_SNM.TabStop = false;
            groupBoxTwo_SNM.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Переменная X:";
            // 
            // groupBoxThree_SNM
            // 
            groupBoxThree_SNM.Controls.Add(label3);
            groupBoxThree_SNM.Controls.Add(textBoxResult_SNM);
            groupBoxThree_SNM.Location = new Point(524, 267);
            groupBoxThree_SNM.Name = "groupBoxThree_SNM";
            groupBoxThree_SNM.Size = new Size(264, 111);
            groupBoxThree_SNM.TabIndex = 1;
            groupBoxThree_SNM.TabStop = false;
            groupBoxThree_SNM.Text = "Вывод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 30);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Результат:";
            // 
            // buttonHelp_SNM
            // 
            buttonHelp_SNM.FlatStyle = FlatStyle.Flat;
            buttonHelp_SNM.Location = new Point(548, 391);
            buttonHelp_SNM.Name = "buttonHelp_SNM";
            buttonHelp_SNM.Size = new Size(60, 48);
            buttonHelp_SNM.TabIndex = 1;
            buttonHelp_SNM.Text = "?";
            buttonHelp_SNM.UseVisualStyleBackColor = true;
            buttonHelp_SNM.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_SNM);
            Controls.Add(buttonDone_SNM);
            Controls.Add(groupBoxThree_SNM);
            Controls.Add(groupBoxTwo_SNM);
            Controls.Add(groupBoxOne_SNM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Стоякин Н.М.";
            groupBoxOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SNM).EndInit();
            groupBoxTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.PerformLayout();
            groupBoxThree_SNM.ResumeLayout(false);
            groupBoxThree_SNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_SNM;
        private PictureBox pictureBoxFormula_SNM;
        private Button buttonDone_SNM;
        private TextBox textBoxVarA_SNM;
        private TextBox textBoxResult_SNM;
        private GroupBox groupBoxTwo_SNM;
        private Label label1;
        private GroupBox groupBoxThree_SNM;
        private Label label3;
        private TextBox textBoxTask_SNM;
        private Button buttonHelp_SNM;
    }
}
