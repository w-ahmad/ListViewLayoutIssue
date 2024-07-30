using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App2;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window, INotifyPropertyChanged
{
    private double _widthOfButtons = 40;

    public MainWindow()
    {
        InitializeComponent();
    }

    public double WidthOfButtons
    {
        get => _widthOfButtons;
        set
        {
            _widthOfButtons = value;
            PropertyChanged?.Invoke(this, new(nameof(WidthOfButtons)));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

}
