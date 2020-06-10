using Dikeko.ORM.Core.DataBase;
using System;
using System.Collections.Generic;
using System.Text;


namespace DikekoStore.Common
{
    public class DataBase
    {
        public IDikekoDataBase db = new DikekoDataBase("DikekoStore");
    }
}
