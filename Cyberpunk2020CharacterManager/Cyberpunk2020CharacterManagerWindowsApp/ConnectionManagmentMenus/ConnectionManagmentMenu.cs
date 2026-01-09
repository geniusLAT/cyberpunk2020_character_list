using Cyberpunk2020GameEntities;

namespace Cyberpunk2020CharacterManagerWindowsApp.ConnectionManagmentMenus;

internal class ConnectionManagmentMenu : Form
{
    Form1? _form1;

    #region elements
    private Label ipAddressLabel;
    private Label portLabel;
    private Label usernameLabel;
    private Label label1;
    private TextBox ipAddressTextBox;
    private TextBox portTextBox;
    private TextBox usernameTextBox;
    private TextBox passwordTextBox;
    private Button checkConnectionButton;
    private Label checkResultLabel;
    #endregion

    public ConnectionManagmentMenu(Form1 form1)
    {
        InitializeComponent();
        _form1 = form1;
    }

    private void InitializeComponent()
    {
        ipAddressLabel = new Label();
        portLabel = new Label();
        usernameLabel = new Label();
        label1 = new Label();
        ipAddressTextBox = new TextBox();
        portTextBox = new TextBox();
        usernameTextBox = new TextBox();
        passwordTextBox = new TextBox();
        checkConnectionButton = new Button();
        checkResultLabel = new Label();
        SuspendLayout();
        // 
        // ipAddressLabel
        // 
        ipAddressLabel.AutoSize = true;
        ipAddressLabel.Location = new Point(64, 13);
        ipAddressLabel.Name = "ipAddressLabel";
        ipAddressLabel.Size = new Size(54, 15);
        ipAddressLabel.TabIndex = 0;
        ipAddressLabel.Text = "IP адрес:";
        // 
        // portLabel
        // 
        portLabel.AutoSize = true;
        portLabel.Location = new Point(80, 42);
        portLabel.Name = "portLabel";
        portLabel.Size = new Size(38, 15);
        portLabel.TabIndex = 1;
        portLabel.Text = "Порт:";
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Location = new Point(6, 71);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(112, 15);
        usernameLabel.TabIndex = 2;
        usernameLabel.Text = "Имя пользователя:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(66, 100);
        label1.Name = "label1";
        label1.Size = new Size(52, 15);
        label1.TabIndex = 3;
        label1.Text = "Пароль:";
        // 
        // ipAddressTextBox
        // 
        ipAddressTextBox.Location = new Point(124, 5);
        ipAddressTextBox.Name = "ipAddressTextBox";
        ipAddressTextBox.Size = new Size(155, 23);
        ipAddressTextBox.TabIndex = 4;
        // 
        // portTextBox
        // 
        portTextBox.Location = new Point(124, 34);
        portTextBox.Name = "portTextBox";
        portTextBox.Size = new Size(155, 23);
        portTextBox.TabIndex = 5;
        // 
        // usernameTextBox
        // 
        usernameTextBox.Location = new Point(124, 63);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(155, 23);
        usernameTextBox.TabIndex = 6;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(124, 92);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.Size = new Size(155, 23);
        passwordTextBox.TabIndex = 7;
        // 
        // checkConnectionButton
        // 
        checkConnectionButton.Location = new Point(5, 119);
        checkConnectionButton.Name = "checkConnectionButton";
        checkConnectionButton.Size = new Size(274, 23);
        checkConnectionButton.TabIndex = 8;
        checkConnectionButton.Text = "Проверить";
        checkConnectionButton.UseVisualStyleBackColor = true;
        checkConnectionButton.Click += checkConnectionButton_Click;
        // 
        // checkResultLabel
        // 
        checkResultLabel.AutoSize = true;
        checkResultLabel.Location = new Point(6, 145);
        checkResultLabel.Name = "checkResultLabel";
        checkResultLabel.Size = new Size(94, 15);
        checkResultLabel.TabIndex = 9;
        checkResultLabel.Text = "Введите данные";
        // 
        // ConnectionManagmentMenu
        // 
        ClientSize = new Size(284, 261);
        Controls.Add(checkResultLabel);
        Controls.Add(checkConnectionButton);
        Controls.Add(passwordTextBox);
        Controls.Add(usernameTextBox);
        Controls.Add(portTextBox);
        Controls.Add(ipAddressTextBox);
        Controls.Add(label1);
        Controls.Add(usernameLabel);
        Controls.Add(portLabel);
        Controls.Add(ipAddressLabel);
        Name = "ConnectionManagmentMenu";
        Text = "Добавление нового сервера";
        ResumeLayout(false);
        PerformLayout();
    }

    private void checkConnectionButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Проверка соединения");
    }  
}
