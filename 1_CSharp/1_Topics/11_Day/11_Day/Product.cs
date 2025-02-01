using System;
using System.Net.NetworkInformation;
using Days_11.models;

namespace Days_11
{
    public class Product
    {
        public int age = 30;
        private Customer customer = new Customer();
        private int productId = 0;

        public Product()
        {
            Console.WriteLine(age);
            productId = 101;
        }

        public string ProductSliderTitle()
        {
            return productId switch
            {
                100 => "TV",
                101 => "iPhone",
                _ => ""
            };
        }

        public bool ProductSave(ProductModel productModel)
        {
            Console.WriteLine($"{productModel.title} - {productModel.price} - {productModel.detail} - {productModel.status}");
            return true;
        }

        public ProductModel Save(ProductModel productModel)
        {
            productModel.Pid = Guid.NewGuid();
            return productModel;
        }

        public void GetStatus(EStatus eStatus)
        {
            switch (eStatus)
            {
                case EStatus.USER:
                    Console.WriteLine("User Status");
                    break;
                case EStatus.ADMIN:
                    Console.WriteLine("Admin Status");
                    break;
                case EStatus.CUSTOMER:
                    Console.WriteLine("Customer Status");
                    break;
                default:
                    Console.WriteLine("Empty Status");
                    break;
            }
        }
    }
}
