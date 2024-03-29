﻿using System;
using System.Collections.Generic;

namespace Employee_Management_React_App.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }
}
