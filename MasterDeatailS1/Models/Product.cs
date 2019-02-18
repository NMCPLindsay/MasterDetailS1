using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MasterDeatailS1.Models
{
    public class Product
    {
        #region ENUMS
        public enum Races
        {
            Zen_Whoberis,
            Human,
            Cybernetic,
            Insectoid,
            Centaurian,
            Flora
        }


        #endregion

        #region FIELDS
        private Races _race;
        private string _name;
        private string _alias;
        private DateTime _timeWanted;
        private string _imgFileName;
        private int _id;
        private double _bounty;
        private string _description;
        private string _imgFilePath;
        




















        #endregion

        #region PROPERTIES
        public Races Race
        {
            get { return _race; }
            set { _race = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }
        public DateTime TimeWanted
        {
            get { return _timeWanted; }
            set { _timeWanted = value; }
        }
        public string ImgFileName
        {
            get { return _imgFileName; }
            set
            {
                _imgFileName = value;
                _imgFilePath = @"../Images/" + _imgFileName;
                
            }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public double Bounty
        {
            get { return _bounty; }
            set { _bounty = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string ImgFilePath
        {
            get { return _imgFilePath; }
            set { _imgFilePath = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Product()
        {

        }


        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion


    }
}
