using LearnWpf.Domain.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace LearnWpf.UI;


public partial class App : Application
{
    private IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder().ConfigureServices(services =>
        {
            services.AddSingleton<AppViewModel>();
            services.AddSingleton<MainWindow>(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<AppViewModel>()
            });

        }).Build();
    }


    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        _host.Start();
        MainWindow = _host.Services.GetRequiredService<MainWindow>();
        MainWindow.Show();
    }

}