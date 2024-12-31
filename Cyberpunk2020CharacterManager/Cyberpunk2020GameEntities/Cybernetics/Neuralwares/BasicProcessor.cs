﻿namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class BasicProcessor : Neuralware
{
    public override string Name { get { return "Имплантированные жабры"; } }

    public BasicProcessor()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Основной нейронный процессор представляет собой \"распределительную коробку\" имплантированную в нижнюю часть позвоночника, " +
            "и используется для передачи сигналов от внешнего кибероснащения в центральную нервную систему. Это основная система для любого типа " +
            "нейронного интерфейса, включая ускорители рефлексов, интерфейсные разъёмы, оружие, коннекторы для Дата Термов и транспортных средств, " +
            "мини-компьютеры и сенсорные аугментации." +
            "\tНейронный процессор имеет небольшое техническое пространство, что позволяет вставлять вторичные сопроцессоры в модуль базового процессора." +
            " Это позволяет модернизировать процессор в стерильной среде устанавливая новые сопроцессоры в техническое пространство." +
            "\tВнедрить нейронный процессор намного проще, чем можно было ожидать, благодаря науке о нанотехнологиях.Основной модуль" +
            " хирургически прикрепляется к позвоночнику, где он выпускает поток нано-хи - рургических единиц в позвоночный столб. " +
            "Эти микроскопические машины пронизывают крошечные связи через центральную нервную систему, " +
            "привязывая нервные окончания к нейронному процессору.Этот процесс занимает некоторое время(1D6 + 7 дней)," +
            " прежде чем нано - хирурги проберутся через всё тело, и все соединения подключатся к нейронному процессору.";
        HumanityLossFormula = "1D6";
        Cost = 1000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
