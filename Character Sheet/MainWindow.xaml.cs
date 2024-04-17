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
using charactercreatorRedo;
using System;

namespace Character_Sheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
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
                MessageBox.Show("Load Complete");

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

                charDesc.Text = loadedChar.Description;
                charStory.Text = loadedChar.Backstory;

                foreach (var eachSkill in loadedChar.proficiencies)
                {
                    string skillName = eachSkill.Key;
                    string checkBoxName = $"checkBox_Prof_{skillName}";
                    CheckBox checkBoxBeingChecked = (CheckBox)FindName(checkBoxName);
                    if (eachSkill.Value == true)
                    {
                        checkBoxBeingChecked.IsChecked = true;
                    }
                    else
                    {
                        checkBoxBeingChecked.IsChecked = false;
                    }
                }

            }
        }
}