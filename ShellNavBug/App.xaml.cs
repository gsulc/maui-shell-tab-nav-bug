﻿namespace ShellNavBug;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell(new NavService());
    }
}

