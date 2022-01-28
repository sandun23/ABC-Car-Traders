using ABC_Car_Traders.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo
{
    interface ISparePartRepo
    {
        bool AddSparePart(SparePart sparePart);

        List<SparePart> GetAllSpareParts();

        List<SparePart> FilterSparePartList(string filterString);

        SparePart FilterSparePartListCustomer(string spareName, string sparebrand);
    }
}
