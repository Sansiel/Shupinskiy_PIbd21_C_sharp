using System;

namespace Windows_forms_plane
{
    class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден самолет по месту " + i)
        { }

    }
}
