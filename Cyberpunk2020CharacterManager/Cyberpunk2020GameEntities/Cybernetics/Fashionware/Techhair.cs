namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class Techhair : Implant
{
    public override string Name { get { return "Тех-Волосы"; } }

    public Techhair()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Стержни этих искусственных волос пропитаны различными типами реактивных химикатов. " +
            "Некоторые типы чувствительны к температуре и меняют цвет или поднимаются в зависимости от погоды." +
            " Другие содержат те же пигменты, которые используются в светящихся татуировках, накапливая и" +
            " испуская свет в цветных узорах. Третьи могут менять цвет по твоему желанию, используя" +
            " специальные химические шампуни. Тех-Волосы могут быть имплантированы в ирокезы, в кудри," +
            " парики, гривы, косы, усы и другие менее очевидные (но интересные) места.";
        HumanityLossFormula = "2";
        Cost = 1;
        MaxCost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }
}
