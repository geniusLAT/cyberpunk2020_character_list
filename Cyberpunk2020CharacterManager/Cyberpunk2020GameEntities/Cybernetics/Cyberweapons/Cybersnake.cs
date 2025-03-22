using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class Cybersnake : Cyberweapon
{
    public override string Name { get { return "Киберзмея"; } }

    public Cybersnake()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Это более простая версия киберзмеи, из приложения \"ПРОКАЧАННЫЕ\" (стр. 22)." +
            " Эта версия имеет гораздо меньше возможностей и ограничивается только атакой-выпадом." +
            " Выпад имеет радиус действия 1 метр и каждый раз наносит 1D6 урона. Кибер-змея может быть " +
            "установлена в любом отверстии в теле диаметром в 2,5 см и более, или может быть имплантирована" +
            " в плечи с помощью специального крепления.";
        HumanityLossFormula = "4D6";
        Cost = 1200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
