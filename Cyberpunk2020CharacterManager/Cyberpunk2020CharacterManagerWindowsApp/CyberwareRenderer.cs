using Cyberpunk2020GameEntities.Cybernetics;

namespace Cyberpunk2020CharacterManagerWindowsApp;

public partial class Form1 : Form
{
    Control RenderCyberwarePanel(BodyPart part, int i)
    {
        int g = 14;
        int text_size = 180;
        int extra_size = 60;

        int HumanilyLossLabelMargin = 180;
        int HumanilyLossLabelSize = 25;

        Panel CyberwarePanel = new Panel();
        _panels.Add(CyberwarePanel);
        tabPage2.Controls.Add(CyberwarePanel);

        Label NamePanel = new()
        {
            Size = new Size(text_size, g)
        };

        CyberwarePanel.Controls.Add(NamePanel);
        CyberwarePanel.Size = new Size(extra_size + text_size, g);
        
        NamePanel.Text = part.Name;
        CyberwarePanel.Location = new Point(0, i * g);

        CyberwarePanel.Controls.Add(new Label()
        {
            Location = new Point(HumanilyLossLabelMargin, 0),
            Text = part.HumanityLoss.ToString(),
            Size = new Size(HumanilyLossLabelSize, g)
        }
            );

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
