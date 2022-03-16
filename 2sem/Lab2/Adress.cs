namespace Lab2
{
    public class Adress
    {
        #region Fields
        private Flat flat;
        private string country;
        private string town;
        private string district;
        private string street;
        private string building;
        private string flatt;
        #endregion
        #region Props
        public string Flatt
        {
            get { return flatt; }
            set { flatt = value; }
        }


        public string Building
        {
            get { return building; }
            set { building = value; }
        }


        public string Street
        {
            get { return street; }
            set { street = value; }
        }


        public string District
        {
            get { return district; }
            set { district = value; }
        }


        public string Town
        {
            get { return town; }
            set { town = value; }
        }


        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        public Flat Flat
        {
            get { return flat; }
            set { flat = value; }
        }
        #endregion
        public Adress(Flat flat, string country, string town, string district, string street, string building, string flatt)
        {
            Flat = flat;
            Country = country;
            Town = town;
            District = district;
            Street = street;
            Building = building;
            Flatt = flatt;
        }

        private string Options()
        {
            string options="";
            byte i = 0;
            foreach (var item in flat.Options)
            {
                if (item != null) options += i == 0 ? item : ", " + item;
                i++;
            }
            if (options.Length==0) options = "опции не включены";

            return options;
        }
        public string ShowInfo()
        {
            return $"Метраж:{Flat.Meters}.\nСтрана:{Country}.\nГород:{Town}.\nРайон: {District}.\n"+
                $"Дата: {Flat.Date}.\nКол-во комнат: {Flat.RoomsCount}.\nТип материала: {Flat.Material}.\n" +
                $"Улица: {Street}.\nКорпус:{Building}.\nНомер квартиры:{Flatt}.\nВключенные опции: {Options()}.";
        }
    }
}
