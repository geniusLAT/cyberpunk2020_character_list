﻿using Cyberpunk2020GameEntities;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    Control RenderSkillPanel(string text, int i, int column, bool header, int s, int l, int skillNumber = 0,int value = 0)
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
        that_label.Text = text + "____________________________________";// "skill" + i.ToString();

        if (IsProfessionalSkill(text))
        {
            that_label.ForeColor = Color.Blue;
        }

        //that_label.Text =  "skill" + i.ToString();
        skill_panel.Location = new Point((extra_size + text_size) * column, i * g);


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
            skillNumeric.Value = value;
            
            skillNumeric.Minimum = 0;
            skillNumeric.Maximum = 10;
            skillNumeric.Name = skillNumber.ToString();
            //skillNumeric.Maximum = skillNumber;
            //skillNumeric.Value = skillNumber;
            skillNumeric.ValueChanged += SkillPointChanged;
        }
        return skill_panel;

    }

    void RenderSkills(int s, int l)
    {
        int n = 0;
        int c = 0;
        int skillNumber = 0;

        foreach (Control item in _panels)
        {
            tabPage1.Controls.Remove(item);
        }
        _panels = new List<Panel>();
        RenderSkillPanel("особые способности", n++, c, true, s, l);
        for (int i = 0; i < Character.role_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.role_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ПРВЛ ", n++, c, true, s, l);
        for (int i = 0; i < Character.attr_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.attr_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("КРУТ/ХЛАД ", n++, c, true, s, l);
        for (int i = 0; i < Character.cool_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.cool_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ЭМП ", n++, c, true, s, l);
        for (int i = 0; i < Character.emp_skills_name.Length; i++)
        {

            RenderSkillPanel(Character.emp_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ИНТ ", n++, c, true, s, l);
        for (int i = 0; i < Character.int_skills_name.Length; i++)
        {


            RenderSkillPanel(Character.int_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
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

            RenderSkillPanel(Character.ref_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
        }

        RenderSkillPanel(" ", n++, c, true, s, l);
        RenderSkillPanel("ТЕХ ", n++, c, true, s, l);
        for (int i = 0; i < Character.tech_skills_name.Length; i++)
        {


            RenderSkillPanel(Character.tech_skills_name[i], n++, c, false, s, l, skillNumber, _chosenCharacter?.skills[skillNumber] ?? 0);
            skillNumber++;
            if (Character.tech_skills_name[i] == "Маскировка")
            {
                c++;
                n = 0;
            }
        }
    }
}
