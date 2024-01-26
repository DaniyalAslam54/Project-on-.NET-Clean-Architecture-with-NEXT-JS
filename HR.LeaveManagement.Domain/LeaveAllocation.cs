﻿using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public partial class LeaveAllocation : BaseEntity
{
    public int NumberofDays { get; set; }
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
    public string EmployeeId { get; set; } = string.Empty;
}
