using System.Windows.Forms;

namespace FormsUI.FacebookAppLogic
{
    internal static class FormFactory
    {
        internal static Form CreateForm(Utils.eFormName i_FormName)
        {
            switch (i_FormName)
            {
                case Utils.eFormName.Game:
                    return new GameForm();
                case Utils.eFormName.Filter:
                    return new FilterForm();
            }
            return null;
        }
    }
}
