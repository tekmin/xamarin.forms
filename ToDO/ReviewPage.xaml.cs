using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToDO
{
	public partial class ReviewPage : ContentPage
	{
		public List<ToDoItem> ToDoItems { get; set; }

		public ReviewPage (List<ToDoItem> toDoItems)
		{
			ToDoItems = toDoItems;
			BindingContext = this;
			InitializeComponent ();
			this.Title = "Review";
		}
	}
}

