﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        txtnot1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ders ortalamanız = "' 
        ' Button1
        ' 
        Button1.Location = New Point(311, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 72)
        Button1.TabIndex = 1
        Button1.Text = "Kaydet"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtnot1
        ' 
        txtnot1.Location = New Point(311, 117)
        txtnot1.Name = "txtnot1"
        txtnot1.Size = New Size(103, 27)
        txtnot1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtnot1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtnot1 As TextBox
End Class
