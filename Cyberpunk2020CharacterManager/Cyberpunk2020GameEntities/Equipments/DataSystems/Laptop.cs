namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class Laptop : Equipment
{
    public override string Name { get { return "Портативный компьютер"; } }

    public override int BookIndex { get; set; } = 0;

    public Laptop()
    {
        Description = "простой ноутбук, со встроенным жестким диском, " +
            "видео экраном (съёмным) и слотами для чипов данных / программ. " +
            "Эти единицы не имею продвинутых процессоров и пространства памяти," +
            " доступные B обычной компьютерной системе, они не могут быть " +
            "использованы для Нетраннинга.";
        Cost = 900;
    }
}
