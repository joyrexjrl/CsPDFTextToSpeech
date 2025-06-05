using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;

using PdfPigDoc = UglyToad.PdfPig.PdfDocument;
using PdfiumDoc = PdfiumViewer.PdfDocument;

namespace Bed_Time_Story
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer _synthesizer = new SpeechSynthesizer();
        PdfiumDoc _loadedDocument;
        int _totalPages = 0;
        int _currentCharIndex = 0;
        int _lastKnownCharIndex = 0;
        string _fullTextToRead = "";
        string _filePath = "";
        bool _isPaused = false;

        public Form1()
        {
            InitializeComponent();
            loadedPdfTotalPageLabel.Text = "";
            playButton.Enabled = false;
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            clearTextButton.Enabled = false;
            darkModeCheckbox.Checked = true;

            PopulateVoiceOptions();

            customTextCheckBox.CheckedChanged += customTextCheckBox_CheckedChanged;
            displayPdfTextbox.TextChanged += displayPdfTextbox_TextChanged;
            _synthesizer.SpeakCompleted += Synthesizer_SpeakCompleted;
        }

        void exitButton_Click(object sender, EventArgs e) => Close();

        async void loadPdfButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "FDP files (*.pdf)|*.pdf";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    if (customTextCheckBox.Checked)
                    {
                        customTextCheckBox.Checked = false;
                        displayPdfTextbox.Text = "";
                    }
                    _filePath = dialog.FileName;
                    string fileName = Path.GetFileName(_filePath);
                    _loadedDocument?.Dispose();
                    _loadedDocument = PdfiumDoc.Load(_filePath);
                    _totalPages = _loadedDocument.PageCount;

                    loadedPdfTotalPageLabel.Text = $"Max pages: {_totalPages}";
                    loadedPdfTextbox.Text = $"Loaded: {fileName}";

                    if (!HasTextLayer(_filePath)) MessageBox.Show("This PDF does not appear to contain a readable text layer. It may be an image-only scan.");

                    await pdfWebBrowser.EnsureCoreWebView2Async(null);
                    pdfWebBrowser.CoreWebView2.Navigate(new Uri(_filePath).AbsoluteUri);
                    playButton.Enabled = true;
                }
            }            
        }

        string ExtractWithPdfPig(string filePath, int startPage, int endPage)
        {
            var textBuilder = new StringBuilder();
            using (PdfPigDoc document = PdfPigDoc.Open(filePath))
            {
                for (int i = startPage; i <= endPage; i++)
                {
                    var page = document.GetPage(i);
                    var lines = page.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        string trimmed = line.Trim();
                        if (int.TryParse(trimmed, out int num) && num >= startPage && num <= endPage) continue;
                        if (trimmed.ToLower().StartsWith("page ") || trimmed.ToLower().EndsWith("page")) continue;
                        trimmed = Regex.Replace(trimmed, @"(?<![\s.,;:!?])([A-Z])", " $1");
                        textBuilder.Append(trimmed);
                        if (!trimmed.EndsWith(" ")) textBuilder.Append(" ");
                    }
                    textBuilder.AppendLine();
                }
            }
            return textBuilder.ToString();
        }

        bool HasTextLayer(string filePath, int pagesToCheck = 3)
        {
            using (var document = PdfPigDoc.Open(filePath))
            {
                int pages = Math.Min(pagesToCheck, document.NumberOfPages);
                for (int i = 1; i <= pages; i++)
                {
                    var pageText = document.GetPage(i).Text;
                    if (!string.IsNullOrWhiteSpace(pageText)) return true;
                }
            }
            return false;
        }

        void PopulateVoiceOptions()
        {
            voiceSelectCombobox.Items.Clear();
            using (SpeechSynthesizer tempSynth = new SpeechSynthesizer())
            {
                foreach (InstalledVoice voice in tempSynth.GetInstalledVoices())
                {
                    var info = voice.VoiceInfo;
                    voiceSelectCombobox.Items.Add(info.Name);
                }
            }
            if (voiceSelectCombobox.Items.Count > 0) voiceSelectCombobox.SelectedIndex = 0;
        }

        void playButton_Click(object sender, EventArgs e)
        {
            if (customTextCheckBox.Checked)
            {
                _fullTextToRead = displayPdfTextbox.Text;
            }
            else
            {
                if (_loadedDocument == null)
                {
                    MessageBox.Show("Please load a PDF first.");
                    return;
                }

                bool hasStart = int.TryParse(startPageTextbox.Text, out int startPage);
                bool hasEnd = int.TryParse(endPageTextbox.Text, out int endPage);

                if (!hasStart && !hasEnd) _fullTextToRead = ExtractWithPdfPig(_filePath, 1, _totalPages);
                else
                {
                    startPage = hasStart ? Clamp(startPage, 1, _totalPages) : 1;
                    endPage = hasEnd ? Clamp(endPage, startPage, _totalPages) : _totalPages;
                    _fullTextToRead = ExtractWithPdfPig(_filePath, startPage, endPage);
                }
                displayPdfTextbox.Text = _fullTextToRead;
            }

            _currentCharIndex = 0;
            _isPaused = false;

            if (voiceSelectCombobox.SelectedItem != null) _synthesizer.SelectVoice(voiceSelectCombobox.SelectedItem.ToString());

            _synthesizer.Rate = talkSpeedSlider.Value;
            _synthesizer.Volume = talkVolumeSlider.Value;
            _synthesizer.SpeakProgress -= Synthesizer_SpeakProgress;
            _synthesizer.SpeakProgress += Synthesizer_SpeakProgress;
            _synthesizer.SpeakAsync(_fullTextToRead);

            pauseButton.Enabled = true;
            stopButton.Enabled = true;
            talkSpeedSlider.Enabled = false;
            talkVolumeSlider.Enabled = false;
        }


        int Clamp(int value, int min, int max) => (value < min) ? min : (value > max) ? max : value;

        void pauseButton_Click(object sender, EventArgs e)
        {
            if (!_isPaused)
            {
                _synthesizer.Pause();
                _isPaused = true;
                pauseButton.Text = "Unpause";
            }
            else
            {
                _synthesizer.Resume();
                _isPaused = false;
                pauseButton.Text = "Pause";
            }
        }

        void Synthesizer_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            _currentCharIndex = e.CharacterPosition;
            _lastKnownCharIndex = _currentCharIndex;
        }

        void Synthesizer_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            void ResetControls()
            {
                stopButton.Enabled = false;
                pauseButton.Enabled = false;
                pauseButton.Text = "Pause";
                playButton.Enabled = customTextCheckBox.Checked
                    ? !string.IsNullOrWhiteSpace(displayPdfTextbox.Text)
                    : _loadedDocument != null;

                talkSpeedSlider.Enabled = true;
                talkVolumeSlider.Enabled = true;
                _isPaused = false;
                _currentCharIndex = 0;
            }
            if (InvokeRequired) Invoke(new Action(ResetControls));
            else ResetControls();
        }

        void stopButton_Click(object sender, EventArgs e)
        {
            _synthesizer.SpeakAsyncCancelAll();
            _currentCharIndex = 0;
            _isPaused = false;
            pauseButton.Text = "Pause";
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            talkSpeedSlider.Enabled = true;
            talkVolumeSlider.Enabled = true;
        }

        void clearPdfButton_Click(object sender, EventArgs e)
        {
            if (pdfWebBrowser.CoreWebView2 != null) pdfWebBrowser.CoreWebView2.Navigate("about:blank");
            _loadedDocument?.Dispose();
            _loadedDocument = null;
            loadedPdfTextbox.Clear();
            startPageTextbox.Clear();
            endPageTextbox.Clear();            
            loadedPdfTotalPageLabel.Text = "";
            displayPdfTextbox.Text = "";
            _totalPages = 0;
            _fullTextToRead = "";
            _currentCharIndex = 0;
            _isPaused = false;
            _synthesizer.SpeakAsyncCancelAll();
            pauseButton.Text = "Pause";
            playButton.Enabled = false;
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            talkSpeedSlider.Enabled = true;
            talkVolumeSlider.Enabled = true;
        }

        void customTextCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            displayPdfTextbox.ReadOnly = !customTextCheckBox.Checked;
            if (customTextCheckBox.Checked)
            {
                displayPdfTextbox.Text = "";
                clearTextButton.Enabled = true;
            }
            else
            {
                displayPdfTextbox.Text = "";
                clearTextButton.Enabled = false;
            }
            UpdatePlayButtonEnabledState();
        }

        void displayPdfTextbox_TextChanged(object sender, EventArgs e) => UpdatePlayButtonEnabledState();

        void UpdatePlayButtonEnabledState()
        {
            if (customTextCheckBox.Checked) playButton.Enabled = !string.IsNullOrWhiteSpace(displayPdfTextbox.Text);
            else playButton.Enabled = _loadedDocument != null;
        }

        void darkModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.SetDarkMode(darkModeCheckbox.Checked);
            ThemeManager.ApplyTheme(this);
        }

        void clearTextButton_Click(object sender, EventArgs e) => displayPdfTextbox.Text = "";

        void openNotesButton_Click(object sender, EventArgs e)
        {
            AddNotes notes = new AddNotes();
            notes.Show();
        }
    }
}
