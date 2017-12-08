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
using Java.Lang;

namespace Cardapio
{
	public class ImagemAdapter: BaseAdapter
	{
		private Context ctx;
		private List<Imagens> Imagens;
		private LayoutInflater layinfla;


		public ImagemAdapter(List<Imagens> _imagens, Context c)
		{
			this.Imagens = _imagens;
			this.ctx = c;
		}
		public override int Count
		{
			get
			{
				return Imagens.Count;
			}
		}
		public override  Java.Lang.Object GetItem (int position)
		{
			return Imagens[position].Nome;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			if(layinfla == null)
			{
				layinfla = (LayoutInflater)ctx.GetSystemService(Context.LayoutInflaterService);
			}
			if(convertView ==null)
			{
				convertView = layinfla.Inflate(Resource.Layout.modeloGrid, parent, false);
			}

			ImageView Imagem = convertView.FindViewById<ImageView>(Resource.Id.ImgGridImagem);
			TextView txtNome = convertView.FindViewById<TextView>(Resource.Id.TxtNomeGridImage);			

			txtNome.Text = Imagens[position].Nome;
			Imagem.SetImageResource(Imagens[position].Imagem);

			return convertView;
		}
	}
}