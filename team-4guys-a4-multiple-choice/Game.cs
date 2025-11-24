// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        public static int question = 0;
        cursorDetect Cursor = new cursorDetect(new Vector2(-1, -1), new Vector2(1, 1));
        button[] questionOne = {
        new button(new Vector2(100, 200), new Vector2(100, 100), true, Color.Black, "Correct"), // Correct Answer
        new button(new Vector2(250, 200), new Vector2(100, 100), false, Color.Black, "Wrong"),
        new button(new Vector2(100, 350), new Vector2(100, 100), false, Color.Black, "Wrong"),
        new button(new Vector2(250, 350), new Vector2(100, 100), false, Color.Black, "Wrong"),
        };
        button[] questionTwo = {
        new button(new Vector2(0, 0), new Vector2(250, 600), true, Color.Black, "Correct"), // Correct Answer
        new button(new Vector2(250, 0), new Vector2(550, 50), false, Color.Black, "Wrong"),
        new button(new Vector2(720, 50), new Vector2(80, 40), false, Color.Black, "Wrong"),
        new button(new Vector2(450, 90), new Vector2(350, 510), false, Color.Black, "Wrong"),
        };
        button[] questionThree = {
        new button(new Vector2(0, 0), new Vector2(250, 600), true, Color.Black, "Correct"), // Correct Answer
        new button(new Vector2(250, 0), new Vector2(550, 50), false, Color.Black, "Wrong"),
        new button(new Vector2(720, 50), new Vector2(80, 40), false, Color.Black, "Wrong"),
        new button(new Vector2(450, 90), new Vector2(350, 510), false, Color.Black, "Wrong"),
        };
        button[] questionFour = {
        new button(new Vector2(0, 0), new Vector2(250, 600), true, Color.Black, "Correct"), // Correct Answer
        new button(new Vector2(250, 0), new Vector2(550, 50), false, Color.Black, "Wrong"),
        new button(new Vector2(720, 50), new Vector2(80, 40), false, Color.Black, "Wrong"),
        new button(new Vector2(450, 90), new Vector2(350, 510), false, Color.Black, "Wrong"),
        };
        button[] questionFive = {
        new button(new Vector2(0, 0), new Vector2(250, 600), true, Color.Black, "Correct"), // Correct Answer
        new button(new Vector2(250, 0), new Vector2(550, 50), false, Color.Black, "Wrong"),
        new button(new Vector2(720, 50), new Vector2(80, 40), false, Color.Black, "Wrong"),
        new button(new Vector2(450, 90), new Vector2(350, 510), false, Color.Black, "Wrong"),
        };

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Multiple Choice Game");
            Window.SetSize(800, 600);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            if (question == 0)
            {
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 1)
            {
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 2)
            {
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 3)
            {
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 4)
            {
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 5)
            {
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
        }
    }

}