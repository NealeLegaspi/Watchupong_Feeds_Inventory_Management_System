using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator
{
    public class ProductListItems
    {
        List<int> ProductId = new List<int>();
        List<int> quanitty = new List<int>();
        List<decimal> price = new List<decimal>();

        private static ProductListItems _instace;
        
        public static ProductListItems Instace
        {
            get
            {
                if(_instace == null)
                {
                    _instace = new ProductListItems();
                }
                return _instace;
            }
        }
        //product line
        public int getId(int count)
        {
            int id = ProductId[count];
            return id;
        }
        public void AddId(int id)
        {
            ProductId.Add(id);
        }
        public void clearItems()
        {
            ProductId.Clear();
        }
        public int getCount() 
        { 
            return ProductId.Count;
        }
        public void DeleteItem(int id)
        {
            ProductId.Remove(id);
        }
        // quantity line 
        public int getquanCount()
        {
            return quanitty.Count;
        }
        public int getInt(int item)
        {
            return quanitty[ProductId.IndexOf(item)];
        }
        public void AddInt(int quan)
        {
            quanitty.Add(quan);
        }
        public void clearquan()
        {
            quanitty.Clear();
        }
        public void Removequan(int indexItem)
        {
            quanitty.Remove(ProductId.IndexOf(indexItem));
        }
        public void UpdateInt(int Pid, int quan)
        {
            quanitty[ProductId.IndexOf(Pid)] = quan;
        }
        // price line
        public int getPriceCount()
        {
            return price.Count;
        }
        public decimal getPrice(int item)
        {
            return price[ProductId.IndexOf(item)];
        }
        public void RemvePrice(int indexItem)
        {
            price.Remove(ProductId.IndexOf(indexItem));
        }
        public void AddPrice(decimal Pprice)
        {
            price.Add(Pprice);
        }
        public void ClearPrice()
        {
            price.Clear();
        }
    


    }
}
