namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class ApartmentCube : Equipment
{
    public override string Name { get { return "Квартира-Куб"; } }

    public override int BookIndex { get; set; } = 6;

    public ApartmentCube()
    {
        Description = "жилой модуль 3х3х2,4 метра, в котором вся основная мебель и техника спрятаны в скрытых углублениях " +
            "в стенах и выдвигаются только при использовании. Содержит кровать, шкаф, небольшую плиту, холодильник, телевизор " +
            "и цифровой развлекательный центр, два стула, раскладной стол, передвигаемый стол. Обычно кубы бывают настолько " +
            "малы, что, если ты раздвинешь всю свою мебель сразу, для тебя не останется места!";
        Cost = 5000;
    }
}
