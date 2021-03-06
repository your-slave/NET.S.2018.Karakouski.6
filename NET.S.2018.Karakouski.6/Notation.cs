﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Karakouski._6
{
    /// <summary>
    /// Notation class which dterminesl ligal characters for n base number(n>2 n <16))
    /// </summary>
    public class Notation
    {
        private static string legal6BaseChars;
        private int nBase;

        public int NBase { get { return nBase; } set { if (nBase < 2 || nBase > 16) throw new ArgumentException(nameof(NBase) + " must be from 2 to 16"); else nBase = value; } }
        public string Legal6BaseChars { get { return legal6BaseChars; } }

        public Notation(int nBase)
        {
            StringBuilder sb = new StringBuilder();
            NBase = nBase;

            int diigtCharIndexConficent = 48;
            int uppeterLatterCharConficent = 65;

            for (int i=0; i<nBase; i++)
            {
                if(i<10)
                    sb.Append((char)(diigtCharIndexConficent + i));
                else
                    sb.Append((char)(uppeterLatterCharConficent + i));
            }

            legal6BaseChars = sb.ToString();
        }
    }
}
