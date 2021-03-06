﻿using System;
using System.Security.Cryptography;

namespace Harj1
{
    class Dice
    {
        public int Roll()
        {
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];
            rand.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);
            return new Random(result).Next(1, 7);
        }
    }
}
