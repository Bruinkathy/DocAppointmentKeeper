﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocAppointmentKeeper.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Doctor = "Doctor";
        public static string Patient = "Patient";

        public static string appointmentAdded = "Appointment added successfully.";
        public static string appointmentUpdated = "Appointment updated successfully.";
        public static string appointmentDeleted = "Appointment deleted successfully.";
        public static string appointmentExists = "Appointment for selected date and tie already exists.";
        public static string appointmentNotExists = "Appointment does not exist";

        public static string appointmentAddError = "Something went wrong. Please try again.";
        public static string appointmentUpdateError = "Something went wrong. Please try again.";
        public static string somethingWentWrong = "Something went wrong. Please try again.";

        public static int success_code = 1;
        public static int failure_code = 0;

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Value=Helper.Admin,Text=Helper.Admin },
                new SelectListItem{ Value=Helper.Doctor,Text=Helper.Doctor },
                new SelectListItem{ Value=Helper.Patient,Text=Helper.Patient }
            };
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 60;
            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 1; i<=12; i++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr" });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr 30 min" });
                minute = minute + 30;
            }

            return duration;
        }


    }
}
