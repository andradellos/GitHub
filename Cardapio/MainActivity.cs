using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Cardapio
{
	[Activity(Label = "Cardapio", Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int cont = 1;
		string[] estados;
		AutoCompleteTextView autoCompletar1;
		Button btnEnviar;
		Button btnExemploUm;
		Button btnGridImage;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);


			//Button Avisobtn = FindViewById<Button>(Resource.Id.btnAviso);

			//Avisobtn.Click += delegate
			//{
			//	Avisobtn.Text = string.Format("{0} Cliques!", cont++);
			//	Avisobtn.SetTextColor(Android.Graphics.Color.Yellow);
			//};

			Button Olabtn = FindViewById<Button>(Resource.Id.btnAviso);
			Olabtn.Click += delegate
			{
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				AlertDialog alerta = builder.Create();
				//Definir título, ícone, mensagem e os botoes
				alerta.SetTitle("Menu");
				alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
				alerta.SetMessage("Deseja contonuar com o pedido?");
				alerta.SetButton("Ok", (s, ev) =>
				{
					Toast.MakeText(this, "Obrigado e bom apetite...", ToastLength.Short).Show();
				});

				alerta.Show();

			};



			Button btnAvisoTres = FindViewById<Button>(Resource.Id.butComTres);
			btnAvisoTres.Click += delegate
			{
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				AlertDialog alerta = builder.Create();
				alerta.SetCancelable(false);
				//Definir título, ícone, mensagem e os botoes
				alerta.SetTitle("Menu Carnes");
				alerta.SetIcon(Android.Resource.Drawable.IcDialogInfo);
				alerta.SetMessage("Deseja contonuar com o pedido de carnes?");
				alerta.SetButton("Sim", (s, ev) =>
				{
					Toast.MakeText(this, "Obrigado e bom apetite...", ToastLength.Short).Show();
				});
				alerta.SetButton2("Não", (s, ev) =>
				{
					Toast.MakeText(this, "Ainda tem tempo...", ToastLength.Short).Show();
				});
				alerta.SetButton3("Cancelar", (s, ev) =>
				{
					Toast.MakeText(this, "Que pena...", ToastLength.Short).Show();
				});

				alerta.Show();

			};


			estados = new string[] { "Amazona", "Bahia", "Brasilia", "Ceará", "São Paulo", "Rio de Janeiro", "Espirito Sato", "Alagoas", "Tocantins", "Goiás" };
			autoCompletar1 = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView);
			autoCompletar1.Threshold = 3;
			btnEnviar = FindViewById<Button>(Resource.Id.btnEnviar);
			ArrayAdapter adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, estados);
			autoCompletar1.Adapter = adapter;
			btnEnviar.Click += delegate
			{
				if(autoCompletar1.Text != "")
				{
					Toast.MakeText(this, " Estdo = " + autoCompletar1.Text, ToastLength.Short).Show();
				}
				else
				{
					Toast.MakeText(this,"Informe Estado desejado.", ToastLength.Short).Show();
				}
			};


			btnExemploUm = FindViewById<Button>(Resource.Id.btnExemploUm);
			btnExemploUm.Click += BtnExemploUm_Click;

			btnGridImage = FindViewById<Button>(Resource.Id.btnExGridImage);
			btnGridImage.Click += BtnGridImage_Click;
		}

		private void BtnGridImage_Click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(AGridComFoto));
		}

		private void BtnExemploUm_Click(object sender, System.EventArgs e)
		{
			var intent = new Intent(this, typeof(AExemploUm));
			StartActivity(intent);
		}
	}
}

