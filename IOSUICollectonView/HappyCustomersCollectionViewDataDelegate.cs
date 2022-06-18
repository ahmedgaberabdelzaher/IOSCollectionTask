using System;
using System.Collections.Generic;
using Foundation;
using IOSUICollectonView.Model;
using IOSUICollectonView.VieCels;
using UIKit;

namespace IOSUICollectonView
{
    public class HappyCustomersCollectionViewDataDelegate: UICollectionViewDataSource
    {
        List<HappyCustomersModel> _happyCustomers;
        public HappyCustomersCollectionViewDataDelegate(List<HappyCustomersModel> happyCustomers)
        {
            _happyCustomers = happyCustomers;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            HappyCustomerViewCell cell = collectionView.DequeueReusableCell("customCell", indexPath) as HappyCustomerViewCell;
          
            cell.ConfigureCell(model: _happyCustomers[indexPath.Row]);
            cell.Update(_happyCustomers[indexPath.Row].rate);
            return cell;

        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _happyCustomers.Count;
        }
    }
}
