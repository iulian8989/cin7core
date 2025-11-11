using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml.Serialization;
using CIN7Core_MFT_EDI.Models;
using log4net;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CIN7Core_MFT_EDI.Forms
{
    public partial class frmOrders : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(frmOrders));  // Log4Net logger instance
        private readonly Cin7CoreApiClinet client; //class Cin7CoreApiClinet
        private Dictionary<string, decimal> orderSKUUnitPrices ;
        private Dictionary<string, string> customerDetails;
        public frmOrders()
        {
            InitializeComponent(); //constructor and client is an instance of class
            client = new Cin7CoreApiClinet(Properties.Settings.Default.Cin7AccountId.ToString(), Properties.Settings.Default.Cin7APIKey.ToString()); //initiates API client with credentials
            customerDetails = new Dictionary<string, string>();
            orderSKUUnitPrices = new Dictionary<string, decimal>();
            log.Info("frmOrders initialized.");
        }        
        private async void btnFetchSaleOrderList_Click(object sender, EventArgs e) //method
        {
            log.Info("Fetching sale order list.");
            try
            {
                ClearDataGrids();
                var filters = GetFilters(); // collect filters from all like comboboxes and DTP
                log.Debug($"Filters applied: {JsonConvert.SerializeObject(filters)}");
                string jsonResponse = await client.GetListAsync("saleList", filters); //Async API request using client and GetListAsync is called with two arguments
                log.Debug($"Response received for saleList: {jsonResponse}");
                var response = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                var saleList = response.SaleList.ToObject<List<dynamic>>();
                var orderList = new List<object>();
                foreach (var o in saleList)
                {
                    orderList.Add(new
                    {
                        SaleID = (string)o.SaleID, //casting
                        CustomerID = (string)o.CustomerID,
                        OrderNumber = (string)o.OrderNumber,
                        OrderDate = (DateTime?)o.OrderDate,
                        Status = (string)o.Status,
                        InvoiceNumber = (string)o.InvoiceNumber,
                        CustomerReference = (string)o.CustomerReference,
                        InvoiceAmount = (double?)o.InvoiceAmount,
                        PaidAmount = (double?)o.PaidAmount,
                        InvoiceDueDate = (DateTime?)o.InvoiceDueDate,
                        CreditNoteNumber = (string)o.CreditNoteNumber,
                        OrderStatus = (string)o.OrderStatus,
                        CombinedPickingStatus = (string)o.CombinedPickingStatus,
                        CombinedPackingStatus = (string)o.CombinedPackingStatus,
                        FulFilmentStatus = (string)o.FulFilmentStatus,
                        Type = (string)o.Type,
                    });
                }
                dataGridViewSaleOrdersList.DataSource = orderList;
                log.Info($"Sale order list fetched successfully. Total orders: {orderList.Count}");

                if (orderList != null && orderList.Count > 0)
                {
                    dataGridViewSaleOrdersList.Columns[0].Visible = false;
                    dataGridViewSaleOrdersList.Columns[1].Visible = false;
                    dataGridViewSaleOrdersList.Columns[2].Width = 120;
                    dataGridViewSaleOrdersList.Columns[5].Width = 140;
                    dataGridViewSaleOrdersList.Columns[6].Width = 170;
                    dataGridViewSaleOrdersList.Columns[7].Width = 135;
                    dataGridViewSaleOrdersList.Columns[8].Width = 110;
                    dataGridViewSaleOrdersList.Columns[9].Width = 150;
                }                
                bindingNavigatorPositionItem.Text = response.Page.ToString();
                bindingNavigatorCountItem.Text = $"of {Math.Ceiling((double)response.Total / 100)}";
            }
            catch (Exception ex)
            {
                log.Error("Error fetching sale order list.", ex);
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private Dictionary<string, string> GetFilters()
        {
            log.Info("Generating filters for sale order list.");
            var filters = new Dictionary<string, string>();
            if (comboBoxOverallStatus.SelectedIndex > 0)
                filters.Add("Status", comboBoxOverallStatus.SelectedItem.ToString());
            if (comboBoxCombinedPackingStatus.SelectedIndex > 0)
                filters.Add("CombinedPackStatus", comboBoxCombinedPackingStatus.SelectedItem.ToString());
            if (comboBoxCombinedPickingStatus.SelectedIndex > 0)
                filters.Add("CombinedPickStatus", comboBoxCombinedPickingStatus.SelectedItem.ToString());
            if (comboBoxCombinedShippingStatus.SelectedIndex > 0)
                filters.Add("CombinedShippingStatus", comboBoxCombinedShippingStatus.SelectedItem.ToString());
            filters.Add("CreatedSince", dateTimePickerOrderCreated.Value.ToString("yyyy-MM-dd"));
            filters.Add("UpdatedSince", dateTimePickerOrderUpdated.Value.ToString("yyyy-MM-dd"));
            log.Debug($"Filters generated: {JsonConvert.SerializeObject(filters)}");
            return filters;
        }
        private void resetCustomerDetails() 
        {
            log.Info("Resetting customer details.");
            lblCustomerName.Text = "";
            lblTerms.Text = "";
            lblContact.Text = "";
            lblEmail.Text = "";
            lblPhone.Text = "";
            lblShippingAddress.Text = "";
            lblAddressLine.Text = "";
            lblAddPostCode.Text = "";
            lblAddCity.Text = "";
            lblAddCountry.Text = "";
            //lblShippingAddress.Text = "";
            //lblAddressLine.Text = "";
            //lblAddPostCode.Text = "";
            //lblAddCity.Text = "";
            //lblAddCountry.Text = "";
            customerDetails.Clear();
            orderSKUUnitPrices.Clear();
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ResetControls()
        {
            comboBoxOverallStatus.SelectedIndex = 0;
            comboBoxCombinedPackingStatus.SelectedIndex = 0;
            comboBoxCombinedPickingStatus.SelectedIndex = 0;
            comboBoxCombinedShippingStatus.SelectedIndex = 0;
            dateTimePickerOrderCreated.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerOrderUpdated.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            chkIncludeShipped.Checked = false;
            chkIncludeShipped.Checked = false;
            resetCustomerDetails();
        }
        private async void dataGridViewSaleOrdersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                log.Info($"DataGridView Sale Orders List cell clicked. Row index: {e.RowIndex}");
                resetCustomerDetails();
                dataGridViewSaleOrderFulfilments.DataSource = null;
                dataGridViewFulfilmentLines.DataSource = null;
                var saleID = dataGridViewSaleOrdersList.Rows[e.RowIndex].Cells["SaleID"].Value.ToString();

                var customerID = dataGridViewSaleOrdersList.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                // customerDetails["TaxNumber"] = customer.TaxNumber.ToString();
                //log.Debug($"Selected SaleID: {saleID}, CustomerID: {customerID}");
                // Get Customer Details (Name, Contact, Email, Phone, Shipping Address Line 1, Shipping Address Line 2)
                try
                {
                    if (customerID != null)
                    {
                        string jsonCustomerResponse = await client.GetListAsync("customer", new Dictionary<string, string> { { "ID", customerID } });
                        log.Debug($"Customer response: {jsonCustomerResponse}");
                        var customerResponse = JsonConvert.DeserializeObject<dynamic>(jsonCustomerResponse);
                        var customer = customerResponse.CustomerList[0];

                        if (customer != null)
                        {
                            customerDetails["Name"] = customer.Name;
                            customerDetails["PaymentTerm"] = customer.PaymentTerm;
                            customerDetails["TaxNumber"] = customer.TaxNumber.ToString();
                        }
                    }
                    if (saleID != null)
                        {
                        string jsonSaleResponse = await client.GetListAsync("sale", new Dictionary<string, string> { { "ID", saleID } });
                        log.Debug($"Sale response: {jsonSaleResponse}");
                        var saleResponse = JsonConvert.DeserializeObject<dynamic>(jsonSaleResponse);
                        if (saleResponse != null)
                        {
                            
                            if (saleResponse.Order != null && saleResponse.Order.Lines != null)
                                {
                                foreach (var line in saleResponse.Order.Lines)
                                {
                                    // Check if SKU, Total, and Quantity are not null
                                    if (line != null && line.SKU != null && line.Total != null && line.Quantity != null)
                                    {
                                        string sku = line.SKU.ToString();
                                        decimal total;
                                        int quantity = 1;

                                        // Safely parse Total and Quantity, checking for valid values
                                        if (decimal.TryParse(line.Total.ToString(), out total) && int.TryParse(line.Quantity.ToString(), out quantity))
                                        {
                                            if (quantity > 0)
                                            {
                                                decimal unitPrice = total / quantity;
                                                orderSKUUnitPrices[sku] = unitPrice;
                                }
                            }
                                    }
                                }
                            }
                            if (saleResponse.Order != null && saleResponse.Order.AdditionalCharges != null)
                            {
                                decimal shippingcharges = 0.0m;
                                foreach (var charge in saleResponse.Order.AdditionalCharges)
                                {
                                    if (charge !=null && charge.Description !=null) 
                                    {
                                        string chargeDescription = charge.Description.ToString().ToUpper();
                                        if (!chargeDescription.Contains("SHIPPING")) continue;
                                        decimal shiptotal;
                                        int shipquantity = 1;
                                        if (decimal.TryParse(charge.Total.ToString(), out shiptotal) && int.TryParse(charge.Quantity.ToString(), out shipquantity))
                                        {
                                            if (shipquantity > 0)
                                            {
                                                decimal shipunitCost = shiptotal / shipquantity;
                                                shippingcharges = shippingcharges + shipunitCost;
                                            }
                                        }
                                    }                                    
                                }
                                orderSKUUnitPrices["iulian"] = shippingcharges;
                                }
                            customerDetails["Name"] = saleResponse.Customer;
                            customerDetails["PaymentTerm"] = saleResponse.Terms;
                            lblCustomerName.Text = $"Name:{Environment.NewLine}{saleResponse.Customer}";
                            lblTerms.Text = $"Terms: {saleResponse.Terms}";

                            lblContact.Text = $"Contact: {saleResponse.Contact}";
                            lblEmail.Text = $"Email: {saleResponse.Email}";
                            lblPhone.Text = saleResponse.Phone;
                            customerDetails["ContactName"] = saleResponse.Contact;
                            customerDetails["ContactEmail"] = saleResponse.Email;
                            customerDetails["ContactPhone"] = saleResponse.Phone;
                            if (saleResponse.BillingAddress != null) 
                            {   
                                customerDetails["InvoiceAdd1"] = saleResponse.BillingAddress.Line1;
                                customerDetails["InvoiceCity"] = saleResponse.BillingAddress.City;
                                customerDetails["InvoicePostCode"] = saleResponse.BillingAddress.Postcode;
                                customerDetails["InvoiceCountry"] = saleResponse.BillingAddress.Country;
                            }

                            if (saleResponse.ShippingAddress != null)
                            {
                                lblShippingAddress.Text = $"Shipping Address:{Environment.NewLine}{saleResponse.ShippingAddress.DisplayAddressLine1}{Environment.NewLine}{saleResponse.ShippingAddress.DisplayAddressLine2}";
                                lblAddressLine.Text = saleResponse.ShippingAddress.DisplayAddressLine1;
                                lblAddPostCode.Text = saleResponse.ShippingAddress.Postcode;
                                lblAddCity.Text = saleResponse.ShippingAddress.City;
                                lblAddCountry.Text = saleResponse.ShippingAddress.Country;
                            }
                        }
                    }
                    string jsonResponse = await client.GetListAsync($"sale/fulfilment", new Dictionary<string, string> { { "SaleID", saleID } });
                    log.Debug($"Fulfilment response: {jsonResponse}");
                    var saleFulfilments = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    var fulfilmentDetails = new List<object>();
                    
                    foreach (var f in saleFulfilments.Fulfilments)
                    {
                        bool addFulfilment = true;

                        // Check if chkPacked is not checked and the Pack.status is AUTHORISED
                        if (!chkIncludePacked.Checked && f.Pack.Status == "AUTHORISED")
                        {
                            addFulfilment = false;
                        }

                        // Check if chkShipped is not checked and the Ship.status is AUTHORISED
                        if (!chkIncludeShipped.Checked && f.Ship.Status == "AUTHORISED")
                        {
                            addFulfilment = false;
                        }

                        if (addFulfilment)
                        {
                            fulfilmentDetails.Add(new
                            {
                                TaskID = (string)f.TaskID,
                                No = (int?)f.FulfillmentNumber,
                                Status = (string)f.FulFilmentStatus,
                                LinkedInvoiceNumber = (string)f.LinkedInvoiceNumber
                            });
                        }
                            
                    }
                    dataGridViewSaleOrderFulfilments.DataSource = fulfilmentDetails;
                    log.Info($"Fulfilment details loaded. Total fulfilments: {fulfilmentDetails.Count}");
                    if (fulfilmentDetails != null && fulfilmentDetails.Count > 0)
                    {
                        dataGridViewSaleOrderFulfilments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewSaleOrderFulfilments.Columns[0].Visible = false;
                        dataGridViewSaleOrderFulfilments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        dataGridViewSaleOrderFulfilments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // This will take remaining space
                        dataGridViewSaleOrderFulfilments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error loading fulfilment details.", ex);
                    MessageBox.Show($"An error occurred while loading fulfilment details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void dataGridViewSaleOrderFulfilments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                log.Info($"DataGridView Sale Order Fulfilments cell clicked. Row index: {e.RowIndex}");
                lblShippingAddress.Text = "";
                lblAddressLine.Text = "";
                lblAddPostCode.Text = "";
                lblAddCity.Text = "";
                lblAddCountry.Text = "";
                dataGridViewFulfilmentLines.DataSource = null;
                var taskID = dataGridViewSaleOrderFulfilments.Rows[e.RowIndex].Cells["TaskID"].Value.ToString();
                log.Debug($"Selected TaskID: {taskID}");
                try
                {
                    string jsonResponse = await client.GetListAsync($"sale/fulfilment", new Dictionary<string, string> { { "SaleID", taskID } });
                    log.Debug($"Fulfilment response: {jsonResponse}");
                    var response = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    var shippingAddress = response.Fulfilments[0].Ship.ShippingAddress.ToObject<dynamic>();
                    if (shippingAddress != null)
                    {
                        lblShippingAddress.Text = $"Shipping Address:{Environment.NewLine}{shippingAddress.DisplayAddressLine1}{Environment.NewLine}{shippingAddress.DisplayAddressLine2}";
                        lblAddressLine.Text = shippingAddress.DisplayAddressLine1;
                        lblAddPostCode.Text = shippingAddress.Postcode;
                        lblAddCity.Text = shippingAddress.City;
                        lblAddCountry.Text = shippingAddress.Country;
                    }
                    log.Info("Shipping address details loaded.");
                    var fulfilmentLines = response.Fulfilments[0].Pick.Lines.ToObject<List<dynamic>>();
                    var fulfilmentLinesDetails = new List<object>();
                    foreach (var fl in fulfilmentLines)
                    {
                        string sku = (string)fl.SKU;
                        int boxQuantity = await GetBoxQtyAsync(sku); // Await the async method to get the BoxQuantity

                        fulfilmentLinesDetails.Add(new
                        {
                            SKU = sku,
                            Name = (string)fl.Name,
                            Quantity = (int?)fl.Quantity,
                            BoxQuantity = boxQuantity,
                        });
                    }
                    dataGridViewFulfilmentLines.DataSource = fulfilmentLinesDetails;
                    if (fulfilmentLinesDetails.Count > 0)
                    {
                    dataGridViewFulfilmentLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewFulfilmentLines.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewFulfilmentLines.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewFulfilmentLines.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataGridViewFulfilmentLines.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }
                    else { MessageBox.Show("No fulfilment Pick Line found."); }
                    
                    log.Info("Fulfilment lines loaded.");
                }
                catch (Exception ex)
                {
                    log.Error("Error loading fulfilment lines.", ex);
                    MessageBox.Show($"An error occurred while loading fulfilment lines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task<int> GetBoxQtyAsync(string sku)
        {
            try
            {
                if (!sku.ToUpper().StartsWith("CUS."))
                {
                    return 1;
                }

                // Call the API if SKU does not start with "CUS."
                try
                {
                    string jsonCustomerResponse = await client.GetListAsync("product", new Dictionary<string, string> { { "sku", sku } });

                    // Parse JSON response
                    dynamic response = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonCustomerResponse);

                    if (response != null && response.Products.Count > 0)
                    {
                        var product = response.Products[0];

                        // Try to get AdditionalAttribute1
                        try
                        {
                            string additionalAttribute1 = product.AdditionalAttribute1;
                            if (int.TryParse(additionalAttribute1, out int boxQty))
                            {
                                return boxQty;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle parsing error
                            Console.WriteLine($"Error parsing AdditionalAttribute1 for SKU {sku}: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle API call or JSON deserialization error
                    Console.WriteLine($"Error calling API for SKU {sku}: {ex.Message}");
                }

                // Return 1 if AdditionalAttribute1 is null, not an integer, or any exception occurs
                return 1;
            }
            catch (Exception ex)
            {
                // Handle any unforeseen exceptions
                Console.WriteLine($"Unexpected error in GetBoxQtyAsync: {ex.Message}");
                return 1;
            }
        }

        private void ClearDataGrids()
        {
            log.Info("Clearing data grids.");
            dataGridViewSaleOrdersList.DataSource = null;
            dataGridViewSaleOrderFulfilments.DataSource = null;
            dataGridViewFulfilmentLines.DataSource = null;
            resetCustomerDetails();
        }
        // Event handlers for ComboBoxes and DateTimePickers
        private void comboBoxOverallStatus_SelectedIndexChanged(object sender, EventArgs e) => ClearDataGrids();
        private void comboBoxCombinedPickingStatus_SelectedIndexChanged(object sender, EventArgs e) => ClearDataGrids();
        private void comboBoxCombinedPackingStatus_SelectedIndexChanged(object sender, EventArgs e) => ClearDataGrids();
        private void comboBoxCombinedShippingStatus_SelectedIndexChanged(object sender, EventArgs e) => ClearDataGrids();
        private void dateTimePickerOrderCreated_ValueChanged(object sender, EventArgs e) => ClearDataGrids();
        private void dateTimePickerOrderUpdated_ValueChanged(object sender, EventArgs e) => ClearDataGrids();
        private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Info("frmOrders form closing.");
            client?.Dispose();
            base.OnFormClosing(e);
        }
        //private string GetCountryCode(string countryName)
        //{
        //    log.Info($"Getting country code for: {countryName}");
        //    var regions = System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures)
        //                    .Select(culture => new System.Globalization.RegionInfo(culture.Name))
        //                    .Distinct();

        //    var region = regions.FirstOrDefault(r => r.EnglishName.ToLower() == countryName.ToLower());

        //    return region != null ? region.TwoLetterISORegionName : string.Empty;
        //}

        private void btnSync_Click(object sender, EventArgs e)
        {
            log.Info("Sync button clicked.");
            try
            {
                // Get the selected rows
                var selectedOrderRow = dataGridViewSaleOrdersList.SelectedCells[0].OwningRow;
                var selectedFulfilmentRow = dataGridViewSaleOrderFulfilments.SelectedCells[0].OwningRow;

                string debtorName = lblCustomerName.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)[1];
                log.Debug($"Selected Debtor Name: {debtorName}");

                // Create Orders object
                Orders orders = new Orders
                {
                    OrderList = new List<Order>
                    {
                        new Order
                        {
                            SOH = new SOH
                            {
                                OrderID = $"{selectedOrderRow.Cells["OrderNumber"].Value.ToString()}-{selectedFulfilmentRow.Cells["No"].Value.ToString()}",
                                DebtorName = debtorName,
                                DebtorAdd1 = lblAddressLine.Text ?? string.Empty,
                                DebtorPostCode = lblAddPostCode.Text ?? string.Empty,
                                DebtorCity = lblAddCity.Text ?? string.Empty,
                                DebtorCountry =  CountryISOMapper.GetCountryISOCode(lblAddCountry.Text) !="Invalid Country Name" ? CountryISOMapper.GetCountryISOCode(lblAddCountry.Text) : CountryISOMapper.GetCountryISOCode(customerDetails["InvoiceCountry"]),
                                WhsID = "WMD1",
                                CustomerID = "B1",
                                DebtorPhone = lblPhone.Text ?? string.Empty,
                                OrderType = "NO",
                                RepCode = "NO",
                                VIPEmail = lblEmail.Text.Replace("Email: ", "") ?? string.Empty,
                                InvoiceName = debtorName ?? string.Empty,
                                InvoiceAdd1 = customerDetails.ContainsKey("InvoiceAdd1") ? customerDetails["InvoiceAdd1"] : string.Empty,
                                InvoicePostCode = customerDetails.ContainsKey("InvoicePostCode") ? customerDetails["InvoicePostCode"] : string.Empty,
                                InvoiceCity = customerDetails.ContainsKey("InvoiceCity") ? customerDetails["InvoiceCity"] : string.Empty,
                                InvoiceCountry = customerDetails.ContainsKey("InvoiceCountry") ? CountryISOMapper.GetCountryISOCode(customerDetails["InvoiceCountry"])  !="Invalid Country Name" ? CountryISOMapper.GetCountryISOCode(customerDetails["InvoiceCountry"]) : CountryISOMapper.GetCountryISOCode(lblAddCountry.Text) : string.Empty,
                                CustRef = string.Empty,
                                DebtorID = string.Empty,
                                Carrier = string.Empty,
                                ServiceDesc = string.Empty,
                                Incoterm ="DDP",
                                IncotermPlace = string.Empty,
                                Urgent = false,
                                Comment2 = string.Empty,
                                RequiredDate = string.Empty,
                                BookingToDate = string.Empty,
                                DebtorEORI = string.Empty,
                                DebtorVOEC = string.Empty,
                                DebtorVAT = customerDetails.ContainsKey("TaxNumber") ? customerDetails["TaxNumber"] : string.Empty, // Ensure DebtorVAT is set
                                
                            },
                            SOLList = new List<SOL>()
                        }
                    }
                };
                log.Info($"Orders object created with OrderID: {orders.OrderList[0].SOH.OrderID}");

                // Iterate through fulfilment lines
foreach (DataGridViewRow row in dataGridViewFulfilmentLines.Rows)
{
    // 1. Pull raw qty and per-box values
    int qty    = Convert.ToInt32(row.Cells["Quantity"].Value);
    int perBox = Convert.ToInt32(row.Cells["BoxQuantity"].Value);

    // 2. Compute full boxes + remainder
    int fullBoxes = qty / perBox;
    int remainder = qty % perBox;

    // 3. Only round up if remainder ≥ 100
    if (remainder >= 100)
        fullBoxes++;

    // 4. Always ship at least one box
    int boxCount = Math.Max(fullBoxes, 1);

    // 5. Add to your SOL list
    orders.OrderList[0].SOLList.Add(new SOL
    {
        Line = new Line
        {
            OrderID      = $"{selectedOrderRow.Cells["OrderNumber"].Value}-{selectedFulfilmentRow.Cells["No"].Value}",
            LineNo       = (row.Index + 1).ToString("D4"),
            WhsStockCode = row.Cells["SKU"].Value.ToString().ToUpper(),
            Quantity     = boxCount,
            Grade1       = string.Empty,
            Grade2       = string.Empty,
            UnitPrice    = orderSKUUnitPrices.TryGetValue(row.Cells["SKU"].Value.ToString(), out var up) ? up : 0m,
            Currency     = "EUR",
            FreightCosts = orderSKUUnitPrices.TryGetValue("iulian", out var fc) ? fc : 0m,
            CurrencyFreight   = "EUR",
            InsuranceCosts   = 0.0m,
            CurrencyInsurance= "EUR",
            CustStockCode    = row.Cells["SKU"].Value.ToString().ToUpper()
        }
    });
}
                log.Info("Fulfilment lines added to Orders object.");

                string orderID = orders.OrderList[0].SOH.OrderID;
                string fileName = $"MFT_ORD_B1_{orderID}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xml";
                fileName = SanitizeFileName(fileName);
                string filePath = System.IO.Path.Combine(Application.StartupPath, fileName);
                log.Debug($"Sanitized file name: {fileName}, file path: {filePath}");

                // Serialize to XML
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Orders));
                using (var writer = new System.IO.StreamWriter(filePath))
                {
                    xmlSerializer.Serialize(writer, orders);
                }
                log.Info($"Orders object serialized to XML file: {filePath}");

                // Attempt to upload to FTP
                string ftpUrl = Properties.Settings.Default.FtpURL.ToString();
                string ftpDirectory = Properties.Settings.Default.FtpTargetDirectory.ToString();
                string ftpUsername = Properties.Settings.Default.FtpUsername.ToString();
                string ftpPassword = Properties.Settings.Default.FtpPassword.ToString();
                string ftpFilePath = $"{ftpUrl}/{ftpDirectory}/{fileName}";
                log.Info($"Attempting to upload file to FTP server at: {ftpFilePath}");

                if (FtpFileWithSubstringExists($"{ftpUrl}/{ftpDirectory}/", orderID, ftpUsername, ftpPassword))
                {
                    var result = MessageBox.Show($"A file with the name '{fileName}' already exists on the FTP server. Do you want to replace it?",
                                                 "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        log.Info("File upload skipped by user.");
                        MessageBox.Show("File upload skipped.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ResetControls();
                        return;
                    }
                }

                if (UploadFileToFTP(filePath, ftpFilePath, ftpUsername, ftpPassword))
                {
                    log.Info("XML file uploaded to FTP successfully.");
                    MessageBox.Show("XML file uploaded to FTP successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Remove the file from the local drive after successful upload
                    try
                    {
                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);
                            log.Info("Local file deleted successfully.");
                            //MessageBox.Show("Local file deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error("Failed to delete local file.", ex);
                        MessageBox.Show($"Failed to delete local file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    { 
                        //ResetControls(); 
                    }
                }
                else
                {
                    var result = MessageBox.Show("Failed to connect to FTP server. Do you want to save the file locally instead?",
                                                 "FTP Connection Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        string localPath = System.IO.Path.Combine(Application.StartupPath, fileName);
                        System.IO.File.Move(fileName, localPath);
                        log.Info("File saved locally at application path.");
                        MessageBox.Show("File saved locally at application path.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ResetControls();
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error("An error occurred while writing the XML file.", ex);
                MessageBox.Show($"An error occurred while writing the XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string SanitizeFileName(string fileName)
        {
            // Replace invalid characters with an underscore
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }
            return fileName;
        }
        private bool UploadFileToFTP(string localFilePath, string ftpFilePath, string ftpUsername, string ftpPassword)
        {
            try
            {
                log.Info($"Uploading file to FTP: {ftpFilePath}");
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpFilePath);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                using (FileStream fs = new FileStream(localFilePath, FileMode.Open, FileAccess.Read))
                using (Stream requestStream = request.GetRequestStream())
                {
                    fs.CopyTo(requestStream);
                }

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                log.Info("File uploaded successfully to FTP.");
                return true;
            }
            catch (WebException ex)
            {
                log.Error("Error uploading file to FTP.", ex);
                if (ex.Response is FtpWebResponse response && response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    return false; // File does not exist
                }
                else
                {
                    return false; // Re-throw other exceptions
                }
            }
        }
        private bool FtpFileWithSubstringExists(string ftpDirectoryPath, string substring, string ftpUsername, string ftpPassword)
        {
            log.Info($"Checking if any file containing '{substring}' exists on FTP: {ftpDirectoryPath}");
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpDirectoryPath);
                
                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.UsePassive = true;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(substring))
                        {
                            log.Info($"File with substring '{substring}' exists: {line}");
                            return true; // Found a file with the specified substring
                        }
                    }
                }
                log.Info($"No file with substring '{substring}' exists on FTP.");
                return false; // No file with the specified substring found
            }
            catch (WebException ex)
            {
                log.Error("Error checking if file with substring exists on FTP.", ex);
                return false;
               //throw; // Re-throw any exceptions
            }
        }

    }
}
