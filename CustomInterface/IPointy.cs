﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    public interface IPointy
    {
        byte GetNumberOfPoints();
        byte Points { get; }
    }
}
