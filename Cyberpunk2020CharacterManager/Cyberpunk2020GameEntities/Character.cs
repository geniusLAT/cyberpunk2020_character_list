using Cyberpunk2020GameEntities.Cybernetics;
using Cyberpunk2020GameEntities.Cybernetics.Natural;
using Cyberpunk2020GameEntities.Equipments;
using System.Text.Json;
using System.Reflection;

namespace Cyberpunk2020GameEntities;

public class Character
{
    public CreateStep createStep { get; set; } = CreateStep.Name;

    public string name { get; set; } = "";

    public role Role { get; set; } = role.none;

    public int MonthIncome { get; set; } = 0;

    public float CurrentMoney { get; set; } = 0;

    #region stats
    public int int_stat { get; set; } = 0;

    public int cur_ref_stat { get; set; } = 0;

    public int global_ref_stat { get; set; } = 0;

    public int tech_stat { get; set; } = 0;

    public int cool_stat { get; set; } = 0;

    public int attr_stat { get; set; } = 0;

    public int cur_luck_stat { get; set; } = 0;

    public int global_luck_stat { get; set; } = 0;

    public int movement_stat { get; set; } = 0;

    public int body_stat { get; set; } = 0;

    public int cur_emp_stat { get; set; } = 0;

    public int global_emp_stat { get; set; } = 0;
    #endregion

    private float _totalHumanityLoss = 0;

    public float totalHumanityLoss 
    {
        get 
        { 
            return _totalHumanityLoss;
        }
        set
        {
            _totalHumanityLoss = value;
            cur_emp_stat = global_emp_stat - (int)(value / 10);
        }
    }

    public float humanity { 
        get {

            return global_emp_stat * 10 - _totalHumanityLoss;
        } 
    }
    
    public void SerializeInnerFields()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        BodyPartsSerialized = [];
        foreach (var TheBodyPart in BodyParts)
        {
            Type type = TheBodyPart.GetType();

            var serialized = JsonSerializer.Serialize(TheBodyPart, type, options);
            BodyPartsSerialized.Add(serialized);
        }

