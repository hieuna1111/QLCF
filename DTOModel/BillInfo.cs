using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLCafe.DTOModel
{
    public class BillInfo
    {
        public BillInfo(int foodID, int billID, int count)
        {
            this.FoodID = foodID;
            this.BillID = billID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.FoodID = (int)row["FoodID"];
            this.BillID = (int)row["BillID"];
            this.Count = (int)row["Count"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int foodID;

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }
    }
}
