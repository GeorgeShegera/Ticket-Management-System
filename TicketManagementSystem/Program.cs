using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using Newtonsoft.Json;

namespace TicketManagementSystem
{
    internal static class Program
    {
        internal static DataBase dataBase;
        internal static User curUser = null;
        internal static void LoadDataBase()
        {            
            string json = "";
            using (FileStream stream = new FileStream("DataBase.json", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    while (!reader.EndOfStream) json += reader.ReadLine();
            }
            JsonSerializerSettings setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            dataBase = JsonConvert.DeserializeObject<DataBase>(json, setting);
            if (dataBase is null) dataBase = new DataBase();
        }

        internal static void ErrorMessage(string message) => MessageBox.Show(message, "Error",
                                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationWnd());
        }
    }
}
