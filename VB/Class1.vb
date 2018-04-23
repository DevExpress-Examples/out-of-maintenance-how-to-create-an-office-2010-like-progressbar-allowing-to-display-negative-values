Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils

Namespace WindowsApplication1
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyProgressBar
		Inherits RepositoryItemProgressBar

		#Region "default"
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyProgressBar"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyProgressBar), GetType(RepositoryItemMyProgressBar), GetType(ProgressBarViewInfo), New MyProgressBarPainter(), True, CType(Nothing, Image), GetType(DevExpress.Accessibility.ProgressBarAccessible)))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		#End Region ' default
	End Class
	''' <summary>
	''' MyProgressBar is a descendant from ProgressBar.
	''' It displays a dialog form below the text box when the edit button is clicked.
	''' </summary>
	Public Class MyProgressBar
		Inherits ProgressBarControl
		#Region "default"
		Shared Sub New()
			RepositoryItemMyProgressBar.Register()
		End Sub
		Public Sub New()
		End Sub


		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyProgressBar.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyProgressBar
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyProgressBar)
			End Get
		End Property
		#End Region ' default
	End Class

	Public Class MyProgressBarPainter
		Inherits ProgressBarPainter

		Private calc As MyProgressBarCalculator

		Private _NegativeValueAppearance As AppearanceObject
		Public Property NegativeValueAppearance() As AppearanceObject
			Get
				Return GetNegativeValueAppearance()
			End Get
			Set(ByVal value As AppearanceObject)
				_NegativeValueAppearance = value
			End Set
		End Property

		Private _PositiveValueAppearance As AppearanceObject
		Public Property PositiveValueAppearance() As AppearanceObject
			Get
				Return GetPositiveValueAppearance()
			End Get
			Set(ByVal value As AppearanceObject)
				_PositiveValueAppearance = value
			End Set
		End Property

		Private Function GetNegativeValueAppearance() As AppearanceObject
			If _NegativeValueAppearance IsNot Nothing Then
				Return _NegativeValueAppearance
			End If
			Dim obj As New AppearanceObject()
			obj.BackColor = Color.White
			obj.BackColor2 = Color.Red
			obj.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Return obj
		End Function

		Private Function GetPositiveValueAppearance() As AppearanceObject
			If _PositiveValueAppearance IsNot Nothing Then
				Return _PositiveValueAppearance
			End If
			Dim obj As New AppearanceObject()
			obj.BackColor = Color.White
			obj.BackColor2 = Color.Blue
			obj.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Return obj
		End Function

		Private Sub DrawCenterLine(ByVal info As ControlGraphicsInfoArgs)
			Dim obj As New AppearanceObject()
			obj.BackColor = Color.Gray
			obj.BackColor2 = Color.Black
			obj.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			obj.FillRectangle(info.Cache, calc.CenterBounds)
			obj.Dispose()
		End Sub

		Private Sub DrawValue(ByVal info As ControlGraphicsInfoArgs)
			Dim obj As AppearanceObject
			If calc.IsNegativeValue Then
				obj = NegativeValueAppearance
			Else
				obj = PositiveValueAppearance
			End If
			obj.FillRectangle(info.Cache, calc.GetValueBounds())
		End Sub

		Private Sub DrawTitle(ByVal info As ControlGraphicsInfoArgs)
			If (TryCast(info.ViewInfo, ProgressBarViewInfo)).Item.ShowTitle Then
				Dim bounds As Rectangle = info.Bounds
				Dim obj As New AppearanceObject(info.ViewInfo.PaintAppearance)
				obj.ForeColor = Color.White
				obj.DrawString(info.Cache, info.ViewInfo.DisplayText, bounds)
				bounds.Offset(1, 1)
				info.ViewInfo.PaintAppearance.DrawString(info.Cache, info.ViewInfo.DisplayText, bounds)
			End If
		End Sub

		Public Overrides Sub Draw(ByVal info As ControlGraphicsInfoArgs)
			calc = New MyProgressBarCalculator(TryCast(info.ViewInfo, ProgressBarViewInfo))
			info.ViewInfo.PaintAppearance.FillRectangle(info.Cache, info.Bounds)
			DrawCenterLine(info)
			DrawValue(info)
			DrawTitle(info)
		End Sub

	End Class

	Public Class MyProgressBarCalculator

		Private _ViewInfo As ProgressBarViewInfo
		Public Property ViewInfo() As ProgressBarViewInfo
			Get
				Return _ViewInfo
			End Get
			Set(ByVal value As ProgressBarViewInfo)
				_ViewInfo = value
			End Set
		End Property


		Private _CenterBounds As Rectangle
		Public ReadOnly Property CenterBounds() As Rectangle
			Get
				Return CalcCenterRectangle()
			End Get
		End Property

		Private _Center As Double
		Public ReadOnly Property Center() As Integer
			Get
				Return CInt(Fix(_Center))
			End Get
		End Property

		Public ReadOnly Property IsNegativeValue() As Boolean
			Get
				Return ViewInfo.Position < 0
			End Get
		End Property



		Public Sub New(ByVal info As ProgressBarViewInfo)
			_ViewInfo = info
			CalcCenter()
		End Sub


		Private Sub CalcCenter()
			Dim c As Double = ViewInfo.Item.Maximum - ViewInfo.Item.Minimum
			c = ViewInfo.Item.Maximum / c
			_Center = ViewInfo.Bounds.Left + (1 - c) * ViewInfo.Bounds.Width
		End Sub

		Private Function CalcCenterRectangle() As Rectangle
			Return New Rectangle(Center - 1, ViewInfo.Bounds.Top, 2, ViewInfo.Bounds.Height)
		End Function

	   Public Function GetValueBounds() As Rectangle
			Dim value As Integer = Math.Abs(ViewInfo.Position)
			Dim width As Double = ViewInfo.Item.Maximum - ViewInfo.Item.Minimum
			width = value / width * ViewInfo.Bounds.Width
			Dim intWidth As Integer = CInt(Fix(width))
			Dim margin As Integer = 1
			If IsNegativeValue Then
				Return New Rectangle(Center - intWidth, ViewInfo.Bounds.Top + margin, intWidth - margin, ViewInfo.Bounds.Height - 2 * margin)
			End If
			Return New Rectangle(Center + margin, ViewInfo.Bounds.Top + margin, intWidth, ViewInfo.Bounds.Height - 2 * margin)
	   End Function
	End Class
End Namespace
