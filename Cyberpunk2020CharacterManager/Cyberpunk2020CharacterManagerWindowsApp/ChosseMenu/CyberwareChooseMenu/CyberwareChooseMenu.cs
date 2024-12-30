using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.CyberwareChooseMenu;

internal partial class CyberwareChooseMenu : Form
{
    Form1 _form1;
    private TreeView AvaliableCyberWareTreeView;
    Character _character;

    public CyberwareChooseMenu(Form1 form1, Character character)
    {
        InitializeComponent();
        _form1 = form1;
        _character = character;

        RenderTree();
    }

    private Button add_chosen_cyberware_button;

    private void InitializeComponent()
    {
        add_chosen_cyberware_button = new Button();
        AvaliableCyberWareTreeView = new TreeView();
        SuspendLayout();
        // 
        // add_chosen_cyberware_button
        // 
        add_chosen_cyberware_button.Location = new Point(12, 582);
        add_chosen_cyberware_button.Name = "add_chosen_cyberware_button";
        add_chosen_cyberware_button.Size = new Size(423, 23);
        add_chosen_cyberware_button.TabIndex = 0;
        add_chosen_cyberware_button.Text = "Добавить выбранное кибероснащение";
        add_chosen_cyberware_button.UseVisualStyleBackColor = true;
        add_chosen_cyberware_button.Click += add_chosen_cyberware_button_Click;
        // 
        // AvaliableCyberWareTreeView
        // 
        AvaliableCyberWareTreeView.Location = new Point(12, 47);
        AvaliableCyberWareTreeView.Name = "AvaliableCyberWareTreeView";
        AvaliableCyberWareTreeView.Size = new Size(260, 529);
        AvaliableCyberWareTreeView.TabIndex = 1;
        // 
        // CyberwareChooseMenu
        // 
        ClientSize = new Size(447, 617);
        Controls.Add(AvaliableCyberWareTreeView);
        Controls.Add(add_chosen_cyberware_button);
        Name = "CyberwareChooseMenu";
        Text = "Добавление кибероснашения";
        ResumeLayout(false);
    }

    private void add_chosen_cyberware_button_Click(object sender, EventArgs e)
    {
        _character.BodyParts.Add(new NasalFilters());

        _form1.CyberwareAdded();
        this.Close();
    }
}
