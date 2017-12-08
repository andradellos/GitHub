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
	[Activity(Label = "ALogin")]
	public class ALogin : Activity
	{
		Button LoginComBDbtn;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.login);
			Button btnRetornar = FindViewById<Button>(Resource.Id.btnVoltar);
			Button btnlogin = FindViewById<Button>(Resource.Id.btnsLoguin);

			LoginComBDbtn = FindViewById<Button>(Resource.Id.btnLoginComBD);

			FindViewById<EditText>(Resource.Id.txtNome).Text = Intent.GetStringExtra("Nome") ?? "Erro ao obter dados.";
			FindViewById<EditText>(Resource.Id.txtSenha).Text = Intent.GetStringExtra("Senha") ?? "Erro ao obter dados.";


			btnlogin.Click += Btnlogin_Click;
			btnRetornar.Click += BtnRetornar_Click;
			LoginComBDbtn.Click += LoginComBDbtn_Click;

		}

		private void LoginComBDbtn_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(AExemploDoisLogin));
		}

		private void BtnRetornar_Click(object sender, EventArgs e)
		{
			Finish();
		}

		private void Btnlogin_Click(object sender, EventArgs e)
		{
			Toast.MakeText(this, " <<< Login >>> ", ToastLength.Long);
		}
	}
}