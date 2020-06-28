using System.Windows.Forms;
using static FormsUI.FacebookAppLogic.Utils;

namespace FormsUI.FacebookAppLogic
{
    internal delegate Form CommandDelegate(eFormName i_EFormName);

    internal class FeatureMenuItem
    {
        public CommandDelegate Command { get; set; }
        public eFormName EnumFormName { get; set; }
        public string Text { get; set; }

        public FeatureMenuItem(CommandDelegate i_Command, string i_Text, eFormName i_EFormName)
        {
            Command = i_Command;
            Text = i_Text;
            EnumFormName = i_EFormName;
        }
    }
}
