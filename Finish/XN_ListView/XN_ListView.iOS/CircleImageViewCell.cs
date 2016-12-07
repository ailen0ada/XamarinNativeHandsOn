using System;

using Foundation;
using UIKit;

namespace XN_ListView.iOS
{
    public partial class CircleImageViewCell : UITableViewCell
    {
        protected CircleImageViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void Update(TableItem item)
        {
            MainLabel.Text = item.Main;
            SubLabel.Text = item.Sub;
            CircleImage.Image = UIImage.FromFile(item.ImagePath);

            CircleImage.Layer.CornerRadius = ContentView.Bounds.Height / 2;
            CircleImage.Layer.BorderWidth = 2;
            CircleImage.Layer.BorderColor = UIColor.FromRGB(0x34, 0x98, 0xdb).CGColor;
            CircleImage.ClipsToBounds = true;
        }
    }
}
