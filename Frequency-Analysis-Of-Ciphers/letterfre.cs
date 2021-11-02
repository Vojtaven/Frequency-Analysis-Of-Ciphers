using System;

namespace Frequency_Analysis_Of_Ciphers
{
    class letterfre
    {
        public char letter { get; private set; }
        public float frequency { get; private set; }
        public int count { get; private set; }

        public letterfre(char letter, float frequency)
        {
            this.letter = letter;
            this.frequency = frequency;
        }

        public letterfre(int count, char letter)
        {
            this.letter = letter;
            this.count = count;
        }
        public override string ToString()
        {
            return $"{letter} {frequency}";
        }
        public void CalculateFrequency(int allLettersCount)
        {
           frequency = (float)Math.Round((double)(count / (decimal)allLettersCount) * 100, 2, MidpointRounding.AwayFromZero);
        }

        public char GetLetter()
        {
            return letter;
        }
        public void AddCount()
        {
            count++;
        }
    }
}
