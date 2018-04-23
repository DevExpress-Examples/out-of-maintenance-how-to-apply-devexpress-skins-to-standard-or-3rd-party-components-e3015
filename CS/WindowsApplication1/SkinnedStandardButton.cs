using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using System.ComponentModel;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class SkinnedStandardButton : Button
    {

        private EditorButton _Button = new EditorButton(ButtonPredefines.Glyph);
        private SkinEditorButtonPainter _Painter;
        public SkinnedStandardButton()
        {
            _Painter = CreatePainter();
        }

        private bool _UseSkins = true;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UseSkins
        {
            get { return _UseSkins; }
            set
            {
                _UseSkins = value;
                Refresh();
            }
        }
        

        protected virtual SkinEditorButtonPainter CreatePainter()
        {
            return new SkinEditorButtonPainter(UserLookAndFeel.Default);
        }

        private ObjectState GetObjectState()
        {
            Point location = PointToScreen(new Point(0, 0));
            bool mouseInButton = new Rectangle(location, new Size(Width, Height)).Contains(Control.MousePosition);
            if (!mouseInButton || DesignMode)
                return ObjectState.Normal;
            return Control.MouseButtons == MouseButtons.Left ? ObjectState.Pressed : ObjectState.Hot;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (UseSkins)
            {
                EditorButtonObjectInfoArgs args = new EditorButtonObjectInfoArgs(new GraphicsCache(pevent.Graphics), _Button, AppearanceObject.EmptyAppearance);
                args.Bounds = new Rectangle(0, 0, Width, Height);
                args.BuiltIn = false;
                args.FillBackground = false;
                args.State = GetObjectState();
                args.Button.Caption = Text;
                _Painter.DrawObject(args);
            }
            else
                base.OnPaint(pevent);
        }


    }
}
