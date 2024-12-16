namespace zadanie13
{
    public partial class Form1 : Form
    {
        int Moves;
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        
        
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for(int i=0; i<currentLocation.Exits.Length; i++) 
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "SprawdŸ " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = true;
            if (currentLocation is IHasExteriorDoor)
                goThoughTheDoor.Visible = true;
            else
                goThoughTheDoor.Visible = false;
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dêbowe drzwi z mosiê¿na klamk¹");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "krzyszta³owy ¿yrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztuæce", "rozsuwane drzwi");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dêbowe drzwi z mosiêzna klamk¹");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");

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

        //private void MoveToANewLocation(Location newLocation)
        //{
        //    currentLocation = newLocation;

        //    exits.Items.Clear();
        //    for (int i = 0; i < currentLocation.Exits.Length; i++)
        //        exits.Items.Add(currentLocation.Exits[i].Name);
        //    exits.SelectedIndex = 0;

        //    description.Text = currentLocation.Description;
        //    if (currentLocation is IHasExteriorDoor)
        //        goThoughTheDoor.Visible = true;
        //    else
        //        goThoughTheDoor.Visible = false;
        //}

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
