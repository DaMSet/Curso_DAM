using MauiApp3_teoria4.MVVM.Model;
using System.Security.Cryptography.X509Certificates;

namespace MauiApp3_teoria4.MVVM.ViewModel;
{
	public partial class PersonViewModel
	{


		public Person Person { get; set; }

		public PersonViewModel()
		{
			Person = new Person
			{
			Name = "Test",
			Age = 1,
			Married = false,
			BirthDate = DateTime.Now,
			Weight = 1,
			Lunchtime = DateTime.Now.TimeOfDay,


			};

		}

	}
	
}