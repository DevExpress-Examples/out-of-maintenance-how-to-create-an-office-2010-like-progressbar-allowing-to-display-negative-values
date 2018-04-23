Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private myProgressBar1 As WindowsApplication1.MyProgressBar
		Private myProgressBar2 As MyProgressBar
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private myProgressBar3 As MyProgressBar
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyProgressBar1 As RepositoryItemMyProgressBar
		Private myProgressBar4 As MyProgressBar
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataSet1 = New System.Data.DataSet()
			Me.myProgressBar1 = New WindowsApplication1.MyProgressBar()
			Me.myProgressBar2 = New WindowsApplication1.MyProgressBar()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMyProgressBar1 = New WindowsApplication1.RepositoryItemMyProgressBar()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.myProgressBar3 = New WindowsApplication1.MyProgressBar()
			Me.myProgressBar4 = New WindowsApplication1.MyProgressBar()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myProgressBar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myProgressBar3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myProgressBar4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' myProgressBar1
			' 
			Me.myProgressBar1.EditValue = 50
			Me.myProgressBar1.Location = New System.Drawing.Point(13, 7)
			Me.myProgressBar1.Name = "myProgressBar1"
			Me.myProgressBar1.Properties.Minimum = -50
			Me.myProgressBar1.Size = New System.Drawing.Size(120, 20)
			Me.myProgressBar1.TabIndex = 0
			' 
			' myProgressBar2
			' 
			Me.myProgressBar2.EditValue = -40
			Me.myProgressBar2.Location = New System.Drawing.Point(156, 7)
			Me.myProgressBar2.Name = "myProgressBar2"
			Me.myProgressBar2.Properties.Maximum = 50
			Me.myProgressBar2.Properties.Minimum = -50
			Me.myProgressBar2.Properties.ShowTitle = True
			Me.myProgressBar2.Size = New System.Drawing.Size(120, 20)
			Me.myProgressBar2.TabIndex = 1
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gridControl1.Location = New System.Drawing.Point(0, 48)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMyProgressBar1})
			Me.gridControl1.Size = New System.Drawing.Size(600, 452)
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "gridColumn1"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "gridColumn2"
			Me.gridColumn2.FieldName = "Date"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 2
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "gridColumn3"
			Me.gridColumn3.ColumnEdit = Me.repositoryItemMyProgressBar1
			Me.gridColumn3.FieldName = "Number"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 1
			' 
			' repositoryItemMyProgressBar1
			' 
			Me.repositoryItemMyProgressBar1.Minimum = -100
			Me.repositoryItemMyProgressBar1.Name = "repositoryItemMyProgressBar1"
			Me.repositoryItemMyProgressBar1.ShowTitle = True
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' myProgressBar3
			' 
			Me.myProgressBar3.EditValue = 50
			Me.myProgressBar3.Location = New System.Drawing.Point(296, 7)
			Me.myProgressBar3.Name = "myProgressBar3"
			Me.myProgressBar3.Properties.Minimum = -500
			Me.myProgressBar3.Size = New System.Drawing.Size(132, 20)
			Me.myProgressBar3.TabIndex = 3
			' 
			' myProgressBar4
			' 
			Me.myProgressBar4.EditValue = 50
			Me.myProgressBar4.Location = New System.Drawing.Point(456, 7)
			Me.myProgressBar4.Name = "myProgressBar4"
			Me.myProgressBar4.Properties.Minimum = -500
			Me.myProgressBar4.Properties.ShowTitle = True
			Me.myProgressBar4.Size = New System.Drawing.Size(132, 20)
			Me.myProgressBar4.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(600, 500)
			Me.Controls.Add(Me.myProgressBar4)
			Me.Controls.Add(Me.myProgressBar3)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.myProgressBar2)
			Me.Controls.Add(Me.myProgressBar1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myProgressBar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myProgressBar3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myProgressBar4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), 100 - i*10, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
				End Function


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = CreateTable(20)
		End Sub
	End Class
End Namespace
