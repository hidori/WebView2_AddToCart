<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.webView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        CType(Me.webView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webView2
        '
        Me.webView2.CreationProperties = Nothing
        Me.webView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.webView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webView2.Location = New System.Drawing.Point(0, 73)
        Me.webView2.Name = "webView2"
        Me.webView2.Size = New System.Drawing.Size(800, 377)
        Me.webView2.TabIndex = 4
        Me.webView2.ZoomFactor = 1.0R
        '
        'button1
        '
        Me.button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.button1.Location = New System.Drawing.Point(0, 25)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(800, 48)
        Me.button1.TabIndex = 3
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(800, 25)
        Me.textBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.webView2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "VBWebView2_AddToCart"
        CType(Me.webView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents webView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
End Class
