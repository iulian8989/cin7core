using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace CIN7Core_MFT_EDI.Models
{
    [XmlRoot(ElementName = "ORDERS")]
    public class Orders
    {
        [XmlElement(ElementName = "Order")]
        public List<Order> OrderList { get; set; }
    }

    public class Order
    {
        [XmlElement(ElementName = "SOH")]
        public SOH SOH { get; set; }

        [XmlElement(ElementName = "SOL")]
        public List<SOL> SOLList { get; set; }
    }

    public class SOH
    {
        [XmlElement(ElementName = "OrderID")]
        public string OrderID { get; set; }

        [XmlElement(ElementName = "CustRef")]
        public string CustRef { get; set; }

        [XmlElement(ElementName = "DebtorID")]
        public string DebtorID { get; set; }

        [XmlElement(ElementName = "DebtorName")]
        public string DebtorName { get; set; }

        [XmlElement(ElementName = "DebtorAdd1")]
        public string DebtorAdd1 { get; set; }

        [XmlElement(ElementName = "DebtorPostCode")]
        public string DebtorPostCode { get; set; }

        [XmlElement(ElementName = "DebtorCity")]
        public string DebtorCity { get; set; }

        [XmlElement(ElementName = "DebtorCountry")]
        public string DebtorCountry { get; set; }

        [XmlElement(ElementName = "InvoiceName")]
        public string InvoiceName { get; set; }

        [XmlElement(ElementName = "InvoiceAdd1")]
        public string InvoiceAdd1 { get; set; }

        [XmlElement(ElementName = "InvoicePostCode")]
        public string InvoicePostCode { get; set; }

        [XmlElement(ElementName = "InvoiceCity")]
        public string InvoiceCity { get; set; }

        [XmlElement(ElementName = "InvoiceCountry")]
        public string InvoiceCountry { get; set; }

        [XmlElement(ElementName = "ClientRef")]
        public string ClientRef { get; set; }

        [XmlElement(ElementName = "WhsID")]
        public string WhsID { get; set; }

        [XmlElement(ElementName = "RepCode")]
        public string RepCode { get; set; }

        [XmlElement(ElementName = "Carrier")]
        public string Carrier { get; set; }

        [XmlElement(ElementName = "ServiceDesc")]
        public string ServiceDesc { get; set; }

        [XmlElement(ElementName = "CustomerID")]
        public string CustomerID { get; set; }

        [XmlElement(ElementName = "DebtorPhone")]
        public string DebtorPhone { get; set; }

        [XmlElement(ElementName = "OrderType")]
        public string OrderType { get; set; }

        [XmlElement(ElementName = "VIPEmail")]
        public string VIPEmail { get; set; }

        [XmlElement(ElementName = "Incoterm")]
        public string Incoterm { get; set; }

        [XmlElement(ElementName = "IncotermPlace")]
        public string IncotermPlace { get; set; }

        [XmlElement(ElementName = "Urgent")]
        public bool Urgent { get; set; }

        [XmlElement(ElementName = "Comment2")]
        public string Comment2 { get; set; }

        [XmlElement(ElementName = "RequiredDate")]
        public string RequiredDate { get; set; }

        [XmlElement(ElementName = "BookingToDate")]
        public string BookingToDate { get; set; }

        [XmlElement(ElementName = "DebtorVAT")]
        public string DebtorVAT { get; set; }

        [XmlElement(ElementName = "DebtorEORI")]
        public string DebtorEORI { get; set; }

        [XmlElement(ElementName = "DebtorVOEC")]
        public string DebtorVOEC { get; set; }
    }

    public class SOL
    {
        [XmlElement(ElementName = "Line")]
        public Line Line { get; set; }
    }

    public class Line
    {
        [XmlElement(ElementName = "OrderID")]
        public string OrderID { get; set; }

        [XmlElement(ElementName = "LineNo")]
        public string LineNo { get; set; }

        [XmlElement(ElementName = "WhsStockCode")]
        public string WhsStockCode { get; set; }

        [XmlElement(ElementName = "Quantity")]
        public int Quantity { get; set; }

        [XmlElement(ElementName = "Grade1")]
        public string Grade1 { get; set; }

        [XmlElement(ElementName = "Grade2")]
        public string Grade2 { get; set; }

        [XmlElement(ElementName = "UnitPrice")]
        public decimal UnitPrice { get; set; }

        [XmlElement(ElementName = "Currency")]
        public string Currency { get; set; }

        [XmlElement(ElementName = "FreightCosts")]
        public decimal FreightCosts { get; set; }

        [XmlElement(ElementName = "CurrencyFreight")]
        public string CurrencyFreight { get; set; }

        [XmlElement(ElementName = "InsuranceCosts")]
        public decimal InsuranceCosts { get; set; }

        [XmlElement(ElementName = "CurrencyInsurance")]
        public string CurrencyInsurance { get; set; }

        [XmlElement(ElementName = "CustStockCode")]
        public string CustStockCode { get; set; }
    }
}
