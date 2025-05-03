namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class CellularCybermodem : BuiltInCyberlimb
{
    public override string Name { get { return "Сотовый Кибер-Модем"; } }

    public CellularCybermodem()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это очень и очень дорогая версия кибер-модема " +
            "позволяет Нетраннеру взаимодействовать напрямую с Сетью" +
            " без прямого телекоммуникационной подключения. \"CellCyb\" " +
            "можно использовать только в крупном городе " +
            "(население более 100,000), где есть сотовая сеть. " +
            "При использовании в движущемся транспортном средстве" +
            " существует 25% вероятность того, что соединение" +
            " будет разорвано, и его необходимо восстановить" +
            " в следующем подключении.";
        HumanityLossFormula = "1";
        Cost = 5000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
