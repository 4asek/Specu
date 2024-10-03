using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Specu.Application.Entities
{
    public class BookingDTO
    {
        public uint ID { get; set; }
        public int RoomID { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}