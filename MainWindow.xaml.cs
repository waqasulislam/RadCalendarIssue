using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Docking;

namespace DifferentToolWindowStyles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }
    }

    public class ViewModel
    {
        ObservableCollection<string> list = new ObservableCollection<string>(new[] {"Apple", "Mango", "Oranges", "Banana", "Melon" });
        private string selectedItem;
        public ViewModel()
        {
            this.DisplayDateCommand = new DelegateCommand(OnDisplayDateChanged);
            this.SelectListItemCommand = new DelegateCommand(OnSelectListItem);
        }

        private void OnSelectListItem(object obj)
        {
            
        }
        public IEnumerable<string> Items { get { return this.list; } }
        public string SelectedItem { get { return this.selectedItem; } set { this.selectedItem = value; } }
        private void OnDisplayDateChanged(object obj)
        {
            
        }

        private DateTime displayDate;

        public DateTime DisplayDate
        {
            get { return displayDate; }
            set { displayDate = value; }
        }

        public DelegateCommand DisplayDateCommand { get; private set; }
        public DelegateCommand SelectListItemCommand { get; private set; }
    }
}
