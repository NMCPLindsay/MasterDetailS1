using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MasterDeatailS1.Models
{
    public class ProductWindowPresenter : ObservableObject
    {
        #region ENUMS


        #endregion

        #region FIELDS
        private Company _companyInfo;
        private Product _selectedProduct;




     







        #endregion

        #region PROPERTIES
        public Company CompanyInfo
        {
            get { return _companyInfo; }
            set { _companyInfo = value; }
        }
        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; }
        }


        #endregion

        #region CONSTRUCTORS
        public ProductWindowPresenter(Company company, Product product)
        {

        }


        #endregion

        #region METHODS
        public void QuitApplication()
        {
            Environment.Exit(0);
        }


        #endregion

        #region EVENTS


        #endregion
    }
}
