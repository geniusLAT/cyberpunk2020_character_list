using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.InventoryChooseMenu;

internal partial class InventoryChooseMenu : Form
{
    Form1 _form1;

    private TreeView AvaliableCyberWareTreeView;

    private Label Implant_Description;

    private Label problem_list_table;

    private ComboBox potentialParentComboBox;

    private readonly Character _character;

    private readonly Random _random = new();

    public InventoryChooseMenu(Form1 form1, Character character)
    {
        InitializeComponent();
        _form1 = form1;
        _character = character;

        add_chosen_cyberware_button!.Text = "Назад";

        RenderTree();
    }

    private Button add_chosen_cyberware_button;

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryChooseMenu));
        add_chosen_cyberware_button = new Button();
        AvaliableCyberWareTreeView = new TreeView();
        Implant_Description = new Label();
        problem_list_table = new Label();
        potentialParentComboBox = new ComboBox();
        SuspendLayout();
        // 
        // add_chosen_cyberware_button
        // 
        add_chosen_cyberware_button.Location = new Point(12, 582);
        add_chosen_cyberware_button.Name = "add_chosen_cyberware_button";
        add_chosen_cyberware_button.Size = new Size(529, 23);
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
        // Implant_Description
        // 
        Implant_Description.AutoSize = true;
        Implant_Description.ImageAlign = ContentAlignment.TopLeft;
        Implant_Description.Location = new Point(278, 47);
        Implant_Description.MaximumSize = new Size(268, 300);
        Implant_Description.Name = "Implant_Description";
        Implant_Description.Size = new Size(268, 300);
        Implant_Description.TabIndex = 2;
        Implant_Description.Text = resources.GetString("Implant_Description.Text");
        Implant_Description.Click += Implant_Description_Click;
        // 
        // problem_list_table
        // 
        problem_list_table.AutoSize = true;
        problem_list_table.ImageAlign = ContentAlignment.TopLeft;
        problem_list_table.Location = new Point(278, 426);
        problem_list_table.MaximumSize = new Size(268, 150);
        problem_list_table.Name = "problem_list_table";
        problem_list_table.Size = new Size(268, 150);
        problem_list_table.TabIndex = 3;
        problem_list_table.Text = resources.GetString("problem_list_table.Text");
        // 
        // potentialParentComboBox
        // 
        potentialParentComboBox.FormattingEnabled = true;
        potentialParentComboBox.Location = new Point(278, 359);
        potentialParentComboBox.Name = "potentialParentComboBox";
        potentialParentComboBox.Size = new Size(263, 23);
        potentialParentComboBox.TabIndex = 4;
        potentialParentComboBox.SelectedIndexChanged += potentialParentComboBox_SelectedIndexChanged;
        // 
        // InventoryChooseMenu
        // 
        ClientSize = new Size(553, 617);
        Controls.Add(potentialParentComboBox);
        Controls.Add(problem_list_table);
        Controls.Add(Implant_Description);
        Controls.Add(AvaliableCyberWareTreeView);
        Controls.Add(add_chosen_cyberware_button);
        Name = "InventoryChooseMenu";
        Text = "Добавление снаряжения";
        ResumeLayout(false);
        PerformLayout();
    }

    private void add_chosen_cyberware_button_Click(object sender, EventArgs e)
    {
        if (_chosenImplant is null)
        {
            add_chosen_cyberware_button.Enabled = false;
            this.Close();
            return;
        }

        var parents = _chosenImplant.PotentialParents(_character);
        if (parents is not null)
        {
            _chosenImplant!.BodyPlace = parents[potentialParentComboBox.SelectedIndex].Guid;
        }

        _chosenImplant.ChipIn(_character, _random);

        _form1.CyberwareAdded();
        this.Close();
    }

    private void potentialParentComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Implant_Description_Click(object sender, EventArgs e)
    {

    }
}
