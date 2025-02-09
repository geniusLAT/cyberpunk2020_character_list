namespace Cyberpunk2020GameEntities.Equipments.Surveillance;

public class IrGoogles : Equipment
{
    public override string Name { get { return "ИК очки"; } }

    public override int BookIndex { get; set; } = 4;

    public IrGoogles()
    {
        Description = "они улавливают незаметные, фоновые источники инфракрасного света. " +
            "Обычно используются с активным ИК источником для невидимой подсветки.";
        Cost = 250;
    }
}
