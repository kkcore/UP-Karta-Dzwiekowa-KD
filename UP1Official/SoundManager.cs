using System;
using System.Text;
using System.Runtime.InteropServices;
using WMPLib;
namespace UP1Official
{
    class SoundManager
    {
        // Funkcja playsound zimportowana z winmm.DLL
        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        public static extern bool PlaySound(string szSound, IntPtr hMod, PlaySoundFlags flags);

        // Funkcja mciSendString zimportowana z winmm.DLL
        [DllImport("winmm.dll")]

        private static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);
        // Obiekt WindowsMediaPlayer do obslugiwania funkcjonalnosci
        // zwiazanymi z Windows Media Player
        private static WindowsMediaPlayer mediaPlayer = null;
        // Wlasciwosc, ktora kiedy jest false to oznacza ze mediaPlayer nie gra,
        // a kiedy ma wartosc true to gra.
        private static bool isPlayerPlaying = false;

        // Wlasciwosci wspomagajace dzialanie funkcji
        private static string MciFileName { get; set; }
        public static string RecordFileName { get; set; }
        //Struktura waveHDR przepisana z dokumentacji winmm.dll
        public struct WaveHdr
        {
            public IntPtr lpData;
            public int dwBufferLength;
            public int dwBytesRecorded;
            public IntPtr dwUser;
            public int dwFlags;
            public int dwLoops;
            public IntPtr lpNext;
            public IntPtr reserved;
        }

        // Flagi do funkcji PlaySound
        [Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }
        // Funkcja zatrzymujaca odtwarzanie WindowsMediaPlayer
        public static void StopWMP()
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.controls.stop();
            }
            isPlayerPlaying = false;
        }
        //Funkcja rozpoczynajaca odtwarzanie za pomoca Windows Media Player
        public static void StartWMP(string fileName)
        {
            if (!String.IsNullOrWhiteSpace(fileName))
            {
                if (isPlayerPlaying == true)
                {
                    StopWMP();
                    mediaPlayer.close();
                }
                mediaPlayer = new WindowsMediaPlayer
                {
                    URL = fileName
                };
                mediaPlayer.controls.play();
                isPlayerPlaying = true;
            }
        }
        // Funkcja odtwarzajaca dzwiek za pomoca funkcji mciSendString
        public static void MciPlay(string fileName)
        {
            mciSendString("open \"" + fileName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play " + fileName + " from 0", null, 0, IntPtr.Zero);
            MciFileName = fileName;
        }

        // Funkcja zatrzymujaca dzwiek puszczony za pomoca komendy mciSendString
        public static void MciStop()
        {
            if (!String.IsNullOrEmpty(MciFileName))
            {
                mciSendString("play " + MciFileName + " from 0", null, 0, IntPtr.Zero);
                MciFileName = null;
            }
        }

        // Funkcja nagrywajaca mikrofon za pomoca mciSendString
        public static void MciRecord(string fileName)
        {
            mciSendString($"set {fileName} time format ms", null, 0, IntPtr.Zero);
            mciSendString($"open new Type waveaudio Alias {fileName}", null, 0, IntPtr.Zero);
            mciSendString($"record {fileName}", null, 0, IntPtr.Zero);
            RecordFileName = fileName;
        }
        // Funkcja zatrzymujaca nagrywanie
        public static void StopRecording()
        {
            if (!String.IsNullOrWhiteSpace(RecordFileName))
            {
                mciSendString($"save {RecordFileName} C:\\Users\\oszust\\{RecordFileName}.wav", null, 0, IntPtr.Zero);
                mciSendString($"close {RecordFileName}", null, 0, IntPtr.Zero);
                RecordFileName = null;
            }
        }
    }
}
