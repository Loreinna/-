﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Interface
{
    public interface IPaymentStrategy
    {
        void Pay(decimal totalAmount);
    }
}
