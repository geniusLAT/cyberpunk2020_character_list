using Cyberpunk2020GameEntities.Cybernetics.CyberOptics;
using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Exoarmor;

public class FrontOpticMount : Implant
{
    public override string Name { get { return $"Фронтальное Оптическое Крепление"; } }

    public FrontOpticMount()
    {
        SurgeryCode = SurgeryCode.Major;
        Description = " это крепление позволяет установить до пяти кибер-оптических " +
            "элементов в экранированный кластер в верхней части лица. Глаза удаляются," +
            " а глазницы используются для крепления принимающего оборудования, необходимого" +
            " для установки кибер- оптики. Оптические крепления бывают нескольких стилей: " +
            "есть тонкие щитки визоров (а-ля Робокоп), вращающиеся группы камер" +
            " (как у старомодной кинокамеры) или один основной оптический прибор с " +
            "меньшими, расположенными вокруг него. Излишне говорить, что это действительно" +
            " портит твою Характеристику Привлекательность, автоматически уменьшая её на -1.";
        HumanityLossFormula = "4D6";
        Cost = 1000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        StringBuilder sb = new StringBuilder();
        var uniqueness = UniquenessPotentialProblem(character);
        if (uniqueness != string.Empty)
        {
            return uniqueness;
        }

        foreach (var item in character.BodyParts)
        {
            if (item is EyeSocket)
            {
                var socket = (EyeSocket)item;
                var eyes = character.GetChildBodyParts(socket.Guid);
                foreach (var eye in eyes)
                {
                    if(eye is BasicCyberOpticalModule)
                    {
                        sb.Append($"{eye.Name} требуется предварительно удалить");
                    }
                }
            }
        }

        
        return sb.ToString();
    }

    public override void ChipIn(Character character, Random random)
    {
        List<BodyPart> natural = [];
        foreach (var item in character.BodyParts)
        {
            if(item is EyeSocket || item is NaturalEye)
            {
                natural.Add(item);
            }
        }

        foreach (var item in natural)
        {
            character.BodyParts.Remove(item);
        }

        for (byte i = 1; i < 6; i++)
        {
            EyeSocket socket = new(i)
            {
                BodyPlace = Guid
            };
            character.BodyParts.Add(socket);
        }

        character.attr_stat--;
        base.ChipIn(character, random);
    }
}
