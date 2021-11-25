using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            int position = 0;
            char[] characters = original.ToCharArray();
            char[] new_characters = new char[characters.Length * 2];
            foreach (char character in original)
            {
                new_characters[position] = character;
                new_characters[position + 1] = character;
                position += 2;
            }
            {
                return new string(new_characters);
            }
        }
    }
}
