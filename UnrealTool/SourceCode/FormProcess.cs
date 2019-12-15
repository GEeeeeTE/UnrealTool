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
        private void MakeEnumerationUE()
        {
            string enumerationText = GTCS_GTL.EMPTYSTRING;

            // UENUM()
            {
                enumerationText += "UENUM(BlueprintType)" + GTCS_GTL.GetNewLineString();
            }
            // enum class That : uint8
            {
                enumerationText += "enum class E" + EnumeratorTextBlockUserControl.TextBox + " : uint8" + GTCS_GTL.GetNewLineString();
            }
            // Enumeration Body
            {
                // {
                enumerationText += "{" + GTCS_GTL.GetNewLineString();
                {
                    List<string> enumNameList = new List<string>(EnumeratorListBox.Items.Count);
                    foreach (var item in EnumeratorListBox.Items)
                    {
                        enumNameList.Add(item.ToString());
                    }
                    bool bAddMaxEnum = false;
                    foreach (int idxChecked in gtEnumeratorOptionCheckedListBoxControl.CheckedIndices)
                    {
                        if(idxChecked == 0)
                        {
                            enumNameList.AddRange(new string[]{ "MAX", "MAXIDX" });
                            bAddMaxEnum = true;
                        }
                    }
                    // Enumeration
                    int theLastIndex = enumNameList.Count - 1;
                    for (int i = 0; i < enumNameList.Count; i++)
                    {
                        enumerationText += GTCS_GTL.TABSTRING;
                        enumerationText += enumNameList[i];
                        if(GTCS_GTL.ConfirmTrue(bAddMaxEnum))
                        {
                            if (i == (theLastIndex - 1))
                            {
                                enumerationText += GTCS_GTL.TABSTRING + GetUMeta(GTCS_GTL.EMPTYSTRING, true);
                            }
                            else
                            if (i == (theLastIndex))
                            {
                                enumerationText += " = " + enumNameList[i - 1] + " - 1";
                                enumerationText += GTCS_GTL.TABSTRING + GetUMeta(GTCS_GTL.EMPTYSTRING, true);
                            }
                        }


                        if (i < theLastIndex)
                        {
                            enumerationText += ",";
                        }
                        enumerationText += GTCS_GTL.GetNewLineString();
                    }
                }
                // }
                enumerationText += "};\n" + GTCS_GTL.GetNewLineString();
            }

            Clipboard.SetText(enumerationText);
        }
    } // FormProcess
}
