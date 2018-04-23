Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Card.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Repository

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits System.Windows.Forms.Form
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents cardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Private nwindDataSet As nwindDataSet
    Private categoriesBindingSource As BindingSource
    Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
    Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Private components As IContainer

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
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
        Me.components = New System.ComponentModel.Container()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nwindDataSet = New nwindDataSet()
        Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.categoriesTableAdapter = New nwindDataSetTableAdapters.CategoriesTableAdapter()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' gridControl1
        ' 
        Me.gridControl1.DataSource = Me.categoriesBindingSource
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.EmbeddedNavigator.Name = ""
        Me.gridControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridControl1.MainView = Me.cardView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1})
        Me.gridControl1.Size = New System.Drawing.Size(627, 434)
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cardView1})
        '			Me.gridControl1.MouseLeave += New System.EventHandler(Me.gridControl1_MouseLeave);
        ' 
        ' categoriesBindingSource
        ' 
        Me.categoriesBindingSource.DataMember = "Categories"
        Me.categoriesBindingSource.DataSource = Me.nwindDataSet
        ' 
        ' nwindDataSet
        ' 
        Me.nwindDataSet.DataSetName = "nwindDataSet"
        Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' cardView1
        ' 
        Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colCategoryName, Me.colDescription, Me.colPicture})
        Me.cardView1.FocusedCardTopFieldIndex = 0
        Me.cardView1.GridControl = Me.gridControl1
        Me.cardView1.Name = "cardView1"
        Me.cardView1.OptionsBehavior.FieldAutoHeight = True
        Me.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
        '			Me.cardView1.CustomDrawCardFieldValue += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.cardView1_CustomDrawCardFieldValue);
        '			Me.cardView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove);
        ' 
        ' colCategoryID
        ' 
        Me.colCategoryID.Caption = "CategoryID"
        Me.colCategoryID.FieldName = "CategoryID"
        Me.colCategoryID.Name = "colCategoryID"
        Me.colCategoryID.Visible = True
        Me.colCategoryID.VisibleIndex = 0
        ' 
        ' colCategoryName
        ' 
        Me.colCategoryName.Caption = "CategoryName"
        Me.colCategoryName.FieldName = "CategoryName"
        Me.colCategoryName.Name = "colCategoryName"
        Me.colCategoryName.Visible = True
        Me.colCategoryName.VisibleIndex = 1
        ' 
        ' colDescription
        ' 
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        ' 
        ' colPicture
        ' 
        Me.colPicture.Caption = "Picture"
        Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 3
        ' 
        ' repositoryItemPictureEdit1
        ' 
        Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
        ' 
        ' categoriesTableAdapter
        ' 
        Me.categoriesTableAdapter.ClearBeforeFill = True
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(627, 434)
        Me.Controls.Add(Me.gridControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        '			Me.Load += New System.EventHandler(Me.Form1_Load);
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
        Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
    End Sub

    Private hotTrackCell_Renamed As GridCell = Nothing
    Private Property HotTrackCell() As GridCell
        Get
            Return hotTrackCell_Renamed
        End Get
        Set(ByVal value As GridCell)
            Dim prevHotTrackRow As Integer
            If hotTrackCell_Renamed Is Nothing Then
                prevHotTrackRow = GridControl.InvalidRowHandle
            Else
                prevHotTrackRow = hotTrackCell_Renamed.RowHandle
            End If
            If value Is Nothing Then
                Return
            End If
            If value Is Nothing OrElse value.RowHandle = GridControl.InvalidRowHandle OrElse value.Column Is Nothing Then
                Me.hotTrackCell_Renamed = Nothing
            Else
                If hotTrackCell_Renamed Is Nothing OrElse (Not value.Column Is hotTrackCell_Renamed.Column OrElse value.RowHandle <> hotTrackCell_Renamed.RowHandle) Then
                    hotTrackCell_Renamed = value
                    cardView1.RefreshRow(prevHotTrackRow)
                    cardView1.RefreshRow(hotTrackCell_Renamed.RowHandle)
                End If
            End If
        End Set
    End Property

    Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cardView1.MouseMove
        Dim view As CardView = TryCast(sender, CardView)
        Dim info As CardHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
        Dim c As GridCell = New GridCell(info.RowHandle, info.Column)
        If info.HitTest = CardHitTest.FieldValue Then
            HotTrackCell = New GridCell(info.RowHandle, info.Column)
            If TypeOf info.Column.RealColumnEdit Is RepositoryItemPictureEdit Then
                gridControl1.BeginInvoke(New MethodInvoker(AddressOf AnonymousMethod1))
            Else
                gridControl1.Cursor = Cursors.Default
            End If
        Else
            HotTrackCell = Nothing
        End If
    End Sub
    Private Sub AnonymousMethod1()
        gridControl1.Cursor = Cursors.Hand
    End Sub
    Private Sub gridControl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridControl1.MouseLeave
        HotTrackCell = Nothing
    End Sub

    Private Sub cardView1_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles cardView1.CustomDrawCardFieldValue
        If hotTrackCell_Renamed Is Nothing Then
            Return
        End If
        If e.RowHandle = hotTrackCell_Renamed.RowHandle AndAlso e.Column Is hotTrackCell_Renamed.Column AndAlso TypeOf e.Column.RealColumnEdit Is RepositoryItemPictureEdit Then
            e.Appearance.BackColor = Color.DarkBlue
        End If
    End Sub
End Class
