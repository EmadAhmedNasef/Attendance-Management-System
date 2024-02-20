using Attendence_Management.PAL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace Attendence_Management.NewFolder.Forms
{
    public partial class FormLogin : Form
    {
        private const string XmlFilePath = @"C:\Users\Nasef\Desktop\Project\XML\authontication.xml";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoadXmlData();
        }
        private void LoadXmlData()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                // Create the schema set and add the schema file
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add("", @"C:\Users\Nasef\Desktop\Project\XML\autontication.xsd");

                // Create the validation settings
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = schemaSet;

                // Set the validation event handler
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);

                // Create the XML reader
                XmlReader reader = XmlReader.Create(XmlFilePath, settings);

                // Read the XML file (this will trigger the validation)
                while (reader.Read()) { }

                // Close the reader
                reader.Close();

                // Now you can access the XML data and populate your form controls
                XmlNodeList nodeList = xmlDoc.SelectNodes("/authentication/user");

                foreach (XmlNode node in nodeList)
                {
                    string username = node.SelectSingleNode("username").InnerText;
                    string password = node.SelectSingleNode("password").InnerText;
                    string role = node.SelectSingleNode("role").InnerText;

                    // Here, you can use the username, password, and role values
                    // to populate your form controls
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            MessageBox.Show("XML validation error: " + e.Message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Assuming textBoxUsername is the TextBox where the user enters their username
            string enteredUsername = textBoxName.Text;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                XmlNode userNode = xmlDoc.SelectSingleNode($"/authentication/user[username='{enteredUsername}']");
                if (userNode != null)
                {
                    string password = userNode.SelectSingleNode("password").InnerText;

                    // Create an instance of FormForgetPassword and pass the username and password
                    FormForgetPassword formForgetPassword = new FormForgetPassword(enteredUsername, password);
                    if (formForgetPassword.ShowDialog() == DialogResult.OK)
                    {
                        // Retrieve the updated username and password from the form
                        enteredUsername = formForgetPassword.Username;
                        password = formForgetPassword.Password;

                        // Update the text boxes with the new values
                        textBoxName.Text = enteredUsername;
                        textBoxPassword.Text = password;
                    }
                }
                else
                {
                    MessageBox.Show("Username not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBoxName.Text;
            string enteredPassword = textBoxPassword.Text;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                XmlNodeList userList = xmlDoc.SelectNodes("/authentication/user");

                foreach (XmlNode userNode in userList)
                {
                    string username = userNode.SelectSingleNode("username").InnerText;
                    string password = userNode.SelectSingleNode("password").InnerText;

                    if (enteredUsername == username && enteredPassword == password)
                    {
                        // Username and password match, login successful
                        string role = userNode.SelectSingleNode("role").InnerText;

                        if (role == "Teacher")
                        {
                            this.Hide();
                            FormTeacher formTeacher = new FormTeacher(enteredUsername, role);
                            formTeacher.ShowDialog();
                            return;
                        }
                        else
                        {
                            // Handle login for other roles (e.g., admin, student)
                            MessageBox.Show($"Login successful! Role: {role}");
                        }
                        return;
                    }
                }

                // If no matching username and password found
                MessageBox.Show("Invalid username or password.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
