// Kyle Lemons
// CSC202
// 9/19/23
// Last Edited: 11/14/23
/*
 *                           Map (not to scale)
 *                             ______________
 *                             |            |
 *                             |  Bedroom   |
 *                             |__        __|
 * __________   ______________   |        |   _______________
 * |        |___|            |___|        |___|             |__
 * |  ????   ___ Dining Room  ___ Hallway  ___ Reading Room  _|    Outside
 * |________|   |____________|   |        |   |_____________|
 *                             __|        |__
 *                             |            |
 *                             |  Bedroom   |
 *                             |____________|
 * 
 * Note: Locations with "?" are not currently implemented
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;


namespace Moonbase
{
    public partial class FormMain : Form
    {

        // All locations in the moonbase
        private static string[] temp = new string[5];
        private static NPC[] temp2 = new NPC[5];
        static Location readingRoom = new Location("Reading Room", temp, "Resources\\Moonbase Room.jpg", "Resources\\Reading Room.wav", temp2, false, false, true, true);
        Location hallway = new Location("Hallway", temp, "Resources\\Moonbase Hall.jpg", "Resources\\Hallway.wav", temp2, true, true, true, true);
        Location diningRoom = new Location("Dining Room", temp, "Resources\\Moonbase Dining.jpg", "Resources\\Dining.wav", temp2, false, false, false, true);
        Location outside = new Location("Outside", temp, "Resources\\Moonbase Outside.jpg", "Resources\\Outside.wav", temp2, false, false, true, false);
        Location northBedroom = new Location("North Bedroom", temp, "Resources\\Moonbase Bedroom 1.jpg", "Resources\\North Bedroom.wav", temp2, false, true, false, false);
        Location southBedroom = new Location("South Bedroom", temp, "Resources\\Moonbase Bedroom 2.jpg", "Resources\\South Bedroom.wav", temp2, true, false, false, false);

        Actor user = new Actor("Reading Room"); // User Actor

        SoundPlayer player = new SoundPlayer(readingRoom.getSound()); // Sets the initial value of the sound player to the music of the starting room

        public FormMain()
        {
            InitializeComponent();

            // Assign descriptions and NPC's to locations
            string[] rrDesc = new string[5];
            rrDesc[0] = "A small room near the corner of Craterville. This room is primarily used as a quiet room far away from the main common areas. Many people come here to read, but others use this place as a private area to play games or have private conversations.";
            rrDesc[1] = "The reading room of the base.";
            rrDesc[2] = "A small room with a shelf full of books used for small gathering and 1-on-1 meetings.";
            rrDesc[3] = "A small quiet place to relax and read books.";
            rrDesc[4] = "The room at the back of the base used by most for quiet time to think or read.";
            NPC[] rrNPC = new NPC[2];
            rrNPC[0] = new NPC("Reading Room", "John", "Librarian");
            rrNPC[1] = new NPC("Reading Room", "Johnny", "Game Master");
            readingRoom.setDescription(rrDesc);
            readingRoom.setNPCList(rrNPC);

            string[] hDesc = new string[5];
            hDesc[0] = "The hallway between the bedrooms of Craterville's residents. The hallway also leads to the dining room and reading room. Many people come through this place every day. It is standard protocol to greet anyone you way see in these halls to avoid potential interpersonal issues.";
            hDesc[1] = "The main hallway of the base.";
            hDesc[2] = "The main connection point between all main sections of the base.";
            hDesc[3] = "The through point of the base where people cordially.";
            hDesc[4] = "The connector between other major parts of the base.";
            NPC[] hNPC = new NPC[1];
            hNPC[0] = new NPC("Hallway", "David", "Engineer");
            hallway.setDescription(hDesc);
            hallway.setNPCList(hNPC);

            string[] drDesc = new string[5];
            drDesc[0] = "This is the most active room in all of Craterville. Residents come to eat and enjoy each other's company. The food selection is quite limited with only dehydrated foods being available. This room is also often host to larger group activities and meetings.";
            drDesc[1] = "The dining room of the base. People get food from here.";
            drDesc[2] = "A place for dining and entertainment for much of the base.";
            drDesc[3] = "Meals are prepared and served in this room. Much of the base eats their food here.";
            drDesc[4] = "The area for larger gathering, base meetings, and generally eating food.";
            NPC[] drNPC = new NPC[5];
            drNPC[0] = new NPC("Dining Room", "Jim", "Captain");
            drNPC[1] = new NPC("Dining Room", "Jimbo", "Engineer");
            drNPC[2] = new NPC("Dining Room", "Jimmy", "Engineer");
            drNPC[3] = new NPC("Dining Room", "Jimmothy", "Chef");
            drNPC[4] = new NPC("Dining Room", "Jimilian", "Waiter");
            diningRoom.setDescription(drDesc);
            diningRoom.setNPCList(drNPC);

            string[] oDesc = new string[5];
            oDesc[0] = "Only a small layer of spacesuit protects you from the cold embrace of space. Outside the base is completely silent due to a lack of atmosphere. The moon dust is a sharp powder due to millions of small meteorite impacts and no atmosphere to erode away the sharp edges. The dust is also electrostatically charged, sticking to any surface it comes into contact with. There's nothing to do out here except check on equipment occasionally.";
            oDesc[1] = "The surface of the Moon.";
            oDesc[2] = "Outside the moonbase.";
            oDesc[3] = "A surface of gray dust completely devoid of life.";
            oDesc[4] = "Despite popular legend, the surface of the moon is not made of cheese. Instead it is an intensely hostile place completely devoid of the facets of life.";
            NPC[] oNPC = new NPC[1];
            oNPC[0] = new NPC("Outside", "Xylonnorg", "Alien");
            outside.setDescription(oDesc);
            outside.setNPCList(oNPC);

            string[] nbDesc = new string[5];
            nbDesc[0] = "The bedrooms in the northern section of Craterville. Higher ranking officials get their own private bedrooms here. Some officials use their bedrooms as personal offices.";
            nbDesc[1] = "The northern bedrooms.";
            nbDesc[2] = "The private bedrooms reserved for high ranking members of the base.";
            nbDesc[3] = "Private bedrooms with considerably more personal space than the alternative.";
            nbDesc[4] = "Bedrooms with personal bathrooms attached to them.";
            NPC[] nbNPC = new NPC[3];
            nbNPC[0] = new NPC("North Bedroom", "Michael", "Officier");
            nbNPC[1] = new NPC("North Bedroom", "Mike", "Doctor");
            nbNPC[2] = new NPC("North Bedroom", "Mikey", "Co-Captain");
            northBedroom.setDescription(nbDesc);
            northBedroom.setNPCList(nbNPC);

            string[] sbDesc = new string[5];
            sbDesc[0] = "The bedrooms in the southern section of Craterville. Here several beds are packed into the same rooms to save space. Some people host lite night gatherings here with their roommates.";
            sbDesc[1] = "The southern bedrooms.";
            sbDesc[2] = "The bedrooms for the large majority of members of the base.";
            sbDesc[3] = "Bedrooms where several people are put into one room and have to share a small space.";
            sbDesc[4] = "Bedrooms with considerable less private areas to be.";
            NPC[] sbNPC = new NPC[3];
            sbNPC[0] = new NPC("South Bedroom", "Bob", "Physicist");
            sbNPC[1] = new NPC("South Bedroom", "Bobert", "Nuclear Physicist");
            sbNPC[2] = new NPC("South Bedroom", "Bobby", "Miner");
            southBedroom.setDescription(sbDesc);
            southBedroom.setNPCList(sbNPC);
        }

        // "Moves" the user to the location given to the method
        private void moveTo(Location room)
        {
            player.Stop();
            string[] desc = room.getDescription();
            Random rand = new Random();
            user.setLocation(room.getLocation());
            textBoxName.Text = room.getLocation();
            textBoxDesc.Text = desc[rand.Next(0, desc.Length)];
            ActiveForm.BackgroundImage = Image.FromFile(room.getImage());
            northButton.Enabled = room.getNorth();
            southButton.Enabled = room.getSouth();
            westButton.Enabled = room.getWest();
            eastButton.Enabled = room.getEast();
            NPC[] npcList = room.getNPCList();
            NameText.Clear();
            JobText.Clear();
            for (int i = 0; i < npcList.Length; i++)
            {
                NameText.AppendText(npcList[i].getName() + Environment.NewLine);
                JobText.AppendText(npcList[i].getJob() + Environment.NewLine);
            }

            player = new SoundPlayer(room.getSound());
            player.PlayLooping();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            user.setLocation(textBoxName.Text); // Upon loading the form, set the location to the current location text name
            northButton.Enabled = false;
            southButton.Enabled = false;
            UserText.Text = user.getName() + " - New Arrival";
            player.PlayLooping();
        }

        // "Moves" the user to the west by by calling the correct room update
        private void westButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Reading Room")
            {
                moveTo(hallway);
            }

            else if (user.getLocation() == "Hallway")
            {
                moveTo(diningRoom);
            }

            else if (user.getLocation() == "Outside")
            {
                moveTo(readingRoom);
            }
        }

        // "Moves" the user to the east by by calling the correct room update
        private void eastButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Reading Room")
            {
                moveTo(outside);
            }

            else if (user.getLocation() == "Hallway")
            {
                moveTo(readingRoom);
            }

            else if (user.getLocation() == "Dining Room")
            {
                moveTo(hallway);
            }
        }

        // "Moves" the user to the north by by calling the correct room update
        private void northButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Hallway")
            {
                moveTo(northBedroom);
            }

            else if (user.getLocation() == "South Bedroom")
            {
                moveTo(hallway);
            }
        }

        // "Moves" the user to the south by by calling the correct room update
        private void southButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Hallway")
            {
                moveTo(southBedroom);
            }

            else if (user.getLocation() == "North Bedroom")
            {
                moveTo(hallway);
            }
        }
    }

    // Class that creates a location object that stores all the information of a location
    public class Location
    {
        // The properties of Location
        private string location;
        private string[] description;
        private string image;
        private string sound;
        private NPC[] npcList;
        private Boolean north;
        private Boolean south;
        private Boolean west;
        private Boolean east;

        // Constructor of Location that gets and stores all the information of a location
        public Location(string location, string[] description, string image, string sound, NPC[] npcList, bool north, bool south, bool west, bool east)
        {
            this.location = location;
            this.description = description;
            image = Path.GetFullPath(image); // Gets the full path of an image, so it can be correctly called later
            this.image = image;
            sound = Path.GetFullPath(sound); // Gets the full path of a sound, so it can be correctly called later
            this.sound = sound;
            this.npcList = npcList;
            this.north = north;
            this.south = south;
            this.west = west;
            this.east = east;
        }

        // Setters and getters for the properties of Location
        public void setLocation(string location)
        {
            this.location = location;
        }

        public void setDescription(string[] description)
        {
            this.description = description;
        }

        public void setImage(string image)
        {
            image = Path.GetFullPath(image);
            this.image = image;
        }

        public void setSound(string sound)
        {
            sound = Path.GetFullPath(sound);
            this.sound = sound;
        }

        public void setNPCList(NPC[] npcList)
        {
            this.npcList = npcList;
        }

        public void setNorth(Boolean north)
        {
            this.north = north;
        }

        public void setSouth(Boolean south)
        {
            this.south = south;
        }

        public void setWeat(Boolean west)
        {
            this.west = west;
        }

        public void setEast(Boolean east)
        {
            this.east = east;
        }

        public string getLocation()
        {
            return location;
        }

        public string[] getDescription()
        {
            return description;
        }
        public string getImage()
        {
            return image;
        }

        public string getSound()
        {
            return sound;
        }

        public NPC[] getNPCList()
        {
            return npcList;
        }

        public Boolean getNorth()
        {
            return north;
        }

        public Boolean getSouth()
        {
            return south;
        }

        public Boolean getWest()
        {
            return west;
        }

        public Boolean getEast()
        {
            return east;
        }

    }

    // Actor class that represents a being in the moonbase
    public class Actor
    {
        // The properties of Actor
        string location;
        string name;

        // Constructor of Actor that gets and stores all the information of an actor
        public Actor(string location)
        {
            this.location = location;
            this.name = Environment.UserName;
        }

        // Setters and getters for the properties of Actor
        public void setLocation(String location)
        {
            this.location = location;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public string getLocation()
        {
            return location;
        }

        public string getName()
        {
            return name;
        }
    }

    // NPC class that represents NPCs in the moonbase
    public class NPC : Actor
    {
        // The properties of NPC
        string name;
        string job;

        // Constructor of NPC that gets and stores all the information of an NPC
        public NPC(string location, string name, string job) : base(location)
        {
            this.name = name;
            this.job = job;
        }

        // Setters and getters for the properties of NPC
        public void setName(String name)
        {
            this.name = name;
        }

        public void setJob(String job)
        {
            this.job = job;
        }

        public string getName()
        {
            return name;
        }

        public string getJob()
        {
            return job;
        }
    }

}
