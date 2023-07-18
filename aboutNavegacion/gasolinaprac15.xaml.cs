namespace aboutNavegacion;

public partial class gasolinaprac15 : ContentPage
{
    private const double LitrosPorGalon = 3.78541; // Factor de conversión de galones a litros
    public gasolinaprac15()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double precioPorLitros = Convert.ToDouble(PrecioPorLitros.Text);

        if (double.TryParse(GallonsEntry.Text, out double galones))
        {

            double litros = galones * LitrosPorGalon;

            double totalPrice = litros * precioPorLitros;
            ResultLabel.Text = $"Cantidad a cobrar: {totalPrice.ToString("C")}";

        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");

        }
    }
}