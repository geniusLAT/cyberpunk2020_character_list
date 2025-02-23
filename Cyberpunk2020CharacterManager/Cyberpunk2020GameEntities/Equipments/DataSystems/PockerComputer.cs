namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class PockerComputer : Equipment
{
    public override string Name { get { return "Карманный компьютер"; } }

    public override int BookIndex { get; set; } = 1;

    public PockerComputer()
    {
        Description = " классический программируемый вычислитель 15 х 8 х 1,3 см " +
            "с клавиату- рой и слотами для чипов, до 100 страниц буквенноцифровой памяти.";
        Cost = 100;
    }
}
