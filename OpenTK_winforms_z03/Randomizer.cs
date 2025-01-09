﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK_winforms_z03
{
     class Randomizer
    {

        private Random r;
        public Randomizer()
        {
            r=new Random();
        }
        public Color GetRandomColor()
        {

            int genR=r.Next(0,255);
            int genG=r.Next(0,255);
            int genB=r.Next(0,255);
            Color col = Color.FromArgb(genR, genG, genB);
            return col;
        }
    }
}
