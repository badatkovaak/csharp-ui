/*using Avalonia;*/
using System;

namespace UI;

class Program
{

    public static void Main(string[] args){
        Monom m1 = new Monom(1, [2]);
        Monom m2 = new Monom(3, [1]);
        Monom m3 = new Monom(5, []);
        Polynomial p = new Polynomial([m1, m2, m3]);
        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine(p);
    }


    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    /*[STAThread]*/
    /*public static void Main(string[] args) => BuildAvaloniaApp()*/
    /*    .StartWithClassicDesktopLifetime(args);*/
    /**/
    /*// Avalonia configuration, don't remove; also used by visual designer.*/
    /*public static AppBuilder BuildAvaloniaApp()*/
    /*    => AppBuilder.Configure<App>()*/
    /*        .UsePlatformDetect()*/
    /*        .WithInterFont()*/
    /*        .LogToTrace();*/
}
