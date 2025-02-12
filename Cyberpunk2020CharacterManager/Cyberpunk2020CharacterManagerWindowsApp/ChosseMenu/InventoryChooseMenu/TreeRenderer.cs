using Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.AddCustomEquipmentMenus;
using Cyberpunk2020GameEntities.Equipments;
using System.Reflection;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.InventoryChooseMenu;

internal partial class InventoryChooseMenu : Form
{
    Equipment? _chosenEquipment;

    private void RenderTree()
    {
        PopulateTreeView();
    }

    private Dictionary<string, string> GetDictionaryForTreeReflected(string baseDirectory)
    {
        List<Equipment> exampleInstances = [];
        Dictionary<string, string> result = [];

        var assembly = Assembly.Load("Cyberpunk2020GameEntities");
        var types = assembly.GetTypes();
        List<Type> classes = [];

        foreach (var type in types)
        { 
            if (type.FullName.Contains(baseDirectory) && type.IsClass)
            {
                try
                {
                    var instance = CreateInstance(type.FullName);
                    if (instance is Equipment) 
                    {
                        exampleInstances.Add(instance);
                    }
                }
                catch (Exception ex) 
                {
                    continue;
                }
            }
        }
        exampleInstances.Sort();
        foreach (var instance in exampleInstances)
        {
            result.Add(instance.GetType().FullName, instance.Name);
        }
        return result;
    }

    private void RenderTreePart(TreeNode? higherNode,string TreePartName, Dictionary<string, string> valuePairs)
    {
        TreeNode rootNode = new(TreePartName)
        {
            Name = TreePartName
        };

        foreach (var pair in valuePairs)
        {
            TreeNode childNode = new TreeNode(pair.Value)
            {
                Name =pair.Key
            };
            rootNode.Nodes.Add(childNode);
        }
        if (higherNode != null)
        {
            higherNode.Nodes.Add(rootNode);
        }
        else
        {
            AvaliableCyberWareTreeView.Nodes.Add(rootNode);
        }
    }

