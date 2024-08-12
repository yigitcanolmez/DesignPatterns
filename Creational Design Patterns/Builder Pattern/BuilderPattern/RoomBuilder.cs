namespace BuilderPattern
{
    public class RoomBuilder
    {
        private Room _room = new();
        public RoomBuilder SetArea(int area)
        {
            _room.Area = area;
            return this;
        }
        public RoomBuilder SetHasWifi(bool hasWifi)
        {
            _room.HasWifi = hasWifi;
            return this;
        }
        public RoomBuilder SetWindowCount(int windowCount)
        {
            _room.WindowCount = windowCount;
            return this;
        }
        public RoomBuilder SetViewType(string viewType)
        {
            _room.ViewType = viewType;
            return this;
        }

        public Room Build()
        {
            return _room;
        }
    }
}
