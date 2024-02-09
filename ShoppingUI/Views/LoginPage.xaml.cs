using Microsoft.Maui.Platform;

namespace ShoppingUI;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        this.BindingContext = new LoginViewModel(this.Navigation);
    }
    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (Platform.CurrentActivity.CurrentFocus != null)
            Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
    }


}