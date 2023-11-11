namespace DalluiApp.Views;

public partial class ImageGeneratorView : ContentPage
{
	public ImageGeneratorView()
	{
		InitializeComponent();
	}

    private void btnFinish_Clicked(object sender, EventArgs e)
    {
		StopGeneration();
    }

	private async void StopGeneration()
	{
		lottie.IsAnimationEnabled = false;
		lottie.IsVisible = false;
		imageBorder.IsVisible = true;

		await Task.WhenAny(
			imageAnimation.ScaleTo(1.1, 1000),
			imageAnimation.FadeTo(0, 1000),
            borderTime.ScaleTo(1, 1000),
            borderTime.FadeTo(1, 1000)
            );
	}
}