using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TinyBistro
{
    public class BigNum
    {
        private List<int> digits_;

        public BigNum(string source)
        {
            if (source == "0")
                digits_ = new List<int>(0);
            else
            {
                digits_ = new List<int>();

                foreach (char c in source)
                {
                    digits_.Add(c - '0');
                }
                digits_.Reverse(); 
            }
        }

        public int GetNumDigits()
        {
            return digits_.Count;
        }

        public void AddDigit(int digit)
        {
            digits_.Add(digit);
        }

        public int GetDigit(int position)
        {
            if (position >= GetNumDigits())
                new OverflowException();

            return digits_[position];
        }

        public void SetDigit(int digit, int position)
        {
            if (digit >= 0 && digit <= 9 && position >= 0 && !(position >= digits_.Count && digit == 0))
            {
                if (position < digits_.Count)
                {
                    digits_[position] = digit;

                    for (int i = digits_.Count - 1; digits_[i] == 0; i--)
                    {
                        digits_.RemoveAt(i);
                    }
                }
                else
                {
                    for (int i = 0; i < position - digits_.Count - 1; i++)
                    {
                        digits_.Add(0);
                    }
                    digits_.Add(digit);
                }
            }
        }

        public void Print()
        {
            if (digits_.Count == 0)
                Console.WriteLine ("0");
            else {
                digits_.Reverse();
                string result = "";
                foreach (int i in digits_)
                {
                    result += i;
                }
                Console.WriteLine(result);
            }
        }

        public static bool operator >(BigNum a, BigNum b)
        {
            int ac = a.GetNumDigits() - 1;
            int bc = b.GetNumDigits() - 1;

            while (ac >= 0 && a.digits_[ac] == 0)
            {
                a.digits_.RemoveAt(ac);
                ac -= 1;
            }
            while (bc >= 0 && b.digits_[bc] == 0)
            {
                b.digits_.RemoveAt(bc);
                bc -= 1;
            }

            if (a.GetNumDigits() == b.GetNumDigits())
            {
                if (a.GetNumDigits() == 0)
                    return false;

                int i = a.GetNumDigits() - 1;

                while (i > 0 && a.digits_[i] == b.digits_[i])
                {
                     i -= 1;
                }
                return a.digits_[i] > b.digits_[i];
            }

            else
                return a.GetNumDigits() > b.GetNumDigits();
        }

        public static bool operator <(BigNum a, BigNum b)
        {
            bool test = true;

            if (a.GetNumDigits() == b.GetNumDigits())
            {
                if (a.GetNumDigits() != b.GetNumDigits())
                {
                    test = false;
                }
                else
                {
                    int i = 0;

                    while (i < a.GetNumDigits() && a.GetDigit(i) == b.GetDigit(i))
                    {
                        i++;
                    }

                    test = i == a.GetNumDigits();
                }
            }

            return !(a > b) && !test;
        }

        public static bool operator ==(BigNum a, BigNum b)
        {
            int ac = a.GetNumDigits() - 1;
            int bc = b.GetNumDigits() - 1;

            while (ac >= 0 && a.digits_[ac] == 0)
            {
                a.digits_.RemoveAt(ac);
                ac -= 1;
            }
            while (bc >= 0 && b.digits_[bc] == 0)
            {
                b.digits_.RemoveAt(bc);
                bc -= 1;
            }

            if (a.GetNumDigits() != b.GetNumDigits())
            {
                return false;
            }
            else
            {
                int i = 0;

                while (i < a.GetNumDigits() && a.GetDigit(i) == b.GetDigit(i))
                {
                    i++;
                }

                return i == a.GetNumDigits();
            }
        }

        public static bool operator !=(BigNum a, BigNum b)
        {
            return !(a == b);
        }

        public static BigNum operator +(BigNum a, BigNum b)
        {
            if (b.GetNumDigits() > a.GetNumDigits())
            {
                BigNum aux = b;
                b = a;
                a = aux;
            }

            string resultat = "";
            int i = 0;
            int retenue = 0;

            while (i < b.GetNumDigits())
            {
                int nb = a.GetDigit(i) + b.GetDigit(i) + retenue;
                resultat = nb % 10 + resultat;
                retenue = nb / 10;
                i++;
            }

            while (i < a.GetNumDigits())
            {
                resultat = (retenue + a.GetDigit(i)) % 10 + resultat;
                retenue = (retenue + a.GetDigit(i)) / 10;
                i++;
            }

            resultat += (retenue == 0 ? "" : retenue.ToString());

            return new BigNum(resultat);
        }

        public static BigNum operator -(BigNum a, BigNum b)
        {
            for (int j = b.GetNumDigits(); j < a.GetNumDigits(); j++)
            {
                b.digits_.Add(0);
            }

            string resultat = "";

            for (int i = 0; i < a.GetNumDigits(); i++)
            {
                int nba = a.digits_[i];
                int nbb = b.digits_[i];

                if (nba < nbb)
                {
                    nba += 10;
                    b.digits_[i + 1] += 1;
                }

                resultat = (nba - nbb).ToString() + resultat;
            }

            return new BigNum(resultat);
        }

        public static BigNum operator *(BigNum a, BigNum b)
        {
            BigNum zero = new BigNum("0");
            if (a == zero || b == zero)
            {
                return zero;
            }

            int la = a.GetNumDigits();
            int lb = b.GetNumDigits();

            string resultat = "";

            int reste = 0;
            for (int i = 0; i < la; i++)
            {
                int nb = a.digits_[i] * b.digits_[0] + reste;
                resultat = (nb % 10).ToString() + resultat;
                reste = nb / 10;
            }

            if (reste > 0)
            {
                resultat = reste.ToString() + resultat;
            }

            int nb0 = 0;

            for (int i = 1; i < lb; i++)
            {
                nb0 += 1;

                string res = "";
                for (int k = 0; k < nb0; k++)
                {
                    res += "0";
                }

                reste = 0;
                for (int j = 0; j < la; j++)
                {
                    int nb = a.digits_[j] * b.digits_[i] + reste;
                    res = (nb % 10).ToString() + res;
                    reste = nb / 10;
                }

                if (reste > 0)
                {
                    res = reste.ToString() + res;
                }

                BigNum tostr = new BigNum(res) + new BigNum(resultat);

                string result = "";

                for (int x = 0; x < tostr.GetNumDigits(); x++)
                {
                    result = tostr.digits_[x].ToString() + result;
                }

                resultat = result;
            }

            return new BigNum(resultat);
        }

        public static BigNum operator /(BigNum a, BigNum b)
        {
            int la = a.GetNumDigits();
            int lb = b.GetNumDigits();

            string resultat = "";
            string dividende = a.digits_[la - 1].ToString();

            int i = la - 1;
            int j = 1;
            while (i > 0)
            {
                j = 1;
                while (new BigNum(dividende) > (b * (new BigNum(j.ToString()))) || new BigNum(dividende) == (b * (new BigNum(j.ToString()))))
                {
                    j += 1;
                }

                BigNum tostr = new BigNum(dividende) - (b * (new BigNum((j - 1).ToString())));

                string result = "";

                for (int x = 0; x < tostr.GetNumDigits(); x++)
                {
                    result = tostr.digits_[x].ToString() + result;
                }

                dividende = result + a.digits_[i-1].ToString();

                resultat += (j - 1).ToString();

                i -= 1;
            }

            j = 1;
            while (new BigNum(dividende) > (b * (new BigNum(j.ToString()))) || new BigNum(dividende) == (b * (new BigNum(j.ToString()))))
            {
                j += 1;
            }

            resultat += (j - 1).ToString();

            return new BigNum(resultat);
        }

        public static BigNum operator %(BigNum a, BigNum b)
        {
            return a - ((a / b) * b);
        }

        public override bool Equals(object obj)
        {
            // DO NOT MODIFY THIS FUNCTION
            return this == (BigNum)obj;
        }

        public override int GetHashCode()
        {
            // DO NOT MODIFY THIS FUNCTION
            return 1;
        }
    }
}
