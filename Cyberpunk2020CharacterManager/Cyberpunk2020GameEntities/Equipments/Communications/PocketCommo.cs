namespace Cyberpunk2020GameEntities.Equipments.Communications;

public  class PocketCommo : Equipment
{
    public override string Name { get { return "Карманный Коммуникатор"; } }

    public PocketCommo()
    {
        Description = " Типичная маленькая рация. Дистанция 10 миль.";
        Cost = 50;
    }
}
