using System;
using System.Collections.Generic;
using SOLID.One.SingleResponsabilityPrinciple.APT;
using SOLID.One.SingleResponsabilityPrinciple.CReport;
using SOLID.Two.OpenClosedPrinciple.Work;

class Program
{
    static void Main(string[] args)
    {
        List<IApplicant> applicants = new List<IApplicant>(){
            new CloudEngineer { FirstName = "Lm", LastName = "Marqz"},
            new Doctor {FirstName = "Lou", LastName = "Mch"},
            new Nurse {FirstName = "Eli", LastName = "Arg"},
            new DataEngineer {FirstName = "Samaly", LastName = "Vqz"}
        };
        
        List<Staff> staffs = new List<Staff>();

        foreach(var staff in applicants){
            staffs.Add(staff.Processor.Create(staff));
        }

        foreach(var staff in staffs){
            Console.WriteLine($"Bienvenido {staff.FirstName} {staff.LastName} ({staff.Email})");
        }

        Console.ReadKey();




        // var report = new CourseReport();
        // report.AddEntry(new CourseReportEntry {Name = "Patrones de Disenio", Students = 250, Rating = 4.7});
        // report.AddEntry(new CourseReportEntry {Name = "Flutter", Students = 500, Rating = 4.9});
        // report.AddEntry(new CourseReportEntry {Name = "CSharp .Net 8", Students = 1200, Rating = 5.0});

        // var storage = new FileStorageService();
        // var date = $"{DateTime.Now.ToString("dd-mm-yy--hh-mm-ss")}";
        // storage.Save("Reports", $"report-{date}.txt", report.ToString());







        // var appt = new Appointment {
        //     Patient = new Patient {
        //         Name = "Elmer Marquez",
        //         Email = "leomarqz@gmail.com"
        //     },
        //     Time = DateTime.Now.AddDays(2).AddHours(2)
        // };

        // var apptService = new AppointmentService();

        // var response = apptService.Create(appt);

        // Console.WriteLine(response);
    }
}