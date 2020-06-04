using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        private static int nextID = 1000;
        public int EntityID { get; }
        private int AssignID()
        {
            int id = nextID;
            nextID += 1;
            return id;
        }

        public AbstractEntity()
        {
            EntityID = AssignID();
        }


    }
}
