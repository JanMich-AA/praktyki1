namespace zadanie13
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "d�bowe drzwi z mosi�na klamk�");
            diningRoom = new Room("Jadalnia", "krzyszta�owy �yrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztu�ce", "rozsuwane drzwi");
            frontYard = new OutsideWithDoor("Podw�rko przed domem", false, "d�bowe drzwi z mosi�zna klamk�");
            backYard = new OutsideWithDoor("Podw�rko za domem", true, "rozsuwane drzwi");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
                goThoughTheDoor.Visible = true;
            else
                goThoughTheDoor.Visible = false;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void exits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThoughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);

        }
    }
}
