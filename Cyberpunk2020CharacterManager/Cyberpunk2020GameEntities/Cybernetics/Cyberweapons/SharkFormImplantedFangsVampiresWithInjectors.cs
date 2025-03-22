namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class SharkFormImplantedFangsVampiresWithInjectors : ImplantedFangs
{
    public override string Name { get { return "Вампиры с инжекторами (спциальный акулий)"; } }

    public SharkFormImplantedFangsVampiresWithInjectors()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " имплантированные клыки, обычно состоящие из карбонового стекла или металла с" +
            " хромированным покрытием. Ты можешь имплантировать полный комплект (так называемый, " +
            "Специальный Акулий, он наносит 1D6 / 2 урона от укуса) или только клыки (1D6 / 3 урона)." +
            " Они считаются \"декоративными\" имплантами, " +
            "а не оружием, но могут быть дополнены инжекторами для ядов" +
            " (которые являются запрещённым) по двойной цене.";
        HumanityLossFormula = "3D6";
        Cost = 400;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }
}
