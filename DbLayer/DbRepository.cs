using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbLayer
{
    public static class DbRepository
    {
        private static HotelPlazaContext context = new HotelPlazaContext();

        public static HotelPlazaContext Context { get { return context; } }
    }
}
