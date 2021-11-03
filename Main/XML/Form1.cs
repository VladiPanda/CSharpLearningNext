using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

// XML СЕРИАЛИЗАЦИЯ.

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Тип для Сериализации и Десериализации.
        readonly XmlSerializer _serializer = new XmlSerializer(typeof(MyClass));

        MyClass _instance1 = new MyClass();
        MyClass _instance2;


        // СЕРИАЛИЗАЦИЯ.
        private void SerializeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                _instance1.Items.Add("Element " + i); // Заполнение списка.
            }

            FileStream stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write, FileShare.Read);

            // Сохраняем объект в XML-файле на диске(СЕРИАЛИЗАЦИЯ).
            _serializer.Serialize(stream, _instance1);
            this.Text = "Объект сериализован!";
            stream.Close();
        }


        // ДЕСЕРИАЛИЗАЦИЯ.
        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

                // Восстанавливаем объект из XML-файла.
                _instance2 = _serializer.Deserialize(stream) as MyClass;
                this.Text = "Объект Десериализован!";


                textBox.Text = "ID        : " + _instance2.ID + Environment.NewLine +
                                "Size     : " + _instance2.Size + Environment.NewLine +
                                "Position : " + _instance2.Position.ToString() + Environment.NewLine +
                                "List     : " + Environment.NewLine;

                foreach (string item in _instance2.Items)
                {
                    textBox.Text += "\t" + item + Environment.NewLine;
                }

                textBox.Text += "Password: " + _instance2.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}