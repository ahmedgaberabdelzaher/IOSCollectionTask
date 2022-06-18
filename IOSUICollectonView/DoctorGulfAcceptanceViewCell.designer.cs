// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace IOSUICollectonView
{
	[Register ("DoctorGulfAcceptanceViewCell")]
	partial class DoctorGulfAcceptanceViewCell
	{
		[Outlet]
		UIKit.UIStackView DataContainer { get; set; }

		[Outlet]
		UIKit.UILabel Degree { get; set; }

		[Outlet]
		UIKit.UIImageView DoctorImage { get; set; }

		[Outlet]
		UIKit.UILabel DrName { get; set; }

		[Outlet]
		UIKit.UIStackView mainHorizontalContainer { get; set; }

		[Outlet]
		UIKit.UIView RatingView { get; set; }

		[Outlet]
		UIKit.UIStackView ReviewandRatingContainer { get; set; }

		[Outlet]
		UIKit.UILabel ReviewrsCount { get; set; }

		[Outlet]
		UIKit.UILabel Specification { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (mainHorizontalContainer != null) {
				mainHorizontalContainer.Dispose ();
				mainHorizontalContainer = null;
			}

			if (DoctorImage != null) {
				DoctorImage.Dispose ();
				DoctorImage = null;
			}

			if (DataContainer != null) {
				DataContainer.Dispose ();
				DataContainer = null;
			}

			if (DrName != null) {
				DrName.Dispose ();
				DrName = null;
			}

			if (Specification != null) {
				Specification.Dispose ();
				Specification = null;
			}

			if (Degree != null) {
				Degree.Dispose ();
				Degree = null;
			}

			if (ReviewandRatingContainer != null) {
				ReviewandRatingContainer.Dispose ();
				ReviewandRatingContainer = null;
			}

			if (RatingView != null) {
				RatingView.Dispose ();
				RatingView = null;
			}

			if (ReviewrsCount != null) {
				ReviewrsCount.Dispose ();
				ReviewrsCount = null;
			}
		}
	}
}
