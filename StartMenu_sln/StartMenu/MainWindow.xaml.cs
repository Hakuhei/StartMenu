using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        MenuApplication fileAdd;
        MenuApplication folderAdd;
        MenuApplication addApp;
        MenuApplication chromeApp;
        MenuApplication photoShopApp;
        MenuApplication illustratorApp;
        MenuApplication deBugApp;
        MenuApplication afterEffectsApp;
        MenuApplication paintApp;
        MenuApplication webCamApp;

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
            string directory;
            directory = Directory.GetCurrentDirectory();

            fileAdd = new MenuApplication(data, "File", (directory + @"\images\dark\appbar.grade.f.png"));
            folderAdd = new MenuApplication(data, "Folder", (directory + @"\images\dark\appbar.folder.open.png"));
            addApp = new MenuApplication(data, "Add Favourite", (directory + @"\images\dark\appbar.add.png"));
            chromeApp = new MenuApplication(data, "Google Chrome", (directory + @"\images\dark\appbar.os.chromium.png"));
            photoShopApp = new MenuApplication(data, "Adobe Photoshop", directory + @"\images\dark\appbar.adobe.photoshop.png");
            illustratorApp = new MenuApplication(data, "Adobe Illustrator", directory + @"\images\dark\appbar.adobe.illustrator.png");
            deBugApp = new MenuApplication(data, "Debug", directory + @"\images\dark\appbar.bug.png");
            afterEffectsApp = new MenuApplication(data, "Adobe AfterEffects", directory + @"\images\dark\appbar.adobe.aftereffects.png");
            paintApp= new MenuApplication(data, "Paint", directory + @"\images\dark\appbar.draw.pencil.png");
            webCamApp = new MenuApplication(data, "Web Cam",  directory + @"\images\dark\appbar.webcam.png");

            Favourite1.Source = addApp.img.Source;
            Favourite2.Source = addApp.img.Source;
            Favourite3.Source = addApp.img.Source;
            Favourite4.Source = addApp.img.Source;
            Favourite5.Source = addApp.img.Source;
            Favourite6.Source = addApp.img.Source;
            F1text.Content = addApp.nameSpaces;
            F2text.Content = addApp.nameSpaces;
            F3text.Content = addApp.nameSpaces;
            F4text.Content = addApp.nameSpaces;
            F5text.Content = addApp.nameSpaces;
            F6text.Content = addApp.nameSpaces;


            //data.appList.OrderBy(x => x.name);
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
            Label lbl = null;
            Label lbl2 = null;

            if (mnu != null)
            {
                img = ((ContextMenu)mnu.Parent).PlacementTarget as Image;
            }

            lbl = getLabel(img);
            lbl2 = getSecondaryLabel(img);
            
            PickFavourite secondWindow = new PickFavourite(img, lbl, lbl2);
            secondWindow.Show();

        }

        private Label getLabel(Image inimg)
        {
            Label retLabel = null;
            switch (inimg.Name)
            {
                case "Favourite1":
                    retLabel = F1text;
                    break;
                case "Favourite2":
                    retLabel = F2text;
                    break;
                case "Favourite3":
                    retLabel = F3text;
                    break;
                case "Favourite4":
                    retLabel = F4text;
                    break;
                case "Favourite5":
                    retLabel = F5text;
                    break;
                case "Favourite6":
                    retLabel = F6text;
                    break;
            }
            return retLabel;
        }
        private Label getSecondaryLabel(Image inimg)
        {
            Label retLabel = null;
            switch (inimg.Name)
            {
                case "Favourite1":
                    retLabel = F1text_Copy;
                    break;
                case "Favourite2":
                    retLabel = F2text_Copy;
                    break;
                case "Favourite3":
                    retLabel = F3text_Copy;
                    break;
                case "Favourite4":
                    retLabel = F4text_Copy;
                    break;
                case "Favourite5":
                    retLabel = F5text_Copy;
                    break;
                case "Favourite6":
                    retLabel = F6text_Copy;
                    break;
            }
            return retLabel;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeFavourite_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = sender as MenuItem;
            Image img = null;
            Label lbl = null;

            if (mnu != null)
            {
                img = ((ContextMenu)mnu.Parent).PlacementTarget as Image;
            }
            lbl = getLabel(img);

            img.Source = addApp.img.Source;
            lbl.Content = addApp.nameSpaces;



        }

        private void Favourite_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image  img = sender as Image;
            
            Label lbl = null;
            Label lbl2 = null;
            lbl = getLabel(img);
            lbl2 = getSecondaryLabel(img);

            //Debug.WriteLine(lbl + " bool: " + lbl.Content.Equals("Add Favourite"));
            if (!lbl.Content.Equals("Add Favourite"))
            {
                string imageSource = Convert.ToString(img.Source);
                string fileSource = Convert.ToString(fileAdd.img.Source);
                string folderSource = Convert.ToString(folderAdd.img.Source);

                if (imageSource.Equals(fileSource))
                {
                    Debug.WriteLine("Is a file");
                    string getDirectory = Convert.ToString(lbl2.Content);
                    Process.Start(getDirectory);
                }
                else if (imageSource.Equals(folderSource))
                {
                    Debug.WriteLine("Is a folder");
                    string getDirectory = Convert.ToString(lbl2.Content);
                    Process.Start(getDirectory);

                }

                return;
            }
            PickFavourite secondWindow = new PickFavourite(img, lbl, lbl2);
            secondWindow.Show();
        }

        private void Favourite2_Drop(object sender, DragEventArgs e)
        {
            Image img = sender as Image;

            Label lbl = null;
            Label lbl2 = null;
            lbl = getLabel(img);
            lbl2 = getSecondaryLabel(img);

            if (!lbl.Content.Equals("Add Favourite"))
                return;

            List<string> filepaths = new List<string>();
            foreach (var s in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                if (Directory.Exists(s))
                {
                    
                    //Add files from folder
                    //filepaths.AddRange(Directory.GetFiles(s));
                    Debug.WriteLine("Folder: " + Directory.GetFiles(s));
                    img.Source = folderAdd.img.Source;
                    lbl2.Content = s;
                    lbl.Content = System.IO.Path.GetFileName(s);
                }
                else
                {
                    //Add filepath
                    //filepaths.Add(s);
                    Debug.WriteLine("File: " + System.IO.Path.GetFileName(s));
                    img.Source = fileAdd.img.Source;
                    lbl2.Content = s;
                    lbl.Content = System.IO.Path.GetFileName(s);
                }
            }
        }
    }
}
