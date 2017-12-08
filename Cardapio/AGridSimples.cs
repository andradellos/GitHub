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
using System.Collections;

namespace Cardapio
{
	[Activity(Label = "AGridSimples")]
	public class AGridSimples : Activity
	{
		GridView Gv;
		ArrayList  recursos;
		ArrayAdapter Adaptador;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.UiGridSimples);
			Gv = FindViewById<GridView>(Resource.Id.IdGridSimples);
			CarregaLista();
			 Adaptador = new ArrayAdapter(this,Android.Resource.Layout.SimpleListItem1,recursos);
			Gv.Adapter = Adaptador;
			Gv.ItemClick += Gv_ItemClick;
		}

		private void Gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			Toast.MakeText(this, recursos[e.Position].ToString(), ToastLength.Long).Show();
		}

		private void CarregaLista()
		{
			recursos = new ArrayList();
			recursos.Add("Maria");
			recursos.Add("pedro");
			recursos.Add("João");
			recursos.Add("Daniela");
			recursos.Add("Emanuel");
			recursos.Add("Teca");
			recursos.Add("Nita");
		}
	}
}