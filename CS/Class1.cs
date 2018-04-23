using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils;

namespace WindowsApplication1 {
	[UserRepositoryItem("Register")]
	public class RepositoryItemMyProgressBar : RepositoryItemProgressBar
    {

        #region default
        static RepositoryItemMyProgressBar() { 
			Register(); 
		}
		public RepositoryItemMyProgressBar() {}
		
		internal const string EditorName = "MyProgressBar";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyProgressBar),
                typeof(RepositoryItemMyProgressBar), typeof(ProgressBarViewInfo),
                new MyProgressBarPainter(), true, null));
        }
		public override string EditorTypeName { 
			get { return EditorName; }
        }

        #endregion default
    }
	/// <summary>
	/// MyProgressBar is a descendant from ProgressBar.
	/// It displays a dialog form below the text box when the edit button is clicked.
	/// </summary>
	public class MyProgressBar : ProgressBarControl
    {
        #region default
        static MyProgressBar() {
			RepositoryItemMyProgressBar.Register();
		}
		public MyProgressBar() {
        }


		public override string EditorTypeName { 
			get { return RepositoryItemMyProgressBar.EditorName; } 
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemMyProgressBar Properties { 
			get { return base.Properties as RepositoryItemMyProgressBar; }
        }
        #endregion default
    }

    public class MyProgressBarPainter : ProgressBarPainter
    {

        MyProgressBarCalculator calc;

        private AppearanceObject _NegativeValueAppearance;
        public AppearanceObject NegativeValueAppearance
        {
            get { return GetNegativeValueAppearance(); }
            set { _NegativeValueAppearance = value; }
        }

        private AppearanceObject _PositiveValueAppearance;
        public AppearanceObject PositiveValueAppearance
        {
            get { return GetPositiveValueAppearance(); }
            set { _PositiveValueAppearance = value; }
        }

        AppearanceObject GetNegativeValueAppearance()
        {
            if (_NegativeValueAppearance != null) return _NegativeValueAppearance;
            AppearanceObject obj = new AppearanceObject();
            obj.BackColor = Color.White;
            obj.BackColor2 = Color.Red;
            obj.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            return obj;
        }

        AppearanceObject GetPositiveValueAppearance()
        {
            if (_PositiveValueAppearance != null) return _PositiveValueAppearance;
            AppearanceObject obj = new AppearanceObject();
            obj.BackColor = Color.White;
            obj.BackColor2 = Color.Blue;
            obj.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            return obj;
        }

        void DrawCenterLine(ControlGraphicsInfoArgs info)
        {
            AppearanceObject obj= new AppearanceObject();
            obj.BackColor = Color.Gray;
            obj.BackColor2 = Color.Black;
            obj.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            obj.FillRectangle(info.Cache, calc.CenterBounds);
            obj.Dispose();
        }

        void DrawValue(ControlGraphicsInfoArgs info)
        {
            AppearanceObject obj = calc.IsNegativeValue ? NegativeValueAppearance : PositiveValueAppearance;
            obj.FillRectangle(info.Cache, calc.GetValueBounds());
        }

        void DrawTitle(ControlGraphicsInfoArgs info)
        {
            if ((info.ViewInfo as ProgressBarViewInfo).Item.ShowTitle)
            {
                Rectangle bounds = info.Bounds;
                AppearanceObject obj = new AppearanceObject(info.ViewInfo.PaintAppearance);
                obj.ForeColor = Color.White;
                obj.DrawString(info.Cache, info.ViewInfo.DisplayText, bounds);
                bounds.Offset(1, 1);
                info.ViewInfo.PaintAppearance.DrawString(info.Cache, info.ViewInfo.DisplayText, bounds);
            }
        }

        public override void Draw(ControlGraphicsInfoArgs info)
        {
            calc = new MyProgressBarCalculator(info.ViewInfo as ProgressBarViewInfo);
            info.ViewInfo.PaintAppearance.FillRectangle(info.Cache, info.Bounds);
            DrawCenterLine(info);
            DrawValue(info);
            DrawTitle(info);
        }

    }

    public class MyProgressBarCalculator
    {

        private ProgressBarViewInfo _ViewInfo;
        public ProgressBarViewInfo ViewInfo
        {
            get { return _ViewInfo; }
            set { _ViewInfo = value; }
        }

 
        private Rectangle _CenterBounds;
        public Rectangle CenterBounds
        {
            get { return CalcCenterRectangle(); }
        }

        private double _Center;
        public int Center
        {
            get { return (int)_Center; }
        }

        public bool IsNegativeValue
        {
            get { return ViewInfo.Position < 0; }
        }



        public MyProgressBarCalculator(ProgressBarViewInfo info)
        {
            _ViewInfo = info;
            CalcCenter();
        }


        void CalcCenter()
        {
            double c = ViewInfo.Item.Maximum - ViewInfo.Item.Minimum;
            c = ViewInfo.Item.Maximum / c;
            _Center = ViewInfo.Bounds.Left + (1 - c) * ViewInfo.Bounds.Width;
        }

        Rectangle CalcCenterRectangle()
        {
            return new Rectangle(Center - 1, ViewInfo.Bounds.Top, 2, ViewInfo.Bounds.Height);
        }

       public Rectangle GetValueBounds()
        {
            int value = Math.Abs(ViewInfo.Position);
            double width = ViewInfo.Item.Maximum - ViewInfo.Item.Minimum;
            width = value / width * ViewInfo.Bounds.Width;
            int intWidth = (int)width;
            int margin = 1 ;
            if (IsNegativeValue)
            {
                return new Rectangle(Center - intWidth, ViewInfo.Bounds.Top + margin, intWidth - margin, ViewInfo.Bounds.Height - 2 * margin);
            }
            return new Rectangle(Center + margin, ViewInfo.Bounds.Top + margin, intWidth, ViewInfo.Bounds.Height - 2 * margin);
        }
    }
}
