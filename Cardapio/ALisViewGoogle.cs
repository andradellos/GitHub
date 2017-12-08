using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Cardapio
{
	[Activity(Label = "ALisViewGoogle")]
	public class ALisViewGoogle : ListActivity
	{
		List<string> recursos;
		
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			//SetContentView(Resource.Layout.ListViewComGoogle);
			CarregaLista();
			ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, recursos);
			
		}

		//sobreescrevendo esse método da base listActivity
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var item = recursos[position];
			Toast.MakeText(this, item, ToastLength.Long).Show();
			var uri = Android.Net.Uri.Parse("https://www.google.com/#q=" + item);

			var intent = new Intent(Intent.ActionView, uri);

			StartActivity(intent);
		}
		private void CarregaLista()
		{
			recursos = new List<string>();
			recursos.Add("Vb .Net");
			recursos.Add("C#");
			recursos.Add("Java");
			recursos.Add("Javascript");
			recursos.Add("VB");
		}
	}
}