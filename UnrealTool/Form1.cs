using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FunctionGroupBox.Controls.Find(CategoryTextBox.Name, false);
        }
        

        private void FunctionSettingButton_Click(object sender, EventArgs e)
        {
            MakeAndCopyUMacro(true);
        }

        private void PropertySettingButton_Click(object sender, EventArgs e)
        {
            MakeAndCopyUMacro(false);
        }
    }
}
