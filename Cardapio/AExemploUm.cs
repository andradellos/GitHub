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
	[Activity(Label = "AExemploUm")]
	public class AExemploUm : Activity
	{
		Button btnFones;
		Button btnWebs;
		Button btnLogins;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.ExemploUm);

			btnFones = FindViewById<Button>(Resource.Id.btnFone);
			btnWebs = FindViewById<Button>(Resource.Id.btnWeb);
			btnLogins = FindViewById<Button>(Resource.Id.btnLogin);

			btnLogins.Click += BtnLogins_Click;
			btnFones.Click += BtnFones_Click;
			btnWebs.Click += BtnWebs_Click;

		}

		private void BtnWebs_Click(object sender, EventArgs e)
		{
			var uri = Android.Net.Uri.Parse("http://www.google.com");
			var intentWeb = new Intent(Intent.ActionView, uri);
			StartActivity(intentWeb);
		}

		private void BtnFones_Click(object sender, EventArgs e)
		{
			var uri = Android.Net.Uri.Parse("tel:1112223333");
			var intentFone = new Intent(Intent.ActionDial, uri);
			StartActivity(intentFone);
		}

		private void BtnLogins_Click(object sender, EventArgs e)
		{
			var intentLogin = new Intent(this, typeof(ALogin));
			//enviando dados para activity ALogin
			intentLogin.PutExtra("Nome", "Manolo");
			intentLogin.PutExtra("Senha", "12344321");
			StartActivity(intentLogin);
		}
	}
}