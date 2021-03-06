﻿using System;

public class UnitFactory : IUnitFactory
{
    public IUnit CreateUnit(string unitType)
    {
        var classType = Type.GetType(unitType);

        return (IUnit)Activator.CreateInstance(classType);
    }
}

