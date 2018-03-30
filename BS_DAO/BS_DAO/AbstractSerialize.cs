using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_DAO
{
    public abstract class AbstractSerialize
    {
        public abstract Admin ReadAdmin();

        public abstract void ReadBookList();

        public abstract void WriteBookList();
    }
}
