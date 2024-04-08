using System.Text;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Reflection;

namespace charactercreatorRedo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RaceProgram.Initialize();
            raceBox.ItemsSource = RaceProgram.races;
        }

        public void onlyNumValid(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        //##### vvvvvv Selection Boxes vvvvvv #####\\

        private string theChangedSelectionName;
        private void Select(object sender, SelectionChangedEventArgs e)
        {
            try { ComboBox theChangedSelection = (ComboBox)sender; theChangedSelectionName = theChangedSelection.Name; } catch { }
            try { ListBox theChangedSelection = (ListBox)sender; theChangedSelectionName = theChangedSelection.Name; } catch { }

            Type type = typeof(MainWindow);
            string methodName = $"{theChangedSelectionName}_Select";
            MethodInfo? methodToRun = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            if (methodToRun != null)
            {
                methodToRun.Invoke(this, null);
            }

        }
        private void raceBox_Select()
        {
            subraceBox.Items.Clear();            // Reset Subrace Box.
            //Uri resourceUri = new Uri("https://d2t4fc8ff77neh.cloudfront.net/cardSrcMedia/1hpaseukj_token_3.png", UriKind.Absolute);   // Erase Image
            //RaceImage.Source = new BitmapImage(resourceUri);    // Erase Image Finish
            var selectedRace = raceBox.SelectedItem as Race;
            var selection = selectedRace;

            if (selectedRace != null)
            {
                foreach (var eachSubrace in selectedRace.subraces)
                {
                    subraceBox.Items.Add(eachSubrace);
                }
                subraceBox.SelectedIndex = 0;

                foreach (var eachRacial in selectedRace.racials)
                {
                    racialListBox.Items.Add(eachRacial);
                }
                racialListBox.SelectedIndex = 0;

                foreach (var eachBG in selectedRace.backgrounds)
                {
                    bgBox.Items.Add(eachBG);
                }
                bgBox.SelectedIndex = 0;
            }
        }
        private void subraceBox_Select()
        {
            classBox.Items.Clear();
            var selectedSubrace = subraceBox.SelectedItem as Subrace;
            var selection = selectedSubrace;
            if (selectedSubrace != null)
            {
                foreach (var eachClass in selectedSubrace.classes)
                {
                    classBox.Items.Add(eachClass);
                }
                foreach (var eachRacial in selectedSubrace.racials)
                {
                    racialListBox.Items.Add(eachRacial);
                }
                racialListBox.SelectedIndex = 0;

                try { raceDesc.Text = selectedSubrace.Description; } catch { };
            }
            classBox.SelectedIndex = 0;
            racialListBox.SelectedIndex = 0;

        }

        private void racialListBox_Select()
        {

            var selectedRacial = racialListBox.SelectedItem as Trait;
            var selection = selectedRacial;
            if (selectedRacial != null)
            {
                try { racialDesc.Text = selectedRacial.Description; } catch { };
            }
        }

        //##### vvvvvv Save and Load vvvvvv #####\\

        private void Save(object sender, RoutedEventArgs e)
        {
            Character characterBeingSaved = new Character();
            characterBeingSaved.Title = TextBox_CharName.Text;
            try { characterBeingSaved.Race = (Race?)raceBox.SelectedItem; } catch { }
            try { characterBeingSaved.Subrace = (Subrace?)subraceBox.SelectedItem; } catch { }
            try { characterBeingSaved.Class = (Class?)classBox.SelectedItem; } catch { }

            characterBeingSaved.Str = int.Parse(strScore.Text);
            characterBeingSaved.Dex = int.Parse(dexScore.Text);
            characterBeingSaved.Con = int.Parse(conScore.Text);
            characterBeingSaved.Int = int.Parse(intScore.Text);
            characterBeingSaved.Wis = int.Parse(wisScore.Text);
            characterBeingSaved.Cha = int.Parse(chaScore.Text);



            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                DefaultExt = ".json",
                AddExtension = true
            };
            bool? result = saveFileDialog.ShowDialog();
            if (result == true)
            {
                string json = JsonConvert.SerializeObject(characterBeingSaved);
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, json);
                MessageBox.Show("Object serialized and saved to file successfully.");
            }
        }
        private void Load(object sender, RoutedEventArgs e)
        {
            var loadFileDialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                DefaultExt = ".json",
                AddExtension = true
            };
            bool? result = loadFileDialog.ShowDialog();
            if (result == true)
            {
                string filePath = loadFileDialog.FileName;
                string json = File.ReadAllText(filePath);
                Character loadedChar = JsonConvert.DeserializeObject<Character>(json);
                MessageBox.Show("Object deserialized successfully.");

                TextBox_CharName.Text = loadedChar.Title;
                try
                {
                    raceBox.SelectedItem = raceBox.Items.Cast<Race>().FirstOrDefault(r => r.Title == loadedChar.Race.Title);
                }
                catch { }
                try
                { 
                    subraceBox.SelectedItem = subraceBox.Items.Cast<Subrace>().FirstOrDefault(r => r.Title == loadedChar.Subrace.Title);
                } 
                catch { }

                try
                {
                    classBox.SelectedItem = classBox.Items.Cast<Class>().FirstOrDefault(r => r.Title == loadedChar.Class.Title);
                }
                catch { }
                
                strScore.Text = loadedChar.Str.ToString();
                dexScore.Text = loadedChar.Dex.ToString();
                conScore.Text = loadedChar.Con.ToString();
                intScore.Text = loadedChar.Int.ToString();
                wisScore.Text = loadedChar.Wis.ToString();
                chaScore.Text = loadedChar.Cha.ToString();

            }
        }


    }
}