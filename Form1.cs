using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Threading;
using System.Diagnostics;
using NAudio.Lame;

namespace Convertio_Wave
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Adding items to the comboboxes
            fromBox.Items.Add("MP3");
            fromBox.Items.Add("WAV");

            toBox.Items.Add("MP3");
            toBox.Items.Add("WAV");
        }

        // Convert Button
        private void convertButtonClick(object sender, EventArgs e)
        {

            try
            {
                // MP3 to WAV format
                if (fromBox.SelectedIndex == 0 && toBox.SelectedIndex == 1)
                {
                    // Taking the mp3 file from the Open Dialog Box & storing into 'mp3' object
                    using (Mp3FileReader mp3 = new Mp3FileReader(inputBox.Text))
                    {
                        // Converting the MP3 format into WAV format & storing it into 'pcm' object
                        using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                        {
                            // Saving the WAV file to the save path
                            WaveFileWriter.CreateWaveFile(outputBox.Text, pcm);

                            // Error & Success Message
                            if (outputBox.Text == "Select Path" || outputBox.Text == null)
                            {
                                MessageBox.Show("You haven't configured a save path!", "Error");
                            }
                            else
                            {
                                MessageBox.Show("Successfully converted from MP3 to WAV format!", "Done");
                            }
                        }
                    }
                }

                // WAV to MP3 format
                else if (fromBox.SelectedIndex == 1 && toBox.SelectedIndex == 0)
                {
                    // Taking the WAV format file & storing into a variable
                    using (var rdr = new WaveFileReader(inputBox.Text))
                    {
                        // Setting the presets and configuring the save path for the converted file
                        using (var wtr = new LameMP3FileWriter(outputBox.Text, rdr.WaveFormat, LAMEPreset.VBR_90))
                        {
                            // Converting into MP3 format
                            rdr.CopyTo(wtr);

                            // Error & Success Message
                            if (outputBox.Text == "Select Path" || outputBox.Text == null)
                            {
                                MessageBox.Show("You haven't configured a save path!", "Error");
                            }
                            else
                            {
                                MessageBox.Show("Successfully converted from WAV to MP3 format!", "Done");
                            }
                        }
                    }
                }

                // Other error & success messages
                else if (fromBox.SelectedIndex == 0 && toBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Can't convert from MP3 to MP3!", "Error");
                }

                else if (fromBox.SelectedIndex == 1 && toBox.SelectedIndex == 1)
                {
                    MessageBox.Show("Can't convert from WAV to WAV!", "Error");
                }

                else if (fromBox.SelectedIndex == -1 || toBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Select formats to convert!", "Error");
                }
            }

            // Error message while no file is selected for conversion
            catch (FileNotFoundException)
            {
                MessageBox.Show("Select a file to convert!", "Error");
            }

        }


        // Opens the file selection dialog box
        private void inputBoxButtonClick(object sender, EventArgs e)
        {
            // For MP3 to WAV
            if (fromBox.SelectedIndex == 0 && toBox.SelectedIndex == 1)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "MP3 File (*.mp3)|*.mp3;";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    inputBox.Text = open.FileName;
                }
            }

            // For WAV to MP3
            else if (fromBox.SelectedIndex == 1 && toBox.SelectedIndex == 0)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "WAV File (*.wav)|*.wav;";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    inputBox.Text = open.FileName;
                }
            }

        }

        // Opens the save path dialog box
        private void outputBoxButtonClick(object sender, EventArgs e)
        {
            // For MP3 to WAV
            if (fromBox.SelectedIndex == 0 && toBox.SelectedIndex == 1)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "WAV File (*.wav)|*.wav;";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    outputBox.Text = save.FileName;
                }
            }

            // For WAV to MP3
            else if (fromBox.SelectedIndex == 1 && toBox.SelectedIndex == 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "MP3 File (*.mp3)|*.mp3;";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    outputBox.Text = save.FileName;
                }
            }
        }
    }
}
