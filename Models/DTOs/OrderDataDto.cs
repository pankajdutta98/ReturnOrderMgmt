using System;

namespace ReturnOrderMgmtSystemV1.Models.DTOs
{
    public class OrderDataDto
    {        
        public string RequestId { get; set; }
        public string customerName { get; set; }

        public string CustContactNo { get; set; }
        public char ComponentType { get; set; }

        public string ComponentName { get; set; }
        public float Quantity { get; set; }
        public double ProcessingCharge { get; set; }
        public double PckgngAndDlvryCharge { get; set; }
        public DateTime DateOfDelivery { get; set; }        
    }
}
