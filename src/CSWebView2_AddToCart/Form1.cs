using System.Windows.Forms;

namespace CSWebView2_AddToCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = Properties.Resources.Url;
        }

        async void InitializeAsync()
        {
            await this.webView2.EnsureCoreWebView2Async(null);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.InitializeAsync();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.textBox1.Enabled = false;
            this.button1.Enabled = false;
            this.webView2.Source = new System.Uri(this.textBox1.Text);
        }

        private void webView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            var source = this.webView2.Source.ToString().ToLower();
            if (source == this.textBox1.Text.ToLower())
            {
                this.webView2.ExecuteScriptAsync(Properties.Resources.AddToCart);
            }
        }
    }
}
