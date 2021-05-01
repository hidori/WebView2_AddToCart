Public Class Form1
    Sub New()
        InitializeComponent()
        Me.textBox1.Text = My.Resources.Url
    End Sub

    Async Sub InitializeAsync()
        Await Me.WebView2.EnsureCoreWebView2Async(Nothing)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeAsync()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.textBox1.Enabled = False
        Me.button1.Enabled = False
        Me.webView2.Source = New Uri(Me.textBox1.Text)
    End Sub

    Private Sub webView2_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles webView2.NavigationCompleted
        Dim source As String = Me.webView2.Source.ToString().ToLower()
        If source = Me.textBox1.Text.ToLower() Then
            Me.webView2.ExecuteScriptAsync(My.Resources.AddToCart)
        End If
    End Sub
End Class
