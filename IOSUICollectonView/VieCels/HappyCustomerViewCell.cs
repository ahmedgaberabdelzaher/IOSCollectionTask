using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using IOSUICollectonView.Model;
using UIKit;

namespace IOSUICollectonView.VieCels
{
    public partial class HappyCustomerViewCell: UICollectionViewCell
    {

        HappyCustomersModel _model;
        UIImageView imageView;
        UILabel DescriptionLabel;
        UILabel Name;
        public HappyCustomerViewCell(IntPtr handle) : base(handle) { }
        [Export("awakeFromNib")]
        public override void AwakeFromNib()
        {
            try
            {
                base.AwakeFromNib();
               
            }
            catch (Exception ex) { }
        }
        /*public HappyCustomerViewCell(CGRect frame) : base(frame)
        {
            BackgroundView = new UIView { BackgroundColor = UIColor.Orange };

          //  SelectedBackgroundView = new UIView { BackgroundColor = UIColor.Green };

            ContentView.Layer.BorderColor = UIColor.LightGray.CGColor;
            ContentView.Layer.BorderWidth = 2.0f;
            ContentView.BackgroundColor = UIColor.White;
            ContentView.Transform = CGAffineTransform.MakeScale(0.8f, 0.8f);
            DescriptionLabel = new UILabel();
            Name = new UILabel();
            imageView = new UIImageView(UIImage.FromBundle("placeholder.png"));
            imageView.Center = ContentView.Center;
            imageView.Transform = CGAffineTransform.MakeScale(0.7f, 0.7f);

            ContentView.AddSubview(imageView);
            ContentView.AddSubview(Name);
            ContentView.AddSubview(DescriptionLabel);
        }*/
        internal void ConfigureCell(HappyCustomersModel model)
        {
            try
            {
                _model = model;
                this.DescriptionLabel.Text = model.review;
                this.Name.Text = model.name;
            }
            catch (Exception ex) { }
        }

        public UIImage Image
        {
            set
            {
                imageView.Image = value;
            }
        }
    }
}
