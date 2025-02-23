namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class LowImpendanceCables : Equipment
{
    public override string Name { get { return "Кабели низкого сопротивления"; } }

    public override int BookIndex { get; set; } = 5;

    public LowImpendanceCables()
    {
        Description = "специальные кабели с низким сопротивлением интерференцией " +
            "для улучшенной передачи данных. Они дают бонус +1 K любым сопутствующим задачам, " +
            "таким как управление кибертранспортными средствами или Нетраннинга.";
        Cost = 60;
    }
}
