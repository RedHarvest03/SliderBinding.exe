

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


namespace Binding;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {
        if (same.IsChecked == true)
        {
            System.Windows.Data.Binding binding = new System.Windows.Data.Binding();
            binding.Path = new PropertyPath("Value");
            binding.Mode = BindingMode.TwoWay;

            binding.Source = slider1;
            slider2.SetBinding(Slider.ValueProperty, binding);
        }
    }
    private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
    {
        if (same.IsChecked == true)
        {

            System.Windows.Data.Binding binding = new System.Windows.Data.Binding();
            binding.Path = new PropertyPath("Value");
            binding.Mode = BindingMode.OneWay;

            binding.Source = slider1;
            slider2.SetBinding(Slider.ValueProperty, binding);
        }
    }

}

