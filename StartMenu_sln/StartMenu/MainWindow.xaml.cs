using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StartMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataBase data;

        public MainWindow()
        {
            InitializeComponent();
            data = new DataBase();
            InitializeApplications();
            generateApplicationList();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Initializes applications
        private void InitializeApplications()
        {
            MenuApplication chromeApp = new MenuApplication(data,"Google Chrome", "/images/dark/appbar.chromium.png");
            MenuApplication photoShopApp = new MenuApplication(data,"Adobe Photoshop", "/images/dark/appbar.adobe.photoshop.png");
            MenuApplication illustratorApp = new MenuApplication(data,"Adobe Illustrator", "/images/dark/appbar.adobe.illustrator.png");
            MenuApplication deBugApp = new MenuApplication(data,"Debug", "/images/dark/appbar.bug.png");
            MenuApplication afterEffectsApp = new MenuApplication(data,"Adobe AfterEffects", "/images/dark/appbar.adobe.aftereffects.png");
            MenuApplication paintApp= new MenuApplication(data,"Paint", "/images/dark/appbar.draw.pencil.png");
            MenuApplication webCamApp = new MenuApplication(data,"Web Cam", "/images/dark/appbar.webcam.png");

            data.appList.OrderBy(x => x.name);
        }

        // Generates applications on the UI
        private void generateApplicationList()
        {

            Image[] img = new Image[20];
            //for (int i = 0; i < 20; i++)
            // {
            if (img[0] != null)
            {
                img[0].Source = new BitmapImage(new Uri("D:/Libraries/Git/StartMenu/StartMenu_sln/StartMenu/appbar.acorn.png", UriKind.Absolute));
                img[0].Width = 50;
                img[0].Height = 50;
                StackPanel_AllApps.Children.Add(img[0]);
            }
           // }
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        // Quits program
        private void button_ShutDown_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        // Simulates restart
        private void button_Restart_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            System.Threading.Thread.Sleep(3000);

            this.Show();

        }

        // Sleeps until user does something
        private void button_Sleep_Click(object sender, RoutedEventArgs e)
        {

        }


        private void button_LogOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_SwitchUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newFavourite_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = sender as MenuItem;
            Image img = null;

            if (mnu != null)
            {
                img = ((ContextMenu)mnu.Parent).PlacementTarget as Image;
            }

            img.Source = new BitmapImage(new Uri("D:/Libraries/Git/StartMenu/StartMenu_sln/StartMenu/images/dark/appbar.os.chromium.png"));
            
        }
    }
}
