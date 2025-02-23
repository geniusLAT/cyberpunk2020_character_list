namespace Cyberpunk2020GameEntities.Equipments.Security;

public class StripwireBinders : Equipment
{
    public override string Name { get { return "Стяжки"; } }

    public override int BookIndex { get; set; } = 18;

    public StripwireBinders()
    {
        Description = "отлично подходят для борьбы с беспорядками. " +
            "Одноразовые пластиковые фиксаторы для временных наручников и " +
            "оков для ног (Очень сложно разорвать (25)). С керамическими волокнами, " +
            "чтобы сопротивляться разрезанию, и гарантировать огнестойкость. " +
            "Поставляются в упаковках по 12.";
        Cost = 5;
    }
}
