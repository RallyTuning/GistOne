namespace GistOne
{
    class ImageLabel : Label
    {
        private Image Img;

        public ImageLabel()
        {
            ImageAlign = ContentAlignment.MiddleLeft;
        }

        public new Image Image
        {
            get { return Img; }

            set
            {
                const int spacing = 3;

                if (Img != null)
                    Padding = new Padding(Padding.Left - spacing - Img.Width, Padding.Top, Padding.Right, Padding.Bottom);

                if (value != null)
                    Padding = new Padding(Padding.Left + spacing + value.Width, Padding.Top, Padding.Right, Padding.Bottom);

                Img = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
            {
                Rectangle r = CalcImageRenderBounds(Image, ClientRectangle, ImageAlign);
                e.Graphics.DrawImage(Image, r);
            }

            base.OnPaint(e);
        }
    }
}
