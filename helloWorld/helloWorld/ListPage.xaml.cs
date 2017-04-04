using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace helloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
            Title = "List Page";
            NavigationPage.SetHasBackButton(this, true);
                       
        }

        void OnBtnScore(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ScorePage(), true);
        }

        void OnBtnCharacter(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new CharacterPage(), true);
        }

        void OnBtnInventory(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new InventoryPage(), true);
        }

        void OnBtnMonsters(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MonstersPage(), true);
        }

        void OnBtnItems(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ItemsPage(), true);
        }

        void OnBtnBattle(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new BattlePage(), true);
        }
    }
}
