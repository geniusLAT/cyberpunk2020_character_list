namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class DrumSynthesizer : Equipment
{
    public override string Name { get { return "Синтезатор ударных"; } }

    public DrumSynthesizer()
    {
        Description = "обычное музыкальное оборудование \"новой волны\". Серия ударных пластин и звуковой блок. " +
            "Он поместится в пару чемоданов и может быть скомпонован любым удобным для барабан- щика способом.";
        Cost = 200;
        MaxCost = 800;
    }
}
