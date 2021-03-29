﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Delivery
    {
        private readonly List<Train> _trains;

        public Delivery()
        {
            Status = StatusType.Created;
            _trains = new List<Train>();
            Console.WriteLine("Створено об'єкт класу Delivery");
        }

        public Delivery(string good, int weight, int volume, Station departureStation,
            Station arrivalStation) : this()
        {
            Good = good;
            Weight = weight;
            Volume = volume;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
        }

        public Delivery(Delivery other) : this(other.Good, other.Weight, other.Volume,
            other.DepartureStation, other.ArrivalStation)
        {
        }

        public StatusType Status { get; private set; }
        public string Good { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }
        public float Price { get; set; }
        public Station DepartureStation { get; set; }
        public Station ArrivalStation { get; set; }
        public int RouteLength { get; set; }
        public ReadOnlyCollection<Train> Trains => _trains.AsReadOnly();

        public void ChangeStatus(StatusType newStatus)
        {
            Status = newStatus;
        }

        public void AddTrain(Train train)
        {
            _trains.Add(train);
        }

        public void CountPrice()
        {
            Price = RouteLength * Weight * Volume / 1000;
        }
    }
}
