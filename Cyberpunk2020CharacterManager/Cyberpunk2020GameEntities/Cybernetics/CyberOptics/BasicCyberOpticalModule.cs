using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class BasicCyberOpticalModule : Implant, OpticalModule
{
    public override string Name { get { return $"{Prefix}Базовый киберглаз "; } }

    public string Prefix {get;set;} = string.Empty;

    public BasicCyberOpticalModule()
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "(1 глаз имеет 4 слота опций)\n" +
            "\n\nСочетание цифрового процессора и камеры, кибероптика являются заменой для нормальных глаз." +
            " Кибер-зрение похоже на обычное зрение, только лучше. Цвета ярче, изображение чётче. И это только начало." +
            "\n\nХочешь увидеть жизнь в виде черно-белого фильма 30 - х годов?" +
            " Нет проблем.Телескопическое или микроскопическое зрение? Забирай.Инфракрасное и " +
            "усиливающее свет зрение? Типично для Соло." +
            "\n\nКибероптика может выглядеть точно так же, как нормальные глаза, хотя доступно " +
            "большое разнообразие цветов радужной оболочки(янтарный, белый, бордовый и фиолетовый о" +
            "чень популярны). Некоторые версии являются прозрачными, с отблеском или огнями, кружащимися внутри них." +
            "Иные являются хромиро - ванными для более \"кибернетического\" вида." +
            "Другие могут менять цвет глаз по желанию или подстраиваться под цвет одежды и обстановки." +
            "у некоторых даже есть крошечные дизайнерские логотипы вокруг радужной оболочки." +
            " Кибер - оптика C камерами или оружием, обычно выдвигается вперёд, раздвигая радужную оболочку," +
            " когда передняя часть глаза раскрывается.";
        HumanityLossFormula = "2D6";
        Cost = 500;
        OptionsAlloweded = 4;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Этот оптический модуль некуда прикрепить\n");
        }

        return result.ToString();
    }

    List<BodyPart>? cashedPotentialParents = null;


    public override List<BodyPart>? PotentialParents(Character character)
    {
        if (cashedPotentialParents != null)
        {
            return cashedPotentialParents;
        }

        cashedPotentialParents = [];
        foreach (var bodyPart in character.BodyParts)
        {
            if (bodyPart is EyeSocket)
            {
                var ChilBodyParts = character.GetChildBodyParts(bodyPart.Guid);
                if (ChilBodyParts.Any())
                {
                    var firstEyeAtTheSlot = ChilBodyParts.First();
                    if (firstEyeAtTheSlot is BasicCyberOpticalModule)
                    {
                        continue;
                    }
                }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }

    public override void ChipIn(Character character, Random random)
    {
        var slot = (EyeSocket)character.GetBodyPart(BodyPlace);

        var othersEyes = character.GetChildBodyParts(BodyPlace);
        foreach (var other in othersEyes)
        {
            character.BodyParts.Remove(other);
        }

        Prefix = slot.generatePrefixForOptics();

        base.ChipIn(character, random);
    }
}
