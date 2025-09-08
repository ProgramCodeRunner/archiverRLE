using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isCancelled;
        private bool isBreak;
        private bool deleteResultFile;

        private void Pack_File_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            string filename = openFileDialog.FileName;
            textBox_Pack_IN.Text = filename;
        }

        private void UnPack_File_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            string filename = openFileDialog.FileName;
            textBox_UnPack_IN.Text = filename;
        }

        private void Pack_File_Path_OUT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.ShowDialog();

            string filename = openFolderDialog.SelectedPath;
            textBox_Pack_OUT.Text = filename+"\\output.pip";
        }

        private void UnPack_File_Path_Out_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.ShowDialog();

            string filename = openFolderDialog.SelectedPath;
            textBox_UnPack_OUT.Text = filename + "\\unzipped.txt";
        }

        private void Clear_Pack_Click(object sender, EventArgs e)
        {
            textBox_Pack_IN.Text = "Путь к файлу";
            textBox_Pack_OUT.Text = "Путь сохранения файла";
        }

        private void Clear_UnPack_Click(object sender, EventArgs e)
        {
            textBox_UnPack_IN.Text = "Путь к файлу";
            textBox_UnPack_OUT.Text = "Путь сохранения файла";
        }

        private void Pack_Click(object sender, EventArgs e)
        {
            if (textBox_Pack_IN.Text == "Путь к файлу" || textBox_Pack_OUT.Text == "Путь сохранения файла" || textBox_Pack_IN.Text == "" || textBox_Pack_OUT.Text == "")
            {
                MessageBox.Show("Ошибка! Поля пустые! Пожалуйста, задайте путь. ", "Ууупс... кажется поля пусты...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isCancelled = false;
                deleteResultFile = false;

                string fileDetroy = textBox_Pack_OUT.Text;
                string fileSource = textBox_Pack_IN.Text;
                using (FileStream sr = new FileStream(fileSource, FileMode.Open))
                {

                    string fileResult = fileDetroy;
                    using (FileStream dest = new FileStream(fileResult, FileMode.OpenOrCreate))
                    {
                        progressBar.Value = 0;
                        int firstByte = sr.ReadByte();
                        int count;
                        int theByte;
                        List<byte> buffer = new List<byte>();

                        int counter = 0;
                        while ((theByte = sr.ReadByte()) != -1)
                        {
                            counter++;
                            if (counter % 10 == 0)
                            {
                                Application.DoEvents();

                                double progress = ((double)counter) * 100 / sr.Length;
                                if (progress < 100)
                                {
                                    progressBar.Value = (int)progress;
                                }
                            }

                            if (isCancelled)
                            {
                                deleteResultFile = true;
                                break;
                            }

                            if (firstByte == theByte)
                            {
                                count = 1;
                                do
                                {
                                    count++;
                                    firstByte = sr.ReadByte();
                                } while (firstByte == theByte);

                                dest.WriteByte((byte)count);
                                dest.WriteByte((byte)theByte);

                                continue;

                            }

                            buffer.Add((byte)firstByte);
                            buffer.Add((byte)theByte);
                            count = 2;
                            while (true)
                            {
                                firstByte = sr.ReadByte();

                                if (firstByte != buffer[count - 1])
                                {
                                    count++;
                                    buffer.Add((byte)firstByte);
                                }
                                else
                                {
                                    sr.Seek(-1, SeekOrigin.Current);
                                    break;
                                }

                                if (firstByte == -1)
                                {
                                    break;
                                }
                            }
                            dest.WriteByte(0);
                            dest.WriteByte((byte)(count - 1));
                            dest.Write(buffer.ToArray(), 0, count - 1);
                            buffer.Clear();
                        }
                        progressBar.Value = 100;
                    }
                }

                if (deleteResultFile)
                {
                    File.Delete(fileDetroy);
                }
            }
        }

        private void Unpack_Click(object sender, EventArgs e)
        {
            if (textBox_UnPack_IN.Text == "Путь к файлу" || textBox_UnPack_OUT.Text == "Путь сохранения файла" || textBox_UnPack_IN.Text == "" || textBox_UnPack_OUT.Text == "")
            {
                MessageBox.Show("Ошибка! Поля пустые! Пожалуйста, задайте путь. ", "Ууупс... кажется поля пусты...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isCancelled = false;
                deleteResultFile = false;

                string fileDetroy = textBox_UnPack_OUT.Text;
                string fileSource = textBox_UnPack_IN.Text;

                using (FileStream sr = new FileStream(fileSource, FileMode.Open))
                {
                    progressBar.Value = 0;
                    string fileResult = fileDetroy;
                    using (FileStream dest = new FileStream(fileResult, FileMode.OpenOrCreate))
                    {
                        int theByte; //a
                        int secondByte; //b

                        int counter = 0;
                        while ((theByte = sr.ReadByte()) != -1)
                        {
                            counter += 6;
                            if (counter % 10 == 0)
                            {
                                Application.DoEvents();

                                double progress = ((double)counter) * 100 / sr.Length;
                                if (progress < 100)
                                {
                                    progressBar.Value = (int)progress;
                                }
                            }

                            if (isCancelled)
                            {
                                deleteResultFile = true;
                                break;
                            }

                            if (theByte != 0)
                            {
                                secondByte = sr.ReadByte();
                                for (int i = 0; i < theByte; i++)
                                {
                                    dest.WriteByte((byte)secondByte);
                                }
                                continue;
                            }
                            theByte = sr.ReadByte();
                            for (int i = 0; i < theByte; i++)
                            {
                                secondByte = sr.ReadByte();
                                dest.WriteByte((byte)secondByte);
                            }
                        }
                        progressBar.Value = 100;
                    }
                }
                if (deleteResultFile)
                {
                    File.Delete(fileDetroy);
                }
            }
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            isCancelled = true;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (textBox_Pack_IN.Text == "Путь к файлу" || textBox_UnPack_OUT.Text == "Путь сохранения файла" || textBox_Pack_IN.Text == "" || textBox_UnPack_OUT.Text == "")
            {
                MessageBox.Show("Ошибка! Поля пустые! Пожалуйста, задайте путь. ", "Ууупс... кажется поля пусты...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isCancelled = false;
                isBreak = false;
                string fileInput = textBox_Pack_IN.Text;
                string fileOutput = textBox_UnPack_OUT.Text;

                using (FileStream sr = new FileStream(fileInput, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (FileStream sr2 = new FileStream(fileOutput, FileMode.Open, FileAccess.ReadWrite))
                    {
                        progressBar.Value = 0;
                        int ByteInput;
                        int ByteOutput;

                        int counter = 0;
                        while ((ByteInput = sr.ReadByte()) != -1)
                        {
                            counter += 6;
                            if (counter % 10 == 0)
                            {
                                Application.DoEvents();
                                double progress = ((double)counter) * 100 / sr.Length;
                                if (progress < 100)
                                {
                                    progressBar.Value = (int)progress;
                                }
                            }

                            if (isCancelled)
                            {
                                break;
                            }

                            if (ByteInput != (ByteOutput = sr2.ReadByte()))
                            {
                                MessageBox.Show("ОШИБКА АРХИВАЦИИ, ФАЙЛЫ ОТЛИЧАЮТСЯ", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                isBreak = true;
                                break;
                            }
                        }
                        if (progressBar.Value < 100 && !isBreak)
                        {
                            progressBar.Value = 100;
                        }

                        if (!isBreak)
                        {
                            MessageBox.Show("ФАЙЛЫ ПРОВЕРЕНЫ, ОНИ ОДИНАКОВЫ! ", "Проверка закончилась успехом!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
