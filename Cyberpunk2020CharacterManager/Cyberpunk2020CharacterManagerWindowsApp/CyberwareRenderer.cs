using Cyberpunk2020GameEntities.Cybernetics;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    private int _cyberwareRenderCount = 2;

    Control RenderCyberwarePanel(BodyPart part, int i, int childGrade = 0)
    {
        int g = 14;
        int text_size = 180;
        int extra_size = 60;

        int HumanilyLossLabelSize = 25;
        int CostLabelSize = 80;

        Panel CyberwarePanel = new Panel();
        _panels.Add(CyberwarePanel);
        tabPage2.Controls.Add(CyberwarePanel);

        CyberwarePanel.Size = new Size(extra_size + text_size + CostLabelSize + HumanilyLossLabelSize, g);
        CyberwarePanel.Location = new Point(0, i * g);

        CyberwarePanel.Controls.Add(
        new Label()
        {
            Size = new Size(text_size, g),
            Text = part.Name //+ " " + part.BodyPlace()
        });

        CyberwarePanel.Controls.Add(new Label()
        {
            Location = new Point(text_size, 0),
            Text = part.HumanityLoss.ToString(),
            Size = new Size(HumanilyLossLabelSize, g)
        });

        CyberwarePanel.Controls.Add(new Label()
        {
            Location = new Point(text_size + HumanilyLossLabelSize, 0),
            Text = part.Cost.ToString(),
            Size = new Size(CostLabelSize, g)
        });

        return CyberwarePanel;
    }

    void RenderCyberwares(int s, int l)
    {
        if (_chosenCharacter is null)
        {
            return;
        }

        ShowHumanity();

        renderCyberwaresHierarchically();

        //var count = 2;
        //foreach (var part in from part in _chosenCharacter.BodyParts
        //                     where part.IsImplant
        //                     select part)
        //{
        //    RenderCyberwarePanel(part, count++);
        //}


        //for (int i = 0; i < _chosenCharacter.BodyParts.Count; i++)
        //{
        //    RenderCyberwarePanel(_chosenCharacter.BodyParts[i], i + 2);
        //}
    }

    private void renderCyberwaresHierarchically()
    {
        var rootCyberwares = (from part in _chosenCharacter.BodyParts
                                       where part.BodyPlace == new Guid()
                                       select part);
        _cyberwareRenderCount = 2;
        foreach (var rootCyberware in rootCyberwares)
        {
            //RenderCyberwarePanel(rootCyberware, count++, 0);
            renderCyberwareAndChildren(rootCyberware);
        }
    }

    private void renderCyberwareAndChildren(BodyPart bodyPart, int childGrade = 0)
    {
        RenderCyberwarePanel(bodyPart, _cyberwareRenderCount++, childGrade);
        var children = _chosenCharacter.GetChildBodyParts(bodyPart.Guid);
        foreach (var child in children)
        {
            renderCyberwareAndChildren(child, childGrade + 1);
        }
    }
}
