﻿namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class SyntheticFurniture : Equipment
{
    public override string Name { get { return "Синтетическая мебель"; } }

    public override int BookIndex { get; set; } = 5;

    public SyntheticFurniture()
    {
        Description = " Что тут ещё добавить?";
        Cost = 100;
    }
}
