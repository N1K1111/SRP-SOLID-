﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP__SOLID_.Model;

namespace SRP__SOLID_.Interfaces
{
    internal interface IPhoneSaver
    {
        public void Save(Phone phone,string fileName);
    }
}
