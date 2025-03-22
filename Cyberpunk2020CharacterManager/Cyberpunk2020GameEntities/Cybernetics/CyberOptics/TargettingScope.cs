namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class TargettingScope : CyberOptics
{
    public override string Name { get { return "Прицельный видоискатель"; } }

    public TargettingScope()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "проецирует прицел в поле зрения по желанию. Прицельный видоискатель будет считывать " +
            "дальность до конкретных объектов, скорость движения, направление и размер, а также предоставит " +
            "несколько типов видоискателя для наведения оружия. Когда подключен чип умного оружия, видо- искатель" +
            " будет сопоставлять датчик наведения ствола с тем, на что ты смотришь, затем" +
            " загорается \"сигнал готовности\" когда прицел сходится. С точки зрения игры, эта" +
            " опция позволяет добавлять + 1 только к атакам умным оружием.";
        HumanityLossFormula = "2";
        Cost = 400;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }
}
