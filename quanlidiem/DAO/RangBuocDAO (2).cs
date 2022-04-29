using QLDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
  public  class RangBuocDAO
    {
        private static RangBuocDAO instance;

        public static RangBuocDAO Instance
        {
            get { if (instance == null) instance = new RangBuocDAO(); return RangBuocDAO.instance; }
            private set { RangBuocDAO.instance = value; }
        }
        private RangBuocDAO() { }
        public List<RangBuoc> GetListRangBuoc()
        {
            List<RangBuoc> list = new List<RangBuoc>();
            string query = "select *from RangBuoc ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                RangBuoc rangbuoc = new RangBuoc(item);
                list.Add(rangbuoc);
            }
            return list;
        }
    }
}
