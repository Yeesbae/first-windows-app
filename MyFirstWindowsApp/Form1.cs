namespace MyFirstWindowsApp;

public partial class Form1 : Form
{
    private Label myLabel;

    public Form1()
    {
        InitializeComponent();
        // Create a button
        Button myButton = new Button();
        myButton.Text = "Click Me";
        myButton.Location = new System.Drawing.Point(100, 100);
        myButton.Click += new EventHandler(Button_Click); // Attach an event handler

        // Create a label
        myLabel = new Label();
        myLabel.Text = "Hello, Windows Forms!";
        myLabel.Location = new System.Drawing.Point(100, 50);
        myLabel.AutoSize = true;

        // Add the button and label to the form
        this.Controls.Add(myButton);
        this.Controls.Add(myLabel);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        myLabel.Text = "You clicked the button!";
        MessageBox.Show("Button was clicked!");
    }
}
