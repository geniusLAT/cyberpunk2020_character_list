namespace Cyberpunk2020GameEntities.Cybernetics.Exoarmor;

public class Faceplate : Implant
{
    public override string Name { get { return $"Лицевая пластина"; } }

    public Faceplate()
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "Стандартная лицевая пластина закрывает всё лицо," +
            " с портами для дыхания, еды и зрения. Бронированный пластик " +
            "сплетён с тонкими мышечными миамарными волокнами и является " +
            "относительно гибким. Мимика лица допускает ограниченные (и несколько жесткие)" +
            " изменения выражения. Эта модификация не должна быть отвратительной - " +
            "многие люди находят серебристые контуры и гладкие поверхности довольно " +
            "привлекательными, что-то вроде накрашенного \"секс робота\" конца 20-го века. " +
            "Однако многим киборгам нравится, когда их лицевые панели вылеплены в " +
            "причудливые и часто пугающие изображения - монстры из мифологии или ужасающие роботизированные формы." +
            "\n   Тебе решать. SP = 25";
        HumanityLossFormula = "4D6";
        Cost = 400;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
