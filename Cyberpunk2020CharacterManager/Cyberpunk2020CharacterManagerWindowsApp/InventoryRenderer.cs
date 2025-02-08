using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics;
using System.Data.Common;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    int pixelsForOneEquipmentPanel = 14;

    Control RenderEquipmentPanel(string text, int i, int column, bool header, int s, int l, int margin)
    {
        int text_size = 180;
        int extra_size = 20;

        Panel equipmentPanel = new Panel();
        _inventoryPanels.Add(equipmentPanel);
        inventoryScrollPanel.Controls.Add(equipmentPanel);
        Label that_label = new Label();
        that_label.Size = new Size(text_size, pixelsForOneEquipmentPanel);

        equipmentPanel.Controls.Add(that_label);
        equipmentPanel.Size = new Size(extra_size + text_size, pixelsForOneEquipmentPanel);
        //skill_panel.BackColor = Color.Yellow;
        that_label.Text = text + "____________________________________";// "skill" + i.ToString();

        if (IsProfessionalSkill(text))
        {
            that_label.ForeColor = Color.Blue;
        }

        //that_label.Text =  "skill" + i.ToString();
        equipmentPanel.Location = new Point((extra_size + text_size) * column, i * pixelsForOneEquipmentPanel);


        if (header)
        {


            that_label.Font = new Font(that_label.Font, that_label.Font.Style | FontStyle.Bold);

        }
        else
        {
            NumericUpDown skillNumeric = new NumericUpDown();
            //skillNumeric.Enabled= false;
            equipmentPanel.Controls.Add(skillNumeric);
            skillNumeric.Location = new Point(l, 0);
            //that_label.Text = skillNumeric.Size.Width.ToString()+", "+ skillNumeric.Size.Height.ToString();
            skillNumeric.Size = new Size(s, 20);
            skillNumeric.Value = 0;
            skillNumeric.Minimum = 0;
            skillNumeric.Maximum = 10;
            skillNumeric.ValueChanged += SkillPointChanged;
        }
        return equipmentPanel;

    }

    void RenderInventory(int s, int l, int margin)
    {
        int n = 0;
        int c = 0;
        foreach (Control item in _inventoryPanels)
        {
            inventoryScrollPanel.Controls.Remove(item);
        }
        _inventoryPanels = [];
        foreach (var item in _chosenCharacter.equipments)
        {

            RenderEquipmentPanel(item.Name, n++, c, false, s, l, margin);
        }
    }
}
