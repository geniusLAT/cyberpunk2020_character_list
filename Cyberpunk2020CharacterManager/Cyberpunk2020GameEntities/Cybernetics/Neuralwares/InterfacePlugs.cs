
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class InterfacePlugs : Neuralware
{
    public override string Name { get { return "Интерфейсные разъёмы"; } }

    public InterfacePlugs()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Это основной элемент Киберпанк культуры. " +
            "Обычно установленные в костях запястья, позвоночника или черепа," +
            " они подключаются к основным нервным стволам и взаимодействуют с" +
            " нейронным процессором для отправки и получения сигналов.\n" +
            "Разъёмы можно использовать для вставки Информационных и рефлексных Чипов Навыков или в " +
            "качестве разъёма для набора интерфейсных кабелей (что позволит тебе напрямую " +
            "управлять любым устройством, для которого у тебя есть надлежащий \"Коннектор\"). " +
            "С точки зрения игры, интерфейсные разъёмы позволяют игроку напрямую связываться многими " +
            "типами устройств, таких как кибермодемы или кибер- транспорт.\r\nИнтерфейсные разъёмы " +
            "довольно распространены. многие компании даже оплатят их установку. Многие рабочие фабрик и " +
            "строек вставляют их прямо B свои инструменты. Интерфейсные разъёмы\r\nимеют решающее значение " +
            "для таких людей, как Нетраннеры (которые должны иметь их, чтобы получить скорость и способность " +
            "Рана в Сети) и Соло (которые используют их для управления умным оружием).\r\nБольшинство людей " +
            "носят разъёмы на запястьях для простоты использования. Время от времени настоящие кибер-техники будут " +
            "монтировать их в виски (Розетко-головый), прямо за ушами (Франкенштейн) или B задней части головы (Марионетки). " +
            "Некоторые закрывают их инкрустированными серебряными или золотыми крышками, другие - манжетами. Повторюсь, стиль важен.";
        HumanityLossFormula = "1D6";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if(PotantialParents(character).Count == 0)
        {
            result.Append("Требуется основной нейронный процессор\n");
        }

        return result.ToString();
    }

    List<BodyPart>? cashedPotentialParents = null;

    public override List<BodyPart>? PotantialParents(Character character)
    {
        if(cashedPotentialParents != null)
        {
            return cashedPotentialParents;
        }

        cashedPotentialParents = [];
        foreach (var bodyPart in character.BodyParts)
        {
            if(bodyPart is BasicProcessor)
            {
                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
