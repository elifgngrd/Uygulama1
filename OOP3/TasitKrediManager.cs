﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi hesaplandi!!!"); ;
        }

        public void ParaVer()
        {
            throw new NotImplementedException();
        }
    }
}
