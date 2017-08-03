using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataTables.Models
{
    public class InitDatabase : DropCreateDatabaseAlways<DataTablesModel>
    {
        protected override void Seed(DataTables.Models.DataTablesModel context)
        {
            List<Employees> employeesList = new List<Employees>();

            employeesList.Add(new Employees {
                FirstName = "Nancy",
                LastName = "Davolio",
                Title = "Sales Representative",
                TitleOfCourtesy = "Ms.",
                BirthDate = Convert.ToDateTime("1948-12-08 00:00:00.000"),
                HireDate = Convert.ToDateTime("1992-05-01 00:00:00.000"),
                Address = "507 - 20th Ave. E. Apt. 2A",
                City = "Seattle",
                Region = "WA",
                PostalCode = "98122",
                Country = "USA",
                HomePhone = "(206) 555-9857",
                Extension = "5467",
                Notes = "Education includes a BA in psychology from Colorado State University in 1970.  She also completed The Art of the Cold Call. Nancy is a member of Toastmasters International.",
                ReportsTo = 2,
                PhotoPath = "../Content/images/1.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Andrew",
                LastName = "Fuller",
                Title = "Vice President, Sales",
                TitleOfCourtesy = "Dr.",
                BirthDate = Convert.ToDateTime("1952-02-19 00:00:00.000"),
                HireDate = Convert.ToDateTime("1992-08-14 00:00:00.000"),
                Address = "908 W. Capital Way",
                City = "Tacoma",
                Region = "WA",
                PostalCode = "98401",
                Country = "USA",
                HomePhone = "(206) 555-9482",
                Extension = "3457",
                Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.",
                ReportsTo = null,
                PhotoPath = "../Content/images/2.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Janet",
                LastName = "Leverling",
                Title = "Sales Representative",
                TitleOfCourtesy = "Ms.",
                BirthDate = Convert.ToDateTime("1963-08-30 00:00:00.000"),
                HireDate = Convert.ToDateTime("1992-04-01 00:00:00.000"),
                Address = "722 Moss Bay Blvd.",
                City = "Kirkland",
                Region = "WA",
                PostalCode = "98033",
                Country = "USA",
                HomePhone = "(206) 555-3412",
                Extension = "3355",
                Notes = "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.",
                ReportsTo = 2,
                PhotoPath = "../Content/images/3.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Margaret",
                LastName = "Peacock",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mrs.",
                BirthDate = Convert.ToDateTime("1937-09-19 00:00:00.000"),
                HireDate = Convert.ToDateTime("1993-05-03 00:00:00.000"),
                Address = "4110 Old Redmond Rd.",
                City = "Redmond",
                Region = "WA",
                PostalCode = "98052",
                Country = "USA",
                HomePhone = "(206) 555-8122",
                Extension = "5176",
                Notes = "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.",
                ReportsTo = 2,
                PhotoPath = "../Content/images/4.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Steven",
                LastName = "Buchanan",
                Title = "Sales Manager",
                TitleOfCourtesy = "Mr.",
                BirthDate = Convert.ToDateTime("1955-03-04 00:00:00.000"),
                HireDate = Convert.ToDateTime("1993-10-17 00:00:00.000"),
                Address = "14 Garrett Hill",
                City = "London",
                Region = null,
                PostalCode = "SW1 8JR",
                Country = "UK",
                HomePhone = "(71) 555-4848",
                Extension = "3453",
                Notes = "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses Successful Telemarketing and International Sales Management.  He is fluent in French.",
                ReportsTo = 2,
                PhotoPath = "../Content/images/5.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Michael",
                LastName = "Suyama",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mr.",
                BirthDate = Convert.ToDateTime("1963-07-02 00:00:00.000"),
                HireDate = Convert.ToDateTime("1993-10-17 00:00:00.000"),
                Address = "Coventry House Miner Rd.",
                City = "London",
                Region = null,
                PostalCode = "EC2 7JR",
                Country = "UK",
                HomePhone = "(71) 555-7773",
                Extension = "428",
                Notes = "Michael is a graduate of Sussex University (MA, economics, 1983) and the University of California at Los Angeles (MBA, marketing, 1986).  He has also taken the courses Multi - Cultural Selling and Time Management for the Sales Professional. He is fluent in Japanese and can read and write French, Portuguese, and Spanish.",
                ReportsTo = 5,
                PhotoPath = "../Content/images/6.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Robert",
                LastName = "King",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mr.",
                BirthDate = Convert.ToDateTime("1960-05-29 00:00:00.000"),
                HireDate = Convert.ToDateTime("1994-01-02 00:00:00.000"),
                Address = "Edgeham Hollow Winchester Way",
                City = "London",
                Region = null,
                PostalCode = "RG1 9SP",
                Country = "UK",
                HomePhone = "(71) 555-5598",
                Extension = "465",
                Notes = "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan in 1992, the year he joined the company.  After completing a course entitled Selling in Europe, he was transferred to the London office in March 1993.",
                ReportsTo = 5,
                PhotoPath = "../Content/images/7.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Laura",
                LastName = "Callahan",
                Title = "Inside Sales Coordinator",
                TitleOfCourtesy = "Ms.",
                BirthDate = Convert.ToDateTime("1958-01-09 00:00:00.000"),
                HireDate = Convert.ToDateTime("1994-03-05 00:00:00.000"),
                Address = "4726 - 11th Ave. N.E.",
                City = "Seattle",
                Region = "WA",
                PostalCode = "98105",
                Country = "USA",
                HomePhone = "(206) 555-1189",
                Extension = "2344",
                Notes = "Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French.",
                ReportsTo = 2,
                PhotoPath = "../Content/images/8.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Anne",
                LastName = "Dodsworth",
                Title = "Sales Representative",
                TitleOfCourtesy = "Ms.",
                BirthDate = Convert.ToDateTime("1966-01-27 00:00:00.000"),
                HireDate = Convert.ToDateTime("1994-11-15 00:00:00.000"),
                Address = "7 Houndstooth Rd.",
                City = "London",
                Region = null,
                PostalCode = "WG2 7LT",
                Country = "UK",
                HomePhone = "(71) 555-4444",
                Extension = "452",
                Notes = "Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German.",
                ReportsTo = 5,
                PhotoPath = "../Content/images/9.jpg"
            });
            employeesList.Add(new Employees
            {
                FirstName = "Kobe",
                LastName = "Bryant",
                Title = "NBA Player",
                TitleOfCourtesy = "Mr.",
                BirthDate = Convert.ToDateTime("1978-8-23 00:00:00.000"),
                HireDate = Convert.ToDateTime("	1996-7-11 00:00:00.000"),
                Address = "Staples Center",
                City = "Los Angeles",
                Region = null,
                PostalCode = null,
                Country = "USA",
                HomePhone = "(00) 000-1111",
                Extension = "24",
                Notes = "An American retired professional basketball player and businessman.",
                ReportsTo = null,
                PhotoPath = "../Content/images/10.jpg"
            });

            employeesList.Add(new Employees
            {
                FirstName = "Kevin",
                LastName = "Durant",
                Title = "NBA Player",
                TitleOfCourtesy = "Mr.",
                BirthDate = Convert.ToDateTime("1988-9-29 00:00:00.000"),
                HireDate = Convert.ToDateTime("	2007-6-28 00:00:00.000"),
                Address = "Oracle Arena",
                City = "State of California",
                Region = null,
                PostalCode = null,
                Country = "USA",
                HomePhone = "(00) 000-2222",
                Extension = "35",
                Notes = "An American professional basketball player for the Golden State Warriors of the National Basketball Association .",
                ReportsTo = null,
                PhotoPath = "../Content/images/11.jpg"
            });

            context.Employees.AddRange(employeesList);

            context.SaveChanges();
        }
    }
}