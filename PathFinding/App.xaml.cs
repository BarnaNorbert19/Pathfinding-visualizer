﻿using System.Windows;

namespace PathfindingVisualizer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ViewModel.MainViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
