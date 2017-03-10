using System;
using System.IO;

namespace TinyBistro
{
    public static class Parser
    {
        public static void Parse()
        {
            string bignum1 = "";
            string bignum2 = "";
            string ope = "";

            System.IO.FileStream fs = new System.IO.FileStream("operation.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read); // Access the file
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);

            while (br.PeekChar() != -1 && br.PeekChar() >= 48 && br.PeekChar() <= 57)
            {
                bignum1 += br.ReadChar();
            }

            while (br.PeekChar() != -1 && (br.PeekChar() == 33 || br.PeekChar() == 37 || br.PeekChar() == 42 || br.PeekChar() == 43 || br.PeekChar() == 45 || br.PeekChar() == 47 || br.PeekChar() == 60 || br.PeekChar() == 61 || br.PeekChar() == 62))
            {
                ope += br.ReadChar();
            }

            while (br.PeekChar() != -1)
            {
                bignum2 += br.ReadChar();
            }

            br.Close();

            Console.WriteLine(bignum1 + " " + ope + " " + bignum2 + " =");

            BigNum resultat;
            BigNum num1 = new BigNum(bignum1);
            BigNum num2 = new BigNum(bignum2);

            if (ope == "<")
            {
                Console.WriteLine(num1 < num2);
            }
            else if (ope == ">")
            {
                Console.WriteLine(num1 > num2);
            }
            else if (ope == "==")
            {
                Console.WriteLine(num1 == num2);
            }
            else if (ope == "!=")
            {
                Console.WriteLine(num1 != num2);
            }
            else if (ope == "+")
            {
                resultat = num1 + num2;
                resultat.Print();
            }
            else if (ope == "-")
            {
                resultat = num1 - num2;
                resultat.Print();
            }
            else if (ope == "*")
            {
                resultat = num1 * num2;
                resultat.Print();
            }
            else if (ope == "/")
            {
                resultat = num1 / num2;
                resultat.Print();
            }
            else if (ope == "%")
            {
                resultat = num1 % num2;
                resultat.Print();
            }
            else
            {
                Console.WriteLine("Opérateur non reconnu");
            }

        }
    }
}
