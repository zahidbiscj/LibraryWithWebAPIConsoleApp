﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWithWebAPI.Services
{
    public interface IReportingService
    {
        int CheckLateFee(int id, string Barcode);
        double CheckFine(int Id);
        int CalculateFine(DateTime ReturnDate, DateTime IssueDate);
    }
}
