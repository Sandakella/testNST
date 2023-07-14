﻿using testNST.Models;
using System.Collections.Generic;

namespace testNST
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Get();
        Person Get(long id);
        void PostPerson(Person item);
        void PutPerson(Person item);
        Person Delete(long id);
    }
}