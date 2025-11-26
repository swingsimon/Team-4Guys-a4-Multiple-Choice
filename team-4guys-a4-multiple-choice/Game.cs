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
        public static int point = 0;
        public static bool incorrect = false;
        cursorDetect Cursor = new cursorDetect();

        button Title = new button(new Vector2(250, 200), new Vector2(250, 100), true, "PLAY", 50);

        button Continue = new button(new Vector2(250, 200), new Vector2(250, 100), true, "CONTINUE", 50);

        button[] questionOne = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, "Draws the user interface", 15),
        new button(new Vector2(150, 500), new Vector2(200, 80), true,"Handles continuous logic every frame", 10), // Correct Answer
        new button(new Vector2(450, 400), new Vector2(200, 80), false, "Runs once when the game starts", 12),
        new button(new Vector2(450, 500), new Vector2(200, 80), false, "Saves the game state", 17),
        };
        button[] questionTwo = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, "    String", 25),
        new button(new Vector2(150, 500), new Vector2(200, 80), false,"    Boolean", 25),
        new button(new Vector2(450, 400), new Vector2(200, 80), true, "    Integer", 25), // Correct Answer
        new button(new Vector2(450, 500), new Vector2(200, 80), false, "   Character", 25),
        };
        button[] questionThree = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, " To save player progress", 15),
        new button(new Vector2(150, 500), new Vector2(200, 80), false," To increase framerate", 16),
        new button(new Vector2(450, 400), new Vector2(200, 80), false, " To render 3D graphics", 16),
        new button(new Vector2(450, 500), new Vector2(200, 80), true, " To check if two objects overlap", 11), // Correct Answer
        };
        button[] questionFour = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, " A function that runs every frame", 11),
        new button(new Vector2(150, 500), new Vector2(200, 80), true," A blueprint for creating objects", 11), // Correct Answer
        new button(new Vector2(450, 400), new Vector2(200, 80), false, " A variable storing player data", 12),
        new button(new Vector2(450, 500), new Vector2(200, 80), false, " A single instance of an object", 12),
        };
        button[] questionFive = {
        new button(new Vector2(150, 400), new Vector2(200, 80), true, "     Array", 25), // Correct Answer
        new button(new Vector2(150, 500), new Vector2(200, 80), false,"    Boolean", 25),
        new button(new Vector2(450, 400), new Vector2(200, 80), false, "     String", 25),
        new button(new Vector2(450, 500), new Vector2(200, 80), false, "    Integer", 25),
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
            Window.ClearBackground(Color.Black);
            if (question == 0)
            {
                Title.Update();
                Cursor.Update(Title);
            }
            if (question == 1)
            {
                Text.Size = 20;
                Text.Color = Color.Green;
                Text.Draw("Q1: In most game engines, what does the 'Update()' function typically do?", 10, 20);
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 2)
            {
                if(incorrect == false)
                {
                    // CORRECT
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    Continue.Update();
                    Cursor.Update(Continue);
                }
            }
            if (question == 3)
            {
                Text.Size = 20;
                Text.Color = Color.Green;
                Text.Draw("Q2: Which data type is the best for storing a player's health value?", 40, 20);
                for (int i = 0; i < questionTwo.Length; i++)
                {
                    questionTwo[i].Update();
                }
                Cursor.Update(questionTwo);
            }
            if (question == 4)
            {
                if (incorrect == false)
                {
                    // CORRECT
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 5)
            {
                Text.Size = 20;
                Text.Color = Color.Green;
                Text.Draw("Q3: What is collision detection used for in games?", 120, 20);
                for (int i = 0; i < questionThree.Length; i++)
                {
                    questionThree[i].Update();
                }
                Cursor.Update(questionThree);
            }
            if (question == 6)
            {
                if (incorrect == false)
                {
                    // CORRECT
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 7)
            {
                Text.Size = 20;
                Text.Color = Color.Green;
                Text.Draw("Q4: In object-oriented programming, what is a class?", 120, 20);
                for (int i = 0; i < questionFour.Length; i++)
                {
                    questionFour[i].Update();
                }
                Cursor.Update(questionFour);
            }
            if (question == 8)
            {
                if (incorrect == false)
                {
                    // CORRECT
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 9)
            {
                Text.Size = 15;
                Text.Color = Color.Green;
                Text.Draw("Q5: If you want to spawn 10 enemies at different positions, which data structure is most efficient?", 5, 20);
                for (int i = 0; i < questionFive.Length; i++)
                {
                    questionFive[i].Update();
                }
                Cursor.Update(questionFive);
            }
            if (question == 10)
            {
                if (incorrect == false)
                {
                    // CORRECT
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 10)
            {
                if(point < 3)
                {
                    // Try again!

                }
                if (point == 3 || point == 4 )
                {
                    // Not bad!

                }
                if (point == 5)
                {
                    // Perfect!

                }
            }
        }
    }

}