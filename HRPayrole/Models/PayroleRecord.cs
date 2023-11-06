using System;
using System.Collections.Generic;

namespace HRPayrole.Models
{
    public class PayRoleRecord
    {
        public int PayId { get; set; }
        public string Month { get; set; }
        public string MonthCap { get; set; }
        public string MonthTill { get; set; }
        public string MonthTillCap { get; set; }
        public string status { get; set; }
        public string Total { get; set; }
        public string Process { get; set; }
        public string EPF { get; set; }
        public string ESI { get; set; }
        public string TDS { get; set; }
        public int Active { get; set; }
        public string TotalPay { get; set; }
        public string TotalPayDate { get; set; }
    }
    public class GetPayRoleRecord
    {
        public List<PayRoleRecord> PayRoleRecord()
        {
            var Pays = new List<PayRoleRecord>();
            var Pay1 = new PayRoleRecord()
            {
                PayId = 1,
                Month = "Jan 2022",
                MonthCap = "JAN 2022",
                MonthTill = "DEC 26 - JAN 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "200/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay1);
            var Pay2 = new PayRoleRecord()
            {
                PayId = 2,
                Month = "Feb 2022",
                MonthCap = "JAN 2022",
                MonthTill = "JAN 26 - FEB 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "200/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay2);
            var Pay3 = new PayRoleRecord()
            {
                PayId = 3,
                Month = "Mar 2022",
                MonthCap = "JAN 2022",
                MonthTill = "FEB 26 - MAR 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay3);
            var Pay4 = new PayRoleRecord()
            {
                PayId = 4,
                Month = "Apr 2022",
                MonthCap = "JAN 2022",
                MonthTill = "MAR 26 - APR 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay4);
            var Pay5 = new PayRoleRecord()
            {
                PayId = 5,
                Month = "May 2022",
                MonthCap = "JAN 2022",
                MonthTill = "APR 26 - MAY 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay5);
            var Pay6 = new PayRoleRecord()
            {
                PayId = 6,
                Month = "Jun 2022",
                MonthCap = "JAN 2022",
                MonthTill = "MAY 26 - JUN 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay6);
            var Pay7 = new PayRoleRecord()
            {
                PayId = 7,
                Month = "Jul 2022",
                MonthCap = "JAN 2022",
                MonthTill = "JUN 26 - JUL 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay7);
            var Pay8 = new PayRoleRecord()
            {
                PayId = 8,
                Month = "Aug 2022",
                MonthCap = "JAN 2022",
                MonthTill = "JUL 26 - AUG 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay8);
            var Pay9 = new PayRoleRecord()
            {
                PayId = 9,
                Month = "Sep 2022",
                MonthCap = "JAN 2022",
                MonthTill = "AUG 26 - SEP 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "COMPLETED",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay9);
            var Pay10 = new PayRoleRecord()
            {
                PayId = 10,
                Month = "Oct 2022",
                MonthCap = "JAN 2022",
                MonthTill = "SEP 26 - OCT 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "ONGOING",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay10);
            var Pay11 = new PayRoleRecord()
            {
                PayId = 11,
                Month = "Nov 2022",
                MonthCap = "JAN 2022",
                MonthTill = "OCT 26 - NOV 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "UPCOMING",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay11);
            var Pay12 = new PayRoleRecord()
            {
                PayId = 12,
                Month = "Dec 2022",
                MonthCap = "JAN 2022",
                MonthTill = "NOV 26 - DEC 25",
                MonthTillCap = "DEC 26 - JAN 25",
                status = "UPCOMING",
                Total = "200",
                Process = "147/200",
                EPF = "11,29,000.00",
                ESI = "11,29,000.00",
                TDS = "11,29,000.00",
                Active = 80,
                TotalPay = "15.19.21.000.00",
                TotalPayDate = "31/01/2022",
            };
            Pays.Add(Pay12);
            return Pays;
            
        }
    }
}

