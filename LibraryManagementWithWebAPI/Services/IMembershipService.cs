﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWithWebAPI.Services
{
    public interface IMembershipService
    {
        List<Student> ShowAllStudent();
       Student ShowMemberProfile(int id);
        bool EnrollMembership(int id, string name);
        void DeleteStudent(int id);
        bool UpdateProfile(int id, Student student);
        bool ReceiveFine(int Id, double FineAmount);
    }
}
