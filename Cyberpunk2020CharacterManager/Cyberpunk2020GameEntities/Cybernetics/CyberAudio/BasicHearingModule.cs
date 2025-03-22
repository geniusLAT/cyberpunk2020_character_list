namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class BasicHearingModule : Implant, HearingModule
{
    public override string Name { get { return "Базовый слуховой модуль"; } }

    public BasicHearingModule()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Кибераудио системы встраиваются B слуховые нервы и речевые центры мозга. " +
            "Это усовершенствование влияет на оба уха, а также включает в себя субвокализующий микрофон" +
            " на сосцевидной кости. Не приводит к видимым изменениям во внешнем ухе, хотя некоторые" +
            " киберпанки заменяют внешнее ухо набором механических датчиков для максимального эффекта.";
        HumanityLossFormula = "2D6";
        Cost = 500;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
