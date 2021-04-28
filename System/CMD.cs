using System;
using System.Collections.Generic;
using System.Text;
using AndroidSystemOS.Commands;
using AndroidSystemOS.Self_Methods;

namespace AndroidSystemOS.System
{
    class CMD
    {
        string command;
        string lstCommand = "";
        public void Start()
        {
            Console.Write("-> ");
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.Enter)
            {
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (lstCommand != "")
                        {
                            command += lstCommand;
                        }
                        Console.Write(command);
                        break;
                    case ConsoleKey.Backspace:
                        command = new RemoveLst().RemoveLstString(command);
                        Console.WriteLine();
                        Console.Write("-> " + command);
                        break;
                    default:
                        command += k.KeyChar.ToString();
                        break;
                }
                k = Console.ReadKey();
            }
            if (k.Key == ConsoleKey.Enter)
            {
                lstCommand = command.Split()[0];
            }
            Console.WriteLine();
            Processing(command.Split());
            command = "";
        }

        public void Processing(string[] input)
        {
            switch (input[0])
            {
                case "help":
                    new Help();
                    break;
                case "calc":
                    if (input.Length > 2)
                    {
                        new Calculator(input);
                    }
                    else
                    {
                        new Error(1);
                    }
                    break;
                case "exit":
                    new Exit();
                    break;
                default:
                    new Error(0);
                    break;
            }
        }
    }
}
