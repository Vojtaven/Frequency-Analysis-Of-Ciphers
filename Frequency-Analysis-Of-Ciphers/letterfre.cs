namespace Frequency_Analysis_Of_Ciphers
{
    class letterfre
    {
        public char letter { get; private set; }
        public float frequency { get; private set; }
        public int count { get; private set; }
        public char originalLetter;
        public char changingLetter;
        public letterfre(char originalLetter, char changingLetter)
        {
            this.changingLetter = changingLetter;
            this.originalLetter = originalLetter;
        }
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
        public float getFrequency()
        {
            return frequency;
        }
        public char getLetter()
        {
            return letter;
        }
        public int getCount()
        {
            return count;
        }
        public void addCount()
        {
            count++;
        }
    }
}
