using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsUI.FacebookAppLogic
{
    internal class FeatureMenu : ComboBox
    {
        private List<FeatureMenuItem> m_FeatureMenuItems = new List<FeatureMenuItem>();

        public void AddRange(params FeatureMenuItem[] i_Items)
        {
            int i = 0;
            object[] listOfLables = new object[i_Items.Length];
            foreach (FeatureMenuItem item in i_Items){
                m_FeatureMenuItems.Add(item);
                listOfLables[i] = item.Text;
                i++;
            }
            base.Items.AddRange(listOfLables);
        }

        public void OnClickOption()
        {
            int index = this.SelectedIndex;
            Form form = m_FeatureMenuItems[index].Command.Invoke(m_FeatureMenuItems[index].EnumFormName);
            form.Show();
        }
    }
}
