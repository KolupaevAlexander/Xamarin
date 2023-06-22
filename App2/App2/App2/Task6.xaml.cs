using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Task6 : CarouselPage
	{
		public Task6 (string name)
		{
			InitializeComponent ();
            helloUser.Title = "Добро пожаловать "+ name;
		}

		public async void EnterButton_Clicked(object sender, EventArgs e)
		{
			ArrayList firstPage = new ArrayList() { FirstPageSlider.Value, 
													FirstPagePicker.SelectedItem, 
													FirstPageCheckBox1.IsChecked, 
													FirstPageCheckBox2.IsChecked, 
													FirstPageRadioButton1.IsChecked, 
													FirstPageRadioButton2.IsChecked,
													FirstPageSwitch.IsToggled};
			ArrayList SecondPage = new ArrayList() { SecondPageSlider.Value,
													 SecondPagePicker.SelectedItem,
													 SecondPageCheckBox1.IsChecked,
													 SecondPageCheckBox2.IsChecked,
													 SecondPageRadioButton1.IsChecked,
                                                     SecondPageRadioButton2.IsChecked,
													 SecondPageSwitch.IsToggled};
            ArrayList ThirdPage = new ArrayList() { ThirdPageSlider.Value, 
													ThirdPagePicker.SelectedItem, 
													ThirdPageCheckBox1.IsChecked, 
													ThirdPageCheckBox2.IsChecked, 
													ThirdPageRadioButton1.IsChecked,
													ThirdPageRadioButton2.IsChecked,
													ThirdPageSwitch.IsToggled};
            
			await Navigation.PushAsync(new Info(firstPage, SecondPage, ThirdPage));
        }

    }
}