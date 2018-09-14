using System;
using System.Data.Entity;

namespace ChatCourseWork.DataBase.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}