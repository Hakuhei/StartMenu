using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StartMenu
{
    class MenuApplication : IComparable<MenuApplication>
    {
        public String name;
        public int Usage;
        public String imgDirectory;
        public String tooltip;

        // Initialize each application with a name and icon directory
        public MenuApplication(DataBase data, String name, string imgDirectory)
        {
            this.name = name;
            Usage = 0;
            this.imgDirectory = imgDirectory;
            data.appList.Add(this);
        }

        public int CompareTo(MenuApplication app2)
        {
            return this.name.CompareTo(app2.name);
        }

    }
}
