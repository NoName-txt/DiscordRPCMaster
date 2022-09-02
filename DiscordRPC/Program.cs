using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Specialized;
using System.Net;
using System.Text.RegularExpressions;
using System.Text;
using static DiscordRPCMaster.DiscordRPCMaster;

namespace DiscordRPCMaster
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiscordRPCMaster());
        }


    }
    public class Config : AppSettings<Config>
    {
        public List<CDatas> Options = new List<CDatas>();

    }
    public class AppSettings<T> where T : new()
    {
        private const string fileName = "DiscordRPCMaster.json";

        public void Save()
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
        }

        public static void Save(T pSettings)
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
        }

        public static T Load()
        {
            T t = new T();
            if (File.Exists(fileName))
                t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
            return t;
        }
    }

    public class CDatas : IEquatable<CDatas>
    {
        public string DataName { get; set; }
        public string clientID { get; set; }
        public string details { get; set; }
        public string state { get; set; }
        public bool timestamp { get; set; }
        public string smallImageName { get; set; }
        public string smallImageText { get; set; }
        public string largeImageName { get; set; }
        public string largeImageText { get; set; }
        public string button1Text { get; set; }
        public string button1Url { get; set; }
        public string button2Text { get; set; }
        public string button2Url { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            CDatas objAsPart = obj as CDatas;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(CDatas other)
        {
            if (other == null) return false;
            return (this.DataName.Equals(other.DataName));
        }
    }
}
