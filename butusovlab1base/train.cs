using System.Drawing;

namespace butusovlab1base
{
    public class Train : BaseTrain
    {
        public Color AdditColor { private set; get; }
        public bool Horns { private set; get; }
        public bool Flashlight { private set; get; }

        public Train(int maxSpeed, float weight, Color mainColor, Color additColor, bool horns, bool flashLight) : base(maxSpeed, weight, mainColor, 200, 190)
        {
            AdditColor = additColor;
            Flashlight = flashLight;
            Horns = horns;
        }
        public override void DrawTrain(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush additbrush = new SolidBrush(AdditColor);
            if (Horns)
            {
                g.DrawLine(pen, _startPosX + 30, _startPosY + 50, _startPosX + 15, _startPosY);
                g.DrawLine(pen, _startPosX + 30, _startPosY + 50, _startPosX + 45, _startPosY);
                g.DrawLine(pen, _startPosX + 75, _startPosY + 50, _startPosX + 60, _startPosY);
                g.DrawLine(pen, _startPosX + 75, _startPosY + 50, _startPosX + 90, _startPosY);
                g.DrawLine(pen, _startPosX + 120, _startPosY + 50, _startPosX + 105, _startPosY);
                g.DrawLine(pen, _startPosX + 120, _startPosY + 50, _startPosX + 135, _startPosY);
                g.DrawLine(pen, _startPosX + 165, _startPosY + 50, _startPosX + 150, _startPosY);
                g.DrawLine(pen, _startPosX + 165, _startPosY + 50, _startPosX + 180, _startPosY);
            }
            base.DrawTrain(g);
            if (Flashlight)
            {
                g.FillRectangle(additbrush, _startPosX, _startPosY + 50, 20, 20);
            }
        }
    }
}