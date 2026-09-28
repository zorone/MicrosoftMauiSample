using Microsoft.Maui.Platform.Linux;

namespace MicrosoftMaui;

public class Program
{
    public static void Main(string[] args)
    {
        var app = MauiProgramSample.CreateMauiApp();
        LinuxApplication.Run(app, args);
    }
}
