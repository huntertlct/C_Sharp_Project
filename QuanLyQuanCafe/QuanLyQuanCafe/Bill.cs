using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe
{
    public class Bill
    {
        private int billNo;
        private DateTime? billCheckInTime;
        private DateTime? billCheckOutTime;
        private int billStt;

        public Bill(DataRow row)
        {
            this.BillNo = (int)row["bill_no"];
            this.BillCheckInTime = (DateTime?)row["bill_checkintime"];
            var billCheckOutTmp = row["bill_checkouttime"];
            if(billCheckOutTmp.ToString() != "")
                this.BillCheckOutTime = (DateTime?)billCheckOutTmp;
            this.BillStt = (int)row["bill_stt"];
        }

        public int BillNo { get => billNo; set => billNo = value; }
        public DateTime? BillCheckInTime { get => billCheckInTime; set => billCheckInTime = value; }
        public DateTime? BillCheckOutTime { get => billCheckOutTime; set => billCheckOutTime = value; }
        public int BillStt { get => billStt; set => billStt = value; }
    }
}
