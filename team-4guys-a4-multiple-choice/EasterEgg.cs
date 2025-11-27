using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class EasterEgg
    {
        private Vector2 pos;
        private Vector2 size;
        private bool visible = false;
        private bool activated = false;

        public EasterEgg()
        {
            // Hidden zone off to the side corner
            pos = new Vector2(700, 500);
            size = new Vector2(80, 80);
        }

        public void Reveal()
        {
            visible = true;
        }

        public void Update()
        {
            if (!visible) return;

            
            Vector2 mousePos = Input.GetMousePosition();

            bool inside =
                mousePos.X >= pos.X &&
                mousePos.X <= pos.X + size.X &&
                mousePos.Y >= pos.Y &&
                mousePos.Y <= pos.Y + size.Y;

            activated = inside;

            if (activated)
            {
                DrawSmiley();
            }
        }


        private void DrawSmiley()
        {
            Draw.FillColor = Color.Yellow;
            Draw.Circle(400, 300, 100); // Face

            Draw.FillColor = Color.Black;
            Draw.Circle(370, 270, 15);  // Left eye
            Draw.Circle(430, 270, 15);  // Right eye

            Draw.FillColor = Color.Black;
            Draw.Circle(400, 350, 25); // Gasp
        }
    }
}
