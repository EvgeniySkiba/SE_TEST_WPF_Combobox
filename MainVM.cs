using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboboxBinding
{
    public class MainVM
    {
        private IList<string> standards = new List<string>();
        private string selectedStandard;

        private IList<Place> places = new List<Place>();
        private Place selectedPlace;

        private IList<PlaceUsingTemplate> placesUsingTemplate = new List<PlaceUsingTemplate>();
        private PlaceUsingTemplate selectedPlaceUsingTemplate;

        private Gender selectedGender;

        private int cityID;
        private string selectedValuePath = "ID";
   

        public MainVM()
        {
            PopulateComoboBoxes();
        }


        /// <summary>
        /// The function can be used to populate all the collection properties from any datasource
        /// </summary>
        private void PopulateComoboBoxes()
        {
            Standards = new List<string>() { "First", "Second", "Third" };

            Places = new List<Place>() { new Place(){ID =1, City = "New Delhi", Country = "India"}, 
            new Place(){ID= 2, City = "Bangalore", Country = "India"}, 
            new Place(){ID = 3 ,City = "New York", Country = "USA"}, 
            new Place(){ID = 4, City = "London", Country = "UK"}, 
            new Place(){ID =5, City = "Paris", Country = "France"}};

            PlacesUsingTemplate = new List<PlaceUsingTemplate>() { new PlaceUsingTemplate(){ID =1, City = "New Delhi", Country = "India"}, 
            new PlaceUsingTemplate(){ID= 2, City = "Bangalore", Country = "India"}, 
            new PlaceUsingTemplate(){ID = 3 ,City = "New York", Country = "USA"}, 
            new PlaceUsingTemplate(){ID = 4, City = "London", Country = "UK"}, 
            new PlaceUsingTemplate(){ID =5, City = "Paris", Country = "France"}};

            //This is the case for SelectedValue and selectedValuePath

        }

        public IList<string> Standards
        {
            get
            {
                return standards;
            }
            set
            {
                standards = value;
            }
        }

        public string SelectedStandard 
        {
            get
            {
                return selectedStandard;
            }
            set
            {
                selectedStandard = value;
            }
        }

        public IList<Place> Places 
        {
            get
            {
                return places;
            }
            set
            {
                places = value;
            }
        }

        public Place SelectedPlace
        {
            get
            {
                return selectedPlace;
            }
            set
            {
                selectedPlace = value;
            }
        }

        public IList<PlaceUsingTemplate> PlacesUsingTemplate
        {
            get
            {
                return placesUsingTemplate;
            }
            set
            {
                placesUsingTemplate = value;
            }
        }

        public PlaceUsingTemplate SelectedPlaceUsingTemplate
        {
            get
            {
                return selectedPlaceUsingTemplate;
            }
            set
            {
                selectedPlaceUsingTemplate = value;
            }
        }

        public Gender SelectedGender 
        {
            get
            {
                return selectedGender;
            }
            set
            {
                selectedGender = value;
            }
        }      

        public int CityID 
        {
            get
            {
                return cityID;
            }
            set
            {
                cityID = value;
            }
        }

        public string SelectedValuePath
        {
            get
            {
                return "ID";
            }
        }

        public string Name { get; set; }
    }

    public class Place
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return City + " - " + Country;
        }
    }

    public class PlaceUsingTemplate
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }       
    }


    public enum Gender
    {       
        Male,
        Female
    }    
}
