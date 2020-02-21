using System;
using System.Collections.Generic;
using System.Text;
using Task10.Entities;

namespace Task10.BLL.Interfaces
{
    public interface IAwardLogic
    {
        void Add(Award award);
        void Remove(int id);
        Award GetById(int id);
        IEnumerable<Award> GetAll();
    }
}
