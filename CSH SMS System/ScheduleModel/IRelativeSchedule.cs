using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleModel
{
    interface IRelativeSchedule
    {
        SchedulePeriod Period { get; set; }
        int PeriodQuantity { get; set; }
        BeforeAfter BeforeAfter { get; set; }
    }
}
