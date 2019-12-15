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
                "BlueprintImplementableEvent",
                "BlueprintNativeEvent",
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
        private string GetUMeta(string displayName, bool bHidden)
        {
            string temp = GTCS_GTL.EMPTYSTRING;
            if(GTCS_GTL.ConfirmFalse(GTCS_GTL.ConfirmEmptyStringSP(displayName)))
            {
                temp += "DisplayName=" + GTCS_GTL.DecorateString(displayName, "\"");
                temp += ",";
            }
            if(GTCS_GTL.ConfirmTrue(bHidden))
            {
                temp += "Hidden";
            }

            // �e���ꂼ��ɍŌ�R���}���܂߂Ă���̂ōŌゾ���͗v��Ȃ��̂ł���Ύ�菜���Ă���
            if(temp.EndsWith(","))
            {
                temp = temp.Remove(temp.Length - 1);
            }
            
            // FinalGatheringString..
            if(GTCS_GTL.ConfirmFalse(GTCS_GTL.ConfirmEmptyStringSP(temp)))
            {
                return GTCS_GTL.DecorateString(temp, "UMETA(", ")");
            }

            // Return Empty..
            return temp;
        }
    } // Accessor
}
