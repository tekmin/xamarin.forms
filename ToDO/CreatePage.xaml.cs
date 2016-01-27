using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToDO
{
	public partial class CreatePage : ContentPage
	{
		public List<ToDoItem> ToDoList;

		public CreatePage ()
		{
			ToDoList = new List<ToDoItem> ();
			InitializeComponent ();
		}

		public void SaveItem(object obj, EventArgs e)  {
			ToDoList.Add (new ToDoItem (
				ToDoItemName.Text
			));
			Clear ();
		}

		public void Clear() {
			ToDoItemName.Text = String.Empty;
		}
	}
}

