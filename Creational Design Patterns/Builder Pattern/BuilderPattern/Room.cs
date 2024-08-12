namespace BuilderPattern
{
    public class Room
    {
        //public Room(int area, bool hasWifi, int windowCount, string viewType)
        //{
        //    Area = area;
        //    HasWifi = hasWifi;
        //    WindowCount = windowCount;
        //    ViewType = viewType;
        //}
        public Room()
        {
            
        }
        public int Area { get; set; }
        public bool HasWifi { get; set; }
        public int WindowCount { get; set; }
        public string ViewType { get; set; }
    }
}
