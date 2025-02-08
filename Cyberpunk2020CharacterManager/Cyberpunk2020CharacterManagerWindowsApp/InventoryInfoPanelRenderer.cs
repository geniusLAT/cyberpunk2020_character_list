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

        chosenEquipmentNameLabel.Text = equipment.Name;
        chosenEquipmentCostLabel.Text = $"Цена за штуку: {equipment.Cost} ed";
        chosenEquipmentDescriptionLabel.Text = equipment.Description;
    }
}
