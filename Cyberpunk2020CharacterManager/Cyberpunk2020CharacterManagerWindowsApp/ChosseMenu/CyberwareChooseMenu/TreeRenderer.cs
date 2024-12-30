using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;
using System.Reflection;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.CyberwareChooseMenu;

public class exampleClass
{
    public exampleClass() { }
}

internal partial class CyberwareChooseMenu : Form
{
    private void RenderTree()
    {
        PopulateTreeView();
    }

    private void RenderCyberwearPlaceInTheBodyTreePart()
    {
        string[] namesToShow = new string[] { "Назальные фильтры" };
        string[] namesToCall = new string[] { "NasalFilters" };

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
            
            HandleChildClick(e.Node.Text);
        }
    }

    private void HandleChildClick(string childName)
    {
        // Здесь вы можете обработать клик по дочернему элементу
        //MessageBox.Show($"Кликнули на: {childName}");

        //CreateInstance("Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody.NasalFilters");

        CreateInstance("Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.CyberwareChooseMenu.exampleClass");
    }

    static void CreateInstance(string className)
    {
        // Получаем тип класса по имени
        Type type = Type.GetType(className);

        if (type != null)
        {
            // Создаем экземпляр класса с помощью конструктора по умолчанию
            object instance = Activator.CreateInstance(type);

            MessageBox.Show("OK");
            // Если нужно, можно использовать instance для дальнейшей работы с объектом
        }
        else
        {
            MessageBox.Show($"Класс с именем {className} не найден.");
        }
    }
}