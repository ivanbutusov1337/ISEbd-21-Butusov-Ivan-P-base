using System.Drawing;

namespace butusovlab1base
{
	public class Parking<T> where T : class, ITransport
	{
		//objects` array
		private readonly T[] _places;

		//window
		private readonly int pictureWidth;
		private readonly int pictureHeight;
		
		//parking space
		private readonly int _placeSizeWidth = 210;
		private readonly int _placeSizeHeight = 200;

		//constructor
		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static int operator +(Parking<T> p, T train)
		{
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p._places[i] == null)
				{
					p._places[i] = train;
					return i;
				}
			}
			return -1;
		}

		public static T operator -(Parking<T> p, int index)
		{
			if (index > -1 && index < p._places.Length && p._places[index] != null)
			{
				T Train = p._places[index];
				p._places[index] = null;
				return Train;
			}
			else
			{
				return null;
			}
		}


		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				if (_places[i] != null)
				{
					FormTrain form = new FormTrain();
					if (i < 3)
					{
						_places[i].SetPosition(i * _placeSizeWidth + 5, 10, pictureWidth + 250, pictureHeight);
					}
					if ((i > 2) && (i < 6))
					{
						_places[i].SetPosition((i - 3) * _placeSizeWidth + 5, _placeSizeHeight + 10, pictureWidth + 250, pictureHeight);
					}
				}
			}
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i]?.DrawTrain(g);
			}
		}

		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);

			for(int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j=0;j<pictureHeight/_placeSizeHeight+1;++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *_placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}
