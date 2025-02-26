namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class CyberlimbArmor : CyberlimbCovering
{
    public override string Name { get { return "Броня"; } }

    public CyberlimbArmor()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Вместо покрытия кибер-конечность может быть бронирована кевларом " +
            "и баллистическим пластиком. Это бронированное покрытие защищает конечность на 20 SP." +
            " Однако ты не сможешь покрывать или хромировать бронированную конечность.";
        HumanityLossFormula = "1D6";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }

    public override void ChipIn(Character character, Random random)
    {
        var slot = character.GetBodyPart(BodyPlace);
        if(slot is Cyberarm)
        {
            var arm = ((Cyberarm)slot);
            arm.MaxStoppingPower = arm.CurrentStoppingPower = 20;
        }
        if(slot is Cyberleg)
        {
            var leg = ((Cyberleg)slot);
            leg.MaxStoppingPower = leg.CurrentStoppingPower = 20;
        }
        //((Implant)slot).OptionsAlloweded--;

        base.ChipIn(character, random);
    }
}
