using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise_4
{
    internal class Appointment
    {
        public int AppointmentId;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physican";
            AppointmentDate = DateTime.Today;    
        }



    }
}
