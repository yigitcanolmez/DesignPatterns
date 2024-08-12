using BuilderPattern;

//var room = new Room(50, true, 2, "ağaç");

//var room2 = new Room(50, true, 0, "dört duvar");

var room3 = new RoomBuilder().SetArea(50)
                             .SetWindowCount(2)
                             .SetViewType("Ağaç")
                             .Build();

var room4 = new RoomBuilder().SetArea(20)
                             .Build();

Console.WriteLine();