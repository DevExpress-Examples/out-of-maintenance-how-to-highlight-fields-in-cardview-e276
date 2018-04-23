using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;

namespace HotTrack
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private nwindDataSet nwindDataSet;
        private BindingSource categoriesBindingSource;
        private HotTrack.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private IContainer components;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new HotTrack.nwindDataSet();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.categoriesTableAdapter = new HotTrack.nwindDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.categoriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(627, 434);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription,
            this.colPicture});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.CustomDrawCardFieldValue += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.cardView1_CustomDrawCardFieldValue);
            this.cardView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "CategoryID";
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "CategoryName";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colPicture
            // 
            this.colPicture.Caption = "Picture";
            this.colPicture.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 3;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(627, 434);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
		}

        private GridCell hotTrackCell = null;
        private GridCell HotTrackCell {
            get {
                return hotTrackCell;
            }
            set {
                int prevHotTrackRow = hotTrackCell == null ? GridControl.InvalidRowHandle : hotTrackCell.RowHandle;
                if(value == null) return;
                if(value == null || value.RowHandle == GridControl.InvalidRowHandle || value.Column == null) { 
                    this.hotTrackCell = null;
                }
                else {
                    if( hotTrackCell == null || (value.Column != hotTrackCell.Column ||
                        value.RowHandle != hotTrackCell.RowHandle)) {
                        hotTrackCell = value;
                        cardView1.RefreshRow(prevHotTrackRow);
                        cardView1.RefreshRow(hotTrackCell.RowHandle);
                    }
                }
            }
        }

		private void gridView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            CardView view = sender as CardView;
			CardHitInfo info = view.CalcHitInfo(new Point(e.X, e.Y));
            GridCell c = new GridCell(info.RowHandle, info.Column);
            if(info.HitTest == CardHitTest.FieldValue){
                HotTrackCell = new GridCell(info.RowHandle, info.Column);
                if(info.Column.RealColumnEdit is RepositoryItemPictureEdit)
                    gridControl1.BeginInvoke(new MethodInvoker(delegate() { gridControl1.Cursor = Cursors.Hand; }));
                else
                    gridControl1.Cursor = Cursors.Default;
            }
            else {
                HotTrackCell = null;
            }
		}
		private void gridControl1_MouseLeave(object sender, System.EventArgs e) {
            HotTrackCell = null;
		}
        
        private void cardView1_CustomDrawCardFieldValue(object sender, RowCellCustomDrawEventArgs e) {
            if(hotTrackCell == null) return;
            if(e.RowHandle == hotTrackCell.RowHandle && e.Column == hotTrackCell.Column &&
                e.Column.RealColumnEdit is RepositoryItemPictureEdit){
                e.Appearance.BackColor = Color.DarkBlue;
            }
        }
	}
}
