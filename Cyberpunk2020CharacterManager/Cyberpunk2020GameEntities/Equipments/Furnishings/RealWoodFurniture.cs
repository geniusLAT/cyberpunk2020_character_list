﻿namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class RealWoodFurniture : Equipment
{
    public override string Name { get { return "Мебель из натурального дерева"; } }

    public RealWoodFurniture()
    {
        Description = " Что тут ещё добавить?";
        Cost = 200;
    }
}
