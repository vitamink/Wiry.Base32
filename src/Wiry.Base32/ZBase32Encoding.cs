﻿// Copyright (c) Dmitry Razumikhin, 2016-2017.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace Wiry.Base32
{
    internal sealed class ZBase32Encoding : Base32Encoding
    {
        private const string Alphabet = "ybndrfg8ejkmcpqxot1uwisza345h769";

        public override string GetString(byte[] bytes, int index, int count)
        {
            return ToBase32(bytes, index, count, Alphabet, null);
        }

        public override byte[] ToBytes(string encoded, int index, int length)
        {
            return ToBytes(encoded, index, length, null, GetOrCreateLookupTable(Alphabet));
        }
    }
}