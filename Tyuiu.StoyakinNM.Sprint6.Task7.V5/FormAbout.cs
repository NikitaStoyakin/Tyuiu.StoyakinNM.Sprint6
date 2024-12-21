using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.StoyakinNM.Sprint6.Task7.V5
{
    public partial class FormAbout: Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonDone_SNM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
