using System;
using System.Collections.Generic;
using System.Linq;

public class PetClinic
{
    private int numberOfRooms;
    private HashSet<int> takenRoomsIndexes;
    private HashSet<int> freedRoomsIndexes;
    private int vacantRoomsCount;

    public PetClinic(string name, int numberOfRooms)
    {
        this.Name = name;
        this.NumberOfRooms = numberOfRooms;
        this.Rooms = new Dictionary<int, Pet>(this.NumberOfRooms);
        this.takenRoomsIndexes = new HashSet<int>(this.NumberOfRooms);
        this.freedRoomsIndexes = new HashSet<int>(this.NumberOfRooms);
        this.vacantRoomsCount = this.NumberOfRooms;
        this.InitializeRooms();
    }

    public string Name { get; private set; }

    public Dictionary<int, Pet> Rooms { get; private set; }

    public int NumberOfRooms
    {
        get { return numberOfRooms; }
        private set
        {
            if (value % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            numberOfRooms = value;
        }
    }

    private void InitializeRooms()
    {
        for (int i = 0; i < this.NumberOfRooms; i++)
        {
            this.Rooms[i] = null;
        }
    }

    public void Print()
    {
        foreach (var room in this.Rooms)
        {
            if (room.Value == null)
            {
                Console.WriteLine("Room empty");
            }
            else
            {
                Console.WriteLine(room.Value);
            }
        }
    }

    public void Print(int index)
    {
        if (this.Rooms[index] == null)
        {
            Console.WriteLine("Room empty");
        }
        else
        {
            Console.WriteLine(this.Rooms[index]);
        }
    }

    public bool HasEmptyRooms()
    {
        if (this.vacantRoomsCount == 0)
        {
            return false;
        }
        return true;
    }

    public bool Release()
    {
        var releaseIndexes = new List<int>(this.NumberOfRooms);

        for (int i = this.Rooms.Count / 2; i < this.Rooms.Count; i++)
        {
            releaseIndexes.Add(i);
        }

        for (int i = 0; i < this.Rooms.Count/ 2; i++)
        {
            releaseIndexes.Add(i);
        }

        bool petFound = false;

        for (int i = 0; i < releaseIndexes.Count; i++)
        {
            if (this.Rooms[releaseIndexes[i]] != null)
            {
                petFound = true;
                this.vacantRoomsCount++;
                this.Rooms[releaseIndexes[i]] = null;
                this.takenRoomsIndexes.Remove(releaseIndexes[i]);
                break;
            }
        }
        return petFound;
    }

    public bool Add(Pet pet)
    {
        if (this.freedRoomsIndexes.Count > 0)
        {
            var index = this.freedRoomsIndexes.First();
            this.freedRoomsIndexes.Remove(index);
            this.Rooms[index] = pet;
            this.takenRoomsIndexes.Add(index);
            this.vacantRoomsCount--;
            return true;
        }
        int takenRoomsCount = this.Rooms.Where(r => r.Value != null).Count();
        if (this.Rooms.All(r => r.Value != null))
        {
            return false;
        }
        if (this.Rooms.Where(r => r.Value == null).Count() == this.Rooms.Count)
        {
            var index = this.Rooms.Count / 2;
            this.Rooms[index] = pet;
            this.takenRoomsIndexes.Add(index);
            this.vacantRoomsCount--;
            return true;
        }
        else
        {
            if (takenRoomsCount % 2 == 1)
            {
                var index = this.takenRoomsIndexes.Last() - takenRoomsCount;
                this.Rooms[index] = pet;
                this.takenRoomsIndexes.Add(index);
                this.vacantRoomsCount--;
                return true;
            }
            else
            {
                var index = this.takenRoomsIndexes.Last() + takenRoomsCount;
                this.Rooms[index] = pet;
                this.takenRoomsIndexes.Add(index);
                this.vacantRoomsCount--;
                return true;
            }
        }
    }
}
