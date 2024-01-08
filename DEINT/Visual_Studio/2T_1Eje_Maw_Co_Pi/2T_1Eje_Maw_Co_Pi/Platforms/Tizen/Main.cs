using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace _2T_1Eje_Maw_Co_Pi
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}