namespace mobapp;

public partial class Page1 : FlyoutPage
{
	public Page1()
	{
		InitializeComponent();
		Detail= new NavigationPage(new MainPage());
		IsPresented=false;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Detail = new NavigationPage(new Page2());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		Detail = new NavigationPage(new MainPage());
    }
}