using System;
namespace Days_11.models
{
    public struct ProductModel
    {
        public Guid? Pid { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public int Price { get; set; }
        public bool? Status { get; set; }

        public ProductModel(Guid? pid, string title, string detail, int price, bool? status)
        {
            Pid = pid;
            Title = title;
            Detail = detail;
            Price = price;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Pid}-{Title}-{Detail}-{Price}-{Status}";
        }
    }
}