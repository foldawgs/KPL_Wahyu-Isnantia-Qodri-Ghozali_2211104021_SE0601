using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum1_console
{
    class Program
    {
        enum State { START, GAME, PAUSE, EXIT };
        public static void Main()
        {
            State state = State.START;
            string[] screenName = { "START", "GAME", "PAUSE", "EXIT" };
            while (state != State.EXIT)
            {
                Console.WriteLine(screenName[(int)state] + " SCREEN");
                Console.Write("Enter Command : ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.START:
                        if (command == "ENTER")
                            state = State.GAME;
                        else if (command == "QUIT")
                            state = State.EXIT;
                        else
                            state = State.START;
                        break;
                    case State.GAME:
                        if (command == "ESC")
                            state = State.PAUSE;
                        else
                            state = State.GAME;
                        break;
                    case State.PAUSE:
                        if (command == "BACK")
                            state = State.GAME;
                        else if (command == "HOME")
                            state = State.START;
                        else if (command == "QUIT")
                            state = State.EXIT;
                        else
                            state = State.PAUSE;
                        break;
                }
            }
            Console.WriteLine("EXIT SCREEN");
        }
    }
}
