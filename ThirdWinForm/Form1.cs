using System;
using System.IO;
using System.Windows.Forms;

namespace ThirdWinForm
{
    public partial class Form1 : Form
    {
        private const string TxtFilter = "txt files (*.txt)|*.txt";
        private const string SaveFileName = "NewFile";

        private const string EmptyString = "Вы ничего не ввели";

        public Form1()
        {
            InitializeComponent();

            ConfigureStripMenu();
            ConfigureDialog();
        }

        private void ConfigureDialog()
        {
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Filter = TxtFilter;

            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = TxtFilter;
        }

        private void ConfigureDialogFileName()
        {
            saveFileDialog.FileName = SaveFileName;
            openFileDialog.FileName = string.Empty;
        }

        private void ConfigureStripMenu()
        {
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

            ToolStripMenuItem saveFileItem = new ToolStripMenuItem("Сохранить");
            ToolStripMenuItem openFileItem = new ToolStripMenuItem("Открыть");
            ToolStripMenuItem exitFileItem = new ToolStripMenuItem("Закрыть");

            ToolStripMenuItem editItem = new ToolStripMenuItem("Редактировать");

            ToolStripMenuItem insertItem = new ToolStripMenuItem("Вставить");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Удалить");

            openFileItem.Click += OpenFileItem_Click;
            saveFileItem.Click += SaveFileItem_Click;
            exitFileItem.Click += ExitFileItem_Click;
            insertItem.Click += InsertItem_Click;
            deleteItem.Click += DeleteItem_Click;

            fileItem.DropDownItems.Add(saveFileItem);
            fileItem.DropDownItems.Add(openFileItem);
            fileItem.DropDownItems.Add(exitFileItem);

            editItem.DropDownItems.Add(insertItem);
            editItem.DropDownItems.Add(deleteItem);

            menuStrip.Items.Add(fileItem);
            menuStrip.Items.Add(editItem);
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxList.SelectedIndex;
            listBoxList.Items.RemoveAt(listBoxList.SelectedIndex);

            if (selectedIndex == listBoxList.Items.Count)
            {
                selectedIndex--;
            }
            listBoxList.SelectedIndex = selectedIndex;
        }

        private void InsertItem_Click(object sender, EventArgs e)
        {
            if (!IsTextBoxNullOrWhiteSpace())
            {
                listBoxList.Items[listBoxList.SelectedIndex] = textBoxWithText.Text;
            }
        }

        private void ExitFileItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveFileItem_Click(object sender, EventArgs e)
        {
            ConfigureDialogFileName();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog.FileName;

                WriteTextFile(name);
            }
        }

        private void OpenFileItem_Click(object sender, EventArgs e)
        {
            ConfigureDialogFileName();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog.FileName;
                ReadTextFile(name);
                listBoxList.SelectedIndex = 0;
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            if (!IsTextBoxNullOrWhiteSpace())
            {
                listBoxList.Items.Add(textBoxWithText.Text);
                listBoxList.SelectedIndex = listBoxList.Items.Count - 1;
            }
        }

        private void WriteTextFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var item in listBoxList.Items)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private void ReadTextFile(string fileName)
        {
            listBoxList.Items.Clear();
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    listBoxList.Items.Add(sr.ReadLine());
                }
            }
        }

        private bool IsTextBoxNullOrWhiteSpace()
        {
            if (string.IsNullOrWhiteSpace(textBoxWithText.Text))
            {
                errorProvider.SetError(textBoxWithText, EmptyString);
                return true;
            }
            return false;
        }

        private void textBoxWithText_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
