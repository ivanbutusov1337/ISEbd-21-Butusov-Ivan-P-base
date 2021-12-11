using System;
using System.Drawing;
using System.Windows.Forms;

namespace butusovlab1base
{
	public partial class FormParking : Form
	{
		private readonly Parking<BaseTrain> parking;

		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<BaseTrain>(pictureBoxTrains.Width, pictureBoxTrains.Height);
			Draw();
		}
		
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxTrains.Width, pictureBoxTrains.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxTrains.Image = bmp;
		}
		
		private void buttonAddTrain_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var train = new BaseTrain(100, 1000, dialog.Color);
				if (parking + train >= 0)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}

		private void buttonAddHornedTrain_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if(dialog.ShowDialog()==DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if(dialogDop.ShowDialog()==DialogResult.OK)
				{
					var train = new Train(100, 1000, dialog.Color, dialogDop.Color, true, true);

					if (parking+train>=0)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}

		private void buttonTakeCar_Click(object sender, EventArgs e)
		{
			if (maskedTextBox1.Text != "")
			{
				var train = parking - Convert.ToInt32(maskedTextBox1.Text);
				if (train != null)
				{
					FormTrain form = new FormTrain();
					form.SetTrain(train);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
