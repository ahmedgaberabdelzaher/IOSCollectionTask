using CoreGraphics;
using Foundation;
using IOSUICollectonView.Model;
using Rating;
using System;
using System.Collections.Generic;
using UIKit;

namespace IOSUICollectonView
{
    public partial class ViewController : UIViewController
    {
        public List<DoctorsModel> MainCollectionLst { get; set; }

        public List<HappyCustomersModel> HappyCustomerLst { get; set; }
        public List<DoctorsacceptingMedGulfInsuranceModel> DoctorsacceptingMedGulfInsuranceModelLst { get; set; }

        public UICollectionViewFlowLayout layout = new UICollectionViewFlowLayout();
        public static readonly string CellIdentifier = "DoctorsViewCellIdentifier";

        public ViewController(IntPtr handle) : base(handle)
        {

        }
     
        public override void ViewDidLoad()
        {

            HappyCustomerLst = new List<HappyCustomersModel>()
            {
                new HappyCustomersModel(){ name="محمد", review="Test Reviw",rate=3, reviewrCount=120,sinceDays=30, drName="Dr.Ali Mohamed", age=25, department="Interneal Medicine",reviewImage="image",doctorImage="DRImage", image="UserPicture"},
                                new HappyCustomersModel(){ name="حسن", review="Test Reviw2",rate=3,sinceDays=30,drName="Dr.Ali Hassan",  reviewrCount=120, age=25, department="Interneal Medicine",reviewImage="image",doctorImage="DRImage", image="UserPicture"},
                new HappyCustomersModel(){ name="علي", review="Test Reviw3",rate=3, reviewrCount = 150,sinceDays=30,drName="Dr.Ali Mohamed", age = 25, department = "Interneal Medicine",reviewImage="image",doctorImage="DRImage", image="UserPicture"},
                new HappyCustomersModel(){ name="احمد", review="Test Reviw4",rate=3, reviewrCount = 300,sinceDays=30,drName="Dr.Ali Ahmed", age = 25, department = "Interneal Medicine",reviewImage="image",doctorImage="DRImage", image="UserPicture"}
            };

            DoctorsacceptingMedGulfInsuranceModelLst = new List<DoctorsacceptingMedGulfInsuranceModel>()
            {
                new DoctorsacceptingMedGulfInsuranceModel(){ rate=3, specification="specialist",reviewrCount=120, name="Dr.Ali Mohamed", department="Interneal Medicine",image="DrImageMedGulf"},
                                new DoctorsacceptingMedGulfInsuranceModel(){ rate=3, specification="specialist",name="Dr.Ali Hassan",  reviewrCount=120, department="Interneal Medicine",image="DrImageMedGulf"},
                new DoctorsacceptingMedGulfInsuranceModel(){ rate=3, specification="specialist", reviewrCount = 150,name="Dr.Ali Mohamed", department = "Interneal Medicine",image="DrImageMedGulf" },
                new DoctorsacceptingMedGulfInsuranceModel(){ rate=3, specification="specialist", reviewrCount = 300,name="Dr.Ali Ahmed", department = "Interneal Medicine", image="DrImageMedGulf"}
            };

            MainCollectionLst = new List<DoctorsModel>();
            MainCollectionLst.Add(new DoctorsModel()
            {
                Header = "Our Happy Customers",
                OurHappyCustomersLst = HappyCustomerLst
            }) ;
            MainCollectionLst.Add(new DoctorsModel()
            {
                Header = "Doctors Accepting Med Gulf staff",
                OurHappyCustomersLst = HappyCustomerLst
            });
            base.ViewDidLoad();
            mainCollectionView.DataSource = new HappyCustomersCollectionViewDataDelegate(HappyCustomerLst);
            DrAcceptanceGulfCollectionView.DataSource = new DoctorGulfAcceptanceCollectionViewDataDelegate(DoctorsacceptingMedGulfInsuranceModelLst);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
