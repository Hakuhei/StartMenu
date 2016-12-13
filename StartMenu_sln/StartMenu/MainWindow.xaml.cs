using System;
using System.Collections;
using System.Collections.Generic;
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

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // Generates applications on the UI
        private void generateApplicationList()
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
    }
}
