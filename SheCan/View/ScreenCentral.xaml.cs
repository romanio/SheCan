using System;
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
using MahApps.Metro.Controls;
using SheCan.ViewModel;

namespace SheCan
{
    public partial class ScreenCentral : MetroWindow
    {
        ScreenCentralModel Model = new ScreenCentralModel();
                
        public ScreenCentral()
        {
            InitializeComponent();
            DataContext = Model;
        }

        private void OpenModel(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog() { Filter = "Eclipse file|*.SMSPEC" };
            if (fileDialog.ShowDialog() == true)
            {
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (boxNameOptions.SelectedIndex)
            {
                case 0:
                    //Model.UpdateListNames(NameOptions.Field);
                    break;
                case 1:
                    //Model.UpdateListNames(NameOptions.Group);
                    break;
                case 2:
                    //Model.UpdateListNames(NameOptions.Well);
                    break;
                case 3:
                    //Model.UpdateListNames(NameOptions.Aquifer);
                    break;
                case 4:
                    //Model.UpdateListNames(NameOptions.Region);
                    break;
                case 5:
                    //Model.UpdateListNames(NameOptions.Other);
                    break;
            }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = new List<string>();
            foreach (string item in ((System.Windows.Controls.ListBox)sender).SelectedItems)
            {
                selection.Add(item.ToString());
            }
            //Model.UpdateSelectedNames(selection);
        }

        private void OnRestartDateSelect(object sender, SelectionChangedEventArgs e)
        {
            //Model.OnRestartDateSelect(((System.Windows.Controls.ComboBox)sender).SelectedIndex);
        }

    }

}
