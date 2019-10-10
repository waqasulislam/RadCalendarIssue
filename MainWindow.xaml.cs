using System;
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
        public ViewModel()
        {
            this.DisplayDateCommand = new DelegateCommand(OnDisplayDateChanged);
        }

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
    }
}
