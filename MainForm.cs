using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.Diagnostics;
using System.Drawing;
using Microsoft.Win32;
using System.Runtime.InteropServices;



namespace RMBackground
{
    public partial class MainForm : Form
    {
        const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public MainForm()
        {
            InitializeComponent();
            ClearFolder($"Temp");
            if (IsWindowsDarkMode())
            {
                if (SystemInformation.UserInteractive)
                {
                    this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    this.ForeColor = System.Drawing.Color.White;
                    SubColorPanel.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
                    DragDropInstructionLABEL.ForeColor = System.Drawing.Color.FromArgb(97, 97, 97);
                    PANELFinalQuickActions.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);


                    int darkMode = 1; // Enable dark mode
                    DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkMode, sizeof(int));

                    // Set the custom title bar color
                    int color = ColorTranslator.ToWin32(Color.Black); // Convert Color to Win32 color
                    DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref color, sizeof(int));
                }
            }
        }

        private void SetDarkTitleBar()
        {
            int darkMode = 1;  // 1 pour activer, 0 pour désactiver
            DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkMode, sizeof(int));

            int captionColor = Color.Black.ToArgb();
            DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref captionColor, sizeof(int));
            
        }

        static bool IsWindowsDarkMode()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
            {
                if (key != null)
                {
                    object value = key.GetValue("AppsUseLightTheme");
                    if (value != null)
                    {
                        return (int)value == 0;
                    }
                }
            }
            return false;
        }

        private void InputFileDraggerPANEL_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (ImageValidator.IsValidImage(file))
                {
                    OperationLoadingPANEL.Visible = true;
                    string APIkey = GetApiKey();
                    ImagePathVALUE.Text = '"' + file + '"';

                    string Args = $"--api-key {APIkey} --output-directory {Path.Combine(Directory.GetCurrentDirectory(), "Temp")} {ImagePathVALUE.Text}";

                    ProcessLauncher.RunExecutableAsync("removebg.exe", Args, this);
                }
                else
                {
                    MessageBox.Show($"This file is not a photo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InputFileDraggerPANEL_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public static string GetApiKey()
        {
            if (File.Exists("APIKey.yaml"))
            {
                string yamlContent = File.ReadAllText("APIKey.yaml");

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();

                var data = deserializer.Deserialize<Dictionary<string, string>>(yamlContent);

                if (data != null && data.ContainsKey("API_Key"))
                {
                    return data["API_Key"];
                }
            }
            return string.Empty;
        }

        public static class ProcessLauncher
        {
            public static async Task RunExecutableAsync(string exePath, string arguments, MainForm form)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = exePath,
                            Arguments = arguments,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            CreateNoWindow = true
                        };

                        Process process = new Process { StartInfo = psi };
                        process.Start();

                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        process.WaitForExit(); 

                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show($"The script at the heart of this application (removebg.exe) returned this error : {error}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            form.Invoke(new Action(() => form.OperationLoadingPANEL.Visible = false));
                            form.Invoke(new Action(() => form.FinalImagePreview.Visible = true));
                            form.Invoke(new Action(() => form.AfterOperating()));
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The error '{ex.Message}' was produced when launching the script to remove the background from your image", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class FileHelper
        {
            public static string GetPngFileInTempDirectory()
            {
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string tempDirectory = Path.Combine(exeDirectory, "Temp");

                if (Directory.Exists(tempDirectory))
                {
                    string[] pngFiles = Directory.GetFiles(tempDirectory, "*.png");

                    if (pngFiles.Length == 1)
                    {
                        return pngFiles[0];
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

                return string.Empty; 
            }
        }

        static void ClearFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    File.Delete(file);
                }

                foreach (string dir in Directory.GetDirectories(folderPath))
                {
                    Directory.Delete(dir, true);
                }
            }
            else
            {
                Directory.CreateDirectory($"Temp");
            }
        }



        public void AfterOperating()
        {
            string pngFilePath = FileHelper.GetPngFileInTempDirectory();
            string newName = "temp.png";
            string newPath = Path.Combine(Path.GetDirectoryName(pngFilePath), newName);

            File.Move(pngFilePath, newPath);
            PICBOXFinalPreviewer.Image = Image.FromFile($"Temp/temp.png");
        }

        private void BTNSaveImage_Click(object sender, EventArgs e)
        {
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                string source = "Temp/temp.png";
                string destination = SaveDialog.FileName;
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(destination));
                    File.Copy(source, destination, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error : {ex.Message}");
                }
            }
        }

        private void BTNCopyImage_Click(object sender, EventArgs e)
        {
            CopyImageToClipboard(PICBOXFinalPreviewer.Image);
        }

        static void CopyImageToClipboard(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                DataObject data = new DataObject();
                data.SetData("PNG", false, ms);
                Clipboard.SetDataObject(data, true);
            }
        }
    }
}
