﻿namespace Wiry.Base32
{
    internal sealed class StandardBase32Encoding : Base32Encoding
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

        public override string GetString(byte[] bytes, int index, int count)
        {
            return ToBase32(bytes, index, count, Alphabet, '=');
        }
    }
}