using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.CyberwareChooseMenu;

internal partial class CyberwareChooseMenu : Form
{
    Form1 _form1;
    private TreeView AvaliableCyberWareTreeView;
    private Label Implant_Description;
    private Label problem_list_table;
    private ComboBox comboBox1;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyberwareChooseMenu));
        add_chosen_cyberware_button = new Button();
        AvaliableCyberWareTreeView = new TreeView();
        Implant_Description = new Label();
        problem_list_table = new Label();
        comboBox1 = new ComboBox();
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
        // Implant_Description
        // 
        Implant_Description.AutoSize = true;
        Implant_Description.ImageAlign = ContentAlignment.TopLeft;
        Implant_Description.Location = new Point(278, 47);
        Implant_Description.MaximumSize = new Size(155, 300);
        Implant_Description.Name = "Implant_Description";
        Implant_Description.Size = new Size(151, 300);
        Implant_Description.TabIndex = 2;
        Implant_Description.Text = resources.GetString("Implant_Description.Text");
        // 
        // problem_list_table
        // 
        problem_list_table.AutoSize = true;
        problem_list_table.ImageAlign = ContentAlignment.TopLeft;
        problem_list_table.Location = new Point(278, 426);
        problem_list_table.MaximumSize = new Size(155, 150);
        problem_list_table.Name = "problem_list_table";
        problem_list_table.Size = new Size(151, 150);
        problem_list_table.TabIndex = 3;
        problem_list_table.Text = resources.GetString("problem_list_table.Text");
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(278, 359);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(157, 23);
        comboBox1.TabIndex = 4;
        // 
        // CyberwareChooseMenu
        // 
        ClientSize = new Size(447, 617);
        Controls.Add(comboBox1);
        Controls.Add(problem_list_table);
        Controls.Add(Implant_Description);
        Controls.Add(AvaliableCyberWareTreeView);
        Controls.Add(add_chosen_cyberware_button);
        Name = "CyberwareChooseMenu";
        Text = "Добавление кибероснашения";
        ResumeLayout(false);
        PerformLayout();
    }

    private void add_chosen_cyberware_button_Click(object sender, EventArgs e)
    {
        _character.BodyParts.Add(new NasalFilters());

        _form1.CyberwareAdded();
        this.Close();
    }
}
