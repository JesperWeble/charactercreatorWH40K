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
using System;

namespace charactercreatorRedo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string theChangedSelectionName;
        private string theCheckedBoxName;

        public MainWindow()
        {
            InitializeComponent();
            RaceProgram.Initialize();
            raceBox.ItemsSource = RaceProgram.races;
        }

        public void onlyNumValid(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text + e.Text;
            if (input.Length <= 2)
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
            else
            {
                e.Handled = true;
            }
            
            
        }

        //##### vvvvvv Selection Boxes vvvvvv #####\\
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

        private void Proficient(object sender, RoutedEventArgs e)
        {
            try { CheckBox theCheckedBox = (CheckBox)sender; theCheckedBoxName = theCheckedBox.Name; } catch { }
                
            
        }

        Race? selectedRace;
        private void raceBox_Select()
        {
            // Reinitialize \\
            subraceBox.Items.Clear();
            racialListBox.Items.Clear();

            selectedRace = raceBox.SelectedItem as Race;
            var selection = selectedRace;

            if (selectedRace != null)
            {
                foreach (var eachRacial in selectedRace.racials)
                {
                    racialListBox.Items.Add(eachRacial);
                }
                racialListBox.SelectedIndex = 0;
                foreach (var eachSubrace in selectedRace.subraces)
                {
                    subraceBox.Items.Add(eachSubrace);
                }
                //subraceBox.SelectedIndex = 0;
                //foreach (var eachBG in selectedRace.backgrounds)
                //{
                //    bgBox.Items.Add(eachBG);
                //}
                //bgBox.SelectedIndex = 0;
            }
        }

        Subrace? selectedSubrace;
        private void subraceBox_Select()
        {
            // Reinitialize \\
            classBox.Items.Clear();
            if (selectedSubrace != null){foreach (var eachRacial in selectedSubrace.racials){racialListBox.Items.Remove(eachRacial);}}

            selectedSubrace = subraceBox.SelectedItem as Subrace;
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


        Class? selectedClass;
        private void classBox_Select()
        {
            if (selectedClass != null) { foreach (var eachClassFeat in selectedClass.traits) { classFeatListBox.Items.Remove(eachClassFeat); } }

            selectedClass = classBox.SelectedItem as Class;
            var selection = selectedClass;
            if (selectedClass != null)
            {
                foreach (var eachClassFeat in selectedClass.traits)
                {
                    classFeatListBox.Items.Add(eachClassFeat);
                }
                try { classDesc.Text = selectedClass.Description; } catch { };
            }
            classFeatListBox.SelectedIndex = 0;
        }
        private void classFeatListBox_Select()
        {

            var selectedClassFeat = classFeatListBox.SelectedItem as Trait;
            var selection = selectedClassFeat;
            if (selectedClassFeat != null)
            {
                try { classFeatDesc.Text = selectedClassFeat.Description; } catch { };
            }
        }

        //##### vvvvvv Save and Load vvvvvv #####\\

        private void Save(object sender, RoutedEventArgs e)
        {
            Character characterBeingMade = new Character();
            characterBeingMade.Title = TextBox_CharName.Text;
            try { characterBeingMade.Race = (Race?)raceBox.SelectedItem; } catch { }
            try { characterBeingMade.Subrace = (Subrace?)subraceBox.SelectedItem; } catch { }
            try { characterBeingMade.Class = (Class?)classBox.SelectedItem; } catch { }
            //try { characterBeingMade.Background = (Background?)bgBox.SelectedItem; } catch { }'
            try { characterBeingMade.Description = charDesc.Text; } catch { }
            try { characterBeingMade.Backstory = charStory.Text; } catch { }

            characterBeingMade.abilityScores["STR"] = int.Parse(strScore.Text);
            characterBeingMade.abilityScores["DEX"] = int.Parse(dexScore.Text);
            characterBeingMade.abilityScores["CON"] = int.Parse(conScore.Text);
            characterBeingMade.abilityScores["INT"] = int.Parse(intScore.Text);
            characterBeingMade.abilityScores["WIS"] = int.Parse(wisScore.Text);
            characterBeingMade.abilityScores["CHA"] = int.Parse(chaScore.Text);

            foreach (var eachAbility in characterBeingMade.abilityScores)
            {
                string abilityName = eachAbility.Key;
                for (int index = 0; index < characterBeingMade.Class.traits.Count; index++)
                {
                    var trait = characterBeingMade.Class.traits[index];
                    if (trait.abilityBonus[$"{abilityName}_Bonus"] != null)
                    {
                        characterBeingMade.abilityScores[abilityName] += trait.abilityBonus[$"{abilityName}_Bonus"];
                    }
                }
                //Modifiers
                characterBeingMade.abilityModifiers[$"{abilityName}_Mod"] = (characterBeingMade.abilityScores[abilityName] - 10) / 2;
            }

            // Hit Points
            for (int index = 0; index < characterBeingMade.Class.traits.Count; index++)
            {
                var trait = characterBeingMade.Class.traits[index];
                if (trait.hpMin != null)
                {
                    if (trait.hpMin > characterBeingMade.hpMin)
                    {
                        characterBeingMade.hpMin = trait.hpMin;
                    }

                }
                characterBeingMade.maxHP = characterBeingMade.hpMin;
                if (trait.hp != null)
                {
                    characterBeingMade.maxHP += trait.hp;
                }
            }
            characterBeingMade.maxHP += characterBeingMade.abilityModifiers["CON_Mod"];

            if (characterBeingMade.maxHP < characterBeingMade.hpMin)
            {
                characterBeingMade.maxHP = characterBeingMade.hpMin;

            }
            characterBeingMade.hp = characterBeingMade.maxHP;

            

            foreach (var eachSave in characterBeingMade.savingThrows)
            {
                string saveName = eachSave.Key;
                CheckBox checkBoxBeingChecked = (CheckBox)FindName($"checkBox_{saveName}");
                if (checkBoxBeingChecked.IsChecked == true)
                {
                    characterBeingMade.savingThrows[eachSave.Key] = true;
                }
                else
                {
                    characterBeingMade.savingThrows[eachSave.Key] = false;
                }
            }

            foreach (var eachSkill in characterBeingMade.proficiencies)
            {
                string skillName = eachSkill.Key;
                string checkBoxName = $"checkBox_Prof_{skillName}";
                CheckBox checkBoxBeingChecked = (CheckBox)FindName(checkBoxName);
                if (checkBoxBeingChecked.IsChecked == true)
                {
                    characterBeingMade.proficiencies[eachSkill.Key] = true;
                }
                else
                {
                    characterBeingMade.proficiencies[eachSkill.Key] = false;
                }
            }


            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                DefaultExt = ".json",
                AddExtension = true
            };
            bool? result = saveFileDialog.ShowDialog();
            if (result == true)
            {
                string json = JsonConvert.SerializeObject(characterBeingMade);
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, json);
                MessageBox.Show("Save Complete");
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
                
                strScore.Text = loadedChar.abilityScores["STR"].ToString();
                dexScore.Text = loadedChar.abilityScores["DEX"].ToString();
                conScore.Text = loadedChar.abilityScores["CON"].ToString();
                intScore.Text = loadedChar.abilityScores["INT"].ToString();
                wisScore.Text = loadedChar.abilityScores["WIS"].ToString();
                chaScore.Text = loadedChar.abilityScores["CHA"].ToString();

                charDesc.Text = loadedChar.Description;
                charStory.Text = loadedChar.Backstory;

                foreach (var eachSave in loadedChar.savingThrows)
                {
                    string saveName = eachSave.Key;
                    CheckBox checkBoxBeingChecked = (CheckBox)FindName($"checkBox_{saveName}");
                    if (eachSave.Value == true)
                    {
                        checkBoxBeingChecked.IsChecked = true;
                    }
                    else
                    {
                        checkBoxBeingChecked.IsChecked = false;
                    }
                }

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
}