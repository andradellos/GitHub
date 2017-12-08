using Android.App;
using Android.Widget;
using Android.OS;

namespace AppMenu
{
	[Activity(Label = "Menu", Icon = "@drawable/Food-Dome-icon.png")]
	public class MainActivity : Activity
	{
		int cont = 1;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			 SetContentView (Resource.Layout.Main);


			Button Avisobtn = FindViewById<Button>(Resource.Id.btnAviso);

			Avisobtn.Click += delegate
			{
				Avisobtn.Text = string.Format("{0} Cliques!", cont++);
				Avisobtn.SetTextColor(Android.Graphics.Color.Yellow);
			};

			Button Olabtn = FindViewById<Button>(Resource.Id.btnOla);
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



			Button btnAvisoTres = FindViewById<Button>(Resource.Id.btnAviso);
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


		}
	}
}

