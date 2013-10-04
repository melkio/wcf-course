using Contracts;
using System;

namespace Services
{
    public class HierarchyServiceImpl : IHierarchyService
    {
        public Boolean Save(Person person)
        {
            return person != null 
                && !String.IsNullOrEmpty(person.Name) 
                && person.Name.Length > 5;
        }
    }
}
