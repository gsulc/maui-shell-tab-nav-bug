namespace ShellNavBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PageB));
    }
}
