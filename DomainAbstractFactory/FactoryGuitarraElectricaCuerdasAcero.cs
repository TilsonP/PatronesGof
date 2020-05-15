﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainAbstractFactory
{
    public class FactoryGuitarraElectricaCuerdasAcero : GuitarraAbstractFactory
    {
        public override Cuerdas PonerCuerdas()
        {
            return new Acero();
        }

        public override Guitarra ArmarGuitarra()
        {
            return new Electrica();
        }
    }
}
