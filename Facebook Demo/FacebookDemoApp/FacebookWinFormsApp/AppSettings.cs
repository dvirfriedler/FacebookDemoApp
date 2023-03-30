using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FacebookWinFormsApp
{
    public class AppSettings
    {
        private static readonly string sr_FileName;

        static AppSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }

        private AppSettings()
        {
        }

        private static AppSettings s_This;

        public static AppSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = AppSettings.LoadFromFileOrDefault();
                }

                return s_This;
            }
        }

        public static AppSettings LoadFromFileOrDefault()
        {
            AppSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedThis = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new AppSettings()
                {
                    AutoLogin = false,
                };
            }

            return loadedThis;
        }

        public bool AutoLogin { get; set; }

        public Point LastWindowLocation { get; set; }

        public string AccessToken { get; set; }

        public void SaveToFile()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}
