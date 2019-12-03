using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace Homework11
{
    class GameForSpeed
    {

        public static void Game(int time)
        {
           
            Random rand = new Random();
            System.Timers.Timer t = new System.Timers.Timer(2500);
            try
            {
                
                while (true)
                {
                    //Monitor.Enter(t);
                    t.Start();
                    int input;
                    int p = rand.Next(0, 9);
                    Console.WriteLine("Press number " + p);
                    t.Elapsed += (sender, e) =>
                    {
                        try
                        {
                            throw new OutOfTimeException();
                        }
                        catch (OutOfTimeException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Game Over"); 

                        }
                        finally
                        {
                            t.Dispose();
                            Exit();                           
                        }
                        

                    };

                    input = Convert.ToInt32(Console.ReadLine());
                    if (input != p)
                    {
                        Console.WriteLine("Wrong number. Game over.");
                        t.Stop();
                        break;
                    }
                    t.Stop();
                    //Monitor.Exit(t);
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Game Over");
                t.Stop();
            }
        }
        
        private static void Exit()
        {
            Environment.Exit(1);
        }
        

    }
}
