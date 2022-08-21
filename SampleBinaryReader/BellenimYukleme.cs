using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SampleBinaryReader
{
    public partial class BellenimYukleme : Form
    {
        public BellenimYukleme()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd;
        string seciliDosyaAdi;
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            seciliDosyaAdi = DosyaAc(".mcs Dosyası Aç", this.GetInitialDirtectory(), "bin files (*.bin)|*.bin|mcs files (*.mcs)|*.mcs|All files (*.*)|*.*", "*.mcs");
            this.tbFileName.Text = this.seciliDosyaAdi;
        }
        public static string DosyaAc(string baslik, string initialDirectory, string filtre, string defaultFileExtension)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogInvoker ofdDosyaSec = new DialogInvoker();
            DialogResult dr;
            ofdDosyaSec.InvokeDialog.RestoreDirectory = true;//İlk önce hangi dizinde dosya açıldıysa 2.de de orada açılmak için
            ofdDosyaSec.InvokeDialog.Title = baslik;
            ofdDosyaSec.InvokeDialog.Filter = filtre;
            ofdDosyaSec.InvokeDialog.DefaultExt = defaultFileExtension;
            ofdDosyaSec.InvokeDialog.InitialDirectory = initialDirectory;
            dr = ofdDosyaSec.Invoke();
            if (dr == DialogResult.OK)
                return (ofdDosyaSec.InvokeDialog.FileName);
            else
                return (initialDirectory);
        }

        string initialDirectory = "";
        private string GetInitialDirtectory()
        {
            if (initialDirectory == "")
                return Directory.GetCurrentDirectory();
            else
                return initialDirectory;
        }

        FileStream readStream;
        FileStream writeStream;
        BinaryReader binaryReader;
        BinaryWriter bw;
        StreamReader sr;
        char[] streamReaderBytes = new char[1024];
        private void btnGonder_Click(object sender, EventArgs e)
        {
            /*
            #region Stream Reader
            sr = new StreamReader(this.seciliDosyaAdi);
            sr.Read(streamReaderBytes, 0, 1024);
            #endregion
             */
            
            #region Binary Reader
            //writeStream = new FileStream("F:\\Ceken\\Aselsan\\SampleBinaryReader\\SampleBinaryReader\\bin\\Debug\\sample1.bin", FileMode.Open, FileAccess.Write , FileShare.ReadWrite);
            readStream = new FileStream(this.seciliDosyaAdi, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            binaryReader = new BinaryReader(readStream);
            //bw = new BinaryWriter(writeStream);
            //1024-byte oku
            //string hexString = binaryReader.ReadByte(1024);

            //The string in the file should be preceded by a 7-bit encoded length
            //Reads a string from the current stream. The string is prefixed with the length, encoded as an integer seven bits at a time.
            //first byte is considered to be the length
            //string hexString = binaryReader.ReadString();
            //hexString = binaryReader.ReadString();
            byte[] chunk = binaryReader.ReadBytes(1024);
            string s = BitConverter.ToString(chunk);
            string result = System.Text.Encoding.UTF8.GetString(chunk);

            byte[] ba = ToByteArray(result);

            //okunan 1024-byte lık veriler, hex-encoded stringler ise

            //bw.Write(chunk);
            //bw.Flush();

            binaryReader.Close();
            #endregion
        }
        /// <summary>
        /// Hex formatlı hexString string'ini byte[] e çevirir
        /// </summary>
        /// <param name="hexString">byte[]'e çevrilecek string</param>
        /// <returns></returns>
        public static byte[] ToByteArray(String hexString)
        {
            if (hexString.Contains("0x"))
                hexString = hexString.Substring(2);
            int numberChars = hexString.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
