using Cyberpunk2020GameEntities.Cybernetics;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    Control RenderCyberwarePanel(BodyPart part, int i)
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

        for (int i = 0; i < _chosenCharacter.BodyParts.Count; i++)
        {
            RenderCyberwarePanel(_chosenCharacter.BodyParts[i], i + 2);
        }
    }
}
