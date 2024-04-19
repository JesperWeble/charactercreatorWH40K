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
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Character_Sheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string filePath;
        int health;

        public MainWindow()
        {
            InitializeComponent();
        }
        public void onlyNumValid(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9+-]+");
            e.Handled = regex.IsMatch(e.Text);


        }

        private void Save()
        {
            if (filePath != null)
            {
                string json = File.ReadAllText(filePath);
                Character loadedChar = JsonConvert.DeserializeObject<Character>(json);

                loadedChar.hp = int.Parse(textBox_currentHP.Text);
                loadedChar.weapons.Clear();

                // Save Weapons \\
                //foreach (Weapon eachWeapon in datagrid_Weapons.Items)
                //{
                //    loadedChar.weapons.Add(eachWeapon.Title, eachWeapon);
                //}

                // Make similar for saving Inventory \\

                string saveFile = JsonConvert.SerializeObject(loadedChar);
                File.WriteAllText(filePath, saveFile);
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
                filePath = loadFileDialog.FileName;
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
                    TextBlock TextBlockToModify = (TextBlock)FindName($"textBlock_{abilityName}");
                    TextBlockToModify.Text = loadedChar.abilityScores[abilityName].ToString();
                    TextBlockToModify = (TextBlock)FindName($"textBlock_{abilityName}_Mod");
                    TextBlockToModify.Text = loadedChar.abilityModifiers[$"{abilityName}_Mod"].ToString();
                }

                // Hit Points
                try { textBlock_maxHP.Text = loadedChar.maxHP.ToString(); } catch { }
                try { textBox_currentHP.Text = loadedChar.hp.ToString(); } catch { }
                health = int.Parse(textBox_currentHP.Text);

                // Armor Class
                loadedChar.ac = loadedChar.abilityModifiers["DEX_Mod"];
                try { textBlock_AC.Text = loadedChar.ac.ToString(); } catch { }

                // Saves
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

                // Proficiencies
                foreach (var eachSkill in loadedChar.proficiencies)
                {
                    string skillName = eachSkill.Key;
                    CheckBox checkBoxBeingChecked = (CheckBox)FindName($"checkBox_Prof_{skillName}");
                    if (eachSkill.Value == true)
                    {
                        checkBoxBeingChecked.IsChecked = true;
                    }
                    else
                    {
                        checkBoxBeingChecked.IsChecked = false;
                    }
                }

                
                // Weapons
                var weaponData = new ObservableCollection<Weapon>(loadedChar.Class.Loadout.Values);
                datagrid_Weapons.ItemsSource = weaponData;

                // Inventory
                var inventoryData = new ObservableCollection<Item>(loadedChar.Class.ItemPack.Values);
                datagrid_Inventory.ItemsSource = inventoryData;

                // Feats
                var featData = new ObservableCollection<Trait>(loadedChar.traits);
                datagrid_Feat.ItemsSource = featData;


            }
        }

        // Add Method for Button to add weapons to the Weapon Grid
        // Same but for items for the Inventory Grid.
        private void datagridChanges(object sender, EventArgs e)
        {

        }

        private void changeHP(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textBox_currentHP.Text.StartsWith("-") || textBox_currentHP.Text.StartsWith("+"))
                {
                    health += int.Parse(textBox_currentHP.Text);
                    textBox_currentHP.Text = health.ToString();
                }
                Save();
                Keyboard.ClearFocus();
                
            }
            
        }

        private void datagrid_Feat_LostFocus(object sender, RoutedEventArgs e)
        {
            datagrid_Feat.SelectedItem = null;
        }
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scroller = (ScrollViewer)sender;
            scroller.ScrollToVerticalOffset(scroller.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}