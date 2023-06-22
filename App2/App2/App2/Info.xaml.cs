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
	public partial class Info : ContentPage
	{
		public Info (ArrayList firstpage, ArrayList secondpage, ArrayList thirdpage)
		{
			InitializeComponent ();

			if ((double)firstpage[0] >= (double)secondpage[0] && (double)firstpage[0] >= (double)thirdpage[0])
				pagesInfo.Text = $"Максимальное значение Slider на 1 странице {(double)firstpage[0]}\n\n";
			else if ((double)secondpage[0] >= (double)thirdpage[0])
				pagesInfo.Text = $"Максимальное значение Slider на 2 странице {(double)secondpage[0]}\n\n";
			else pagesInfo.Text = $"Максимальное значение Slider на 3 странице {(double)thirdpage[0]}\n\n";

			pagesInfo.Text += "Информация о первой странице\n" + GetInfo(firstpage);
			pagesInfo.Text += "Информация о второй странице\n" + GetInfo(secondpage);
            pagesInfo.Text += "Информация о третьей странице\n" + GetInfo(thirdpage);

        }

		public string GetInfo(ArrayList page)
		{
			string info= "О dropbox:\n";
            if (page[1] != null)
				info += "Выбрано " + page[1]+"\n";
            else 
				info += "Выбора не было\n";

            info += "О checkbox:\n";
			if ((bool)page[2] && (bool)page[3])
				info += "Выбраны 2 варианта\n";
			else if ((bool)page[2])
                info += "Выбран 1 вариант\n";
            else if ((bool)page[3])
                info += "Выбран 2 вариант\n";
			else info += "Выбора не было\n";

            info += "О radioButton:\n";
			if ((bool)page[4])
                info += "Выбран 1 вариант\n";
            else if((bool)page[5])
                info += "Выбран 2 вариант\n";
            else info += "Выбора не было\n";

            info += "О switch:\n";
            if ((bool)page[6])
                info += "Включен\n\n";
			else info += "Выключен\n\n";
            return info;
		}
	}
}