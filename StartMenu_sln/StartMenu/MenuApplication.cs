using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace StartMenu
{
    class MenuApplication : IComparable<MenuApplication>
    {
        
        public string nameSpaces;
        public int Usage;
        public Image img = new Image();

        // Initialize each application with a name and icon directory
        public MenuApplication(DataBase data, string nameSpaces, string imgDirectory)
        {
            this.nameSpaces = nameSpaces;
            Usage = 0;
            img.Source = new BitmapImage(new Uri(imgDirectory));
            data.appList.Add(this);
        }

        public int CompareTo(MenuApplication app2)
        {
            return 0;
        }

    }
}
