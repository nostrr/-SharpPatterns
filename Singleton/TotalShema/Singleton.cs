﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.TotalShema
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
