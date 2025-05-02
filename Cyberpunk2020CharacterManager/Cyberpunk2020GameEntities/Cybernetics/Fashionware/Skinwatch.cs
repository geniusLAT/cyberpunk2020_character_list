namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class Skinwatch : Implant
{
    public override string Name { get { return "Подкожные часы"; } }

    public Skinwatch()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "предшественник био- монитора, кожные часы имплантируется чуть ниже" +
            " эпидермиса и используют крошечные светодиоды для проецирования светящихся " +
            "светящихся цифр через кожу. Кожные часы можно имплантировать куда угодно, " +
            "хотя наиболее распространенными местами являются рука, запястье и пальцы." +
            " Расширенные версии могут быть пере- настроены осторожным нажатием на дисплей" +
            " до тех пор, пока не появятся правильные комбинации чисел. Действительно " +
            "продвинутые версии имеют тихие звуковые сигналы. Используй своё воображение.";
        HumanityLossFormula = "1";
        Cost = 50;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }

    public override string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }
}
