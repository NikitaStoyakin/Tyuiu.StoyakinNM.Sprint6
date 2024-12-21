namespace Tyuiu.StoyakinNM.Sprint6.Task7.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonDone_SNM = new Button();
            pictureBoxOne_SNM = new PictureBox();
            textBoxInfo_SNM = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_SNM).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.Location = new Point(477, 187);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(75, 23);
            buttonDone_SNM.TabIndex = 5;
            buttonDone_SNM.Text = "ОК";
            buttonDone_SNM.UseVisualStyleBackColor = true;
            buttonDone_SNM.Click += buttonDone_SNM_Click;
            // 
            // pictureBoxOne_SNM
            // 
            pictureBoxOne_SNM.AccessibleRole = AccessibleRole.IpAddress;
            pictureBoxOne_SNM.Location = new Point(12, 12);
            pictureBoxOne_SNM.Name = "pictureBoxOne_SNM";
            pictureBoxOne_SNM.Size = new Size(166, 198);
            pictureBoxOne_SNM.TabIndex = 4;
            pictureBoxOne_SNM.TabStop = false;
            // 
            // textBoxInfo_SNM
            // 
            textBoxInfo_SNM.BorderStyle = BorderStyle.None;
            textBoxInfo_SNM.Location = new Point(184, 12);
            textBoxInfo_SNM.Multiline = true;
            textBoxInfo_SNM.Name = "textBoxInfo_SNM";
            textBoxInfo_SNM.ReadOnly = true;
            textBoxInfo_SNM.Size = new Size(368, 161);
            textBoxInfo_SNM.TabIndex = 3;
            textBoxInfo_SNM.Text = resources.GetString("textBoxInfo_SNM.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(buttonDone_SNM);
            Controls.Add(pictureBoxOne_SNM);
            Controls.Add(textBoxInfo_SNM);
            MinimumSize = new Size(600, 300);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_SNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_SNM;
        private PictureBox pictureBoxOne_SNM;
        private TextBox textBoxInfo_SNM;
    }
}