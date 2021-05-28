using System;

namespace Pling
{
    public class Plang
    {
        public static string Plong(int input)
        {
            string ans = null;

                if (input % 3 == 0)
                {
                    ans += "Pling";
                }
                if (input % 5 == 0)
                {
                    ans += "Plang";
                }
                if (input % 7 == 0)
                {
                    ans += "Plong";
                }

                return _ = ans ?? (_ = input.ToString());
            }
        }
    }
