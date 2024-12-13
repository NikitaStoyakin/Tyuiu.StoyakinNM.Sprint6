namespace Tyuiu.StoyakinNM.Sprint6.Task6.V2
{
    partial class FormAbout_SNM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SNM));
            textBoxInfo_SNM = new TextBox();
            pictureBoxOne_SNM = new PictureBox();
            buttonDone_SNM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_SNM).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_SNM
            // 
            textBoxInfo_SNM.BorderStyle = BorderStyle.None;
            textBoxInfo_SNM.Location = new Point(184, 12);
            textBoxInfo_SNM.Multiline = true;
            textBoxInfo_SNM.Name = "textBoxInfo_SNM";
            textBoxInfo_SNM.ReadOnly = true;
            textBoxInfo_SNM.Size = new Size(368, 161);
            textBoxInfo_SNM.TabIndex = 0;
            textBoxInfo_SNM.Text = resources.GetString("textBoxInfo_SNM.Text");
            // 
            // pictureBoxOne_SNM
            // 
            pictureBoxOne_SNM.Image = Properties.Resources.p_DSC0978_kopia__2_;
            pictureBoxOne_SNM.Location = new Point(12, 12);
            pictureBoxOne_SNM.Name = "pictureBoxOne_SNM";
            pictureBoxOne_SNM.Size = new Size(166, 198);
            pictureBoxOne_SNM.TabIndex = 1;
            pictureBoxOne_SNM.TabStop = false;
            // 
            // buttonDone_SNM
            // 
            buttonDone_SNM.Location = new Point(500, 187);
            buttonDone_SNM.Name = "buttonDone_SNM";
            buttonDone_SNM.Size = new Size(75, 23);
            buttonDone_SNM.TabIndex = 2;
            buttonDone_SNM.Text = "ОК";
            buttonDone_SNM.UseVisualStyleBackColor = true;
            buttonDone_SNM.Click += buttonDone_SNM_Click;
            // 
            // FormAbout_SNM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 222);
            Controls.Add(buttonDone_SNM);
            Controls.Add(pictureBoxOne_SNM);
            Controls.Add(textBoxInfo_SNM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FormAbout_SNM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_SNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_SNM;
        private PictureBox pictureBoxOne_SNM;
        private Button buttonDone_SNM;
    }
}