using System;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml;

namespace Attendence_Management.NewFolder.Forms
{
    internal static class Program
    {
        private const string XmlFilePath = @"C:\Users\Nasef\Desktop\Project\XML\authontication.xml";
        private const string XsdFilePath = @"C:\Users\Nasef\Desktop\Project\XML\autontication.xsd";

        [STAThread]
        static void Main()
        {
            // Validate the XML file against the XSD schema
            if (ValidateXml())
            {
                // If validation succeeds, run the Windows Forms application
                ApplicationConfiguration.Initialize();
                Application.Run(new FormLogin());
            }
            else
            {
                // If validation fails, show an error message and exit the application
                MessageBox.Show("XML validation failed. Application will now exit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool ValidateXml()
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add("", XsdFilePath);
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);

                XmlReader reader = XmlReader.Create(XmlFilePath, settings);
                while (reader.Read()) { }

                reader.Close();
                return true; // Validation succeeded
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Validation failed
            }
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            MessageBox.Show("XML validation error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
