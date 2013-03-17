using System;

namespace Piggy
{
    public static class MyExtensions
    {
        public static bool IsVowel(this char c)
        {
            c = char.ToLower(c);

            switch (c) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}
