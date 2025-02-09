namespace Cyberpunk2020GameEntities.Equipments.Communications;

public  class MastoidCommo : Equipment
{
    public override string Name { get { return "Мастоид-Коммуникатор"; } }

    public override int BookIndex { get; set; } = 0;

    public MastoidCommo()
    {
        Description = " Все коммуникаторы являются радиопередатчиками. Этот приклеенный к " +
            "челюсти и виску, ты совершаешь передачу через субвокализацию и сообщения беззвучными вибрациями. Дистанция 10 миль.";
        Cost = 100;
    }
}
