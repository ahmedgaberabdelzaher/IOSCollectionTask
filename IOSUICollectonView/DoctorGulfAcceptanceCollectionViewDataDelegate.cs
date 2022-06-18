using System;
using System.Collections.Generic;
using Foundation;
using IOSUICollectonView.Model;
using UIKit;

namespace IOSUICollectonView
{
    public class DoctorGulfAcceptanceCollectionViewDataDelegate: UICollectionViewDataSource
    {
        public DoctorGulfAcceptanceCollectionViewDataDelegate()
        {
        }
        List<DoctorsacceptingMedGulfInsuranceModel> _DoctorsacceptingMedGulfInsurances;
        public DoctorGulfAcceptanceCollectionViewDataDelegate(List<DoctorsacceptingMedGulfInsuranceModel> DoctorsacceptingMedGulfInsurances)
        {
            _DoctorsacceptingMedGulfInsurances = DoctorsacceptingMedGulfInsurances;
        }

           public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _DoctorsacceptingMedGulfInsurances.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            DoctorGulfAcceptanceViewCell cell = collectionView.DequeueReusableCell("DoctorAcceptanceCell", indexPath) as DoctorGulfAcceptanceViewCell;

            cell.ConfigureCell(model: _DoctorsacceptingMedGulfInsurances[indexPath.Row]);
            return cell;
        }
    }
}
