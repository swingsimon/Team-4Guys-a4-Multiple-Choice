using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class cursorDetect
    {
        // Cursor position and size
        Vector2 pos;
        Vector2 size;

        // Set up for cursor position and size
        public cursorDetect(Vector2 pos, Vector2 size)
        {
            this.pos = pos;
            this.size = size;

        }

        public void choiceUpdate(button[] buttonDetect)
        {
            mousePos();
            collisionProcess(buttonDetect);
        }

        public void mousePos()
        {
            pos = Input.GetMousePosition();
        }

        // Collision detection
        public void collisionProcess(button[] buttonDetect)
        {
            for (int buttonBox = 0; buttonBox < buttonDetect.Length; buttonBox++)
            {
                button select = buttonDetect[buttonBox];

                // Hitbox collision boundaries
                float hitboxTop = select.pos.Y;
                float hitboxBottom = select.pos.Y + select.size.Y;
                float hitboxLeft = select.pos.X;
                float hitboxRight = select.pos.X + select.size.X;

                // Player collision boundaries
                float playerTop = pos.Y - size.Y / 2;
                float playerBottom = pos.Y + size.Y / 2 - 1;
                float playerLeft = pos.X - size.X / 2;
                float playerRight = pos.X + size.X / 2 - 1;

                // Checks if they touch each other
                bool onClick = playerRight >= hitboxLeft && playerLeft <= hitboxRight && playerBottom >= hitboxTop && playerTop <= hitboxBottom && Input.IsMouseButtonPressed(MouseInput.Left);

                if (onClick)
                {
                    // If player touches the wall
                    if (select.answer)
                    {
                        Game.question++;
                        Console.WriteLine("Correct!");
                    }
                    // If player touches the goal
                    if (select.answer == false)
                    {
                        Game.question++;
                        Console.WriteLine("Wrong!");
                    }
                }

            }
        }
    }
}