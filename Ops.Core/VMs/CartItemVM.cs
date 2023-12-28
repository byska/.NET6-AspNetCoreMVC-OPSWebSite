using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class CartItemVM
    {
        public CartItemVM()
        {
            
        }
        public CartItemVM(ProductVM product)
        {
            ProductId = product.Id;
            ProductName = product.Name;
            Quantity = 1;
            Image = product.Photo;
            Price = product.Price;
        }
        public int ProductId { get; set; }
       public string ProductName { get; set; }
       public int Quantity { get; set; }
       public decimal Price { get; set; }
       public decimal TotalPrice { get { 
                return Quantity * Price; } }
        public string Image {  get; set; }

    }
}
