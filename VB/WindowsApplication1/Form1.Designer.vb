Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.skinnedStandardButton2 = New WindowsApplication1.SkinnedStandardButton()
			Me.skinnedStandardButton1 = New WindowsApplication1.SkinnedStandardButton()
			Me.SuspendLayout()
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.Location = New System.Drawing.Point(403, 22)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(89, 21)
			Me.checkBox1.TabIndex = 2
			Me.checkBox1.Text = "UseSkins"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' skinnedStandardButton2
			' 
			Me.skinnedStandardButton2.Location = New System.Drawing.Point(44, 84)
			Me.skinnedStandardButton2.Name = "skinnedStandardButton2"
			Me.skinnedStandardButton2.Size = New System.Drawing.Size(265, 31)
			Me.skinnedStandardButton2.TabIndex = 1
			Me.skinnedStandardButton2.Text = "skinnedStandardButton2"
			Me.skinnedStandardButton2.UseSkins = False
			' 
			' skinnedStandardButton1
			' 
			Me.skinnedStandardButton1.Location = New System.Drawing.Point(44, 12)
			Me.skinnedStandardButton1.Name = "skinnedStandardButton1"
			Me.skinnedStandardButton1.Size = New System.Drawing.Size(265, 31)
			Me.skinnedStandardButton1.TabIndex = 0
			Me.skinnedStandardButton1.Text = "skinnedStandardButton1"
			Me.skinnedStandardButton1.UseSkins = True
'			Me.skinnedStandardButton1.Click += New System.EventHandler(Me.skinnedStandardButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(543, 309)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.skinnedStandardButton2)
			Me.Controls.Add(Me.skinnedStandardButton1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents skinnedStandardButton1 As SkinnedStandardButton
		Private skinnedStandardButton2 As SkinnedStandardButton
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox


	End Class
End Namespace

