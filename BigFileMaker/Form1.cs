using System;
using System.IO;
using System.Windows.Forms;

namespace BigFileMaker
{
    public partial class BigFileMaker : Form
    {
        public BigFileMaker()
        {
            InitializeComponent();
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            const int blockSize = 1024 * 8;
            const int blocksPerMb = (1024 * 1024) / blockSize; //MB size
            const int blocksPerGb = (1024 * 1024 * 1024) / blockSize; //GB size

            byte[] data = new byte[blockSize];
            Random rand = new Random();

            SaveFileDialog save = new SaveFileDialog(); //save file dialog box
            save.Filter = "Text File|*.txt|BIN|*.bin"; //save as Text File or Binary

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName; //save file path to string

                /* On OK, it creates and saves a text file based on user selected size and location.
                 * If the Gigabyte radio button is checked create it in Gigabytes,
                 * else create it using the default check of Megabytes
                */
                using (FileStream stream = File.OpenWrite(path))
                {
                    if (radioButtonGb.Checked)
                    {
                        for (int i = 0; i < sizeUpDown.Value * blocksPerGb; i++)
                        {
                            rand.NextBytes(data);
                            stream.Write(data, 0, data.Length);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < sizeUpDown.Value * blocksPerMb; i++)
                        {
                            rand.NextBytes(data);
                            stream.Write(data, 0, data.Length);
                        }
                    }
                    
                }
            }

        }
    }
}