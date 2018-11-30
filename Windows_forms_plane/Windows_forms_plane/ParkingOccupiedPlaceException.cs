using System;

namespace Windows_forms_plane
{
    class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоитавтомобиль")
        { }
    }
}
