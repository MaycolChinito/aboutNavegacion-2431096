namespace aboutNavegacion;

public partial class SuperficieDelTrianguloprac15 : ContentPage
{
	public SuperficieDelTrianguloprac15()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double AlturaTriangulo = Convert.ToDouble(Altura.Text);
        double BaseTriangulo = Convert.ToDouble(basee.Text);


        double superficie = BaseTriangulo * AlturaTriangulo / 2;

        SuperficieRespuesta.Text = Convert.ToString(superficie);
    }
}