    private void PopulateTreeView()
    {
       
        AvaliableCyberWareTreeView.Nodes.Clear();

        TreeNode GearListNode = new("Лист снаряжения")
        {
            Name = "Лист снаряжения"
        };
        AvaliableCyberWareTreeView.Nodes.Add(GearListNode);

        RenderTreePart(GearListNode, "Инструменты", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Tools"));
        RenderTreePart(GearListNode, "Личная Электроника", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.PersonalElectronics"));
        RenderTreePart(GearListNode, "DataSystems", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.DataSystems"));
        RenderTreePart(GearListNode, "Связь", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Communications"));
        RenderTreePart(GearListNode, "Наблюдение", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Surveillance"));
        RenderTreePart(GearListNode, "Развлечения", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Entertainment"));
        RenderTreePart(GearListNode, "Security", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Security"));
        RenderTreePart(GearListNode, "Medical", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Medical"));
        RenderTreePart(GearListNode, "Мебель", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Furnishings"));
        RenderTreePart(GearListNode, "Транспорт", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Vehicles"));
        RenderTreePart(GearListNode, "Образ жизни", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.LifeStyle"));
        RenderTreePart(GearListNode, "Бакалея", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Groceries"));
        RenderTreePart(GearListNode, "Жильё", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.Housing"));

        TreeNode otherNode = new("Прочее")
        {
            Name = "Прочее"
        };
        AvaliableCyberWareTreeView.Nodes.Add(otherNode);
        RenderTreePart(otherNode, "Кастомные", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Equipments.CustomEquipment"));


        AvaliableCyberWareTreeView.NodeMouseClick += AvaliableCyberWareTreeView_NodeMouseClick;
    }

    private void AvaliableCyberWareTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        if (e.Node.Level == 2) 
        {
            MessageBox.Show(e.Node.Name);
            if(e.Node.Name == "Cyberpunk2020GameEntities.Equipments.CustomEquipment.CustomEquipment")
            {
                this.Close();
                HandleCustom();
                return;
            }

            HandleChildClick(e.Node.Name);
        }
    }

    private void HandleCustom()
    {
        var menu = new AddCustomEquipmentMenu(_form1, _character);
        menu.Show();
        menu.BringToFront(); 
        menu.Activate();
        menu.TopMost = true;

        return;
    }

    private void HandleChildClick(string childName)
    {
        ChooseEquipment( CreateInstance(childName));
    }

    static Equipment CreateInstance(string className)
    {
        var assembly = Assembly.Load("Cyberpunk2020GameEntities");
        var type = assembly.GetType(className);

        if (type != null)
        {
            // Создаем экземпляр класса с помощью конструктора по умолчанию
            object instance = Activator.CreateInstance(type);

            if (instance is null) throw new NullReferenceException();

            if(instance is Equipment)
            {
                return (Equipment)instance;
            }
            else
            {
                throw new NotImplementedException();
                //return new Implant();
            }
        }
        else
        {
            throw new NotImplementedException(className);
        }
    }

    private void ChooseEquipment(Equipment equipmentItem)
    {
        radioButton1.Enabled = radioButton2.Enabled = equipmentQuantityNumerucUpDown.Enabled = true;
        equipmentQuantityNumerucUpDown.Value = 1;
        radioButton1.Checked = true;

        var extraCostNote = string.Empty;
        if (equipmentItem.MaxCost is not null)
        {
            extraCostNote = $"-{equipmentItem.MaxCost}";
        }

        Implant_Description.Text = equipmentItem.Name +
            $"\n\nСтоимость: {equipmentItem.Cost}{extraCostNote} \n\n"
            + equipmentItem.Description;

        potentialOptionComboBox.Items.Clear();
        var options = equipmentItem.GetOptions();
        if (options.Any())
        {
            potentialOptionComboBox.Visible = potentialOptionComboBox.Enabled = true;
            foreach (var option in options)
            {
                potentialOptionComboBox.Items.Add(option);
            }
            potentialOptionComboBox.SelectedIndex = 0;
        }
        else
        {
            potentialOptionComboBox.Visible = potentialOptionComboBox.Enabled = false;
        }

        if(equipmentItem.MaxCost is null)
        {
            ExtraCostTrackBar.Enabled = ExtraCostTrackBar.Visible = ExtraCostLabel.Visible = false;
        }
        else
        {
            ExtraCostLabel.Text = $"Цена: {equipmentItem.Cost}";
            ExtraCostTrackBar.Enabled = ExtraCostTrackBar.Visible = ExtraCostLabel.Visible = true;
            ExtraCostTrackBar.Minimum = (int)equipmentItem.Cost;
            ExtraCostTrackBar.Value = (int)equipmentItem.Cost;
            ExtraCostTrackBar.Maximum = equipmentItem.MaxCost ?? 0;
        }

        //var potentialsParents = equipmentItem.PotentialParents(_character);

        //if (potentialsParents != null)
        //{
        //    potentialParentComboBox.Visible =
        //    potentialParentComboBox.Enabled = true;

        //    potentialParentComboBox.Items.Clear();

        //    //if(potentialsParents.Count > 0)
        //    //{
        //    //    foreach (var potentialsParent in potentialsParents)
        //    //    {
        //    //        potentialParentComboBox.Items.Add(potentialsParent.Name);
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    potentialParentComboBox.Items.Add("Нет опций");
        //    //}
        //    potentialParentComboBox.SelectedIndex = 0;
        //}
        //else
        //{
        //    potentialParentComboBox.Visible = 
        //    potentialParentComboBox.Enabled = false;
        //}
        
        _chosenEquipment = equipmentItem;
        LookForProblemForEquipment(equipmentItem);
        add_chosen_cyberware_button.Text = "Купить";
    }

    void LookForProblemForEquipment(Equipment equipment)
    {

        var problems = buingMode ? PricePotentialProblem(equipment) : string.Empty;
        problem_list_table.Text = problems;
        if (problems == string.Empty)
        {
            add_chosen_cyberware_button.Enabled = true;
        }
        else
        {
            add_chosen_cyberware_button.Enabled = false;
        }
    }

    private string PricePotentialProblem(Equipment equipmentItem)
    {
        var practicalCostPerOne = equipmentItem.Cost * equipmentItem.GetOptionPriceModifier(potentialOptionComboBox.Text);

        if (ExtraCostTrackBar.Enabled)
        {
            practicalCostPerOne = ExtraCostTrackBar.Value;
        }
        var moneyNeeded = practicalCostPerOne * equipmentItem.Quantity;
        if (moneyNeeded > _character.CurrentMoney && buingMode)
        {
            var quntityNote = equipmentItem.Quantity != 1 ? $"({equipmentItem.Quantity} шт.)" : string.Empty;
            return $"\nДля покупки {quntityNote} не хватает {moneyNeeded - _character.CurrentMoney} евродолларов.";
        }
        return string.Empty;
    }
}