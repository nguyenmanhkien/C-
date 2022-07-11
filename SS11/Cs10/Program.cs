﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
class Department : IEnumerable
{
    string[] departmentNames = { "Marketing", "Finance", "Information", "Technology", "HumanResource" };
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < departmentNames.Length; i++)
        {
            yield return departmentNames[i];
        }
    }

    static void Main(string[] args)
    {
        Department objDepartment = new Department();
        Console.WriteLine("Department Names");
        Console.WriteLine();
        foreach (string str in objDepartment)
        {
            Console.WriteLine(str);
        }
    }
}
