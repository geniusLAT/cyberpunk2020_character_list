namespace Cyberpunk2020GameEntities.Equipments.Groceries;

public class GenericPrepak : Equipment
{
    public override string Name { get { return "Универсальная упаковка (на неделю)"; } }

    public override int BookIndex { get; set; } = 1;

    public GenericPrepak()
    {
        Description = " по сравнению с обычным \"телевизионным ужином\", эти пакеты с едой могут быть " +
            "приготовлены в микроволновке или холодильнике, в зависимости от того, что содержится внутри." +
            " Многие поставляются со своими химическими вкладышами для разогрева или охлаждения. " +
            "Кулинария не впечатляет, но всё же, лучше чем (Kibble) Корм.";
        Cost = 150;
    }
}
