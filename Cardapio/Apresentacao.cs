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
using System.Threading;

namespace Cardapio
{
	[Activity(Theme = "@style/manolo.Theme", MainLauncher = true, NoHistory = true)]
	public class Apresentacao : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			//tempo
			Thread.Sleep(3000);
			//startar a activit escolhida
			StartActivity(typeof(MainActivity));
		}
	}
}