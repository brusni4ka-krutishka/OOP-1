using System;
namespace Lab2
{
    public class Flat
    {
        #region fields
        private uint meters;
        private uint roomsCount;
        private string[] options;
        private string date;
        private string material;
        private uint floor;
        #endregion
        #region Props
        public uint Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }


        public string Date
        {
            get { return date; }
            set { date = value; }
        }


        public string[] Options
        {
            get { return options; }
            set { options = value; }
        }


        public uint RoomsCount
        {
            get { return roomsCount; }
            set { roomsCount = value; }
        }

        [NormalMeters]
        public uint Meters
        {
            get { return meters; }
            set { meters = value; }
        }
        #endregion
        public Flat(uint meters, uint roomsCount, string[] options, DateTime date, string material, uint floor)
        {
            Meters = meters;
            RoomsCount = roomsCount;
            Options = options;
            Date = date.ToString();
            Material = material;
            Floor = floor;
        }

    }
}
