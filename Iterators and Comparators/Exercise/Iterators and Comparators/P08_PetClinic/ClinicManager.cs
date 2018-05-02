using System;
using System.Collections.Generic;
using System.Linq;

public class ClinicManager
{
    private List<Pet> pets;
    private List<PetClinic> clinics;

    public ClinicManager()
    {
        this.pets = new List<Pet>();
        this.clinics = new List<PetClinic>();
    }

    public void ReadCommands()
    {
        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var input = Console.ReadLine().Split();
            var command = input[0];

            try
            {
                switch (command)
                {
                    case "Create":
                        Create(input);
                        break;
                    case "Add":
                        AddPet(input);
                        break;
                    case "HasEmptyRooms":
                        HasEmptyRooms(input);
                        break;
                    case "Release":
                        ReleasePet(input);
                        break;
                    case "Print":
                        Print(input);
                        break;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private void Print(string[] input)
    {
        var clinicName = input[1];

        if (input.Length == 3)
        {
            int roomNumber = int.Parse(input[2]);
            clinics.First(c => c.Name == clinicName).Print(roomNumber-1);
        }
        else
        {
            clinics.First(c => c.Name == clinicName).Print();
        }
    }

    private void ReleasePet(string[] input)
    {
        var clinicName = input[1];
        Console.WriteLine(clinics.First(c => c.Name == clinicName).Release());
    }

    private void HasEmptyRooms(string[] input)
    {
        var clinicName = input[1];

        Console.WriteLine(clinics.First(c => c.Name == clinicName).HasEmptyRooms());
    }

    private void AddPet(string[] input)
    {
        var petName = input[1];
        var clinicName = input[2];

        Console.WriteLine(clinics.First(c => c.Name == clinicName).Add(pets.First(p => p.Name == petName)));
    }

    private void Create(string[] input)
    {
        var type = input[1];
        if (type == "Clinic")
        {
            var petClinic = new PetClinic(input[2], int.Parse(input[3]));
            clinics.Add(petClinic);
        }
        else
        {
            var pet = new Pet(input[2], int.Parse(input[3]), input[4]);
            pets.Add(pet);
        }
    }
}
