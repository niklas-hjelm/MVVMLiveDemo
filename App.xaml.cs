using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVMLiveDemo.Models;
using MVVMLiveDemo.ViewModels;

namespace MVVMLiveDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Här instansieras våran Model och ViewModel
            var demoModel = new DemoModel();
            var demoViewModel = new DemoViewModel(demoModel);

            //Instansierar fönstret och sätter DataContext till en ny instans av MainViewModel
            //och skickar med demoViewModel som instansierats ovanför
            var mainWindow = new MainWindow() {DataContext = new MainViewModel(demoViewModel)};

            //Visar fönstret.
            mainWindow.Show();
        }
    }
}
