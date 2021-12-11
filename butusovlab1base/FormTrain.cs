using System;
using System.Drawing;
using System.Windows.Forms;

namespace butusovlab1base
{
	public partial class FormTrain : Form
	{
		private Train train;

		public FormTrain()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxtrain.Width, pictureBoxtrain.Height);
			Graphics gr = Graphics.FromImage(bmp);
			train.DrawTrain(gr);
			pictureBoxtrain.Image = bmp;
		}

		private void buttonCreate_Click(object sender ,EventArgs e)
		{
			Random rnd = new Random();
			train = new Train();
			train.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
			train.SetPos(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxtrain.Width, pictureBoxtrain.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					train.MoveTrain(Direction.Up);
					break;
				case "buttonDown":
					train.MoveTrain(Direction.Down);
					break;
				case "buttonLeft":
					train.MoveTrain(Direction.Left);
					break;
				case "buttonRight":
					train.MoveTrain(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
