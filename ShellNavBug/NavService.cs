using System;
namespace ShellNavBug;

public interface INavService
{
    Task GoToInitial();
    Task GoTo(string route);
}

public class NavService : INavService
{
    public NavService()
    {
    }

    public Task GoTo(string route) => Shell.Current.GoToAsync(route);

    public Task GoToInitial() => Shell.Current.GoToAsync(nameof(MainPage));
}

