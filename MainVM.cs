using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboboxBinding
{
    public enum ProgramLanguage
    {
        CPlusPlus = 2,
        CSharp = 4,
        FSharp = 5
    };

    public class MainVM
    {
        private IList<string> standards = new List<string>();
        private string selectedStandard;

        private IList<Place> places = new List<Place>();
        private Place selectedPlace;

        private IList<KeyValuePair<int, string>> languages = new List<KeyValuePair<int, string>>();
        private KeyValuePair<int, string> selectedLanguage;

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

var res = Enum.GetValues(typeof(ProgramLanguage))
    .Cast<ProgramLanguage>()
    .Select(v => v.ToString())
    .ToList();

            var dict = new Dictionary<int, string>();
            foreach (var name in Enum.GetNames(typeof(ProgramLanguage)))
            {
                dict.Add((int)Enum.Parse(typeof(ProgramLanguage), name), name);

                int key = (int)Enum.Parse(typeof(ProgramLanguage), name);
                string value = name;
                KeyValuePair<int, string> keyVal = new KeyValuePair<int, string>(key,value);
              

                languages.Add(keyVal);
            }

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

        public IList<KeyValuePair<int, string>> Places2
        {
            get
            {
                return languages;
            }
            set
            {
                languages = value;
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

        public KeyValuePair<int, string> SelectedPlace2
        {
            get
            {
                return selectedLanguage;
            }
            set
            {
                selectedLanguage = value;
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
