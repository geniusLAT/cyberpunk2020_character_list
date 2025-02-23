﻿namespace Cyberpunk2020GameEntities.Equipments.Fashion;

public class Jacket : FashionStyle
{
    public override string Name { get { return "Куртка"; } }

    public override int BookIndex { get; set; } = 1;

    public Jacket()
    {
        Description = "Стиль одежды 2020 разбит на пять основных модных течений:"+
        "\n   Универсальный шик: стандартная уличная одежда, состоящая из модульных компонентов во " +
        "множестве расцветок.Преобладают портупеи, пальто, пояса, ботинки."+
        "\n  Досуговая одежда: это эквивалент спортивной одежды 21 - го века.Мягкий флисс, " +
        "корпоративные и спортивные логотипы."+
        "\n  Деловая одежда: это эквивалент стандартного делового костюма, приглушенные цвета," +
        " полоски, обувь из натуральной кожи и т.д.Шерсть и другие натуральные ткани считаются " +
        "подходящим облачением для перспективных Корпоративных сотрудников."+
        "\n  Высокая мода: Утончённая и дорогаяодежда для высшего класса. Дизайнерские лейблы такие " +
        "как Miyake, Si - fui Yan и Anne Calvin."+
        "\n  Городское сияние: видео - куртки, ткани с изменяющимися цветами, камуфляж, кожа," +
        " металлические шипы, логотипы, джинсы, кожаные юбки, ботинки. Самый дикий и самый чиловый в кибер - моде.";
        Cost = 35;
    }
}
