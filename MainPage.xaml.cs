namespace MauiApp_Animations;

public partial class MainPage : ContentPage
{
    private bool isVisible = true;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnClick(object sender, EventArgs e)
    {
        MyButton.IsEnabled = false;
        if (isVisible)
        {
            await Task.WhenAll
            (
                MyImage1.FadeTo(0, 1000),
                MyImage2.FadeTo(0, 1000)
            );
            await MyImage3.FadeTo(0, 1000);
            MyButton.Text = "Show Image";
        }
        else
        {
            await Task.WhenAll
            (
                MyImage1.FadeTo(1, 1000),
                MyImage2.FadeTo(1, 1000)
            );
            await MyImage3.FadeTo(1, 1000);
            MyButton.Text = "Hide Image";
        }
        isVisible = !isVisible;
        MyButton.IsEnabled = true;
    }
}

