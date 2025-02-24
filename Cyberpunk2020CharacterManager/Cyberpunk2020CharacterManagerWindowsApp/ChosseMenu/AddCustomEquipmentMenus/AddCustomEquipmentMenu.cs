using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Equipments.CustomEquipment;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.AddCustomEquipmentMenus;

internal partial class AddCustomEquipmentMenu : Form
{
    Form1 _form1;
    private Button addButton;
    private TextBox nameTextBox;
    private Label label1;
    private TextBox descriptionTextBox;
    private Label label2;
    private Label label3;
    private NumericUpDown costNumericUpDown;
    private NumericUpDown quantityNumericUpDown;
    private Label label4;
    private Button buyButton;
    Character _character;

    private void InitializeComponent()
    {
        addButton = new Button();
        nameTextBox = new TextBox();
        label1 = new Label();
        descriptionTextBox = new TextBox();
        label2 = new Label();
        label3 = new Label();
        costNumericUpDown = new NumericUpDown();
        quantityNumericUpDown = new NumericUpDown();
        label4 = new Label();
        buyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)costNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // addButton
        // 
        addButton.Location = new Point(951, 226);
        addButton.Name = "addButton";
        addButton.Size = new Size(75, 23);
        addButton.TabIndex = 0;
        addButton.Text = "Добавить";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(80, 12);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(273, 23);
        nameTextBox.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(62, 15);
        label1.TabIndex = 2;
        label1.Text = "Название:";
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(80, 52);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(865, 197);
        descriptionTextBox.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 52);
        label2.Name = "label2";
        label2.Size = new Size(65, 15);
        label2.TabIndex = 4;
        label2.Text = "Описание:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(359, 20);
        label3.Name = "label3";
        label3.Size = new Size(70, 15);
        label3.TabIndex = 5;
        label3.Text = "Стоимость:";
        // 
        // costNumericUpDown
        // 
        costNumericUpDown.Location = new Point(435, 15);
        costNumericUpDown.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
        costNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        costNumericUpDown.Name = "costNumericUpDown";
        costNumericUpDown.Size = new Size(215, 23);
        costNumericUpDown.TabIndex = 6;
        costNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // quantityNumericUpDown
        // 
        quantityNumericUpDown.Location = new Point(779, 12);
        quantityNumericUpDown.Maximum = new decimal(new int[] { 268435456, 1042612833, 542101086, 0 });
        quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        quantityNumericUpDown.Name = "quantityNumericUpDown";
        quantityNumericUpDown.Size = new Size(215, 23);
        quantityNumericUpDown.TabIndex = 7;
        quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(703, 17);
        label4.Name = "label4";
        label4.Size = new Size(75, 15);
        label4.TabIndex = 8;
        label4.Text = "Количество:";
        // 
        // buyButton
        // 
        buyButton.Location = new Point(951, 197);
        buyButton.Name = "buyButton";
        buyButton.Size = new Size(75, 23);
        buyButton.TabIndex = 9;
        buyButton.Text = "Купить";
        buyButton.UseVisualStyleBackColor = true;
        buyButton.Click += this.buyButton_Click;
        // 
        // AddCustomEquipmentMenu
        // 
        ClientSize = new Size(1038, 261);
        Controls.Add(buyButton);
        Controls.Add(label4);
        Controls.Add(quantityNumericUpDown);
        Controls.Add(costNumericUpDown);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(descriptionTextBox);
        Controls.Add(label1);
        Controls.Add(nameTextBox);
        Controls.Add(addButton);
        Name = "AddCustomEquipmentMenu";
        Text = "Добавить свой элемент снаряжения";
        ((System.ComponentModel.ISupportInitialize)costNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    public AddCustomEquipmentMenu(Form1 form1, Character character)
    {
        _form1 = form1;
        _character = character;

        InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        CustomEquipment customEquipment = new CustomEquipment()
        { 
            Description = descriptionTextBox.Text,
            Cost = (float)costNumericUpDown.Value,
            Quantity = (int)quantityNumericUpDown.Value

        };
        customEquipment.SetName(nameTextBox.Text);

        customEquipment.Add(_character, new Random());
        _form1.EquipmentChanged();
        //_character.equipments.Add(customEquipment);
        this.Close();
    }

    private void buyButton_Click(object sender, EventArgs e)
    {
        CustomEquipment customEquipment = new CustomEquipment()
        {
            Description = descriptionTextBox.Text,
            Cost = (float)costNumericUpDown.Value,
            Quantity = (int)quantityNumericUpDown.Value

        };
        customEquipment.SetName(nameTextBox.Text);

        customEquipment.Buy(_character, new Random());
        _form1.EquipmentChanged();
        //_character.equipments.Add(customEquipment);
        this.Close();
    }
}
