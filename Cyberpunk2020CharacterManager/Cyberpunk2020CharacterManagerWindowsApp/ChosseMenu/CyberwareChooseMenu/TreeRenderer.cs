using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;
using System.Reflection;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.CyberwareChooseMenu;

internal partial class CyberwareChooseMenu : Form
{
    Implant? _chosenImplant;

    private void RenderTree()
    {
        PopulateTreeView();
    }

    private Dictionary<string, string> GetDictionaryForTreeReflected(string baseDirectory)
    {
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
                    if (instance is BodyPart) 
                    {
                        result.Add(type.FullName, instance.Name);
                    }
                }
                catch (Exception ex) 
                {
                    continue;
                }
            }
        }
        return result;
    }

    private void RenderTreePart(string TreePartName, Dictionary<string, string> valuePairs)
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

        AvaliableCyberWareTreeView.Nodes.Add(rootNode);
    }

    private void PopulateTreeView()
    {
       
        AvaliableCyberWareTreeView.Nodes.Clear();

        RenderTreePart("Нейро-оснащение", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Cybernetics.Neuralwares"));
        RenderTreePart("Кибер-оснащение, размещенное в теле", GetDictionaryForTreeReflected("Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody"));

        AvaliableCyberWareTreeView.NodeMouseClick += AvaliableCyberWareTreeView_NodeMouseClick;
    }

    private void AvaliableCyberWareTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
       
        if (e.Node.Level == 1) 
        {
            
            HandleChildClick(e.Node.Name);
        }
    }

    private void HandleChildClick(string childName)
    {
        ChooseCyberware( CreateInstance(childName));
    }

    static Implant CreateInstance(string className)
    {
        var assembly = Assembly.Load("Cyberpunk2020GameEntities");
        var type = assembly.GetType(className);

        if (type != null)
        {
            // Создаем экземпляр класса с помощью конструктора по умолчанию
            object instance = Activator.CreateInstance(type);

            if (instance is null) throw new NullReferenceException();

            if(instance is Implant)
            {
                return (Implant)instance;
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

    private void ChooseCyberware(Implant implant)
    {
        Implant_Description.Text = implant.Name +
            $"\n\nСтоимость: {implant.Cost} " +
            $"\nПотеря человечности: {implant.HumanityLossFormula} " +
            $"\nХирургический код: {implant.SurgeryCode}\n\n"
            + implant.Description;

        var problems = implant.BarriersForChipIn(_character);
        problems += PricePotentialProblem(implant);

        var potentialsParents = implant.PotantialParents(_character);

        if (potentialsParents != null)
        {
            MessageBox.Show(potentialsParents.Count.ToString());

            potentialParentComboBox.Visible =
            potentialParentComboBox.Enabled = true;

            potentialParentComboBox.Items.Clear();

            if(potentialsParents.Count > 0)
            {
                foreach (var potentialsParent in potentialsParents)
                {
                    potentialParentComboBox.Items.Add(potentialsParent.Name);
                }
            }
            else
            {
                potentialParentComboBox.Items.Add("Нет опций");
            }
            potentialParentComboBox.SelectedIndex = 0;
        }
        else
        {
            potentialParentComboBox.Visible = 
            potentialParentComboBox.Enabled = false;
        }

        problem_list_table.Text = problems;
        if(problems == string.Empty) 
        {
            add_chosen_cyberware_button.Enabled = true;
            _chosenImplant = implant;
        }
        else
        {
            add_chosen_cyberware_button.Enabled = false;
            _chosenImplant = null;
        }

        add_chosen_cyberware_button.Text = "Добавить выбранное кибероснащение";
    }

    private string PricePotentialProblem(Implant implant)
    {
        if (implant.Cost > _character.CurrentMoney)
        {
            return $"\nДля покупки не хватает {implant.Cost - _character.CurrentMoney} евродолларов.";
        }
        return string.Empty;
    }
}