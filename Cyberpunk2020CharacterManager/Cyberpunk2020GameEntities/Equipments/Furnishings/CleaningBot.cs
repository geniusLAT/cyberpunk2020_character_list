﻿namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class CleaningBot : Equipment
{
    public override string Name { get { return "Робот-Уборщик"; } }

    public override int BookIndex { get; set; } = 8;

    public CleaningBot()
    {
        Description = "небольшое заранее запрограммированное роботизированное чистящее устройство." +
            " Обычно размером с портативный пылесос. Не слишком умный.";
        Cost = 1000;
    }
}
