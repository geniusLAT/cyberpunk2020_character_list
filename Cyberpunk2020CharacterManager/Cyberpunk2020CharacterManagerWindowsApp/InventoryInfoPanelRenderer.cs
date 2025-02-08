using Cyberpunk2020GameEntities.Equipments;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    private Equipment _chosenEquipment;

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
            Panel oldPanel = (Panel)_clickedInventoryLabel.Parent;
            oldPanel.BackColor = Color.White;
            recolorChildrenLabels(oldPanel, Color.Black);
        }
        Panel newPanel = (Panel)control.Parent;
        (newPanel).BackColor = Color.Blue;
        _clickedInventoryLabel = (Label)control;
        recolorChildrenLabels(newPanel, Color.White);
    }

    void recolorChildrenLabels(Panel panel, Color color)
    {
        foreach (var child in panel.Controls) {
            if (child is Label) 
            {
                ((Label)child).ForeColor = color;
            }
        }
    }

    private void ChooseEquipment(Equipment equipment)
    {
        _chosenEquipment = equipment;

        chosenEquipmentNameLabel.Text = equipment.Name;
        chosenEquipmentCostLabel.Text = $"Цена за штуку: {equipment.Cost} ed";
        chosenEquipmentDescriptionLabel.Text = equipment.Description;
    }
}
