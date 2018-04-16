using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrsingXMLFile
{
    using System.IO;
    using System.Security;
    using System.Xml.Serialization;

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Salva os dados num ficheiro XML
        private void buttonCreateSaveXml_Click(object sender, EventArgs e)
        {
            try
            {
                Information info = new Information();
                info.Data1 = textBoxData1.Text;
                info.Data2 = textBoxData2.Text;
                info.Data3 = textBoxData3.Text;
                SaveXml.SaveData(info, "data.xml");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // Verifica se existe file e se sim preenche os campos
        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);
                textBoxData1.Text = info.Data1;
                textBoxData2.Text = info.Data2;
                textBoxData3.Text = info.Data3;
            }
        }
    }
}
