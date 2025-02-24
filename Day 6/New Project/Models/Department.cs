using System;
using System.Collections.Generic;

namespace New_Project.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? DepartmentName { get; set; }

    public string? Location { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? CreatedAt { get; set; }
}
