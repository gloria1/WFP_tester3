using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace WFP_tester3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int _q;
        public int q
        {
            get { return _q; }
            set
            {
                _q = value;
                NotifyPropertyChanged();
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            grid.DataContext = this;

            q = 3;
            q = 4;
            q = 5;
            q = Add(5, 6);
            q = 9;
        }

        // implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        [DllImport("c:\\onedrive\\AO\\programming\\vsp projects\\WFP_tester3\\Debug\\cpp_dll.dll")]
        public static extern int Add(int a, int b);

    }


}
