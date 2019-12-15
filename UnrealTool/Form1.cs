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
            FunctionMacroGroupBox.Controls.Find(CategoryTextBox.Name, false);
        }
        

        private void FunctionSettingButton_Click(object sender, EventArgs e)
        {
            MakeAndCopyUMacro(true);
        }

        private void PropertySettingButton_Click(object sender, EventArgs e)
        {
            MakeAndCopyUMacro(false);
        }

        private void AddEnumeratorButton_Click(object sender, EventArgs e)
        {
            string text = gtEnumeratorTextBoxControl.Text;
            // テキストが空だと列挙に追加できないのでreturn
            if (GTCS_GTL.ConfirmEmptyStringSP(text)) { return; }
            // 既に存在している列挙名の場合return
            foreach (string item in EnumeratorListBox.Items)
            {
                if(text == item) { return; }
            }

            // 未だ追加されていない列挙名なので列挙体リストに追加する
            GTCS_GTL.AddItemListBox(EnumeratorListBox, text);
        }

        private void CommonListBox_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            if(listbox == null) { return; }


            if(e.KeyCode == Keys.Delete)
            {
                foreach (var item in listbox.SelectedItems)
                {
                    listbox.Items.Remove(item);
                }
            }
        }

        private void EnumeratorSettingButton_Click(object sender, EventArgs e)
        {
            MakeEnumerationUE();
        }
    }
}
