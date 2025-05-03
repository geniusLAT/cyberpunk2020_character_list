namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class Cybermodem : BuiltInCyberlimb
{
    public override string Name { get { return "Кибер-модем"; } }

    public Cybermodem()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта опция позволяет пользователю всегда " +
            "носить с собой небольшой (и очень дорогой) кибер-модем. " +
            "Модем должен быть подключен к Дата Терму или " +
            "компьютеру другой телекоммуникационной линии, " +
            "чтобы его можно было использовать. Питание (до 3 часов)" +
            " обеспечивается от аккумуляторной батареи (заряжается за 1 час) " +
            "или от внешнего шнура питания. Программные чипы меняются через" +
            " порт доступа в конечности. Кибер-модем напрямую подключен к" +
            " нервной системе через собственные внутренние кабели и" +
            " не требует внешних интерфейсных разъёмов.";
        HumanityLossFormula = "1";
        Cost = 3000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
