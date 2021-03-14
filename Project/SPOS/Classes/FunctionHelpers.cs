using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPOS.Classes
{
    public static class FunctionHelpers
    {
        public static int getItemTypeFromName(string type_name)
        {
            List<ItemType> itemTypes = Requests.Requests.GetItemTypes();
            foreach (var type in itemTypes)
            {
                if (type.type_name.Equals(type_name))
                    return type.type_id;
            }
            return -1;
        }
    }
}
