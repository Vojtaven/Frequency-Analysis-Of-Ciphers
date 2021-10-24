﻿namespace Frequency_Analysis_Of_Ciphers
{
    class changedLetter
    {
        public char originalLetter;
        public char changingLetter;
        public changedLetter(char originalLetter, char changingLetter)
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
