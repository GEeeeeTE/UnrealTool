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
    public partial class Form1
    {
        private string GetFunctionDomain(int index)
        {
            string domain = string.Empty;
            var items = gtFunctionCheckedListBoxControl.Items;
            string[] templateUFUNCTIONMacros = new string[]
            {
                "BlueprintCallable",
                "BlueprintPure",
            };
            if (GTCS_GTL.ConfirmOutOfRangeVoid(templateUFUNCTIONMacros, index) == false)
            {
                domain = templateUFUNCTIONMacros[index];
            }
            return domain;
        }
        private string GetPropertyDomain(int index)
        {
            string domain = string.Empty;
            var items = gtPropertyCheckedListBoxControl.Items;
            string[] templateUPROPERTYMacros = new string[]
            {
                // �ҏW����(ReadWrite)
                "EditAnywhere",
                "EditInstanceOnly",
                "EditDefaultsOnly",
                // �{������(ReadOnly)
                "VisibleAnywhere",
                "VisibleInstanceOnly",
                "VisibleDefaultsOnly",
            };
            if (GTCS_GTL.ConfirmOutOfRangeVoid(templateUPROPERTYMacros, index) == false)
            {
                domain = templateUPROPERTYMacros[index];
            }
            return domain;
        }
    } // Accessor
}
