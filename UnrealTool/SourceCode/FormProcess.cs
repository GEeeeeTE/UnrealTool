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
        private void MakeAndCopyUMacro(bool bFuncOrProp)
        {
            string macroU = (bFuncOrProp) ? "UFUNCTION" : "UPROPERTY";
            macroU += "(";
            var indexAvailables = (bFuncOrProp) ? gtFunctionCheckedListBoxControl.CheckedIndices : gtPropertyCheckedListBoxControl.CheckedIndices;
            //GTCS_GTL.ForLoopGT(indexAvailables, delegate (int i, IList<int> val){ }, delegate (){ } );
            for (int i = 0; i < indexAvailables.Count; i++)
            {
                int index = indexAvailables[i];
                macroU += (bFuncOrProp) ? GetFunctionDomain(index) : GetPropertyDomain(index);
                if (index < (indexAvailables.Count - 1))
                {
                    macroU += ", ";
                }
            }

            // カテゴリー名を連結させる
            {
                string []category = GTCS_GTL.DivideString(CategoryTextBox.Text, ",");
                int nCategory = category.Length;
                if(nCategory > 0)
                {
                    macroU += ", ";
                    macroU += "Category = ";

                    string tempCate = string.Empty;
                    for (int i = 0; i < nCategory; i++)
                    {
                        if (GTCS_GTL.ConfirmEmptyStringSP(category[i]) == false)
                        {
                            tempCate += category[i];
                            if (i < (nCategory - 1))
                            {
                                tempCate += "|";
                            }
                        }
                    }
                    macroU += GTCS_GTL.DecorateString(tempCate, "\"");
                }
               
            }
            // metaを連結させる
            {
                
            }

            macroU += ")";
            Clipboard.SetText(macroU);
        }
    } // FormProcess
}
