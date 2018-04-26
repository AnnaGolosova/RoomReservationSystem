using RoomReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomReservationSystem
{
    public class DBRepository
    {
        public static FLOOR GetFloor(int Id)
        {
            return new FLOOR() { Id = 1, Number = 1};
        }

        public static Room GetRoom(int Id)
        {
            return new Room() { Id = 1, IdFloor = 1, Number = 234 };
        } 
        public static Event GetEvent(int Id)
        {
            return new Event() { Id = 1, IdGroup = 1, IdRoom = 1, IdType = 1, IdUser = "sdsdcsd", Title = "Some Event"};
        }

        public static Equipment GetEquipment(int Id)
        {
            return new Equipment() { Id = 1, IdInventory = 1, IdRoom = 1};
        }

        public static Inventory GetInventory(int Id)
        {
            return new Inventory() { Id = 1, title = "Some Inventory" };
        }

        public static Event_Type GetEvent_Type(int Id)
        {
            return new Event_Type() { Id = 1, Title = "Some Event type"};
        }

        public static Group GetGroup(int Id)
        {
            return new Group() { Id = 1, Title = "Some Group", IdFaculty = 1};
        }

        public static Faculty GetFaculty(int Id)
        {
            return new Faculty() { Id = 1, Title = "Some Faculty"};
        }

        
        public static List<FLOOR> GetFloor()
        {
            return new List<FLOOR>() { GetFloor(1), GetFloor(1) };
        }

        public static List<Room> GetRoom()
        {
            return new List<Room>() { GetRoom(1), GetRoom(2)};
        }
        public static List<Event> GetEvent()
        {
            return new List<Event>() { GetEvent(1), GetEvent(1), GetEvent(1), GetEvent(1), GetEvent(1), GetEvent(1) };
        }

        public static List<Equipment> GetEquipment()
        {
            return new List<Equipment>() { GetEquipment(1), GetEquipment(1), GetEquipment(1), GetEquipment(1), GetEquipment(1), GetEquipment(1)};
        }

        public static List<Inventory> GetInventory()
        {
            return new List<Inventory>() { GetInventory(1), GetInventory(1), GetInventory(1), GetInventory(1)};
        }

        public static List<Event_Type> GetEvent_Type()
        {
            return new List<Event_Type>() { GetEvent_Type(1), GetEvent_Type(1), GetEvent_Type(1)};
        }

        public static List<Group> GetGroup()
        {
            return new List<Group>() { GetGroup(1), GetGroup(1), GetGroup(1)};
        }

        public static List<Faculty> GetFaculty()
        {
            return new List<Faculty>() { GetFaculty(1), GetFaculty(1), GetFaculty(1), GetFaculty(1) };
        }
    }
}