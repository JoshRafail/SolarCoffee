using System;
using System.Collections.Generic;

namespace SolarCoffee.Web.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public CustomerViewModel Customer { get; set; }
        public List<SalesOrderItemModel> SalesOrderItems { get; set; }
        public bool IsPaid { get; set; }
    }
}