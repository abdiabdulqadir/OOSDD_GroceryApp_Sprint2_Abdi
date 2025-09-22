using Grocery.App.ViewModels;
using System;

namespace Grocery.App.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel viewModel)
	{
        InitializeComponent();
		BindingContext = viewModel;
	}
	
} 