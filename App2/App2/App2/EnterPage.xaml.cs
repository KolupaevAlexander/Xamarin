using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EnterPage : ContentPage
	{
		public EnterPage ()
		{
			InitializeComponent ();
		}

		private void OnEnter_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Text) || OptionsPicker.SelectedIndex==-1)
			{
				DisplayAlert("Ошибка ввода", "Заполните поля", "ОК");
				return;
			}
			else
				ToMainPage();
        }

		private async void ToMainPage()
		{
			if (OptionsPicker.SelectedIndex == 0)
				await Navigation.PushAsync(new MainPage(login.Text));
			else
                await Navigation.PushAsync(new Task6(login.Text));
        }
	}
}