namespace ShellNavBug;

public partial class AppShell : Shell
{
    INavService navigation;

    public AppShell(INavService navService)
    {
        navigation = navService;

        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(PageA), typeof(PageA));
        Routing.RegisterRoute(nameof(PageB), typeof(PageB));
        Routing.RegisterRoute(nameof(PageC), typeof(PageC));
    }

    protected override void OnParentSet()
    {
        base.OnParentSet();
        navigation.GoToInitial();
    }
}

