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
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private NumericUpDown equipmentQuantityNumerucUpDown;
    private Label label1;
    private TrackBar ExtraCostTrackBar;
    private Label ExtraCostLabel;
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
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        equipmentQuantityNumerucUpDown = new NumericUpDown();
        label1 = new Label();
        ExtraCostTrackBar = new TrackBar();
        ExtraCostLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)equipmentQuantityNumerucUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ExtraCostTrackBar).BeginInit();
        SuspendLayout();
        // 
        // add_chosen_cyberware_button
        // 
        add_chosen_cyberware_button.Location = new Point(12, 582);
        add_chosen_cyberware_button.Name = "add_chosen_cyberware_button";
        add_chosen_cyberware_button.Size = new Size(529, 23);
        add_chosen_cyberware_button.TabIndex = 0;
        add_chosen_cyberware_button.Text = "Купить";
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
        Implant_Description.MaximumSize = new Size(268, 260);
        Implant_Description.Name = "Implant_Description";
        Implant_Description.Size = new Size(268, 260);
        Implant_Description.TabIndex = 2;
        Implant_Description.Text = resources.GetString("Implant_Description.Text");
        Implant_Description.Click += Implant_Description_Click;
        // 
        // problem_list_table
        // 
        problem_list_table.AutoSize = true;
        problem_list_table.ImageAlign = ContentAlignment.TopLeft;
        problem_list_table.Location = new Point(278, 439);
        problem_list_table.MaximumSize = new Size(268, 130);
        problem_list_table.Name = "problem_list_table";
        problem_list_table.Size = new Size(268, 130);
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
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Enabled = false;
        radioButton1.Location = new Point(278, 388);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(72, 19);
        radioButton1.TabIndex = 6;
        radioButton1.TabStop = true;
        radioButton1.Text = "Покупка";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Enabled = false;
        radioButton2.Location = new Point(356, 388);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(178, 19);
        radioButton2.TabIndex = 7;
        radioButton2.TabStop = true;
        radioButton2.Text = "Альтернативное получение";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // equipmentQuantityNumerucUpDown
        // 
        equipmentQuantityNumerucUpDown.Enabled = false;
        equipmentQuantityNumerucUpDown.Location = new Point(421, 413);
        equipmentQuantityNumerucUpDown.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
        equipmentQuantityNumerucUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        equipmentQuantityNumerucUpDown.Name = "equipmentQuantityNumerucUpDown";
        equipmentQuantityNumerucUpDown.Size = new Size(120, 23);
        equipmentQuantityNumerucUpDown.TabIndex = 8;
        equipmentQuantityNumerucUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        equipmentQuantityNumerucUpDown.ValueChanged += equipmentQuantityNumerucUpDown_ValueChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(278, 415);
        label1.Name = "label1";
        label1.Size = new Size(75, 15);
        label1.TabIndex = 9;
        label1.Text = "Количество:";
        // 
        // ExtraCostTrackBar
        // 
        ExtraCostTrackBar.Location = new Point(407, 310);
        ExtraCostTrackBar.Name = "ExtraCostTrackBar";
        ExtraCostTrackBar.Size = new Size(134, 45);
        ExtraCostTrackBar.TabIndex = 10;
        ExtraCostTrackBar.Scroll += ExtraCostTrackBar_Scroll;
        // 
        // ExtraCostLabel
        // 
        ExtraCostLabel.AutoSize = true;
        ExtraCostLabel.Location = new Point(279, 321);
        ExtraCostLabel.Name = "ExtraCostLabel";
        ExtraCostLabel.Size = new Size(38, 15);
        ExtraCostLabel.TabIndex = 11;
        ExtraCostLabel.Text = "label2";
        // 
        // InventoryChooseMenu
        // 
        ClientSize = new Size(553, 617);
        Controls.Add(ExtraCostLabel);
        Controls.Add(ExtraCostTrackBar);
        Controls.Add(label1);
        Controls.Add(equipmentQuantityNumerucUpDown);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(potentialParentComboBox);
        Controls.Add(problem_list_table);
        Controls.Add(Implant_Description);
        Controls.Add(AvaliableCyberWareTreeView);
        Controls.Add(add_chosen_cyberware_button);
        Name = "InventoryChooseMenu";
        Text = "Добавление снаряжения";
        ((System.ComponentModel.ISupportInitialize)equipmentQuantityNumerucUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)ExtraCostTrackBar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void add_chosen_cyberware_button_Click(object sender, EventArgs e)
    {
        if (_chosenEquipment is null)
        {
            add_chosen_cyberware_button.Enabled = false;
            this.Close();
            return;
        }

        //var parents = _chosenEquipment.PotentialParents(_character);
        //if (parents is not null)
        //{
        //    _chosenEquipment!.BodyPlace = parents[potentialParentComboBox.SelectedIndex].Guid;
        //}
        if (ExtraCostTrackBar.Enabled)
        {
            _chosenEquipment.Cost = ExtraCostTrackBar.Value;
        }

        if (buingMode)
        {
            _chosenEquipment.Buy(_character, _random);
        }
        else
        {
            _chosenEquipment.Add(_character, _random);
        }

        _form1.EquipmentChanged();
        this.Close();
    }

    private void potentialParentComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Implant_Description_Click(object sender, EventArgs e)
    {

    }

    bool buingMode = true;

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (_chosenEquipment is null) return;
        add_chosen_cyberware_button.Text = "Получить";
        buingMode = false;
        LookForProblemForEquipment(_chosenEquipment);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (_chosenEquipment is null) return;
        add_chosen_cyberware_button.Text = "Купить";
        buingMode = true;
        LookForProblemForEquipment(_chosenEquipment);
    }

    private void equipmentQuantityNumerucUpDown_ValueChanged(object sender, EventArgs e)
    {
        _chosenEquipment.Quantity = (int)equipmentQuantityNumerucUpDown.Value;
        LookForProblemForEquipment(_chosenEquipment);
    }

    private void ExtraCostTrackBar_Scroll(object sender, EventArgs e)
    {
        ExtraCostLabel.Text = $"Цена: {ExtraCostTrackBar.Value}";
        LookForProblemForEquipment(_chosenEquipment);
    }
}
