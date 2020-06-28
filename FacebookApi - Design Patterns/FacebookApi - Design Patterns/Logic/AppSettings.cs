using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FormsUI.FacebookAppLogic
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings(){ }

        public void SaveToFile()
        {
            FileMode fileMode;
            if (!File.Exists(WelcomeForm.sr_AccessTokenFilePath))
            {
                fileMode = FileMode.Create;
            }
            else
            {
                fileMode = FileMode.Truncate;
            }
            using (Stream stream = new FileStream(WelcomeForm.sr_AccessTokenFilePath, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            appSettings.LastWindowSize = new Size(760, 690);
            appSettings.LastWindowLocation = new Point(0, 0);
            if (File.Exists(WelcomeForm.sr_AccessTokenFilePath))
            {
                if (!String.IsNullOrEmpty(File.ReadAllText(WelcomeForm.sr_AccessTokenFilePath)))
                {
                    using (Stream stream = new FileStream(WelcomeForm.sr_AccessTokenFilePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                }
            }

            return appSettings;
        }
    }
}
