namespace Frequency_Analysis_Of_Ciphers
{
    class ChangedLetter
    {
        public char originalLetter;
        public char changingLetter;
        public ChangedLetter(char originalLetter, char changingLetter)
        {
            this.changingLetter = changingLetter;
            this.originalLetter = originalLetter;
        }

        public override string ToString()
        {
            return $"{originalLetter} -> {changingLetter}";
        }
    }
}
