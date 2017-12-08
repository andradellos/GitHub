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
	[Activity(Label = "AGridComFoto")]
	public class AGridComFoto : Activity
	{
		GridView gv;
		private ImagemAdapter adapter;
		private List<Imagens> ListaImagens;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.UiGridComFoto);

			gv = FindViewById<GridView>(Resource.Id.IdGridFotos);
			adapter = new ImagemAdapter(GetImagens(), this);
			gv.Adapter = adapter;
			gv.ItemClick += Gv_ItemClick;
		}

		private void Gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			Toast.MakeText(this, ListaImagens[e.Position].Nome, ToastLength.Long).Show();
		}

		private List<Imagens> GetImagens()
		{
			ListaImagens = new List<Imagens>();

			ListaImagens.Add(new Imagens("Vitória", Resource.Drawable.vitoriaba));
			ListaImagens.Add(new Imagens("Palmeiras", Resource.Drawable.Palmeiras));
			ListaImagens.Add(new Imagens("Santos", Resource.Drawable.santos));
			ListaImagens.Add(new Imagens("São Paulo", Resource.Drawable.Saopaulo));
			ListaImagens.Add(new Imagens("Flamengo", Resource.Drawable.timeflamengo));
			ListaImagens.Add(new Imagens("Bahia", Resource.Drawable.Bahia));
			return ListaImagens;
		}
	}
}