        EquipmentsSerialized= [];
        foreach (var equipment in equipments)
        {
            Type type = equipment.GetType();

            var serialized = JsonSerializer.Serialize(equipment, type, options);
            EquipmentsSerialized.Add(serialized);
        }
    }

    public class TypeHolder
    {
        public string type { get; set; }
    }

    public void DeserializeInnerFields()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        var assembly = Assembly.Load("Cyberpunk2020GameEntities");

        BodyParts = [];
        foreach (var BodyPartSerialized in BodyPartsSerialized)
        {
            var typeHolder = JsonSerializer.Deserialize<TypeHolder>(BodyPartSerialized, options);
            var type = assembly.GetType(typeHolder.type);
            try
            {
                var deserialized = JsonSerializer.Deserialize(BodyPartSerialized, type, options);
                var result = (BodyPart)deserialized;
                BodyParts.Add(result);
            }
            catch (Exception ex)
            {

            }
        }

        equipments = [];
        foreach (var EquipmentSerialized in EquipmentsSerialized)
        {
            var typeHolder = JsonSerializer.Deserialize<TypeHolder>(EquipmentSerialized, options);
            var type = assembly.GetType(typeHolder.type);
            try
            {
                var deserialized = JsonSerializer.Deserialize(EquipmentSerialized, type, options);
                var result = (Equipment)deserialized;
                equipments.Add(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public List<string> BodyPartsSerialized { get; set; }

    public List<BodyPart> BodyParts = [];

    public List<string> EquipmentsSerialized { get; set; }

    public List<Equipment> equipments = [];


    public Character()
    {
       GenerateOrgansStarterPack();
    }

    private void GenerateOrgansStarterPack()
    {
        LegSlot rightLegSlot = new(false);
        LegSlot leftLegSlot = new(true);

        NaturalLeg rightLeg = new() { BodyPlace = rightLegSlot.Guid };
        NaturalLeg lefttLeg = new() { BodyPlace = leftLegSlot.Guid };

        ArmSlot rightArmSlot = new(false);
        if (rightArmSlot.IsLeft)
        {
            throw new Exception("правая рука считает себя левой");
        }
        ArmSlot leftArmSlot = new(true);
        if (!leftArmSlot.IsLeft)
        {
            throw new Exception("левая рука считает себя правой");
        }

        NaturalArm rightArm = new() { BodyPlace = rightLegSlot.Guid };
        NaturalArm leftArm = new() { BodyPlace = leftLegSlot.Guid };

        BodyParts.AddRange([rightLegSlot, rightLeg, leftLegSlot, lefttLeg, rightArmSlot, rightArm, leftArmSlot, leftArm]);
    }

    public int[] skills { get; set; } = new int[91];

    #region staticRuleInformation
    public static string[] solo_skills_name = {
        "Чувство боя(соло)",
                "Осведомлённость/наблюдательность",
                "Пистолеты",
                "Драка",
                "Ближний бой",
                "Оружейник",
                "Винтовки",
                "Атлетика",
                "Скрытность",
        "Пистолеты-Пулемёты"

        };

    public static string[] corp_skills_name = {
            "Ресурсы(корпорат)",
            "Осведомлённость/наблюдательность",
            "Понимание людей",
            "Обр. и общие знания",
            "Поиск информации",
            "Социальность",
            "Убеждение и забалтывание",
            "Фондовый рынок",
            "Гардероб и Стиль",
            "Уход за собой",
        };

    public static string[] media_skills_name = {

            "Достоверность (медиа)",
            "Осведомлённость/наблюдательность",
            "Сочинение",
            "Обр. и общие знания",
            "Убеждение и забалтывание",
            "Понимание людей",
            "Социальность",
            "Знание улиц",
            "Фотография и кинофильмы"
        };

    public static string[] nomad_skills_name = {
            "Семья(номад)",
             "Осведомлённость/наблюдательность",
             "Выносливость",
             "Ближний бой",
             "Винтовки",
             "Вождение",
             "Базовые технологии",
             "Выживание в дикой местности",
             "Драка",
             "Атлетика",

        };

    public static string[] tech_class_skills_name = {
            "Импр.Ремонт(Техник)",
             "Осведомлённость/наблюдательность",
             "Базовые технологии",
             "Кибер-технологии",
             "Преподавание",
             "Электроника",
             "Вертолётная техника",
             "Авиатехника",
             "Оружейник",
             "Электронная безопасность"
        };

    public static string[] cop_skills_name = {
            "Авторитет(коп)",
            "Осведомлённость/наблюдательность",
            "Пистолеты",
            "Понимание людей",
            "Атлетика",
            "Обр. и общие знания",
            "Драка",
            "Ближний бой",
            "Допрос",
            "Знание улиц"
        };


    public static string[] rocker_skills_name = {
           "Хар. (Рокер)",
           "Осведомлённость/наблюдательность",
           "Выступление",
           "Гардероб и Стиль",
           "Сочинение",
           "Драка",
           "Игра на инструментах",
           "Знание улиц",
           "Убеждение и забалтывание",
           "Соблазнение",
        };

    public static string[] medtech_skills_name = {
           "Мед.Техник(медтехник)",
           "Осведомлённость/наблюдательность",
           "Базовые технологии",
           "Диагностика болезней",
           "Обр. и общие знания",
           "Эксплуатация криокамеры",
           "Поиск информации",
           "Фармацевтика ",
           "Зоология",
           "Понимание людей"

        };

    public static string[] fixer_skills_name = {
           "Уличная сделка(фиксер)",
           "Осведомлённость/наблюдательность",
           "Подделка",
           "Пистолеты",
           "Драка",
           "Ближний бой",
           "Взлом замков",
           "Карманная кража",
           "Запугивание",
           "Убеждение и забалтывание",

        };

    public static string[] netrunner_skills_name = {
           "Интерфейс(нетраннер)",
            "Осведомлённость/наблюдательность",
            "Базовые технологии",
            "Обр. и общие знания",
            "Системные знания",
            "Кибер-технологии",
            "Конструирования кибердек",
            "Сочинение",
            "Электроника",
            "Программирование"

        };

    public string[] GetProfessionalSkillsNames(role that_role)
    {
        switch (that_role)
        {
            case role.solo: return solo_skills_name;
            case role.rocker: return rocker_skills_name;
            case role.netrunner: return netrunner_skills_name;
            case role.media: return media_skills_name;
            case role.nomad: return nomad_skills_name;
            case role.fixer: return fixer_skills_name;
            case role.cop: return cop_skills_name;
            case role.corp: return corp_skills_name;
            case role.tech: return tech_class_skills_name;
            case role.medtech: return medtech_skills_name;

        }
        return solo_skills_name;
    }

    public static string[] role_skills_name =
    {"Авторитет(коп)",
        "Хар. (Рокер)",
        "Чувство боя(соло)",
        "Достоверность (медиа)",
        "Семья(номад)",
        "Интерфейс(нетраннер)",
        "Импр.Ремонт(Техник)",
        "Мед.Техник(медтехник)",
        "Ресурсы(корпорат)",
        "Уличная сделка(фиксер)"
        };

    public static string[] attr_skills_name =
    {"Уход за собой",
         "Гардероб и Стиль"   };

    public static string[] body_skills_name =
    {"Выносливость",
        "Силовая подгтовка",
        "Плавание"};

    public static string[] cool_skills_name =
    {"Допрос",
        "Запугивание",
        "Ораторское искуство",
        "Сопротивление пыткам/наркотикам",
        "Знание улиц"};

    public static string[] emp_skills_name =
    {"Понимание людей",
        "Интервью",
        "Лидерство",
        "Соблазнение",
        "Социальность",
        "Убеждение и забалтывание",
        "Выступление"};

    public static string[] int_skills_name =
    {"Учёт",
        "Антропология",
        "Осведомлённость/наблюдательность",
        "Биология",
        "Ботаника",
        "Химия",
        "Сочинение",
        "Диагностика болезней",
        "Обр. и общие знания",
        "Эксперт",
        "Азартные игры",
        "Геология",
        "Скрываться/Избегать",
        "История",
        "Знание языка",
        "Знание языка",
        "Знание языка",
        "Поиск информации",
        "Математика",
        "Физика",
        "Программирование",
        "Скрытое наблюдение",
        "Фондовый рынок",
        "Системные знания",
        "Преподавание",
        "Выживание в дикой местности",
        "Зоология"};



    public static string[] ref_skills_name =
    {"Стрельба из лука",
        "Атлетика",
        "Драка",
        "Танцы",
        "Уклонение и избегание",
        "Вождение",
        "Фехтование",
        "Пистолеты",
        "Тяжёлое вооружение",
        "Боевые искусства",
        "Ближний бой",
        "Мотоциклы",
        "Управление тяжёлой техникой",
        "Пилот (вертолёты)",
        "Пилот(неподвижное крыло)",
        "Пилот(Дерижабль)",
        "Пилот(Транспорт с вект. тягой)",
        "Винтовки",
        "Скрытность",
        "Пистолеты-Пулемёты"};

    public static string[] tech_skills_name =
    {"Авиатехника",
         "Технологии AV",
         "Базовые технологии",
         "Эксплуатация криокамеры",
         "Конструирования кибердек",
         "Кибер-технологии",
         "Подрывное дело",
         "Маскировка",
         "Электроника",
         "Электронная безопасность",
         "Первая помощь",
         "Подделка",
         "Вертолётная техника",
         "Закрашивать или рисовать",
         "Фотография и кинофильмы",
         "Фармацевтика ",
         "Взлом замков",
         "Карманная кража",
         "Игра на инструментах",
         "Оружейник"
        };

    #endregion
}
