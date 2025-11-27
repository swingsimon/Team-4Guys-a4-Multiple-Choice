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
        public static bool canPlay = false;
        cursorDetect Cursor = new cursorDetect();

        button Title = new button(new Vector2(250, 200), new Vector2(250, 100), true, Color.Green, "   PLAY", 50);

        button Continue = new button(new Vector2(250, 200), new Vector2(250, 100), true, Color.Green, "CONTINUE", 50);

        button Restart = new button(new Vector2(250, 450), new Vector2(250, 100), false, Color.Green, "TRY AGAIN", 50);

        button[] questionOne = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, Color.Red, "Draws the user interface", 15),
        new button(new Vector2(150, 500), new Vector2(200, 80), true, Color.Blue, "Handles continuous logic every frame", 10), // Correct Answer
        new button(new Vector2(450, 400), new Vector2(200, 80), false, Color.Green, "Runs once when the game starts", 12),
        new button(new Vector2(450, 500), new Vector2(200, 80), false, Color.Yellow, "Saves the game state", 17),
        };
        button[] questionTwo = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, Color.Blue, "    String", 25),
        new button(new Vector2(150, 500), new Vector2(200, 80), false,Color.Green,  "    Boolean", 25),
        new button(new Vector2(450, 400), new Vector2(200, 80), true, Color.Yellow, "    Integer", 25), // Correct Answer
        new button(new Vector2(450, 500), new Vector2(200, 80), false, Color.Red, "   Character", 25),
        };
        button[] questionThree = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, Color.Green, " To save player progress", 15),
        new button(new Vector2(150, 500), new Vector2(200, 80), false, Color.Yellow, " To increase framerate", 16),
        new button(new Vector2(450, 400), new Vector2(200, 80), false, Color.Red, " To render 3D graphics", 16),
        new button(new Vector2(450, 500), new Vector2(200, 80), true, Color.Blue, " To check if two objects overlap", 11), // Correct Answer
        };
        button[] questionFour = {
        new button(new Vector2(150, 400), new Vector2(200, 80), false, Color.Yellow, " A function that runs every frame", 11),
        new button(new Vector2(150, 500), new Vector2(200, 80), true, Color.Red, " A blueprint for creating objects", 11), // Correct Answer
        new button(new Vector2(450, 400), new Vector2(200, 80), false, Color.Blue, " A variable storing player data", 12),
        new button(new Vector2(450, 500), new Vector2(200, 80), false, Color.Green, " A single instance of an object", 12),
        };
        button[] questionFive = {
        new button(new Vector2(150, 400), new Vector2(200, 80), true, Color.Red, "     Array", 25), // Correct Answer
        new button(new Vector2(150, 500), new Vector2(200, 80), false, Color.Blue, "    Boolean", 25),
        new button(new Vector2(450, 400), new Vector2(200, 80), false, Color.Green, "     String", 25),
        new button(new Vector2(450, 500), new Vector2(200, 80), false, Color.Yellow, "    Integer", 25),
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
            Graphics.Draw(Graphics.LoadTexture("Textures/Background.png"), 0, 0);
            if (question == 0)
            {
                Text.Size = 100;
                Text.Draw("THE C# TEST", 120, 60);
                Title.Update();
                Cursor.Update(Title);
            }
            if (question == 1)
            {
                Graphics.Draw(Graphics.LoadTexture("Textures/Question_One_Texture.png"), 100, 50);
                Text.Size = 20;
                Text.Color = Color.Black;
                Text.Draw("Q1: In most game engines, what does the 'Update()' function typically do?", 10, 20);
                for (int i = 0; i < questionOne.Length; i++)
                {
                    questionOne[i].Update();
                }
                Cursor.Update(questionOne);
            }
            if (question == 2)
            {
                if (incorrect == false)
                {
                    // CORRECT
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-correct.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-wrong.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 3)
            {
                Graphics.Draw(Graphics.LoadTexture("Textures/Question_Two_Texture.png"), 100, 50);
                Text.Size = 20;
                Text.Color = Color.Black;
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
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-correct.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-wrong.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 5)
            {
                Graphics.Draw(Graphics.LoadTexture("Textures/Question_Three_Texture.png"), 100, 50);
                Text.Size = 20;
                Text.Color = Color.Black;
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
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-correct.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-wrong.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 7)
            {
                Graphics.Draw(Graphics.LoadTexture("Textures/Question_Four_Texture.png"), 100, 50);
                Text.Size = 20;
                Text.Color = Color.Black;
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
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-correct.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-wrong.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 9)
            {
                Graphics.Draw(Graphics.LoadTexture("Textures/Question_Five_Texture.png"), 100, 50);
                Text.Size = 15;
                Text.Color = Color.Black;
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
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-correct.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
                else
                {
                    // WRONG
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/duolingo-wrong.mp3"));
                        canPlay = false;
                    }
                    Continue.Update();
                    Cursor.Update(Continue);

                }
            }
            if (question == 11)
            {
                Text.Size = 100;
                Text.Draw("RESULTS", 210, 60);
                Draw.LineSize = 4;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(200, 200, 400, 200);
                Text.Size = 100;
                Text.Size = 50;
                Text.Draw($"Score: {point}", 280, 320);
                Restart.Update();
                Cursor.Update(Restart);
                if (point < 3)
                {
                    Text.Draw("Try again!", 230, 240);
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/result_tryagain.mp3"));
                        canPlay = false;
                    }
                    // Try again!

                }
                if (point == 3 || point == 4 )
                {
                    Text.Draw("Not bad!", 230, 240);
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/result_notbad.mp3"));
                        canPlay = false;
                    }
                    // Not bad!

                }
                if (point == 5)
                {
                    Text.Draw("Perfect!", 230, 240);
                    if (canPlay)
                    {
                        Audio.Play(Audio.LoadSound("Audio/result_perfect.mp3"));
                        canPlay = false;
                    }
                    // Perfect!

                }
            }
        }
    }

}