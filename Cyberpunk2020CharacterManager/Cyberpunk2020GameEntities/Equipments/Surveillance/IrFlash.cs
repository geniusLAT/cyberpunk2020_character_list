﻿namespace Cyberpunk2020GameEntities.Equipments.Surveillance;

public class IrFlash : Equipment
{
    public override string Name { get { return "ИК лампа"; } }

    public override int BookIndex { get; set; } = 5;

    public IrFlash()
    {
        Description = "смотри выше. Похоже на УФ-вспышку, также можно использовать с соответствующей кибероптикой.";
        Cost = 50;
    }
}
