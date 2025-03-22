using Cyberpunk2020GameEntities.Cybernetics;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    private int _cyberwareRenderCount = 2;

    Control RenderCyberwarePanel(BodyPart part, int i, int childGrade = 0)
    {
        int g = 14;
        int text_size = 280;
        int extra_size = 160;
        int gap_size = 50;

        int size_for_child_grade = childGrade * 20;

        int HumanilyLossLabelSize = 25;
        int CostLabelSize = 80;

        Panel CyberwarePanel = new Panel();
        _panels.Add(CyberwarePanel);
        tabPage2.Controls.Add(CyberwarePanel);

        CyberwarePanel.Size = new Size(gap_size+size_for_child_grade + extra_size + text_size + CostLabelSize + HumanilyLossLabelSize, g);
        CyberwarePanel.Location = new Point(0, i * g);

        CyberwarePanel.Controls.Add(
        new Label()
        {
            Size = new Size(text_size, g),
            Location = new Point(size_for_child_grade, 0),
            Text = part.Name //+ " " + part.BodyPlace()
        });

        CyberwarePanel.Controls.Add(new Label()
        {
            Location = new Point(text_size+ gap_size, 0),
            Text = part.HumanityLoss.ToString(),
            Size = new Size(HumanilyLossLabelSize, g)
        });

        CyberwarePanel.Controls.Add(new Label()
        {
            Location = new Point(text_size + gap_size + HumanilyLossLabelSize, 0),
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
    }

    private void renderCyberwaresHierarchically()
    {
        foreach (var panel in _panels)
        {
            tabPage2.Controls.Remove(panel);
        }
        _panels.Clear();

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
        var hidden = shouldBodyPartBeHidden(bodyPart);
        var nextChildGrade = childGrade;
        if (!hidden)
        {
            RenderCyberwarePanel(bodyPart, _cyberwareRenderCount++, childGrade);
            nextChildGrade = childGrade + 1;
        }
        var children = _chosenCharacter.GetChildBodyParts(bodyPart.Guid);
        foreach (var child in children)
        {
            renderCyberwareAndChildren(child, nextChildGrade);
        }
    }

    static private bool shouldBodyPartBeHidden(BodyPart bodyPart)
    {
        if(bodyPart is Implant)
        {
            return false;
        }

        if (bodyPart is LimbSlot) { 
            var limbSlot = bodyPart as LimbSlot;
            if (limbSlot.HasQuickMount)
            {
                return false;
            }
        }

        return true;
    }
}
