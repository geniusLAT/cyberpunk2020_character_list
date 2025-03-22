namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class Ultraviolet : CyberOptics
{
    public override string Name { get { return "УФ Оптика"; } }

    public Ultraviolet()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта система позволяет пользователю воспринимать изображения, " +
            "облу- чаемые ультрафиолетовым светом, или обнаруживать флуоресцентные порошки и " +
            "трассирующие реагенты, или использовать ультрафиолетовые фонарики (не обнаруживаемые " +
            "обычной оптикой) для освещения.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
