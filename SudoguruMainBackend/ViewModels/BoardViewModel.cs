﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudoguruMainBackend.ViewModels
{
    public class BoardViewModel
    {
        //SquareViewModel[] squares { get; set; }

        public Square[] squares { get; set; }
    }

    public class Square
    {
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        public int id { get; set; }
    }
}
