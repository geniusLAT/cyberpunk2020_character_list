using Cyberpunk2020GameEntities.Cybernetics;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    Control RenderCyberwarePanel(BodyPart part, int i)
    {
        int g = 14;
        int text_size = 180;
        int extra_size = 60;

        Panel CyberwarePanel = new Panel();
        _panels.Add(CyberwarePanel);
        tabPage2.Controls.Add(CyberwarePanel);
        Label that_label = new()
        {
            Size = new Size(text_size, g)
        };

        CyberwarePanel.Controls.Add(that_label);
        CyberwarePanel.Size = new Size(extra_size + text_size, g);
        CyberwarePanel.BackColor = Color.Yellow;
        that_label.Text = part.Name;

        ////that_label.Text =  "skill" + i.ToString();
        CyberwarePanel.Location = new Point(0, i * g);


        //if (header)
        //{


        //    that_label.Font = new Font(that_label.Font, that_label.Font.Style | FontStyle.Bold);

        //}
        //else
        //{
        //    NumericUpDown skillNumeric = new NumericUpDown();
        //    //skillNumeric.Enabled= false;
        //    skill_panel.Controls.Add(skillNumeric);
        //    skillNumeric.Location = new Point(l, 0);
        //    //that_label.Text = skillNumeric.Size.Width.ToString()+", "+ skillNumeric.Size.Height.ToString();
        //    skillNumeric.Size = new Size(s, 20);
        //    skillNumeric.Value = 0;
        //    skillNumeric.Minimum = 0;
        //    skillNumeric.Maximum = 10;
        //    skillNumeric.ValueChanged += SkillPointChanged;
        //}
        return CyberwarePanel;

    }

    void RenderCyberwares(int s, int l)
    {
        if (_chosenCharacter is null)
        {
            return;
        }

        for (int i = 0; i < _chosenCharacter.BodyParts.Count; i++)
        {
            RenderCyberwarePanel(_chosenCharacter.BodyParts[i], i + 2);
        }
    }
}
