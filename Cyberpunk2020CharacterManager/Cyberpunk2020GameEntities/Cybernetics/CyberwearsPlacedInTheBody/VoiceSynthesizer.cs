namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class VoiceSynthesizer : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Синтезатор голоса"; } }

    public VoiceSynthesizer() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Эта система позволяет пользователю имитировать любой голос или тон, ранее записанные его чипом памяти. " +
            "Чип может хранить до 10 \"голосов\". Эта система также дает пользователю +4 к любой " +
            "попытке Маскировки (теперь вы действительно похожи на человека, которому подражаете).";
        HumanityLossFormula = "1D6";
        Cost = 600;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
