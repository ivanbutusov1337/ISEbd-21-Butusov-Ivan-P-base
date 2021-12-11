using System.Collections.Generic;
using System.Linq;

namespace butusovlab1base
{
    class ParkingCollection
    {
        //словарь хранилище с парковками
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        //возвращение списка названий парковок
        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;
        //конструктор
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
            }
        }
        public void DelParking(string name)
        {//добавить проверку что есть ключ
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else return null;
            }
        }
    }
}
