using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace DPI_BLOCKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bypassaktif = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Task<bool> cmdcalistir(string command)
        {
            var tcs = new TaskCompletionSource<bool>();
            try
            {
                var psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c " + command;
                psi.UseShellExecute = false;
                psi.WindowStyle = ProcessWindowStyle.Minimized;
                var process = new Process();
                process.StartInfo = psi;
                process.EnableRaisingEvents = true;
                process.Exited += (s, e) =>
                {
                    tcs.TrySetResult(true);
                    process.Dispose();
                };

                process.Start();
            }
            catch
            {
                tcs.TrySetResult(false);
            }
            return tcs.Task;
        }


        Process dpibypass = new Process();
        async Task<bool> bypassdurdur()
        {
            label6.Text = "Durum: Kapalý";
            try
            {
                if (dpibypass != null && !dpibypass.HasExited)
                {
                    dpibypass.Kill();
                    dpibypass.Dispose();
                }
            }
            catch { }

            try
            {
                await cmdcalistir("/c taskkill /IM dpibypass.exe /F");
                await cmdcalistir("/c taskkill /IM goodbyedpi.exe /F");
            }
            catch { }
            await Task.Delay(500);
            bypassaktif = false;
            button3.Text = "Baþlat";
            button3.Enabled = true;
            return true;

        }

        async Task<bool> bypassbaslat(string arguman)
        {
            button3.Enabled = false;
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string exePath = Path.Combine(basePath, "dpibypass.exe");

            dpibypass = new Process();
            dpibypass.StartInfo.FileName = exePath;
            dpibypass.StartInfo.Arguments = arguman;
            dpibypass.StartInfo.UseShellExecute = false;
            dpibypass.StartInfo.CreateNoWindow = true;
            dpibypass.StartInfo.WorkingDirectory = basePath;

            dpibypass.Start();
            await Task.Delay(500);
            button3.Text = "Durdur";
            button3.Enabled = true;
            bypassaktif = true;
            return true;
        }
        string fixconf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fixconfig.txt");

        private async Task<bool> TestSiteWebView2(string url, int timeoutSeconds)
        {
            var webView = new WebView2();
            await webView.EnsureCoreWebView2Async();

            bool basarili = false;
            string hata = "";
            webView.NavigationCompleted += (s, e) =>
            {
                if (e.IsSuccess)
                    basarili = true;
                else
                    hata = $"WebError: {e.WebErrorStatus}";
            };

            // Timeout kontrolü
            var cts = new System.Threading.CancellationTokenSource(timeoutSeconds * 1000);
            cts.Token.Register(() =>
            {
                basarili = false;
                hata = "Timeout";
            });

            try
            {
                webView.CoreWebView2.Navigate(url);
                while (!basarili && string.IsNullOrEmpty(hata))
                    await Task.Delay(100, cts.Token);

                if (!string.IsNullOrEmpty(hata))
                {
                    return false;
                }
                webView.Reload();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {

            string hedefSite = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(hedefSite))
            {
                MessageBox.Show("Test edilecek siteyi doðru giriniz. Örn: https://discord.com/ þeklinde ");
                return;
            }
            button1.Enabled = false;
            tabControl1.Enabled = false;
            label4.Text = "Durum: Configler Bekleniyor...";
            string argUrl = "https://raw.githubusercontent.com/Reloxe/DPIBlocker/refs/heads/main/confs.txt";

            using var http = new HttpClient { Timeout = TimeSpan.FromSeconds(8) };
            string raw;
       
            try
            {
                raw = await http.GetStringAsync(argUrl);
            }
            catch (Exception ex)
            {
                label4.Text = "Durum: Configler Yüklenemedi!";
                MessageBox.Show($"Configler Yüklenemedi! \nTekrar Deneyiniz! \n\n\nHata: {ex.Message}");
                return;
            }

            string[] argumanlar = raw.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            bool basarili = false;
            foreach (string arg in argumanlar)
            {
                await bypassdurdur();

                label4.Text = "Durum: Config Etkinleþtiriliyor...";
                string temizArg = arg.Trim();
                if (string.IsNullOrWhiteSpace(temizArg)) continue;
                await Task.Delay(200);
                await bypassbaslat(temizArg);

                await Task.Delay(200);
                label4.Text = "Durum: Yeni Bir Config Etkinleþtirildi. Test ediliyor...";

                bool sonuc = await TestSiteWebView2(hedefSite, (int)numericUpDown1.Value);
                basarili = sonuc;

                if (basarili)
                {
                    await bypassdurdur();
                    tabControl1.Enabled = true;
                    label4.Text = "Durum: Baþarýlý! DPI Blocker Size uygun bir ayar buldu!";
                    MessageBox.Show("Baþarýlý! DPI Blocker Size uygun bir ayar buldu! Baþlat / Durdur Menüsünden direkt baþlatýp sansürsüz interneti kullanabilirsiniz.");
                    File.WriteAllText(fixconf, temizArg);
                    button3.Text = "Baþlat";
                    tabControl1.SelectedIndex = 0;
                    return;
                }
                else
                {
                    label4.Text = "Durum: Config çalýþmadý. Baþka bir config deneniyor...";
                    await bypassdurdur();
                }

            }
            label4.Text = "Durum: Hiçbir config hedef siteyi açmayý baþaramadý. Lütfen Ýletiþime geçiniz: www.nokersoft.com";

            MessageBox.Show("Hiçbir config hedef siteyi açmayý baþaramadý. Lütfen Ýletiþime geçiniz: www.nokersoft.com");
            tabControl1.Enabled = true;
            button1.Enabled = true;

        }

        private async Task button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bypassdurdur();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bypassdurdur();
        }

 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bypassdurdur();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (bypassaktif)
            {
                button3.Enabled = false;
                await bypassdurdur();
                return;
            }
            await bypassdurdur();
            if (!File.Exists(fixconf))
            {
                tabControl1.SelectedIndex = 1;
                MessageBox.Show("Config dosyasý bulunamadý! Lütfen þimdi açýlan menüden eriþim engelli bir sitenin linkini girip baþlata basýnýz. Örn: https://discord.com/ þeklinde");
                return;
            }
            string temizArg = File.ReadAllText(fixconf).Trim();

            if (string.IsNullOrWhiteSpace(temizArg))
            {
                MessageBox.Show("Config dosyasýnýn içi boþ!");
                return;
            }
            button3.Enabled = false;
            button3.Text = "Baþlatýlýyor...";
            if (checkBox1.Checked)
            {
                await cmdcalistir("ipconfig /flushdns");
                await Task.Delay(300);
                await cmdcalistir("ipconfig /release");
                await Task.Delay(300);
                await cmdcalistir("ipconfig /renew");
                await Task.Delay(300);
                await cmdcalistir("nbtstat -R");
                await Task.Delay(300);
                await cmdcalistir("nbtstat -RR");
                await Task.Delay(300);
                await cmdcalistir("netsh winsock reset");
                await Task.Delay(300);
                await cmdcalistir("netsh int ip reset");
                await Task.Delay(300);
            }
            await bypassdurdur();

            bypassbaslat(temizArg);
            label6.Text = "Durum: Aktif";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             cmdcalistir("start www.nokersoft.com");
        }
    }
}
