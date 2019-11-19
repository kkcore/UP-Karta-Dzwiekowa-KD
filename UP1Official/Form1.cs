using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace UP1Official
{
    public partial class Form1 : Form
    {
        // Nazwa pliku do odtwarzania
        public string fileName { get; set; }

        // Nazwa pliku do nagrywania
        public string recordedFileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            recordedFileName = "recsound";
        }

        // Wybieranie pliku do odtworzenia
        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Wybierz plik dzwiekowy .wav",
                InitialDirectory = @".",
                Filter = "Wav Files (*.wav)|*.wav",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                fileNameTextbox.Text = dialog.FileName;
            }
        }

        // Przycisk odtwarzajacy dzwiek za pomoca funkcji PlaySound
        private void PlaySoundBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileName))
            {
                SoundManager.PlaySound(fileName, new IntPtr(), SoundManager.PlaySoundFlags.SND_ASYNC);
            }
        }

        // Przycisk zatrzymujacy odtwarzanie dzwieku puszczonego za pomoca funkcji PlaySound
        private void StopPlaySoundBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileName))
            {
                SoundManager.PlaySound(null, new IntPtr(), SoundManager.PlaySoundFlags.SND_SYNC);
            }
        }
        // Po nacisnieciu tego przycisku pojawia sie dane dotyczace naglowka pliku .wav
        private void WavDataBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileName))
            {
                byte[] wavFile = File.ReadAllBytes(fileName);
                byte[] wavHeader = new byte[44];
                for (int i = 0; i < 44; i++)
                {
                    wavHeader[i] = wavFile[i];
                }
                string riffDescription = "";
                for (int i = 0; i < 4; i++)
                {
                    riffDescription += Encoding.ASCII.GetString(new byte[1] { wavHeader[i] });
                }
                string sizeOfFileBytes = "";
                for (int i = 7; i >= 4; i--)
                {
                    sizeOfFileBytes += Convert.ToString(Convert.ToInt32(wavHeader[i]), 2);
                }
                string waveDescription = "";
                for (int i = 8; i < 12; i++)
                {
                    waveDescription += Encoding.ASCII.GetString(new byte[1] { wavHeader[i] });
                }
                string fmtDescription = "";
                for (int i = 12; i < 16; i++)
                {
                    fmtDescription += Encoding.ASCII.GetString(new byte[1] { wavHeader[i] });
                }
                string lengthOfFormatData = "";
                for (int i = 16; i < 20; i++)
                {
                    lengthOfFormatData += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string typesOfFormatData = "";
                for (int i = 20; i < 22; i++)
                {
                    typesOfFormatData += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string numbersOfChannel = "";
                for (int i = 22; i < 24; i++)
                {
                    numbersOfChannel += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string sampleRate = "";
                for (int i = 24; i < 28; i++)
                {
                    sampleRate += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string sampleRateWithOtherThings = "";
                for (int i = 28; i < 32; i++)
                {
                    sampleRateWithOtherThings += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string blockAlign = "";
                for (int i = 32; i < 34; i++)
                {
                    blockAlign += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string bitsPerSample = "";
                for (int i = 34; i < 36; i++)
                {
                    bitsPerSample += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string dataSubChunk = "";
                for (int i = 36; i < 40; i++)
                {
                    dataSubChunk += Convert.ToInt32(wavHeader[i]).ToString();
                }
                string sizeOfDataSection = "";
                for (int i = 40; i < 42; i++)
                {
                    sizeOfDataSection += Convert.ToInt32(wavHeader[i]).ToString();
                }
                List<string> stringsList = new List<string>();
                stringsList.Add($"Opis RIFF. (bity 0-3): {riffDescription}");
                stringsList.Add($"Rozmiar pliku (bity 4- 7): {sizeOfFileBytes}");
                stringsList.Add($"Opis WAV (bity 8- 11): {waveDescription}");
                stringsList.Add($"Opis FMT (bity 12-15): {fmtDescription}");
                stringsList.Add($"Długosc formatu (bity 16-19): {lengthOfFormatData}");
                stringsList.Add($"Typy formatu (bity 20-21): {typesOfFormatData}");
                stringsList.Add($"Liczba kanałow (bity 22-23): {numbersOfChannel}");
                stringsList.Add($"Sample rate (bity 24-27): {sampleRate}");
                stringsList.Add($"Byte rate (bity 28-31): {sampleRateWithOtherThings}");
                stringsList.Add($"Wyrownanie bloku (bity 32-33): {blockAlign}");
                stringsList.Add($"Bity na probke (bity 34-35): {bitsPerSample}");
                stringsList.Add($" 'data chunk', rozpoczyna sekcje danych w pliku .wav (bity 36-39): {dataSubChunk}");
                stringsList.Add($" Rozmiar sekcji danych (bity 40-41): {sizeOfDataSection}");
                string textboxString = "";
                foreach (string text in stringsList)
                {
                    textboxString += text + System.Environment.NewLine;
                }
                wavTextBox.Text = textboxString;
            }
        }
        // Przycisk uruchamiajacy odtwarzanie dzwieku za pomoca MCI
        private void MciPlayBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileName))
            {
                SoundManager.MciPlay(fileName);
            }
        }
        // Przycisk zatrzymujacy odtwarzanie MCI
        private void StopMCIBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileName))
            {
                SoundManager.MciStop();
            }
        }

        // Przycisk rozpoczynajacy nagrywanie za pomoca funkcji mciSendString
        private void RecordButton_Click(object sender, EventArgs e)
        {
            SoundManager.MciRecord(recordedFileName);
        }

        // Przycisk zatrzymujacy nagrywanie
        private void StopRecordBtn_Click(object sender, EventArgs e)
        {
            SoundManager.StopRecording();
        }

        // Przycisk zatrzymujacy odtwarzanie dzwieku za pomoca Windows Media Player
        private void StopWMPBtn_Click(object sender, EventArgs e)
        {
            SoundManager.StopWMP();
        }

        // Przycisk rozpoczynajacy odtwarzanie dzwieku za pomoca Windows Media Player
        private void StartWMPBtn_Click(object sender, EventArgs e)
        {
            SoundManager.StartWMP(fileName);
        }

        // Aktualizowanie wlasciwosci recordedFileName, kiedy zmieni sie tekst w textBoxie.
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            recordedFileName = textBox1.Text;
        }
    }
}
