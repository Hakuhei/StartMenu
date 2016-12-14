using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace StartMenu
{
    class MenuApplication : IComparable<MenuApplication>
    {
        public String name;
        public int Usage;
        public Image img = new Image();

        // Initialize each application with a name and icon directory
        public MenuApplication(DataBase data, String name, string imgDirectory)
        {
            this.name = name;
            img.Name = name;
            Usage = 0;
            img.Source = new BitmapImage(new Uri(imgDirectory));
            data.appList.Add(this);
        }

        public int CompareTo(MenuApplication app2)
        {
            return this.name.CompareTo(app2.name);
        }

    }
}
