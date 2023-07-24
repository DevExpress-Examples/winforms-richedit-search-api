Namespace RichUsingSearchAPI

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.richEditControl1.Location = New System.Drawing.Point(12, 12)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(1145, 442)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(510, 471)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(148, 37)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Process Document"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1169, 520)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.richEditControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace
