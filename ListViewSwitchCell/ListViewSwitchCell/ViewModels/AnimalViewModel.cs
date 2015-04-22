using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace ListViewSwitchCell
{
	public class AnimalViewModel
	{
		public ObservableCollection<Animal> Animals { get; set; }

		public AnimalViewModel ()
		{
			Animals = new ObservableCollection<Animal> 
			{
				new Animal ("Cat", false),
				new Animal ("Dog", true), 
				new Animal ("Horse", false),
				new Animal ("Duck", true),
				new Animal ("Cow", false),
				new Animal ("Chicken", false),
				new Animal ("Lion", true),
				new Animal ("Eagle", true),
				new Animal ("Bear", true),
				new Animal ("Moose", false),
				new Animal ("Rooster", false),
				new Animal ("Turkey", false),
				new Animal ("Whale", false),
				new Animal ("Walrus", true),
				new Animal ("Penguin", true),
				new Animal ("Dolphin", false),
				new Animal ("Turtle", false),
				new Animal ("Monkey", false),
				new Animal ("Gorilla", true),
			};

			foreach (var Animal in Animals)
			{
				Animal.OnToggled += ToggleSelection;
			}
		}
		void ToggleSelection (object sender, EventArgs e)
		{
			var animal = sender as Animal;
			Console.WriteLine ("{0} has been toggled to {1}", animal.Name, animal.IsSelected);
		}
	}
}
