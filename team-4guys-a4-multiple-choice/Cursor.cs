using MohawkGame2D;
using System;
using System.Drawing;
using System.Numerics;

internal class cursorDetect
{
    // Array update (For actual game)
    public void Update(button[] buttonList)
    {
        detectClicksArray(buttonList);
    }

    // Single button update (For title and restart)
    public void Update(button singleButton)
    {
        detectClickSingle(singleButton);
    }

    // Array click detect process
    public void detectClicksArray(button[] buttonList)
    {
        Vector2 mouse = Input.GetMousePosition();

        for (int i = 0; i < buttonList.Length; i++)
        {
            button btn = buttonList[i];

            float top = btn.pos.Y;
            float bottom = btn.pos.Y + btn.size.Y;
            float left = btn.pos.X;
            float right = btn.pos.X + btn.size.X;

            bool clicked =
                mouse.X >= left &&
                mouse.X <= right &&
                mouse.Y >= top &&
                mouse.Y <= bottom &&
                Input.IsMouseButtonPressed(MouseInput.Left);

            if (clicked)
            {
                // If player selects correct answer
                if (btn.answer)
                {
                    Game.question++;
                    Game.point++;
                    Console.WriteLine("DEBUG: Correct!");
                    Game.canPlay = true;
                }
                // If player selects wrong answer
                else
                {
                    Game.question++;
                    Console.WriteLine("DEBUG: Wrong!");
                    Game.incorrect = true;
                    Game.canPlay = true;
                }
            }
        }
    }

    // Single click detect process
    public void detectClickSingle(button btn)
    {
        Vector2 mouse = Input.GetMousePosition();

        float top = btn.pos.Y;
        float bottom = btn.pos.Y + btn.size.Y;
        float left = btn.pos.X;
        float right = btn.pos.X + btn.size.X;

        bool clicked =
            mouse.X >= left &&
            mouse.X <= right &&
            mouse.Y >= top &&
            mouse.Y <= bottom &&
            Input.IsMouseButtonPressed(MouseInput.Left);

        if (clicked)
        {
            // Title/Continue Button
            if (btn.answer)
            {
                Game.question++;
                Game.incorrect = false;
                Console.WriteLine("DEBUG: Continue Button clicked!");
                Game.canPlay = true;

            }
            // Restart
            else
            {
                Game.point = 0;
                Game.question = 0;
                Console.WriteLine("DEBUG: Restart Button clicked!");
            }
        }
    }
}
