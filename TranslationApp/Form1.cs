using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TranslationApp
{
    public partial class Form1 : Form
    {
        // MyMemory Translation API 
        private string apiUrl = "https://api.mymemory.translated.net/get";

        // Desteklenen diller
        private Dictionary<string, string> languages = new Dictionary<string, string>
        {
            {"English", "en"},
            {"Turkish", "tr"},
            {"German", "de"},
            {"French", "fr"},
            {"Spanish", "es"},
            {"Italian", "it"},
            {"Russian", "ru"},
            {"Arabic", "ar"},
            {"Chinese", "zh"},
            {"Japanese", "ja"},
            {"Korean", "ko"},
            {"Portuguese", "pt"},
            {"Dutch", "nl"},
            {"Polish", "pl"},
            {"Greek", "el"},
            {"Hebrew", "he"},
            {"Hindi", "hi"}
        };

        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(30);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            LoadLanguages();

            
            SetDefaultLanguages();
        }

        private void LoadLanguages()
        {
            cmbSourceLang.Items.Clear();
            cmbTargetLang.Items.Clear();

            foreach (var language in languages.Keys)
            {
                cmbSourceLang.Items.Add(language);
                cmbTargetLang.Items.Add(language);
            }
        }

        private void SetDefaultLanguages()
        {
            if (cmbSourceLang.Items.Count > 0)
                cmbSourceLang.SelectedIndex = 0; // English

            if (cmbTargetLang.Items.Count > 1)
                cmbTargetLang.SelectedIndex = 1; // Turkish
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            await TranslateText();
        }

        private async Task TranslateText()
        {
            // Validasyon
            if (!ValidateInput())
                return;

            try
            {
                // UI güncelleme
                SetUIState(false);

                // Çeviri işlemi
                string translatedText = await TranslateWithMyMemoryAPI(
                    txtSourceText.Text.Trim(),
                    languages[cmbSourceLang.SelectedItem.ToString()],
                    languages[cmbTargetLang.SelectedItem.ToString()]
                );

                // Sonucu göster
                txtTranslatedText.Text = translatedText;

                // Başarılı mesajı
                if (!string.IsNullOrEmpty(translatedText))
                {
                    lblStatus.Text = "Çeviri başarılı!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Çeviri hatası: {ex.Message}");
                txtTranslatedText.Text = "Çeviri başarısız oldu.";
            }
            finally
            {
                // UI'ı eski haline getir
                SetUIState(true);
            }
        }

        private bool ValidateInput()
        {
            // Metin kontrolü
            if (string.IsNullOrWhiteSpace(txtSourceText.Text))
            {
                MessageBox.Show("Lütfen çevrilecek metni giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSourceText.Focus();
                return false;
            }

            // Dil seçimi kontrolü
            if (cmbSourceLang.SelectedItem == null || cmbTargetLang.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kaynak ve hedef dilleri seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Aynı dil kontrolü
            if (cmbSourceLang.SelectedIndex == cmbTargetLang.SelectedIndex)
            {
                MessageBox.Show("Kaynak ve hedef diller aynı olamaz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Metin uzunluğu kontrolü (MyMemory için max ~500 karakter)
            if (txtSourceText.Text.Length > 500)
            {
                MessageBox.Show("Metin çok uzun! Maksimum 500 karakter girebilirsiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SetUIState(bool isEnabled)
        {
            btnTranslate.Enabled = isEnabled;
            btnTranslate.Text = isEnabled ? "Çevir" : "Çevriliyor...";
            Cursor = isEnabled ? Cursors.Default : Cursors.WaitCursor;
            lblStatus.Text = isEnabled ? "Hazır" : "Çeviri yapılıyor...";
            lblStatus.ForeColor = System.Drawing.Color.Blue;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblStatus.Text = "Hata oluştu!";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }

        private async Task<string> TranslateWithMyMemoryAPI(string text, string sourceLang, string targetLang)
        {
            try
            {
                // URL encode
                string encodedText = Uri.EscapeDataString(text);
                string url = $"{apiUrl}?q={encodedText}&langpair={sourceLang}|{targetLang}&de=user@example.com";

                // HTTP isteği gönder
                var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API hatası: {response.StatusCode}");
                }

                // Yanıtı oku ve parse et
                string responseJson = await response.Content.ReadAsStringAsync();
                return ParseTranslationResponse(responseJson);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"İnternet bağlantı hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Çeviri işlemi sırasında hata: {ex.Message}");
            }
        }

        private string ParseTranslationResponse(string jsonResponse)
        {
            try
            {
                // JSON'ı parse et
                var json = JObject.Parse(jsonResponse);

                // Yanıt durumunu kontrol et
                int responseStatus = json["responseStatus"].Value<int>();

                if (responseStatus == 200)
                {
                    string translatedText = json["responseData"]?["translatedText"]?.ToString() ?? "";

                    
                    translatedText = System.Net.WebUtility.HtmlDecode(translatedText);

                    return translatedText;
                }
                else
                {
                    string errorDetails = json["responseDetails"]?.ToString() ?? "Bilinmeyen hata";
                    throw new Exception(errorDetails);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Yanıt işleme hatası: {ex.Message}");
            }
        }

        private void btnSwapLanguages_Click(object sender, EventArgs e)
        {
            SwapLanguages();
        }

        private void SwapLanguages()
        {
            if (cmbSourceLang.SelectedItem != null && cmbTargetLang.SelectedItem != null)
            {
                // Dilleri değiştir
                int sourceIndex = cmbSourceLang.SelectedIndex;
                cmbSourceLang.SelectedIndex = cmbTargetLang.SelectedIndex;
                cmbTargetLang.SelectedIndex = sourceIndex;

                // Metinleri de değiştir
                string tempText = txtSourceText.Text;
                txtSourceText.Text = txtTranslatedText.Text;
                txtTranslatedText.Text = tempText;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtSourceText.Clear();
            txtTranslatedText.Clear();
            lblStatus.Text = "Hazır";
            lblStatus.ForeColor = System.Drawing.Color.Black;
        }

        private void txtSourceText_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl+Enter ile çeviri yap
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TranslateText();
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            // Status label'a tıklandığında son durumu göster
            MessageBox.Show($"Kaynak dil: {cmbSourceLang.SelectedItem}\nHedef dil: {cmbTargetLang.SelectedItem}\nMetin uzunluğu: {txtSourceText.Text.Length}", "Durum Bilgisi");
        }
    }
}