namespace DataTables.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(256)]
        public string LastName { get; set; }

        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(256)]
        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        [StringLength(256)]
        public string City { get; set; }

        [StringLength(256)]
        public string Region { get; set; }

        [StringLength(256)]
        public string PostalCode { get; set; }

        [StringLength(256)]
        public string Country { get; set; }

        [StringLength(256)]
        public string HomePhone { get; set; }

        [StringLength(256)]
        public string Extension { get; set; }

        public string Notes { get; set; }

        public int? ReportsTo { get; set; }

        [StringLength(256)]
        public string PhotoPath { get; set; }
    }
}
