﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using SlimDX.DirectInput;

namespace Controller2Mouse
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public JoystickController MainController = new JoystickController();

        public App()
        {
            MainWindow Window = new MainWindow(MainController);
            Window.Show();
        }
    }
}
