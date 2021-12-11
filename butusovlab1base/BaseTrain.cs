using System.Drawing;

namespace butusovlab1base
{
    public class BaseTrain : Vehicle
    {
        protected readonly int trainWidth = 200;

        protected readonly int trainHeight = 190;

        public BaseTrain(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected BaseTrain(int maxSpeed, float weight, Color mainColor, int trainWidth, int trainHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.trainWidth = trainWidth;
            this.trainHeight = trainHeight;
        }

        public override void MoveTrain(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
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
        public override void DrawTrain(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainbrush = new SolidBrush(MainColor);
            Brush wheelbrush = new SolidBrush(Color.Black);
            g.FillRectangle(mainbrush, _startPosX, _startPosY + 50, 200, 100);
            g.FillEllipse(wheelbrush, _startPosX + 5, _startPosY + 130, 60, 60);
            g.FillEllipse(wheelbrush, _startPosX + 70, _startPosY + 130, 60, 60);
            g.FillEllipse(wheelbrush, _startPosX + 135, _startPosY + 130, 60, 60);
        }
    }
}
