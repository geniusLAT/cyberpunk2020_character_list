using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyberpunk2020_character_list_desktop
{
   

    public partial class Form1 : Form
    {
        
        int const_sum = 0;
        Random rand = new Random();
        NumericUpDown[] create_numerics;
        Character chosen_character = null;

        List<Panel> panels = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NameField.Enabled = false;

            NumericUpDown[] numerics = {numeric_int, global_ref_numeric, cool_numeric,
                        tech_numeric, attr_numeric, global_luck_numeric,
                        move_numeric, body_numeric, global_emp_numeric };

            create_numerics = numerics;

            gen_way_panel.Visible = false;
            const_num_numeric.Enabled = false;
            const_num_numeric.Visible = false;
            Render_skills(31,178);


        }

        bool IsProfessionalSkill(string skill)
        {
            if (chosen_character == null) return false;

            string[] professionals = chosen_character.GetProfessionalSkillsNames(chosen_character.Role);
            if(professionals.Contains(skill)) { return true; }
            return false;
        }

        

        int count_skill_sum(bool professinal)
        {
            int count = 0;
            foreach (Control item in panels)
            {
                if(item.Controls.Count <2) continue;  
                string skill_name = ((Label)item.Controls[0]).Text;
                if(IsProfessionalSkill(skill_name.Replace("_",""))==professinal)
                {

                    count += (int) ((NumericUpDown)item.Controls[1]).Value;
                }
            }
            return count;
        }

        private void skill_point_changed(object sender, EventArgs e)
        {
            label16.Text = ">";
            if(sender is NumericUpDown)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                Panel ParentPanel = (Panel)numeric.Parent;
                //label16.Text +=ParentPanel.Controls.ToString();
                string skill_name = ((Label)ParentPanel.Controls[0]).Text;

                if (chosen_character.createStep == Character.CreateStep.prof)
                {
                    int sum = count_skill_sum(true);
                    CommentLabel.Text = "Необходимая сумма:40\nТекущая сумма:" + sum.ToString();
                    if(sum==40)CreateButton.Enabled = true;
                    else CreateButton.Enabled = false;  

                }
                if (chosen_character.createStep == Character.CreateStep.unprof)
                {
                    int sum = count_skill_sum(true);
                    CommentLabel.Text = "Необходимая сумма:"+(chosen_character.global_ref_stat+chosen_character.int_stat).ToString()+ "\nТекущая сумма:" + sum.ToString();
                    if (sum == 40) CreateButton.Enabled = true;
                    else CreateButton.Enabled = false;

                }
            }
            
        }

        Control render_skill_panel(string text,int i, int column, bool header,int s, int l)
        {
            int g = 14;
            int text_size = 180;
            int extra_size = 60;


            Panel skill_panel = new Panel();
            panels.Add(skill_panel);
            tabPage1.Controls.Add(skill_panel);
            Label that_label = new Label();
            that_label.Size = new Size(text_size, g);

            skill_panel.Controls.Add(that_label);
            skill_panel.Size = new Size(extra_size + text_size, g);
            //skill_panel.BackColor = Color.Yellow;
            that_label.Text = text+"____________________________________";// "skill" + i.ToString();

            if (IsProfessionalSkill(text))
            {
                that_label.ForeColor= Color.Blue;
            }

            //that_label.Text =  "skill" + i.ToString();
            skill_panel.Location = new Point((extra_size + text_size)*column, i * g);


            if (header) 
            {
                

              that_label.Font = new Font(that_label.Font, that_label.Font.Style | FontStyle.Bold);

            }
            else
            {
                NumericUpDown skillNumeric = new NumericUpDown();
                //skillNumeric.Enabled= false;
                skill_panel.Controls.Add(skillNumeric);
                skillNumeric.Location = new Point(l, 0);
                //that_label.Text = skillNumeric.Size.Width.ToString()+", "+ skillNumeric.Size.Height.ToString();
                skillNumeric.Size = new Size(s, 20);
                skillNumeric.Value = 0;
                skillNumeric.Minimum = 0;
                skillNumeric.Maximum = 10;
                skillNumeric.ValueChanged += skill_point_changed;
            }
            return skill_panel;

        }

        void Render_skills(int s,int l)
        {
            int n = 0;
            int c = 0;

            foreach(Control item in panels)
            {
                tabPage1.Controls.Remove(item);
            }
            panels = new List<Panel>();
            render_skill_panel("особые способности", n++,c, true, s, l);
            for (int i = 0; i < Character.role_skills_name.Length; i++)
            {

                render_skill_panel(Character.role_skills_name[i], n++, c, false, s, l);
            }

            render_skill_panel(" ", n++, c, true, s, l);
            render_skill_panel("ПРВЛ ", n++, c, true, s, l);
            for (int i = 0; i < Character.attr_skills_name.Length; i++)
            {

                render_skill_panel(Character.attr_skills_name[i], n++, c, false, s, l);
            }

            render_skill_panel(" ", n++, c, true, s, l);
            render_skill_panel("КРУТ/ХЛАД ", n++, c, true, s, l);
            for (int i = 0; i < Character.cool_skills_name.Length; i++)
            {

                render_skill_panel(Character.cool_skills_name[i], n++, c, false, s, l);
            }

            render_skill_panel(" ", n++, c, true, s, l);
            render_skill_panel("ЭМП ", n++, c   , true, s, l);
            for (int i = 0; i < Character.emp_skills_name.Length; i++)
            {

                render_skill_panel(Character.emp_skills_name[i], n++, c, false, s, l);
            }

            render_skill_panel(" ", n++, c, true, s, l);
            render_skill_panel("ИНТ ", n++, c, true, s, l);
            for (int i = 0; i < Character.int_skills_name.Length; i++)
            {


                render_skill_panel(Character.int_skills_name[i], n++, c, false, s, l);
                if (Character.int_skills_name[i] == "Скрываться/Избегать")
                {
                    c++;
                    n = 0;
                }
            }

            render_skill_panel(" ", n++, c, true, s, l);
            render_skill_panel("РЕФ ", n++, c, true, s, l);
            for (int i = 0; i < Character.ref_skills_name.Length; i++)
            {

                render_skill_panel(Character.ref_skills_name[i], n++, c, false, s, l);
            }

            render_skill_panel(" ", n++, c, true, s, l);
            render_skill_panel("ТЕХ ", n++, c, true, s, l);
            for (int i = 0; i < Character.tech_skills_name.Length; i++)
            {


                render_skill_panel(Character.tech_skills_name[i], n++, c, false, s, l);
                if (Character.tech_skills_name[i] == "Маскировка")
                {
                    c++;
                    n = 0;
                }
            }
        }

        public static string ReadFiles()
        {
            string path = @"MyTest.txt";

            if (!File.Exists(path))
            {
                // Create the file.
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info =
                        new UTF8Encoding(true).GetBytes("This is some text in the file.");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            string result = "";

            // Open the stream and read it back.
            using (StreamReader sr = File.OpenText(path))
            {
                
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    result+= s;
                }
            }
            return result;
        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = ReadFiles();

        //    for (int i = 0; i < 60; i++)
        //    {
        //        Label that_label = new Label();
        //        that_label.Text = "skill "+i.ToString();
        //        that_label.Location = new Point(1, i * 20);
        //        panel2.Controls.Add(that_label);
        //        if (i == 0) label1.Text = that_label.Location.ToString();

                

        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool ValidateName()
        {
            if (NameField.Text.Length > 2) return true;
            ErrorLabel.Text = "Вы не ввели имя";
            return false;
        }

        bool ValidateRole()
        {
            switch (RoleChoser.Text.ToLower())
            {
                case "соло":
                    chosen_character.Role = Character.role.solo;
                    return true;
                    break;
                case "рокер":
                    chosen_character.Role = Character.role.rocker;
                    return true;
                    break;
                case "нетраннер":
                    chosen_character.Role = Character.role.netrunner;
                    return true;
                    break;
                case "медиа":
                    chosen_character.Role = Character.role.media;
                    return true;
                    break;
                case "номад":
                    chosen_character.Role = Character.role.nomad;
                    return true;
                    break;
                case "фиксер":
                    chosen_character.Role = Character.role.fixer;
                    return true;
                    break;
                case "коп":
                    chosen_character.Role = Character.role.cop;
                    return true;
                    break;
                case "корп":
                    chosen_character.Role = Character.role.corp;
                    return true;
                    break;
                case "техник":
                    chosen_character.Role = Character.role.tech;
                    return true;
                    break;
                case "медтехник":
                    chosen_character.Role = Character.role.medtech;
                    return true;
                    break;
                default:
                    ErrorLabel.Text = "Надо выбрать роль";
                    RoleChoser.Enabled = true;
                    return false;
                    
                    break;
            }

            
        }

        private void global_numeric_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (NumericUpDown item in create_numerics)
            {
                sum += (int)item.Value;
            }
            sum_label.Text ="Текущая сумма:   "+ sum.ToString()+
                            "\nТребуемая сумма: "+const_sum.ToString();
            if(sum==const_sum) CreateButton.Enabled = true;
            else CreateButton.Enabled = false;
        }

        void Calculate_state()
        {
            chosen_character.int_stat = (int)numeric_int.Value;
            chosen_character.cur_ref_stat=
            chosen_character.global_ref_stat=
            (int)global_ref_numeric.Value;
            cur_reflex_numeric.Value= global_ref_numeric.Value;
            chosen_character.tech_stat=(int)tech_numeric.Value;
            chosen_character.cool_stat=(int)cool_numeric.Value;
            chosen_character.attr_stat=(int)attr_numeric.Value;

            chosen_character.cur_luck_stat =
            chosen_character.global_luck_stat =
            (int)global_luck_numeric.Value;
            cur_luck_numeric.Value = global_luck_numeric.Value;

            chosen_character.body_stat=(int)body_numeric.Value;
            chosen_character.movement_stat=(int)move_numeric.Value;

            chosen_character.cur_emp_stat =
            chosen_character.global_emp_stat =
            (int)global_emp_numeric.Value;
            cur_emp_numeric.Value = global_emp_numeric.Value;

            Extra_stat_label.Text = "Бег:" + (chosen_character.movement_stat * 3).ToString() +
            " прыжок:" + (chosen_character.movement_stat * 4).ToString() 
            + " перенести:" + (chosen_character.body_stat*10).ToString() 
            + " поднять:" + (chosen_character.body_stat * 40).ToString();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
           

            if (chosen_character == null)
            {
                chosen_character= new Character();
                NameField.Enabled = true;
                ErrorLabel.Text = " ";
                CreateButton.Text = "Далее";


                numeric_int.Enabled = cur_reflex_numeric.Enabled =
                global_ref_numeric.Enabled = cool_numeric.Enabled =
                tech_numeric.Enabled = attr_numeric.Enabled =
                cur_luck_numeric.Enabled = global_luck_numeric.Enabled =
                move_numeric.Enabled = body_numeric.Enabled =
                cur_emp_numeric.Enabled = global_emp_numeric.Enabled =
                false;

            }
            else
            {
                switch (chosen_character.createStep)
                {
                    case Character.CreateStep.Name:
                        if(!ValidateName())return;
                        NameField.Enabled = false;
                        chosen_character.createStep = Character.CreateStep.Role;
                        chosen_character.name = NameField.Text;
                        RoleChoser.Enabled = true;

                        



                        return;
                        break;
                    case Character.CreateStep.Role:
                        if (!ValidateRole()) return;
                        RoleChoser.Enabled = false;
                        chosen_character.createStep = Character.CreateStep.stat;

                        //numeric_int.Enabled = 
                        //global_ref_numeric.Enabled = cool_numeric.Enabled =
                        //tech_numeric.Enabled = attr_numeric.Enabled =
                        // global_luck_numeric.Enabled =
                        //move_numeric.Enabled = body_numeric.Enabled =
                        // global_emp_numeric.Enabled =
                        //true;


                        foreach (NumericUpDown item in create_numerics)
                        {
                            //item.Enabled = true;
                            item.Maximum = 10;
                            item.Minimum = 1;
                            item.ValueChanged += global_numeric_Click;
                        }
                        CreateButton.Enabled = false;
                        gen_way_panel.Visible = true;

                        break;
                    case Character.CreateStep.stat:
                        gen_way_panel.Visible = false;
                        Calculate_state();
                        //Render_skills(31, 178);
                        Activate_professionals();
                        CreateButton.Enabled = false;
                        chosen_character.createStep = Character.CreateStep.prof;
                        CommentLabel.Text = "Необходимая сумма:40\nТекущая сумма:0";
                        break;
                    case Character.CreateStep.prof:
                        CommentLabel.Text = "";
                        Activate_professionals(false);
                        CreateButton.Enabled = false;
                        break;
                    case Character.CreateStep.unprof:
                        break;
                    case Character.CreateStep.Money:
                        break;
                    case Character.CreateStep.implants:
                        break;
                    case Character.CreateStep.inventory:
                        break;
                    case Character.CreateStep.finished:
                        break;
                    default:
                        break;
                }
            }
        }

        private void NameEntered(object sender, EventArgs e)
        {
            if (chosen_character != null)
            {
                NameField.Enabled = false;
                chosen_character.createStep = Character.CreateStep.Role;
                chosen_character.name = NameField.Text;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void random_char_Click(object sender, EventArgs e)
        {
            const_sum = 0;
            foreach (NumericUpDown item in create_numerics)
            {
                //item.Enabled = true;
                item.Maximum = 10;
                item.Minimum = 1;
                //item.ValueChanged += global_numeric_Click;
                item.Value = (int)rand.Next(1, 11);
                const_sum += (int)item.Value;
            }
            CreateButton.Enabled = true;
            random_char.Enabled= random_stat_sum_button.Enabled = const_stat_num_button.Enabled = false;
            sum_label.Text = "Текущая сумма:   " + const_sum.ToString();
        }

        private void random_stat_sum_button_Click(object sender, EventArgs e)
        {
            const_sum = rand.Next(9, 90);
            foreach (NumericUpDown item in create_numerics)
            {
                item.Enabled = true;
                item.Maximum = 10;
                item.Minimum = 1;
                item.ValueChanged += global_numeric_Click;
                random_char.Enabled = random_stat_sum_button.Enabled = const_stat_num_button.Enabled = false;
            }
            global_numeric_Click(null, null);
            

        }

        private void const_stat_num_button_Click(object sender, EventArgs e)
        {
            if (const_num_numeric.Enabled) {
                const_stat_num_button.Text = "Заданное число";
                const_num_numeric.Enabled = false;
                const_num_numeric.Visible = false;
                const_stat_num_button.Enabled = false;
                const_sum = (int)const_num_numeric.Value;

                global_numeric_Click(null,null);

            }
            else
            {
                foreach (NumericUpDown item in create_numerics)
                {
                    item.Enabled = true;
                    item.Maximum = 10;
                    item.Minimum = 1;
                    item.ValueChanged += global_numeric_Click;
                }
                const_stat_num_button.Text = "Задать число";
                random_char.Enabled = random_stat_sum_button.Enabled = false;
                const_num_numeric.Enabled = true;
                const_num_numeric.Visible = true;
            }
        }

        private void skillNumeric2_ValueChanged(object sender, EventArgs e)
        {
            //31, 38
            //31,167
            Render_skills((int)skillNumeric2.Value, (int)Skill_numeric.Value);
        }

        private void Skill_numeric_ValueChanged(object sender, EventArgs e)
        {
            Render_skills((int)skillNumeric2.Value, (int)Skill_numeric.Value);
        }

        void Activate_professionals()
        {
            Activate_professionals(true);
        }
        void Activate_professionals(bool professinal)
        {
            string[] professional_skills=chosen_character.GetProfessionalSkillsNames(chosen_character.Role);
            foreach (Panel that_panel in panels)
            {
                if (that_panel.Controls.Count < 2) continue;
                Label label = (Label)that_panel.Controls[0];
                if (label == null) continue;
                //label.Text = chosen_character.name;
                
                NumericUpDown numeric = (NumericUpDown)that_panel.Controls[1];
                if (professinal == professional_skills.Contains(label.Text.Replace("_", "")))
                {
                    if(professinal)label.ForeColor = Color.Blue;
                    if(professinal || (!professinal && !Character.role_skills_name.Contains(label.Text.Replace("_", ""))))numeric.Enabled=true;
                    else numeric.Enabled = false;

                }
                else                numeric.Enabled = false;


            }
        }
    }

    class Character
    {
        public enum CreateStep
        {
            Name,
            Role,
            stat,
            prof,
            unprof,
            Money,
            implants,
            inventory,
            finished
        }

        public enum role
        {
            none,
            solo,
            rocker,
            netrunner,
            media,
            nomad,
            fixer,
            cop,
            corp,
            tech,
            medtech
        }
        public CreateStep createStep = CreateStep.Name;
        public string name = "";
        public role Role = role.none;


        public int int_stat = 0;
        public int cur_ref_stat = 0;
        public int global_ref_stat = 0;
        public int tech_stat = 0;
        public int cool_stat = 0;
        public int attr_stat = 0;
        public int cur_luck_stat = 0;
        public int global_luck_stat = 0;
        public int movement_stat = 0;
        public int body_stat = 0;
        public int cur_emp_stat = 0;
        public int global_emp_stat = 0;


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

    }
}
