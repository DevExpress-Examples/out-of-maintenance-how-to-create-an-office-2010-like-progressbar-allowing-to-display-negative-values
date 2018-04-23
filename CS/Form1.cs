using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
		private WindowsApplication1.MyProgressBar myProgressBar1;
        private MyProgressBar myProgressBar2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MyProgressBar myProgressBar3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private RepositoryItemMyProgressBar repositoryItemMyProgressBar1;
        private MyProgressBar myProgressBar4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
		private void InitializeComponent()
		{
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.myProgressBar1 = new WindowsApplication1.MyProgressBar();
            this.myProgressBar2 = new WindowsApplication1.MyProgressBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMyProgressBar1 = new WindowsApplication1.RepositoryItemMyProgressBar();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.myProgressBar3 = new WindowsApplication1.MyProgressBar();
            this.myProgressBar4 = new WindowsApplication1.MyProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // myProgressBar1
            // 
            this.myProgressBar1.EditValue = 50;
            this.myProgressBar1.Location = new System.Drawing.Point(13, 7);
            this.myProgressBar1.Name = "myProgressBar1";
            this.myProgressBar1.Properties.Minimum = -50;
            this.myProgressBar1.Size = new System.Drawing.Size(120, 20);
            this.myProgressBar1.TabIndex = 0;
            // 
            // myProgressBar2
            // 
            this.myProgressBar2.EditValue = -40;
            this.myProgressBar2.Location = new System.Drawing.Point(156, 7);
            this.myProgressBar2.Name = "myProgressBar2";
            this.myProgressBar2.Properties.Maximum = 50;
            this.myProgressBar2.Properties.Minimum = -50;
            this.myProgressBar2.Properties.ShowTitle = true;
            this.myProgressBar2.Size = new System.Drawing.Size(120, 20);
            this.myProgressBar2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMyProgressBar1});
            this.gridControl1.Size = new System.Drawing.Size(600, 452);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.ColumnEdit = this.repositoryItemMyProgressBar1;
            this.gridColumn3.FieldName = "Number";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // repositoryItemMyProgressBar1
            // 
            this.repositoryItemMyProgressBar1.Minimum = -100;
            this.repositoryItemMyProgressBar1.Name = "repositoryItemMyProgressBar1";
            this.repositoryItemMyProgressBar1.ShowTitle = true;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // myProgressBar3
            // 
            this.myProgressBar3.EditValue = 50;
            this.myProgressBar3.Location = new System.Drawing.Point(296, 7);
            this.myProgressBar3.Name = "myProgressBar3";
            this.myProgressBar3.Properties.Minimum = -500;
            this.myProgressBar3.Size = new System.Drawing.Size(132, 20);
            this.myProgressBar3.TabIndex = 3;
            // 
            // myProgressBar4
            // 
            this.myProgressBar4.EditValue = 50;
            this.myProgressBar4.Location = new System.Drawing.Point(456, 7);
            this.myProgressBar4.Name = "myProgressBar4";
            this.myProgressBar4.Properties.Minimum = -500;
            this.myProgressBar4.Properties.ShowTitle = true;
            this.myProgressBar4.Size = new System.Drawing.Size(132, 20);
            this.myProgressBar4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.myProgressBar4);
            this.Controls.Add(this.myProgressBar3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.myProgressBar2);
            this.Controls.Add(this.myProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProgressBar4.Properties)).EndInit();
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

                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i),  100 - i*10, DateTime.Now.AddDays(i) });
            return tbl;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = CreateTable(20);
        }
	}
}
