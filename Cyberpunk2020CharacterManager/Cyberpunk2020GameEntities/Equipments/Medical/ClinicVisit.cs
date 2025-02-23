namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class ClinicVisit : Equipment
{
    public override string Name { get { return "Визит в клинику"; } }

    public override int BookIndex { get; set; } = 10;

    public ClinicVisit()
    {
        Description = "";
        Cost = 200;
    }
}
