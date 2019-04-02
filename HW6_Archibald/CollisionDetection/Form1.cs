//Justin Archibald
//CSC 3020 C#
//HW 6

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace CollisionDetection
{
    public partial class Form1 : Form
    {
        Timer loop = new Timer();

        List<Square> squares = new List<Square>();

        Bitmap map;
        Pen black = new Pen(Color.Black, 1);
        Pen red = new Pen(Color.Red, 1);

        Random rand = new Random(8675309);

        Stopwatch totalCalcTime = new Stopwatch();
        Stopwatch frameCounter = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            loop.Enabled = true;

            loop.Tick += new EventHandler(Update);
            loop.Interval = 1;

            frameCounter.Start();

            map = new Bitmap(CollisionMap.Width, CollisionMap.Height);
            Square.Bounds = new Vector2(CollisionMap.Width, CollisionMap.Height);
        }

        /// <summary>
        /// Called as fast as it possibly can be called (up to every 1ms)
        /// </summary>
        public void Update(object o, EventArgs e)
        {
            totalCalcTime.Reset(); totalCalcTime.Start();
            map = new Bitmap(CollisionMap.Width, CollisionMap.Height);
            for (int i = 0; i < 20; i++)
                squares.Add(new Square(rand.Next(3, 5), new Vector2(rand.Next(0, CollisionMap.Width), rand.Next(0, CollisionMap.Height)), new Vector2(rand.Next(-3, 4), rand.Next(-3, 4))));

            foreach(Square s in squares)
            {
                s.Move();
            }
            /**********************************************************************/
            /* SWITCH THESE LINES OF CODE TO TEST THE DIFFERENT METHODS */
            //CollisionDetection();
            CollisionDetectionParallel();
            /**********************************************************************/
            DrawSquares(map);

            totalCalcTime.Stop();
            NumSquaresLabel.Invoke(new MethodInvoker(delegate ()
            {
                FPSLabel.Text = "Frames Per Second = " + 1000f / frameCounter.ElapsedMilliseconds;
                NumSquaresLabel.Text = "Num Squares = " + squares.Count;
                CalcTimeLabel.Text = "Total Calculation Time = " + totalCalcTime.ElapsedMilliseconds + "ms";
            }));
            frameCounter.Reset(); frameCounter.Start();
        }

        /// <summary>
        /// Collision detection without tasks
        /// </summary>
        public void CollisionDetection()
        {
            //Reset the color of squares to black.
            for (int i = 0; i < squares.Count; i++)
                squares[i].Color = Color.Black;

            for(int i = 0; i < squares.Count; i++)
            {
                for (int j = 0; j < squares.Count; j++)
                {
                    if (squares[i] != squares[j] && squares[i].IsCollidingWith(squares[j]))
                    {
                        squares[i].Color = Color.Red;
                        squares[j].Color = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Parallelized collision detection
        /// YOUR CODE GOES HERE!
        /// </summary>
        public void CollisionDetectionParallel()
        {
            //Set the number of squares to a variable.
            //This is faster to pull from a function once and save it locally.
            int sqNumber = squares.Count;

            //Threads the reset function, works faster for larger number of particles.
            //Reset the color of squares to black.
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < sqNumber; i++)
                    squares[i].Color = Color.Black;
            });
            //Starts the thread to reset the squares.


            //Sets 2 different threading algorithms at different number of particles on the screen.
            if (sqNumber > 1200)
            {
                //Threads the first loop, this makes it even faster, it lagged a little when i only threaded the itterations.
                //This function tanks at about 20,000 squares and drops below 10 fps at about 30,000 squares
                Task.Factory.StartNew(() =>
                {
                    //Threads each itteration of the loop, this was faster for particles over 2000, 2500 was closer but it starts to tank at 2000.
                    for (int i = 0; i < sqNumber; i++)
                    {
                        sqNumber = squares.Count;
                        //Sends each itteration to a thread, and queues them                        
                        Collidoscope(i, sqNumber);

                    }
                });
            }
            else
            {
                //Threads each itteration of the duel loop if the number of boxes is below 1200.
                //This was faster to put the loop inside of the thread as opposed to running my function.
                Thread Detector = new Thread(() =>
                {
                    //This runs the orrigional algorithm.
                    for (int i = 0; i < sqNumber; i++)
                    {
                        if (sqNumber > i)
                        {
                            for (int j = 0; j < sqNumber; j++)
                            {
                                if (squares[i] != squares[j] && squares[i].IsCollidingWith(squares[j]))
                                {
                                    squares[i].Color = Color.Red;
                                    squares[j].Color = Color.Red;
                                }
                            }
                        }
                    }
                });
                //Starts the thread to detect collisions.
                Detector.Start();
            }
        }

        //Function that makes it easier to thread the nested loop.
        void Collidoscope(int intercept, int sqNum)
        {
            //Sets the count of squares to a local variable.
            //int sqNum = squares.Count;
            //This makes sure that the limiting variable is not somehow passed beyond the variables required range.
            //In previous versions sometimes the input variable was beyond the limiting range of the loop.
            if (sqNum > intercept)
            {
                //Loops to the number of squares to test the number of collisions.
                for (int j = 0; j < sqNum; j++)
                {
                    if (squares[intercept] != squares[j] && squares[intercept].IsCollidingWith(squares[j]))
                    {
                        squares[intercept].Color = Color.Red;
                        squares[j].Color = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// Draws the squares on the screen
        /// </summary>
        /// <param name="bitmap">The bitmap to update</param>
        public void DrawSquares(Image bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            foreach (Square s in squares.Where(t => t.Color == Color.Red))
            {
                g.DrawRectangle(red, s.Position.X, s.Position.Y, s.Size, s.Size);
            }
            foreach (Square s in squares.Where(t => t.Color == Color.Black))
            {
                g.DrawRectangle(black, s.Position.X, s.Position.Y, s.Size, s.Size);
            }
            CollisionMap.Image = bitmap;
        }
    }
}
