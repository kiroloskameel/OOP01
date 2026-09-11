using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    public class Shipment
    {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get { return _trackingCode; }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        public decimal EstimatedCost
        {
            get
            {
                return _deliveryFee + ((decimal)_weight * 5m);
            }
        }


        public Shipment(string trackingCode)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN-CODE";

            _description = "Unknown";
            _weight = 1.0;
            _deliveryFee = 50m;
            Destination = new DeliveryAddress("Cairo", "Default Street", 1);
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN-CODE";

            Description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
            Weight = weight > 0 ? weight : 1.0;
            DeliveryFee = deliveryFee > 0 ? deliveryFee : 50m;
            Destination = destination;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"DeliveryFee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
