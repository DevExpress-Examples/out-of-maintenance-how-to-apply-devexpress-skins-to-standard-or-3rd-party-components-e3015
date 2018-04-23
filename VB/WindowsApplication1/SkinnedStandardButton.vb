Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System.ComponentModel

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class SkinnedStandardButton
		Inherits Button

		Private _Button As New EditorButton(ButtonPredefines.Glyph)
		Private _Painter As SkinEditorButtonPainter
		Public Sub New()
			_Painter = CreatePainter()
		End Sub

		Private _UseSkins As Boolean = True
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
		Public Property UseSkins() As Boolean
			Get
				Return _UseSkins
			End Get
			Set(ByVal value As Boolean)
				_UseSkins = value
				Refresh()
			End Set
		End Property


		Protected Overridable Function CreatePainter() As SkinEditorButtonPainter
			Return New SkinEditorButtonPainter(UserLookAndFeel.Default)
		End Function

		Private Function GetObjectState() As ObjectState
			Dim location As Point = PointToScreen(New Point(0, 0))
			Dim mouseInButton As Boolean = New Rectangle(location, New Size(Width, Height)).Contains(Control.MousePosition)
			If (Not mouseInButton) OrElse DesignMode Then
				Return ObjectState.Normal
			End If
			If Control.MouseButtons = MouseButtons.Left Then
				Return ObjectState.Pressed
			Else
				Return ObjectState.Hot
			End If
		End Function
		Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
			If UseSkins Then
				Dim args As New EditorButtonObjectInfoArgs(New GraphicsCache(pevent.Graphics), _Button, AppearanceObject.EmptyAppearance)
				args.Bounds = New Rectangle(0, 0, Width, Height)
				args.BuiltIn = False
				args.FillBackground = False
				args.State = GetObjectState()
				args.Button.Caption = Text
				_Painter.DrawObject(args)
			Else
				MyBase.OnPaint(pevent)
			End If
		End Sub


	End Class
End Namespace
