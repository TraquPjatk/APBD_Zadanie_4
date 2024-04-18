﻿namespace APBD_Zadanie_4
{
    public class AnimalsDataStore
    {
        public List<Animal> Animals { get; set; }

        public static AnimalsDataStore Current { get; } = new AnimalsDataStore();

        public AnimalsDataStore()
        {
            Animals = new List<Animal>()
            {
                new Animal
                {
                    Id=1 ,
                    Name ="Fifek",
                    Category="Dog",
                    Color="White",
                    Weight=12,
                    Visits = new List<Visit>()
                },
                new Animal
                {
                    Id=2 ,
                    Name ="Miauczek",
                    Category="Cat",
                    Color="Orange",
                    Weight=7,
                    Visits = new List<Visit>()
                },
                new Animal
                {
                    Id=3 ,
                    Name ="Owca",
                    Category="Sheep",
                    Color="Black",
                    Weight=9,
                    Visits = new List<Visit>()
                },
            };
        }
    }
}