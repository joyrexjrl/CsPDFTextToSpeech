using System;
using System.IO;
using System.Windows.Forms;

namespace Bed_Time_Story
{
    public partial class AddNotes : Form
    {
        string _notesPath = Path.Combine(Application.StartupPath, "Data", "notes.txt");

        public AddNotes()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadNotes();
        }

        void NotesBackButton_Click(object sender, EventArgs e) => Close();

        void notesSaveButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_notesPath));
            File.WriteAllText(_notesPath, notesTextbox.Text);
            MessageBox.Show("Note saved successfully.", "Saved");
            Close();
        }

        void LoadNotes()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_notesPath));
            if (File.Exists(_notesPath))
            {
                notesTextbox.Text = File.ReadAllText(_notesPath);
                MessageBox.Show("Notes loaded successfully.", "Load Complete");
            }
            else
            {
                File.WriteAllText(_notesPath, string.Empty);
                notesTextbox.Text = string.Empty;
                MessageBox.Show("No notes file found. A new one has been created.", "File Created");
            }
        }
    }
}
