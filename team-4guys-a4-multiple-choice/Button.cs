using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class button
    {
        public Vector2 pos;
        public Vector2 size;
        public bool answer;
        public string text;
        public int textSize;

        Color color;

        public button(Vector2 pos, Vector2 size, bool answer, string text, int textSize)
        {
            this.pos = pos;
            this.size = size;
            this.answer = answer;
            this.text = text;
            this.textSize = textSize;
        }

        public void Update()
        {
            buttonDraw();
        }

        public void buttonDraw()
        {
            Draw.LineSize = 2;
            Draw.LineColor = Color.Green;
            Draw.FillColor = Color.Black;
            Draw.Rectangle(pos, size);

            float textPosX = pos.X + 2;
            float textPosY = pos.Y + size.Y / 2;

            Text.Color = Color.Green;
            Text.Size = textSize;
            Text.Draw(text, textPosX, textPosY);
        }
    }
}