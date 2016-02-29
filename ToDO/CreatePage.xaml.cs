using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToDO
{
	public partial class CreatePage : ContentPage
	{
		private List<ToDoItem> toDoItems;

		public CreatePage ()
		{
			toDoItems = new List<ToDoItem> ();
			InitializeComponent ();
		}

		public void SaveItem(object obj, EventArgs e)  {
			toDoItems.Add (new ToDoItem (
				ToDoItemName.Text
			));
			Clear ();
		}

		public void Clear() {
			ToDoItemName.Text = String.Empty;
		}

		public void Review(object obj, EventArgs e) {
			Navigation.PushAsync (new ReviewPage (toDoItems));
		}
	}
}

