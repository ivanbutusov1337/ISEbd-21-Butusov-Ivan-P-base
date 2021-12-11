using System.Drawing;

namespace butusovlab1base
{
	class Train
	{
		//свойства поезда - скорость, вес, основной цвет, доп цвет, наличие "рогов", наличие фонаря
		//поля - координаты отрисовки, границы поля
		//константы - ширина и высота поезда
		//методы - инициализация св-в, начальная поз, перемещение, отрисовка
		private float _startPosX;
		private float _startPosY;
		private int _pictureWidth = 900;
		private int _pictureHeight = 500;
		private readonly int trainWidth = 200;
		private readonly int trainHeight = 190;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public Color AdditColor { private set; get; }
		public bool Horns { private set; get; }
		public bool Flashlight { private set; get; }

		public void Init(int maxSpeed, float weight, Color mainColor, Color additColor, bool horns, bool flashlight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			AdditColor = additColor;
			Horns = horns;
			Flashlight = flashlight;
		}
		public void SetPos(int x, int y, int width, int height)
		{
			_pictureHeight = width;
			_pictureHeight = height;
			_startPosX = x;
			_startPosY = y;
		}
		public void MoveTrain(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - trainWidth)
					{
						_startPosX += step;
					}
					break;

				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;

				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;

				case Direction.Down:
					if (_startPosY + step < _pictureHeight - trainHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public void DrawTrain(Graphics g)
		{

			Pen pen = new Pen(Color.Black);
			Brush mainbrush = new SolidBrush(MainColor);
			Brush additbrush = new SolidBrush(AdditColor);
			Brush wheelbrush = new SolidBrush(Color.Black);
			g.FillRectangle(mainbrush, _startPosX, _startPosY + 50, 200, 100);
			g.FillEllipse(wheelbrush, _startPosX + 5, _startPosY + 130, 60, 60);
			g.FillEllipse(wheelbrush, _startPosX + 70, _startPosY + 130, 60, 60);
			g.FillEllipse(wheelbrush, _startPosX + 135, _startPosY + 130, 60, 60);
			if (Horns)
			{
				g.DrawLine(pen, _startPosX + 15, _startPosY + 50, _startPosX, _startPosY);
				g.DrawLine(pen, _startPosX + 15, _startPosY + 50, _startPosX + 30, _startPosY);
				g.DrawLine(pen, _startPosX + 60, _startPosY + 50, _startPosX + 45, _startPosY);
				g.DrawLine(pen, _startPosX + 60, _startPosY + 50, _startPosX + 75, _startPosY);
				g.DrawLine(pen, _startPosX + 105, _startPosY + 50, _startPosX + 90, _startPosY);
				g.DrawLine(pen, _startPosX + 105, _startPosY + 50, _startPosX + 120, _startPosY);
				g.DrawLine(pen, _startPosX + 150, _startPosY + 50, _startPosX + 135, _startPosY);
				g.DrawLine(pen, _startPosX + 150, _startPosY + 50, _startPosX + 165, _startPosY);
				g.DrawLine(pen, _startPosX + 195, _startPosY + 50, _startPosX + 180, _startPosY);
				g.DrawLine(pen, _startPosX + 195, _startPosY + 50, _startPosX + 210, _startPosY);
			}
			if (Flashlight)
			{
				g.FillRectangle(additbrush, _startPosX, _startPosY + 50, 20, 20);
			}
		}
	}
}