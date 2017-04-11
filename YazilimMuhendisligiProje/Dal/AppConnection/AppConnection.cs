using System.Collections.Generic;
using System.Linq;

namespace YazilimMuhendisligiProje.Dal
{
    public class AppConnection
    {
        private static readonly List<AppConnectionItem> ConnectionItems = new List<AppConnectionItem>();
        private static string defaultScope = "File";
        private static string defaultKey = "Mdf";
        private static AppConnectionItem defaultConnection;
        public static AppConnectionItem DefaultConnection
        {
            get
            {
                if (defaultConnection != null) return defaultConnection;
                if (ConnectionItems.Count == 0)
                    AppConnectionListFill();
                defaultConnection = ConnectionItems.FirstOrDefault(x => x.Scope == defaultScope && x.Key == defaultKey && x.Status) ?? ConnectionItems[0];
                return defaultConnection;
            }
        }
        public static void AppConnectionListFill()
        {
            ConnectionItems.Add(new AppConnectionItem { Scope = "File", Key = "Mdf", Value = "AppDbContextFileMdf", Status = true });
            ConnectionItems.Add(new AppConnectionItem { Scope = "File", Key = "Sdf", Value = "AppDbContextFileSdf", Status = true });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Local", Key = "Msql", Value = "AppDbContextLocalMsql", Status = true });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Local", Key = "Mysql", Value = "AppDbContextLocalMysql", Status = false });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Local", Key = "Oracle", Value = "AppDbContextLocalOracle", Status = false });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Public", Key = "Msql", Value = "AppDbContextPublicMsql", Status = true });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Azure", Key = "Msql", Value = "ibrahimekinziAzureDbMsqlContext", Status = true });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Public", Key = "Mysql", Value = "AppDbContextPublicMysql", Status = true });
            ConnectionItems.Add(new AppConnectionItem { Scope = "Public", Key = "Oracle", Value = "AppDbContextPublicOracle", Status = false });
        }
    }
}
