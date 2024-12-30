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
using Cyberpunk2020GameEntities;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    
    private int _constantSum = 0;

    private Random _random = new();

    private NumericUpDown[] _createNumerics = [];

    private Character? _chosenCharacter = null;

    private List<Panel> _panels = [];

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

        _createNumerics = numerics;

        gen_way_panel.Visible = false;
        const_num_numeric.Enabled = false;
        const_num_numeric.Visible = false;
        RenderSkills(31,178);
    }

    bool IsProfessionalSkill(string skill)
    {
        if (_chosenCharacter == null) return false;

        string[] professionals = _chosenCharacter.GetProfessionalSkillsNames(_chosenCharacter.Role);
        if(professionals.Contains(skill)) { return true; }
        return false;
    }

    

    int CountSkillSum(bool professinal)
    {
        int count = 0;
        foreach (Control item in _panels)
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

    private void SkillPointChanged(object sender, EventArgs e)
    {
        label16.Text = ">";
        if(sender is NumericUpDown)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            Panel ParentPanel = (Panel)numeric.Parent!;
            //label16.Text +=ParentPanel.Controls.ToString();
            string skill_name = ((Label)ParentPanel.Controls[0]).Text;

            if (_chosenCharacter!.createStep == CreateStep.prof)
            {
                int sum = CountSkillSum(true);
                CommentLabel.Text = "Необходимая сумма:40\nТекущая сумма:" + sum.ToString();
                if(sum==40)CreateButton.Enabled = true;
                else CreateButton.Enabled = false;  

            }
            if (_chosenCharacter.createStep == CreateStep.unprof)
            {
                int sum = CountSkillSum(false);
                CommentLabel.Text = "Необходимая сумма:"+(_chosenCharacter.global_ref_stat+_chosenCharacter.int_stat).ToString()+ "\nТекущая сумма:" + sum.ToString();
                if (sum == _chosenCharacter.global_ref_stat + _chosenCharacter.int_stat) CreateButton.Enabled = true;
                else CreateButton.Enabled = false;

            }
        }
    }

    Control RenderSkillPanel(string text,int i, int column, bool header,int s, int l)
    {
        int g = 14;
        int text_size = 180;
        int extra_size = 60;

        Panel skill_panel = new Panel();
        _panels.Add(skill_panel);
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
            skillNumeric.ValueChanged += SkillPointChanged;
        }
        return skill_panel;

    }

    void RenderSkills(int s,int l)
    {
        int n = 0;
        int c = 0;

        foreach(Control item in _panels)
        {
            tabPage1.Controls.Remove(item);
        }
        _panels = new List<Panel>();
        RenderSkillPanel("особые способности", n++,c, true, s, l);
        for (int i = 0; i < Character.role_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.role_skills_name[i], n++, c, false, s, l);
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ПРВЛ ", n++, c, true, s, l);
        for (int i = 0; i < Character.attr_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.attr_skills_name[i], n++, c, false, s, l);
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("КРУТ/ХЛАД ", n++, c, true, s, l);
        for (int i = 0; i < Character.cool_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.cool_skills_name[i], n++, c, false, s, l);
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ЭМП ", n++, c   , true, s, l);
        for (int i = 0; i < Character.emp_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.emp_skills_name[i], n++, c, false, s, l);
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ИНТ ", n++, c, true, s, l);
        for (int i = 0; i < Character.int_skills_name.Length; i++)
        {


            RenderSkillPanel(Character.int_skills_name[i], n++, c, false, s, l);
            if (Character.int_skills_name[i] == "Скрываться/Избегать")
            {
                c++;
                n = 0;
            }
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("РЕФ ", n++, c, true, s, l);
        for (int i = 0; i < Character.ref_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.ref_skills_name[i], n++, c, false, s, l);
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ТЕХ ", n++, c, true, s, l);
        for (int i = 0; i < Character.tech_skills_name.Length; i++)
        {


            RenderSkillPanel(Character.tech_skills_name[i], n++, c, false, s, l);
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
                _chosenCharacter.Role = role.solo;
                return true;
                break;
            case "рокер":
                _chosenCharacter.Role = role.rocker;
                return true;
                break;
            case "нетраннер":
                _chosenCharacter.Role = role.netrunner;
                return true;
                break;
            case "медиа":
                _chosenCharacter.Role = role.media;
                return true;
                break;
            case "номад":
                _chosenCharacter.Role = role.nomad;
                return true;
                break;
            case "фиксер":
                _chosenCharacter.Role = role.fixer;
                return true;
                break;
            case "коп":
                _chosenCharacter.Role = role.cop;
                return true;
                break;
            case "корп":
                _chosenCharacter.Role = role.corp;
                return true;
                break;
            case "техник":
                _chosenCharacter.Role = role.tech;
                return true;
                break;
            case "медтехник":
                _chosenCharacter.Role = role.medtech;
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
        foreach (NumericUpDown item in _createNumerics)
        {
            sum += (int)item.Value;
        }
        sum_label.Text ="Текущая сумма:   "+ sum.ToString()+
                        "\nТребуемая сумма: "+_constantSum.ToString();
        if(sum==_constantSum) CreateButton.Enabled = true;
        else CreateButton.Enabled = false;
    }

    void CalculateState()
    {
        if(_chosenCharacter is null)
        {
            return;
        }

        _chosenCharacter.int_stat = (int)numeric_int.Value;
        _chosenCharacter.cur_ref_stat=
        _chosenCharacter.global_ref_stat=
        (int)global_ref_numeric.Value;
        cur_reflex_numeric.Value= global_ref_numeric.Value;
        _chosenCharacter.tech_stat=(int)tech_numeric.Value;
        _chosenCharacter.cool_stat=(int)cool_numeric.Value;
        _chosenCharacter.attr_stat=(int)attr_numeric.Value;

        _chosenCharacter.cur_luck_stat =
        _chosenCharacter.global_luck_stat =
        (int)global_luck_numeric.Value;
        cur_luck_numeric.Value = global_luck_numeric.Value;

        _chosenCharacter.body_stat=(int)body_numeric.Value;
        _chosenCharacter.movement_stat=(int)move_numeric.Value;

        _chosenCharacter.cur_emp_stat =
        _chosenCharacter.global_emp_stat =
        (int)global_emp_numeric.Value;
        cur_emp_numeric.Value = global_emp_numeric.Value;

        Extra_stat_label.Text = "Бег:" + (_chosenCharacter.movement_stat * 3).ToString() +
        " прыжок:" + (_chosenCharacter.movement_stat * 4).ToString() 
        + " перенести:" + (_chosenCharacter.body_stat*10).ToString() 
        + " поднять:" + (_chosenCharacter.body_stat * 40).ToString();
    }

    void GenerateIncome()
    {
        if (_chosenCharacter is null)
        {
            return;
        }

        int roleSkill = 0;
        bool first = true;
        foreach (Panel that_panel in _panels)
        {
            if(that_panel.Controls.Count<2)
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                else break;
            }

            NumericUpDown numeric = (NumericUpDown)that_panel.Controls[1];
            if (numeric.Value > 0)
            {
                roleSkill=(int)numeric.Value; break;    
            }
        }

        switch (_chosenCharacter.Role)
        {
            case role.none:
                break;
            case role.solo:

                _chosenCharacter.MonthIncome = 2000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 12000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 9000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 4500;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 3000;


                break;
            case role.rocker:
                _chosenCharacter.MonthIncome = 1000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 12000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 8000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 2500;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 1500;

                break;
            case role.netrunner:
                _chosenCharacter.MonthIncome = 1000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 10000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 3000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 2000;
                break;
            case role.media:
                _chosenCharacter.MonthIncome = 1000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 10000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 3000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 1200;

                
                break;
            case role.nomad:
                _chosenCharacter.MonthIncome = 1000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 4000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 3000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 2000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 1500;
                break;
            case role.fixer:
                _chosenCharacter.MonthIncome = 1500;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 10000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 8000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 3000;

                break;
            case role.cop:

                _chosenCharacter.MonthIncome = 1000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 9000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 3000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 1500;

                break;
            case role.corp:
                _chosenCharacter.MonthIncome = 1500;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 12000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 9000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 3000;

                break;
            case role.tech:
                _chosenCharacter.MonthIncome = 1000;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 8000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 4000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 3000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 2000;

                break;
            case role.medtech:
                _chosenCharacter.MonthIncome = 1600;

                if (roleSkill == 10) _chosenCharacter.MonthIncome = 15000;
                if (roleSkill == 9) _chosenCharacter.MonthIncome = 10000;
                if (roleSkill == 8) _chosenCharacter.MonthIncome = 7000;
                if (roleSkill == 7) _chosenCharacter.MonthIncome = 5000;
                if (roleSkill == 6) _chosenCharacter.MonthIncome = 2000;

                break;
            default:
                break;
        }

        int random_hit = _random.Next(1, 7);
        MoneyLabel.Text = "Доход:" + _chosenCharacter.MonthIncome.ToString() + " ("+random_hit.ToString()+") Баланс:";
        _chosenCharacter.CurrentMoney =(int)(random_hit * _chosenCharacter.MonthIncome / 3.0f);
        Money_numeric.Enabled = true;
        Money_numeric.Value = _chosenCharacter.CurrentMoney;

    }

  

    private void CreateButton_Click(object sender, EventArgs e)
    {
       

        if (_chosenCharacter == null)
        {
            _chosenCharacter= new Character();
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

            MoneyLabel.Text = "";

        }
        else
        {
            switch (_chosenCharacter.createStep)
            {
                case CreateStep.Name:
                    if(!ValidateName())return;
                    NameField.Enabled = false;
                    _chosenCharacter.createStep = CreateStep.Role;
                    _chosenCharacter.name = NameField.Text;
                    RoleChoser.Enabled = true;

                    



                    return;
                    break;
                case CreateStep.Role:
                    if (!ValidateRole()) return;
                    RoleChoser.Enabled = false;
                    _chosenCharacter.createStep = CreateStep.stat;

                    //numeric_int.Enabled = 
                    //global_ref_numeric.Enabled = cool_numeric.Enabled =
                    //tech_numeric.Enabled = attr_numeric.Enabled =
                    // global_luck_numeric.Enabled =
                    //move_numeric.Enabled = body_numeric.Enabled =
                    // global_emp_numeric.Enabled =
                    //true;


                    foreach (NumericUpDown item in _createNumerics)
                    {
                        //item.Enabled = true;
                        item.Maximum = 10;
                        item.Minimum = 1;
                        item.ValueChanged += global_numeric_Click;
                    }
                    CreateButton.Enabled = false;
                    gen_way_panel.Visible = true;

                    break;
                case CreateStep.stat:
                    gen_way_panel.Visible = false;
                    CalculateState();
                    //Render_skills(31, 178);
                    Activate_professionals();
                    CreateButton.Enabled = false;
                    _chosenCharacter.createStep = CreateStep.prof;
                    CommentLabel.Text = "Необходимая сумма:40\nТекущая сумма:0";
                    break;
                case CreateStep.prof:
                    CommentLabel.Text = "";
                    Activate_professionals(false);
                    CreateButton.Enabled = false;
                    _chosenCharacter.createStep = CreateStep.unprof;
                    break;
                case CreateStep.unprof:
                    CreateButton.Enabled = false;
                    _chosenCharacter.createStep = CreateStep.Money;
                    Deactivate_skills();
                    GenerateIncome();
                    break;
                case CreateStep.Money:
                    break;
                case CreateStep.implants:
                    break;
                case CreateStep.inventory:
                    break;
                case CreateStep.finished:
                    break;
                default:
                    break;
            }
        }
    }

    private void NameEntered(object sender, EventArgs e)
    {
        if (_chosenCharacter != null)
        {
            NameField.Enabled = false;
            _chosenCharacter.createStep = CreateStep.Role;
            _chosenCharacter.name = NameField.Text;
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
        _constantSum = 0;
        foreach (NumericUpDown item in _createNumerics)
        {
            //item.Enabled = true;
            item.Maximum = 10;
            item.Minimum = 1;
            //item.ValueChanged += global_numeric_Click;
            item.Value = (int)_random.Next(1, 11);
            _constantSum += (int)item.Value;
        }
        CreateButton.Enabled = true;
        random_char.Enabled= random_stat_sum_button.Enabled = const_stat_num_button.Enabled = false;
        sum_label.Text = "Текущая сумма:   " + _constantSum.ToString();
    }

    private void random_stat_sum_button_Click(object sender, EventArgs e)
    {
        _constantSum = _random.Next(9, 90);
        foreach (NumericUpDown item in _createNumerics)
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
            _constantSum = (int)const_num_numeric.Value;

            global_numeric_Click(null,null);

        }
        else
        {
            foreach (NumericUpDown item in _createNumerics)
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
        RenderSkills((int)skillNumeric2.Value, (int)Skill_numeric.Value);
    }

    private void Skill_numeric_ValueChanged(object sender, EventArgs e)
    {
        RenderSkills((int)skillNumeric2.Value, (int)Skill_numeric.Value);
    }


    void Deactivate_skills()
    {
        foreach (Panel that_panel in _panels)
        {
            if (that_panel.Controls.Count < 2) continue;
            NumericUpDown numeric = (NumericUpDown)that_panel.Controls[1];
            numeric.Enabled = false;    
        }
    }
    void Activate_professionals()
    {
        Activate_professionals(true);
    }
    void Activate_professionals(bool professinal)
    {
        string[] professional_skills=_chosenCharacter.GetProfessionalSkillsNames(_chosenCharacter.Role);
        foreach (Panel that_panel in _panels)
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

    private void Money_numeric_ValueChanged(object sender, EventArgs e)
    {

    }
}