namespace aboutNavegacion;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
    
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Cambio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cambiopract15());
    }

    private void Superficie_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SuperficieDelTrianguloprac15());
    }

    private void Dinosaurio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new dinosaurioprac15());
    }

    private void Gasolineria_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new gasolinaprac15());
    }

    private void aboutNavegacion_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new aboutNavegacion());
    }
}

