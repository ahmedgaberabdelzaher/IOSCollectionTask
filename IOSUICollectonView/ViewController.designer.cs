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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UICollectionView DocctorsCollectionView { get; set; }

		[Outlet]
		UIKit.UICollectionView DrAcceptanceGulfCollectionView { get; set; }

		[Outlet]
		UIKit.UICollectionView mainCollectionView { get; set; }

		[Outlet]
		UIKit.UIStackView MainStack { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (mainCollectionView != null) {
				mainCollectionView.Dispose ();
				mainCollectionView = null;
			}

			if (MainStack != null) {
				MainStack.Dispose ();
				MainStack = null;
			}

			if (DocctorsCollectionView != null) {
				DocctorsCollectionView.Dispose ();
				DocctorsCollectionView = null;
			}

			if (DrAcceptanceGulfCollectionView != null) {
				DrAcceptanceGulfCollectionView.Dispose ();
				DrAcceptanceGulfCollectionView = null;
			}
		}
	}
}
