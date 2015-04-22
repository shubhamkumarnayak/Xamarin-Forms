using Xamarin.Forms;

namespace ListViewSwitchCell
{
	public class ListViewPage : ContentPage
	{
		private AnimalViewModel ViewModel 
		{
			get { return BindingContext as AnimalViewModel; }
		}
		public ListViewPage ()
		{
			BindingContext = new AnimalViewModel ();

			var stack = new StackLayout 
			{
				Orientation = StackOrientation.Vertical
			};

			var label = new Label 
			{
				Text = "All goodd so far!"
			};
			stack.Children.Add(label);

			var cell = new DataTemplate(typeof(CustomSwitchCell));
			var listView = new ListView (); 
			listView.ItemTemplate = cell; 
			listView.ItemsSource = ViewModel.Animals;
			stack.Children.Add (listView);

			Content = stack;
		}
	}
}
