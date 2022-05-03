using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class ShiftDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public TimeSpan TimeofBegin { get; set; }
        public TimeSpan TimeofEnd { get; set; }

        public ShiftDTO(Shift shift)
        {
            if (shift != null)
            {
                Id = shift.Id;
                Number = shift.Number;
                TimeofBegin = shift.TimeofBegin;
                TimeofEnd = shift.TimeofEnd;
            }
        }
    }
}
