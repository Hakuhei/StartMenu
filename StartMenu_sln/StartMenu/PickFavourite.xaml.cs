using System;
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
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;


namespace StartMenu
{
    /// <summary>
    /// Interaction logic for PickFavourite.xaml
    /// </summary>
    public partial class PickFavourite : Window
    {
        private DataBase data;
        Image img;
        Label appLabel;
        Label labelDirectory;
        MenuApplication storeApp;

        MenuApplication fileAdd;
        MenuApplication folderAdd;
        MenuApplication chromeApp;
        MenuApplication photoShopApp;
        MenuApplication illustratorApp;
        MenuApplication deBugApp;
        MenuApplication afterEffectsApp;
        MenuApplication paintApp;
        MenuApplication webCamApp;

        public PickFavourite(Image img, Label appLabel, Label labelDirectory)
        {
            this.img = img;
            this.appLabel = appLabel;
            this.labelDirectory = labelDirectory;
            InitializeComponent();
            this.Title = "New Favourite App";
            data = new DataBase();
            InitializeApps();
            DisplayApps();
        }

        private void DisplayApps()
        {
            button1.Content = afterEffectsApp.nameSpaces;
            button2.Content = illustratorApp.nameSpaces;
            button3.Content = photoShopApp.nameSpaces;
            button4.Content = deBugApp.nameSpaces;
            button5.Content = chromeApp.nameSpaces;
            button6.Content = paintApp.nameSpaces;
            button7.Content = webCamApp.nameSpaces;
            button8.Content = storeApp.nameSpaces;
            addFolderButton.Content = folderAdd.nameSpaces;
            addFileButton.Content = fileAdd.nameSpaces;
        }

        private void InitializeApps()
        {
            string directory;
            directory = Directory.GetCurrentDirectory();

            fileAdd = new MenuApplication(data, "File", (directory + @"\images\dark\appbar.grade.f.png"));
            folderAdd = new MenuApplication(data, "Folder", (directory + @"\images\dark\appbar.folder.open.png"));
            chromeApp = new MenuApplication(data, "Google Chrome", (directory + @"\images\dark\appbar.os.chromium.png"));
            photoShopApp = new MenuApplication(data, "Adobe Photoshop", directory + @"\images\dark\appbar.adobe.photoshop.png");
            illustratorApp = new MenuApplication(data, "Adobe Illustrator", directory + @"\images\dark\appbar.adobe.illustrator.png");
            deBugApp = new MenuApplication(data, "Debug", directory + @"\images\dark\appbar.bug.png");
            afterEffectsApp = new MenuApplication(data, "Adobe AfterEffects", directory + @"\images\dark\appbar.adobe.aftereffects.png");
            paintApp = new MenuApplication(data, "Paint", directory + @"\images\dark\appbar.draw.pencil.png");
            webCamApp = new MenuApplication(data, "Web Cam", directory + @"\images\dark\appbar.webcam.png");
            storeApp = new MenuApplication(data, "Windows Store", directory + @"\images\dark\appbar.marketplace.png");

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            img.Source = afterEffectsApp.img.Source;
            appLabel.Content = afterEffectsApp.nameSpaces;
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            img.Source = illustratorApp.img.Source;
            appLabel.Content = illustratorApp.nameSpaces;
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            img.Source = photoShopApp.img.Source;
            appLabel.Content = photoShopApp.nameSpaces;
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            img.Source = deBugApp.img.Source;
            appLabel.Content = deBugApp.nameSpaces;
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            img.Source = chromeApp.img.Source;
            appLabel.Content = chromeApp.nameSpaces;
            this.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            img.Source = paintApp.img.Source;
            appLabel.Content = paintApp.nameSpaces;
            this.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            img.Source = webCamApp.img.Source;
            appLabel.Content = webCamApp.nameSpaces;
            this.Close();
        }

        private void addFolder_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.Title = "Select Folder";
            dlg.IsFolderPicker = true;
            dlg.InitialDirectory = Directory.GetCurrentDirectory();

            dlg.AddToMostRecentlyUsedList = false;
            dlg.AllowNonFileSystemItems = false;
            dlg.DefaultDirectory = Directory.GetCurrentDirectory();
            dlg.EnsureFileExists = true;
            dlg.EnsurePathExists = true;
            dlg.EnsureReadOnly = false;
            dlg.EnsureValidNames = true;
            dlg.Multiselect = false;
            dlg.ShowPlacesList = true;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var folder = dlg.FileName;
                string lastFolderName = System.IO.Path.GetFileName(folder);

                img.Source = folderAdd.img.Source;
                labelDirectory.Content = folder;
                appLabel.Content = lastFolderName;
                // Do something with selected folder string
            }
            this.Close();

        }

        private void addFile_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.Title = "Select File";
            dlg.IsFolderPicker = false;
            dlg.InitialDirectory = Directory.GetCurrentDirectory();

            dlg.AddToMostRecentlyUsedList = false;
            dlg.AllowNonFileSystemItems = false;
            dlg.DefaultDirectory = Directory.GetCurrentDirectory();
            dlg.EnsureFileExists = true;
            dlg.EnsurePathExists = true;
            dlg.EnsureReadOnly = false;
            dlg.EnsureValidNames = true;
            dlg.Multiselect = false;
            dlg.ShowPlacesList = true;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var folder = dlg.FileName;
                
                string lastFolderName = System.IO.Path.GetFileName(folder);

                img.Source = fileAdd.img.Source;
                labelDirectory.Content = folder;
                appLabel.Content = lastFolderName;
                // Do something with selected folder string
            }
            this.Close();

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            img.Source = storeApp.img.Source;
            appLabel.Content = storeApp.nameSpaces;
            this.Close();
        }
    }
}
