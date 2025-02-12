using Cyberpunk2020GameEntities;
using Cyberpunk2020GameEntities.Cybernetics.CustomCybernetics;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;
using Cyberpunk2020GameEntities.Equipments.CustomEquipment;
using System;

namespace Cyberpunk2020CharacterManagerWindowsApp.ChosseMenu.AddCustomImplantMenus;

internal partial class AddCustomImplantMenu : Form
{
    Form1 _form1;
    private Button addButton;
    private TextBox nameTextBox;
    private Label label1;
    private TextBox descriptionTextBox;
    private Label label2;
    private Label label3;
    private NumericUpDown costNumericUpDown;
    private NumericUpDown humanityLossNumericUpDown;
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
        humanityLossNumericUpDown = new NumericUpDown();
        label4 = new Label();
        buyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)costNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)humanityLossNumericUpDown).BeginInit();
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
        // humanityLossNumericUpDown
        // 
        humanityLossNumericUpDown.Location = new Point(793, 13);
        humanityLossNumericUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
        humanityLossNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        humanityLossNumericUpDown.Name = "humanityLossNumericUpDown";
        humanityLossNumericUpDown.Size = new Size(215, 23);
        humanityLossNumericUpDown.TabIndex = 7;
        humanityLossNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(656, 15);
        label4.Name = "label4";
        label4.Size = new Size(131, 15);
        label4.TabIndex = 8;
        label4.Text = "Потеря человечности:";
        // 
        // buyButton
        // 
        buyButton.Location = new Point(951, 197);
        buyButton.Name = "buyButton";
        buyButton.Size = new Size(75, 23);
        buyButton.TabIndex = 9;
        buyButton.Text = "Купить";
        buyButton.UseVisualStyleBackColor = true;
        buyButton.Click += buyButton_Click;
        // 
        // AddCustomImplantMenu
        // 
        ClientSize = new Size(1038, 261);
        Controls.Add(buyButton);
        Controls.Add(label4);
        Controls.Add(humanityLossNumericUpDown);
        Controls.Add(costNumericUpDown);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(descriptionTextBox);
        Controls.Add(label1);
        Controls.Add(nameTextBox);
        Controls.Add(addButton);
        Name = "AddCustomImplantMenu";
        Text = "Добавить свой имплант";
        ((System.ComponentModel.ISupportInitialize)costNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)humanityLossNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    public AddCustomImplantMenu(Form1 form1, Character character)
    {
        _form1 = form1;
        _character = character;

        InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        var customImplant = new CustomCybernetic()
        { 
            Description = descriptionTextBox.Text,
            Cost = (int)costNumericUpDown.Value,
            HumanityLoss = (int)humanityLossNumericUpDown.Value

        };
        customImplant.SetName(nameTextBox.Text);

        customImplant.ChipIn(_character, new Random());

        _form1.CyberwareAdded();
        this.Close();
    }

    private void buyButton_Click(object sender, EventArgs e)
    {
        //CustomEquipment customEquipment = new CustomEquipment()
        //{
        //    Description = descriptionTextBox.Text,
        //    Cost = (float)costNumericUpDown.Value,
        //    Quantity = (int)humanityLossNumericUpDown.Value

        //};
        //customEquipment.SetName(nameTextBox.Text);

        //customEquipment.Buy(_character, new Random());
        //_form1.EquipmentChanged();
        ////_character.equipments.Add(customEquipment);
        //this.Close();
    }
}
