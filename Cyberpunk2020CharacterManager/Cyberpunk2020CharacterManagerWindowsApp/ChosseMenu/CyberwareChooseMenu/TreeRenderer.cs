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

    private void RenderCyberwearPlaceInTheBodyTreePart()
    {
        string baseNamespace = "Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody.";

        string[] namesToShow = new string[] { "Назальные фильтры", "Имплантируемые жабры" };
        string[] namesToCall = new string[] { $"{baseNamespace}NasalFilters", $"{baseNamespace}Gills" };

        RenderTreePart("Кибер-оснащение, размещенное в теле",namesToShow,namesToCall);
    }


    private void RenderTreePart(string TreePartName, string[] namesToShow, string[] namesToCall)
    {
        if (namesToShow.Length != namesToCall.Length)
        {
            throw new ApplicationException();
        }

        TreeNode rootNode = new(TreePartName)
        {
            Name = TreePartName
        };

        for (int j = 0; j < namesToShow.Length; j++)
        {
            TreeNode childNode = new TreeNode(namesToShow[j])
            {
                Name = namesToCall[j]
            };
            rootNode.Nodes.Add(childNode);
        }

        AvaliableCyberWareTreeView.Nodes.Add(rootNode);
    }

    private void PopulateTreeView()
    {
       
        AvaliableCyberWareTreeView.Nodes.Clear();

        RenderCyberwearPlaceInTheBodyTreePart();

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
            $"\nХирургический код: {implant.SurgeryCode}\n"
            + implant.Description;

        var problems = implant.BarriersForChipIn(_character);
        problems += PricePotentialProblem(implant);

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