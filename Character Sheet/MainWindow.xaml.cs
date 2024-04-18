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
        public void onlyNumValid(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);


        }

        private void Load(object sender, RoutedEventArgs e)
        {
            int TraitNum = 0;
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

                try { textBlock_CharacterName.Text = loadedChar.Title; } catch { }
                try { textBlock_CharacterRace.Text = $"{loadedChar.Race.Title} | {loadedChar.Subrace.Title}"; } catch { }
                try { textBlock_CharacterClass.Text = loadedChar.Class.Title; } catch { }

                // Ability Scores
                foreach (var eachAbility in loadedChar.abilityScores)
                {
                    string abilityName = eachAbility.Key;
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

                loadedChar.hp = loadedChar.hpMin;

                // Ability Modifiers

                // Hit Points
                for (int index = 0; index < loadedChar.Class.traits.Count; index++)
                {
                    var trait = loadedChar.Class.traits[index];
                    if (trait.hpMin != null)
                    {
                        if (trait.hpMin > loadedChar.hpMin)
                        {
                            loadedChar.hpMin = trait.hpMin;
                        }

                    }

                    if (trait.hp != null)
                    {
                        loadedChar.hp += trait.hp;
                    }
                }
                
                if (loadedChar.hp < loadedChar.hpMin)
                {
                    loadedChar.hp = loadedChar.hpMin;

                }

                try { textBlock_maxHP.Text = loadedChar.hp.ToString(); } catch { }
                try { textBox_currentHP.Text = loadedChar.hp.ToString(); } catch { }

                // Armor Class
                try { textBlock_AC.Text = loadedChar.ac.ToString(); } catch { }
            }
        }
    }
}