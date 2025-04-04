﻿namespace Cyberpunk2020GameEntities.Cybernetics;

public class EyeSocket : BodyPart
{
    public bool IsArtificial { get; set; } = false;

    public override bool IsImplant { get { return IsArtificial; } }

    public bool IsLeft { get; set; } = false; //For natural

    public byte number; //For artificial

    public override string Name
    {
        get
        {
            var note = string.Empty;
            if (IsArtificial)
            {
                switch (number)
                {
                    case 1:
                        note = "первая";
                        break;
                    case 2:
                        note = "вторая";
                        break;
                    case 3:
                        note = "третья";
                        break;
                    case 4:
                        note = "четвёртая";
                        break;
                    case 5:
                        note = "пятая";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                note = IsLeft ? "левая" : "правая";
                //throw new NotImplementedException(note);
            }
            return $"{note} глазница";
        }
    }

    public string generatePrefixForOptics()
    {
        var prefix = string.Empty;
        if (IsArtificial)
        {
            switch (number)
            {
                case 1:
                    prefix = "первый";
                    break;
                case 2:
                    prefix = "вторый";
                    break;
                case 3:
                    prefix = "третий";
                    break;
                case 4:
                    prefix = "четвёртый";
                    break;
                case 5:
                    prefix = "пятый";
                    break;
                default:
                    break;
            }
        }
        else
        {
            prefix = IsLeft ? "левый" : "правый";
            //throw new NotImplementedException(note);
        }
        return $"{prefix} ";
    }

    public EyeSocket(byte number)
    {
        this.number = number;
        IsArtificial = true;
    }

    public EyeSocket(bool isLeft)
    {
        IsLeft = isLeft;
        IsArtificial = false;
    }

    public EyeSocket()
    {

    }
}
