namespace Tyuiu.StoyakinNM.Sprint6.Task6.V2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelOne_SNM = new Panel();
            buttonDone_SNM = new Button();
            buttonFile_SNM = new Button();
            buttonReference_SNM = new Button();
            groupBoxOne_SNM = new GroupBox();
            textBoxTask_SNM = new TextBox();
            panelTwo_SNM = new Panel();
            groupBoxTwo_SNM = new GroupBox();
            textBoxInput_SNM = new TextBox();
            panelThree_SNM = new Panel();
            groupBoxThree_SNM = new GroupBox();
            textBoxResult_SNM = new TextBox();
            splitterOne_SNM = new Splitter();
            openFileDialog_SNM = new OpenFileDialog();
            toolTip_SNM = new ToolTip(components);
            panelOne_SNM.SuspendLayout();
            groupBoxOne_SNM.SuspendLayout();
            panelTwo_SNM.SuspendLayout();
            groupBoxTwo_SNM.SuspendLayout();
            panelThree_SNM.SuspendLayout();
            groupBoxThree_SNM.SuspendLayout();
            SuspendLayout();
            // 
            // panelOne_SNM
            // 
            panelOne_SNM.Controls.Add(buttonDone_SNM);
            panelOne_SNM.Controls.Add(buttonFile_SNM);
            panelOne_SNM.Controls.Add(buttonReference_SNM);
            panelOne_SNM.Controls.Add(groupBoxOne_SNM);
            panelOne_SNM.Dock = DockStyle.Top;
            panelOne_SNM.Location = new Point(0, 0);
            panelOne_SNM.Name = "panelOne_SNM";
            panelOne_SNM.Size = new Size(784, 150);
            panelOne_SNM.TabIndex = 0;
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.Location = new Point(98, 13);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(80, 50);
            buttonDone_SNM.TabIndex = 5;
            buttonDone_SNM.Text = "выполнить";
            toolTip_SNM.SetToolTip(buttonDone_SNM, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonDone_SNM.UseVisualStyleBackColor = true;
            buttonDone_SNM.Click += buttonDone_Click;
            // 
            // buttonFile_SNM
            // 
            buttonFile_SNM.Location = new Point(12, 12);
            buttonFile_SNM.Name = "buttonFile_SNM";
            buttonFile_SNM.Size = new Size(80, 50);
            buttonFile_SNM.TabIndex = 4;
            buttonFile_SNM.Text = "открыть файл";
            buttonFile_SNM.UseVisualStyleBackColor = true;
            buttonFile_SNM.Click += buttonOpenFile_Click;
            // 
            // buttonReference_SNM
            // 
            buttonReference_SNM.Location = new Point(692, 13);
            buttonReference_SNM.Name = "buttonReference_SNM";
            buttonReference_SNM.Size = new Size(80, 50);
            buttonReference_SNM.TabIndex = 3;
            buttonReference_SNM.Text = "помощь";
            buttonReference_SNM.UseVisualStyleBackColor = true;
            buttonReference_SNM.Click += buttonHelp_Click;
            // 
            // groupBoxOne_SNM
            // 
            groupBoxOne_SNM.Controls.Add(textBoxTask_SNM);
            groupBoxOne_SNM.Dock = DockStyle.Bottom;
            groupBoxOne_SNM.Location = new Point(0, 69);
            groupBoxOne_SNM.Name = "groupBoxOne_SNM";
            groupBoxOne_SNM.Size = new Size(784, 81);
            groupBoxOne_SNM.TabIndex = 0;
            groupBoxOne_SNM.TabStop = false;
            groupBoxOne_SNM.Text = "Условие:";
            // 
            // textBoxTask_SNM
            // 
            textBoxTask_SNM.BorderStyle = BorderStyle.None;
            textBoxTask_SNM.Dock = DockStyle.Fill;
            textBoxTask_SNM.Location = new Point(3, 19);
            textBoxTask_SNM.Multiline = true;
            textBoxTask_SNM.Name = "textBoxTask_SNM";
            textBoxTask_SNM.ReadOnly = true;
            textBoxTask_SNM.Size = new Size(778, 59);
            textBoxTask_SNM.TabIndex = 1;
            textBoxTask_SNM.Text = resources.GetString("textBoxTask_SNM.Text");
            // 
            // panelTwo_SNM
            // 
            panelTwo_SNM.Controls.Add(groupBoxTwo_SNM);
            panelTwo_SNM.Dock = DockStyle.Left;
            panelTwo_SNM.Location = new Point(0, 150);
            panelTwo_SNM.Name = "panelTwo_SNM";
            panelTwo_SNM.Size = new Size(375, 311);
            panelTwo_SNM.TabIndex = 1;
            // 
            // groupBoxTwo_SNM
            // 
            groupBoxTwo_SNM.Controls.Add(textBoxInput_SNM);
            groupBoxTwo_SNM.Dock = DockStyle.Fill;
            groupBoxTwo_SNM.Location = new Point(0, 0);
            groupBoxTwo_SNM.Name = "groupBoxTwo_SNM";
            groupBoxTwo_SNM.Size = new Size(375, 311);
            groupBoxTwo_SNM.TabIndex = 0;
            groupBoxTwo_SNM.TabStop = false;
            groupBoxTwo_SNM.Text = "Ввод:";
            // 
            // textBoxInput_SNM
            // 
            textBoxInput_SNM.BorderStyle = BorderStyle.None;
            textBoxInput_SNM.Location = new Point(3, 49);
            textBoxInput_SNM.Multiline = true;
            textBoxInput_SNM.Name = "textBoxInput_SNM";
            textBoxInput_SNM.ReadOnly = true;
            textBoxInput_SNM.ScrollBars = ScrollBars.Vertical;
            textBoxInput_SNM.Size = new Size(369, 259);
            textBoxInput_SNM.TabIndex = 0;
            // 
            // panelThree_SNM
            // 
            panelThree_SNM.Controls.Add(groupBoxThree_SNM);
            panelThree_SNM.Controls.Add(splitterOne_SNM);
            panelThree_SNM.Dock = DockStyle.Fill;
            panelThree_SNM.Location = new Point(375, 150);
            panelThree_SNM.Name = "panelThree_SNM";
            panelThree_SNM.Size = new Size(409, 311);
            panelThree_SNM.TabIndex = 2;
            // 
            // groupBoxThree_SNM
            // 
            groupBoxThree_SNM.Controls.Add(textBoxResult_SNM);
            groupBoxThree_SNM.Dock = DockStyle.Fill;
            groupBoxThree_SNM.Location = new Point(3, 0);
            groupBoxThree_SNM.Name = "groupBoxThree_SNM";
            groupBoxThree_SNM.Size = new Size(406, 311);
            groupBoxThree_SNM.TabIndex = 1;
            groupBoxThree_SNM.TabStop = false;
            groupBoxThree_SNM.Text = "Вывод:";
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
            textBoxResult_SNM.Size = new Size(400, 289);
            textBoxResult_SNM.TabIndex = 1;
            // 
            // splitterOne_SNM
            // 
            splitterOne_SNM.Location = new Point(0, 0);
            splitterOne_SNM.Name = "splitterOne_SNM";
            splitterOne_SNM.Size = new Size(3, 311);
            splitterOne_SNM.TabIndex = 0;
            splitterOne_SNM.TabStop = false;
            // 
            // toolTip_SNM
            // 
            toolTip_SNM.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SNM.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panelThree_SNM);
            Controls.Add(panelTwo_SNM);
            Controls.Add(panelOne_SNM);
            MinimumSize = new Size(800, 400);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 2 | Стоякин Н.М.";
            panelOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.ResumeLayout(false);
            groupBoxOne_SNM.PerformLayout();
            panelTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.ResumeLayout(false);
            groupBoxTwo_SNM.PerformLayout();
            panelThree_SNM.ResumeLayout(false);
            groupBoxThree_SNM.ResumeLayout(false);
            groupBoxThree_SNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne_SNM;
        private Panel panelTwo_SNM;
        private Panel panelThree_SNM;
        private Splitter splitterOne_SNM;
        private GroupBox groupBoxOne_SNM;
        private GroupBox groupBoxTwo_SNM;
        private GroupBox groupBoxThree_SNM;
        private TextBox textBoxTask_SNM;
        private TextBox textBoxInput_SNM;
        private TextBox textBoxResult_SNM;
        private Button buttonDone_SNM;
        private Button buttonFile_SNM;
        private Button buttonReference_SNM;
        private OpenFileDialog openFileDialog_SNM;
        private ToolTip toolTip_SNM;
    }
}
