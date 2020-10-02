﻿using NumSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tensorflow;

namespace AnnDotNET.Common
{
    public interface IPlaceholders
    {
       (Tensor X, Tensor Y) Create(Shape input, Shape output);
       (Tensor X, Tensor Y) Create(int inDim, int outDim);
    }
}