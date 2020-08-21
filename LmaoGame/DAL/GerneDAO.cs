using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectPRN_DAOTesting.DAL
{
    class GerneDAO
    {
        public DataTable getAll()
        {
            return DAO.GetDataTable("Select * from Genre");
        }
    }
}
