using System.Text;

namespace Cyberpunk2020GameEntities.Equipments.Weapons;

public abstract class Weapon : Equipment
{
    public WeaponType type { get; set; }

    public int WeaponAccuracy { get; set; }

    public WeaponConcealability Concealability { get; set; }

    public WeaponAvaliability Avaliability { get; set; }

    public string DamageFormula { get; set; } = "0";

    public virtual int GenerateDamage(Random random) { return 0; }

    public WeaponAmmoType AmmoType { get; set; }

    public int shots { get; set; }

    public int RateOfFireInTurn { get; set; }

    public WeaponReliability Reliability { get; set; }

    public int Range { get; set; }

    public virtual string GenerateWeaponCodeDescription()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append("Тип: ");
        stringBuilder.Append(TypeToHumanReadableFormat(type));
        stringBuilder.Append("\nТочность: ");
        stringBuilder.Append(WeaponAccuracy);
        stringBuilder.Append("\nСкрытность: ");
        stringBuilder.Append(ConcealabilityToHumanReadableFormat(Concealability));
        stringBuilder.Append("\nДоступность: ");
        stringBuilder.Append(AvaliabilityToHumanReadableFormat(Avaliability));
        stringBuilder.Append("\nУрон: ");
        stringBuilder.Append(DamageFormula);
        stringBuilder.Append("\nТип Боеприпаса: ");
        stringBuilder.Append(AmmoTypeToHumanReadableFormat(AmmoType));
        stringBuilder.Append("\nПатронов в магазине: ");
        stringBuilder.Append(shots);
        stringBuilder.Append("\nВыстрелов в ход(ROF): ");
        stringBuilder.Append(RateOfFireInTurn);
        stringBuilder.Append("\nНадёжность: ");
        stringBuilder.Append(ReliabilityToHumanReadableFormat(Reliability));
        stringBuilder.Append("\nДистанция: ");
        stringBuilder.Append(Range);
        stringBuilder.Append("м");

        return stringBuilder.ToString();
    }

    public static string TypeToHumanReadableFormat(WeaponType type)
    {
        switch (type)
        {
            case WeaponType.Melee:
                return "Оружие ближнего боя";
                break;
            case WeaponType.Pistol:
                return "Пистолет";
                break;
            case WeaponType.Submachinegun:
                return "Пистолет-Пулемёт";
                break;
            case WeaponType.Rifle:
                return "Винтовка";
                break;
            case WeaponType.Shotgun:
                return "Дробовик";
                break;
            case WeaponType.Heavy:
                return "Тяжёлое вооружение";
                break;
            case WeaponType.Exotic:
                return "Экзотическое";
                break;
        }
        return "";
    }

    public static string ConcealabilityToHumanReadableFormat(WeaponConcealability concealability)
    {
        switch (concealability)
        {
            case WeaponConcealability.Pocket:
                return "Карман";
                break;
            case WeaponConcealability.Jacket:
                return "Куртка";
                break;
            case WeaponConcealability.LongCoat:
                return "Длинный плащ";
                break;
            case WeaponConcealability.CantBeHidden:
                return "Не может быть спрятано";
                break;
        }
        return "";
    }

    public static string AvaliabilityToHumanReadableFormat(WeaponAvaliability avaliability)
    {
        switch (avaliability)
        {
            case WeaponAvaliability.Excellent:
                return "Отличная";
                break;
            case WeaponAvaliability.Common:
                return "Доступная";
                break;
            case WeaponAvaliability.Poor:
                return "Малая";
                break;
            case WeaponAvaliability.Rare:
                return "Редкая";
                break;
        }
        return "";
    }

    public static string AmmoTypeToHumanReadableFormat(WeaponAmmoType ammoType)
    {
        switch (ammoType)
        {
            case WeaponAmmoType.Bullet5mm:
                return "5мм";
                break;
            case WeaponAmmoType.Bullet6mm:
                return "6мм";
                break;
            case WeaponAmmoType.Bullet9mm:
                return "9мм";
                break;
            case WeaponAmmoType.Bullet10mm:
                return "10мм";
                break;
            case WeaponAmmoType.Bullet11mm:
                return "11мм";
                break;
            case WeaponAmmoType.Bullet12mm:
                return "12мм";
                break;
            case WeaponAmmoType.Bullet5dot56:
                return "5.56";
                break;
            case WeaponAmmoType.Bullet7dot62:
                return "7.62";
                break;
            case WeaponAmmoType.shotshell:
                return "Дробь";
                break;
        }
        return "-";
    }

    public static string ReliabilityToHumanReadableFormat(WeaponReliability reliability)
    {
        switch (reliability)
        {
            case WeaponReliability.VeryReliable:
                return "Очень надёжное";
                break;
            case WeaponReliability.Standart:
                return "Обычное";
                break;
            case WeaponReliability.Unreliable:
                return "Ненадёжное";
                break;
        }
        return "";
    }
}
