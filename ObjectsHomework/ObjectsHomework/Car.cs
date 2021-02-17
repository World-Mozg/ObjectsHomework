using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsHomework
{
    public class Car
    {
        private string Model;
        private string SerialNumber;
        private double Speed;
        private double FuelTankCapacity;
        private int NumberOfSeats;
        private static string CarClass = "легковой транспорт";
        private static int NumberOfWheels = 4;

        public Car()
        {
            Model = "Lada";
            SerialNumber = "5e7df8";
            Speed = 200;
            FuelTankCapacity = 6;
            NumberOfSeats = 5;
        }

        static Car()
        {  }

        public Car(string Model, string SerialNumber, double Speed, double FuelTankCapacity, int NumberOfSeats)
        {
            this.Model = Model;
            this.SerialNumber = SerialNumber;
            this.Speed = Speed;
            this.FuelTankCapacity = FuelTankCapacity;
            this.NumberOfSeats = NumberOfSeats;
        } 
        public Car(string Model, double Speed)
        {
            this.Model = Model;
            this.Speed = Speed;
        }

        public string GetModel()
        {
            return Model;
        }
        public void SetModel(string Model)
        {
            this.Model = Model;
        } 
        
        public string GetSerialNumber()
        {
            return SerialNumber;
        }
        public void SetSerialNumber(string SerialNumber)
        {
            this.SerialNumber = SerialNumber;
        } 
        
        public double GetSpeed()
        {
            return Speed;
        }
        public void SetSpeed(double Speed)
        {
            this.Speed = Speed;
        } 
        
        public double GetFuelTankCapacity()
        {
            return FuelTankCapacity;
        }
        public void SetFuelTankCapacity(double FuelTankCapacity)
        {
            this.FuelTankCapacity = FuelTankCapacity;
        } 
        
        public int GetNumberOfSeats()
        {
            return NumberOfSeats;
        }
        public void SetNumberOfSeats(int NumberOfSeats)
        {
            this.NumberOfSeats = NumberOfSeats;
        }

        public string GetCarClass()
        {
            return CarClass;
        }

        public int GetNumberOfWheels()
        {
            return NumberOfWheels;
        }
    }
}
