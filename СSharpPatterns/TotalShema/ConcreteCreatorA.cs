﻿namespace FactoryMethod.TotalShema
{
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }
}
