﻿using DAL;
using BusinessObject;

namespace BAL
{
    public class Bal
    {
        DAL.Dal dal = new Dal();


        public int AddEmployee(Employee emp)
        {

            dal.AddEmployee(emp);
            return 0;
        }
        public int EditEmployee(int id, Employee emp)
        {
            dal.EditEmployee(id, emp);
            return 0;
        }

        public int DeleteEmployee(int id)
        {
            dal.DeleteEmployee(id);
            return 0;
        }
        public List<Employee> GetEmployees()
        {
            return dal.GetEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return dal.GetEmployee(id);
        }

    }
}