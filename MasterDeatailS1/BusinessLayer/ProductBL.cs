using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MasterDeatailS1;
using MasterDeatailS1.Models;
using MasterDeatailS1.PresentationLayer;

namespace MasterDeatailS1.BusinessLayer

{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS
        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;


        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }


        #endregion

        #region METHODS
        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Nova Corps",
                Location = "Xandar",
                Affiliation = "Nova Empire"

            };
        }

        private Product GetProductData()
        {
            return new Product()
            {


                Id = 1,
                Name = "Peter Quill",
                Alias = "Star Lord",
                Race = Product.Races.Human,
                Bounty = 40000,
                ImgFileName = "peterquill.jpg",
                ImgFilePath = "Images/",
                TimeWanted = DateTime.Parse("March 21, 2019"),
                Description = "Peter Jason Quill, also known as Star-Lord, was an interstellar adventurer who was abducted from Earth by the Ravagers led by Yondu Udonta at a young age. After his abduction, he began building fame as the legendary outlaw Star-Lord. In 2014, he decided to leave the Ravagers and operate individually, starting by stealing a precious artifact known as the Orb, unintentionally becoming a key player in the Quest for the Orb. Following his arrest, he forged an uneasy alliance with fellow inmates Gamora, Drax the Destroyer, Rocket Raccoon, and Groot, and formed the Guardians of the Galaxy with them a short while later in order to stop Ronan the Accuser from destroying Xandar. After the Battle of Xandar, he left with the other Guardians and he became the leader of the Guardians of the Galaxy."


                


            };



        }




        #endregion

        #region EVENTS


        #endregion






    }
}