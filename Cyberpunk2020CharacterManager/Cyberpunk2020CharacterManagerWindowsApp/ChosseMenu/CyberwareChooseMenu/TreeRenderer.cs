using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.CyberwareChooseMenu;

internal partial class CyberwareChooseMenu : Form
{
    private void renderTree()
    {
        PopulateTreeView();
    }

    private void PopulateTreeView()
    {
        // Очищаем TreeView перед заполнением
        AvaliableCyberWareTreeView.Nodes.Clear();

        // Создаем 6 корневых элементов
        for (int i = 1; i <= 6; i++)
        {
            TreeNode rootNode = new TreeNode($"Root {i}");

            for (int j = 1; j <= 10; j++)
            {
                TreeNode childNode = new TreeNode($"Child {j}");
                rootNode.Nodes.Add(childNode);
            }

            AvaliableCyberWareTreeView.Nodes.Add(rootNode);
        }

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
        MessageBox.Show($"Кликнули на: {childName}");
    }
}