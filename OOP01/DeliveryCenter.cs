using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    public class DeliveryCenter
    {
        private Shipment[] _shipments = new Shipment[10];

        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= _shipments.Length)
                {
                    return null;
                }
                return _shipments[index];
            }
            set
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                {
                    return null;
                }

                foreach (Shipment shipment in _shipments)
                {
                    if (shipment != null && shipment.TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                    {
                        return shipment;
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null) return false;

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true; 
                }
            }

            return false; 
        }
    }
}
