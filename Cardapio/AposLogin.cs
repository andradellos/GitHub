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
	[Activity(Label = "AposLogin")]
	public class AposLogin : Activity
	{
		TextView txv;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.PosLogin);
			txv = FindViewById<TextView>(Resource.Id.lblPosLogin);

			txv.Text = "Bem vindo " + Intent.GetStringExtra("nome") ?? "Erro Obterdados";
		}
	}
}