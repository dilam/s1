using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck
{
    class Brainfuck
    {
        public static void interpret(string code)
        {
            int size = 30000;
            int max = 255;

            Stack<int> loop = new Stack<int>();
            int[] tab = new int[size];

            for(int j = 0; j < size; j++)
                tab[j] = 0;

            int i = 0;
            int p = 0;
            int lon = code.Length;

            while(i < lon)
            {
                if (code[i] == '>')
                    p++;
                if (code[i] == '<')
                    p--;
                if (code[i] == '+')
                    tab[p] = tab[p] == max ? 0 : tab[p] + 1;
                if (code[i] == '-')
                    tab[p] = tab[p] == 0 ? max : tab[p] - 1;
                if (code[i] == '.')
                    Console.Write((char)tab[p]);
                if (code[i] == ',')
                    tab[p] = (char)Console.ReadKey(true).KeyChar;
                if (code[i] == '[')
                {
                    loop.Push(i);
                    if (tab[p] == 0)
                    {
                        int test = 0;
                        bool b = true;
                        while (i < lon && b)
                        {
                            if (code[i] == '[')
                                test++;
                            if (code[i] == ']')
                            {
                                if (test == 0)
                                    b = false;
                                else
                                    test--;
                            }
                            i++;
                        }
                        i--;
                    }
                }
                if (code[i] == ']')
                {
                    if (tab[p] != 0)
                        i = loop.Peek();
                }
                i++;
            }
        }

        public static string generate_code_from_text(string text)
        {
            int size = 30000;
            
            int[] tab = new int[size];

            for (int j = 0; j < size; j++)
                tab[j] = 0;

            string result = "";
            
            int lon = text.Length;
            
            for(int i = 0; i < lon; i++)
            {
                int chr = (int)text[i];
                
                if (chr < tab[1])
                {
                    result += "[-]";
                    tab[1] = 0;

                    for (int j = 0; j < chr; j++)
                        result += "+";

                    tab[1] = chr;
                }
                else
                {
                    for (int j = tab[1]; j < chr; j++)
                        result += "+";

                    tab[1] = chr;
                }

                result += ".";
            }

            return result;
        }

        public static string shorten_code(string program)
        {
            string result = "";

            int i = 0;
            int lon = program.Length;

            while (i < lon)
            {
                if (program[i] != '+')
                    result += program[i];
                else
                {
                    int counter = 0;
                    while (program[i] == '+' && i < lon)
                    {
                        i++;
                        counter++;
                    }

                    i--;

                    int mult = (int)Math.Sqrt(counter);
                    while (counter % mult != 0)
                        mult--;

                    if (mult != 1)
                    {
                        result += ">";
                        for (int j = 0; j < mult; j++)
                            result += "+";
                        result += "[<";
                        for (int j = 0; j < counter / mult; j++)
                            result += "+";
                        result += ">-]<";
                    }
                    else
                        for (int j = 0; j < counter; j++)
                            result += "+";
                }
                i++;
            }

            return result;
        }
    }
}
