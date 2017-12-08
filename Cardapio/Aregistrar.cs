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
	[Activity(Label = "Aregistrar")]
	public class Aregistrar : Activity
	{

		EditText User;
		EditText Senha;
		Button btnLoginCriarUser;
		Button bTnGrigSimples;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Registrar);

			User = FindViewById<EditText>(Resource.Id.txtUsuarioReg);
			Senha = FindViewById<EditText>(Resource.Id.txtSenhaReg);
			btnLoginCriarUser = FindViewById<Button>(Resource.Id.btnRegistrarReg);

			btnLoginCriarUser.Click += BtnLoginCriarUser_Click;
			bTnGrigSimples = FindViewById<Button>(Resource.Id.btnGridSimples);
			bTnGrigSimples.Click += BTnGrigSimples_Click;


		}

		private void BTnGrigSimples_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(AGridSimples));
		}

		private void BtnLoginCriarUser_Click(object sender, EventArgs e)
		{
			try
			{
				string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
				var db = new SQLiteConnection(dbPath);
				var dados = db.CreateTable<Login>();

				Login tbLogin = new Login();
				tbLogin.usuario = User.Text;
				tbLogin.senha = Senha.Text;

				db.Insert(tbLogin);

				Toast.MakeText(this, "Usuário cadastrado.", ToastLength.Long).Show();
				
			}
			catch (Exception ex)
			{
				Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
			}
		}
	}
}