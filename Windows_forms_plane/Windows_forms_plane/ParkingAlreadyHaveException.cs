using System;

namespace Windows_forms_plane
{
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На парковке уже есть такая машина") { }
    }
}
