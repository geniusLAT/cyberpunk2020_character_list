using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics;
using Cyberpunk2020GameEntities.Equipments;
using System.Data.Common;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    int pixelsForOneEquipmentPanel = 14;
    Label _clickedInventoryLabel;

    private void EquipmentLabel_Click(object sender, EventArgs e)
    {
        var control = (Control)sender;
        try
        {
            int index = int.Parse(control.Name);
            ChooseEquipment(_chosenCharacter.equipments[index]);
        }
        catch (Exception)
        {
            return;
        }

        if (_clickedInventoryLabel != null)
        {
            ((Panel)_clickedInventoryLabel.Parent).BackColor = Color.White;
            _clickedInventoryLabel.ForeColor = Color.Black;
        }
        ((Panel)control.Parent).BackColor = Color.Blue;
        _clickedInventoryLabel = (Label)control;
        _clickedInventoryLabel.ForeColor = Color.White;
    }

    private void ChooseEquipment(Equipment equipment)
    {
        _chosenEquipment = equipment;
    }

    Control RenderEquipmentPanel(string text, int i, int column, int s, int l)
    {
        int text_size = 180;
        int extra_size = 20;

        Panel equipmentPanel = new Panel();
        _inventoryPanels.Add(equipmentPanel);
        inventoryScrollPanel.Controls.Add(equipmentPanel);
        Label that_label = new Label();
        that_label.Name = i.ToString();
        that_label.Click += new EventHandler(EquipmentLabel_Click);
        that_label.Size = new Size(text_size, pixelsForOneEquipmentPanel);
        that_label.Text = text;

        equipmentPanel.Controls.Add(that_label);
        equipmentPanel.Size = new Size(extra_size + text_size, pixelsForOneEquipmentPanel);
       
        equipmentPanel.Location = new Point((extra_size + text_size) * column, i * pixelsForOneEquipmentPanel);
        return equipmentPanel;
    }

    void RenderInventory(int s, int l)
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

            RenderEquipmentPanel(item.Name, n++, c, s, l);
        }
    }
}
