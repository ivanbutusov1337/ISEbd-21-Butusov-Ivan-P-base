using System.Collections.Generic;
using System.Drawing;
namespace butusovlab1base
{
    public class Parking<T> where T : class, ITransport
    {
        //objects` array
        private readonly List<T> _places;

        private readonly int _maxCount;

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
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
        public static bool operator +(Parking<T> p, T train)
        {
            if (p._places.Count == p._maxCount)
            {
                return false;
            }
            else
            {
                p._places.Add(train);
                return true;
            }
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (index > -1 && index < p._maxCount && index <= p._places.Count)
            {

                T tmp = p._places[index - 1];
                p._places[index - 1] = null;
                p._places.Remove(p._places[index - 1]);
                return tmp;

            }
            return null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
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
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i]?.DrawTrain(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
