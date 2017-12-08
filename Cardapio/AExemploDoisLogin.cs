using System;
using System.IO;
using SQLite;
using Cardapio.Resources.Model;


using Android.App;
using Android.Content;
using Android.OS;

using Android.Widget;

namespace Cardapio
{
	[Activity(Label = "AExemploDoisLogin")]
	public class AExemploDoisLogin : Activity
	{
		EditText User;
		EditText Senha;
		Button btnLogin;
		Button btnRegistrar;
		Button btnListAdapterGoogle;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.ExemploDois);

			User = FindViewById<EditText>(Resource.Id.txtUsuario2);
			Senha = FindViewById<EditText>(Resource.Id.txtSenha2);
			btnLogin = FindViewById<Button>(Resource.Id.btnsLoguin2);
			btnRegistrar = FindViewById<Button>(Resource.Id.btnRegistrar2);
			btnListAdapterGoogle = FindViewById<Button>(Resource.Id.btnExemplo3);

			btnLogin.Click += BtnLogin_Click;
			btnRegistrar.Click += BtnRegistrar_Click;
			btnListAdapterGoogle.Click += BtnListAdapterGoogle_Click;
			CriarBancoDados();
		}

		private void BtnListAdapterGoogle_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(ALisViewGoogle));
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
				var db = new SQLiteConnection(dbPath);
				var dados = db.Table<Login>();

				var Login = dados.Where(x => x.usuario == User.Text && x.senha == Senha.Text).FirstOrDefault();

				if (Login != null)
				{
					Toast.MakeText(this, "Login realizado com sucesso.", ToastLength.Long).Show();
					var VouAtividade2 = new Intent(this, typeof(AposLogin));
					VouAtividade2.PutExtra("nome", FindViewById<EditText>(Resource.Id.txtUsuario2).Text);
					StartActivity(VouAtividade2);
				}
				else
				{
					Toast.MakeText(this, "Usuário  ou senha não existe.", ToastLength.Long).Show();
				}
			}
			catch (Exception ex)
			{
				Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
			}
			
		}

		private void BtnRegistrar_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(Aregistrar));
		}
		private void CriarBancoDados()
		{
			try
			{
				string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
				var db = new SQLiteConnection(dbPath);
			}
			catch (Exception ex)
			{
				Toast.MakeText(this, ex.ToString(), ToastLength.Long).Show();
			}
		
		}
	}
}