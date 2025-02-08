using Cyberpunk2020GameEntities.Equipments;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    int pixelsForOneEquipmentPanel = 14;
    Label _clickedInventoryLabel;

    Control RenderEquipmentPanel(Equipment equipment, int i, int column, int s, int l)
    {
        int text_size = 380;
        int extra_size = 70;

        Panel equipmentPanel = new Panel();
        _inventoryPanels.Add(equipmentPanel);
        inventoryScrollPanel.Controls.Add(equipmentPanel);
        Label nameLabel = new Label();
        nameLabel.Name = i.ToString();
        nameLabel.Click += new EventHandler(EquipmentLabel_Click);
        nameLabel.Size = new Size(text_size, pixelsForOneEquipmentPanel);
        nameLabel.Text = equipment.Name;
       
        Label quantityLabel = new Label();
        quantityLabel.Name = i.ToString();
        quantityLabel.Click += new EventHandler(EquipmentLabel_Click);
        quantityLabel.Size = new Size(extra_size, pixelsForOneEquipmentPanel);
        quantityLabel.Location = new Point(text_size, 0);
        quantityLabel.Text = equipment.Quantity.ToString();
       
        equipmentPanel.Controls.Add(nameLabel);
        equipmentPanel.Controls.Add(quantityLabel);
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

            RenderEquipmentPanel(item, n++, c, s, l);
        }
    }
}
