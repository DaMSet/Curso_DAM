﻿namespace MauiAppEjemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            //MainPage = new NuevaContenPage();

            MainPage = new BindingModos();

        }
    }
}