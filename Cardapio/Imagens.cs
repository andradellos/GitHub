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
	public class Imagens
	{
		public string Nome { get; set; }
		public int Imagem { get; set; }

		public Imagens(string _nome, int _NumImage)
		{
			this.Nome = _nome;
			this.Imagem = _NumImage;
		}
	}
}