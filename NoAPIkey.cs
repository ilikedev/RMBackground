using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace RMBackground
{
    public partial class NoAPIkey : Form
    {
        public NoAPIkey()
        {
            InitializeComponent();
        }

        private void NoAPIkey_Load(object sender, EventArgs e)
        {

        }

        private void LNKTXTCreateRMVBGACC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://accounts.kaleido.ai/users/sign_up";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }

        private void LNKTXTCreateKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.remove.bg/dashboard#api-key";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }

        private void BTNretry_Click(object sender, EventArgs e)
        {
            string yamlFilePath = "APIKey.yaml";
            var data = new Deserializer().Deserialize<Dictionary<string, object>>(File.ReadAllText(yamlFilePath));

            if (data.ContainsKey("API_Key"))
                data["API_Key"] = TXTBOXapiKey.Text;

            File.WriteAllText(yamlFilePath, new Serializer().Serialize(data));


            this.Hide(); // Masque NoAPIkey temporairement
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close(); // Ferme NoAPIkey après MainForm
            mainForm.Show();
        }
    }
}
