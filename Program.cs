Console.ForegroundColor = ConsoleColor.Magenta;
Interfaces.Classes.TeamLeader teamLead = new Interfaces.Classes.TeamLeader();
Interfaces.Classes.Team team = new Interfaces.Classes.Team();

teamLead.Work();
team.Work();

Interfaces.Classes.TheHouse.House house = new Interfaces.Classes.TheHouse.House();
Interfaces.Classes.TheHouse.Basement basement = new Interfaces.Classes.TheHouse.Basement();
Interfaces.Classes.TheHouse.Walls walls = new Interfaces.Classes.TheHouse.Walls();
Interfaces.Classes.TheHouse.Window window = new Interfaces.Classes.TheHouse.Window();
Interfaces.Classes.TheHouse.Roof roof = new Interfaces.Classes.TheHouse.Roof();


house.intallingPart();
basement.intallingPart();
walls.intallingPart();
window.intallingPart();
roof.intallingPart();

house.bePart();
basement.bePart();
walls.bePart();
window.bePart();
roof.bePart();

team.Finish();
teamLead.Finish();