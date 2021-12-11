using System.Drawing;

namespace butusovlab1base
{
	public interface ITransport
	{
		void SetPosition(int x, int y, int width, int height);

		void MoveTrain(Direction direction);

		void DrawTrain(Graphics g);
	}
}
