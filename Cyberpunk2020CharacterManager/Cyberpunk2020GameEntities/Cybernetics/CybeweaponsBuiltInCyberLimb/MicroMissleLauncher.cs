namespace Cyberpunk2020GameEntities.Cybernetics.CybeweaponsBuiltInCyberLimb;

public class MicroMissleLauncher : CybeweaponBuiltInCyberLimb
{
    public override string Name { get { return "Микро-ракетная пусковая установка"; } }

    public MicroMissleLauncher()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта пусковая установка содержит четыре миниатюрные ракеты" +
            " (гироскопические снаряды со взрывающимися боеголовками и с тепловым самонаведением)." +
            " Подобно всплывающему оружию, микро-ракетная пусковая установка хранится в конечности" +
            " и выдвигается при необходимости, запуская до двух ракет за ход. " +
            "Ракеты являются самонаводящимися (+2 Точность) и могут следовать за " +
            "целью через одно изменение направления до 90°, что даёт им возможность" +
            " поворачивать за угол (3 из 10 шансов потерять цель). Перезарядка " +
            "стоит 50 ED/EB за штуку. Урон 4D6 на ракету, дальность действия 200м.";
        HumanityLossFormula = "2D6";
        Cost = 800;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }
}
