using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furniture_DA;
using Furniture_Ob;

namespace Furniture_B
{
    public class UserOp

    { 
       /* public UserOperations(string username)
        {
            this.username = username;
        }

        public string username { get; set; }

        public List<Product> ShowProducts()
        {
            ProductDB prodDB = new ProductDB();
            List<Product> list = new List<Product>();
            list = prodDB.GetProducts();
            //Report
            ReportDB repDB = new ReportDB();
                       
            string activity = "Viewed the products";
            string date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, date);
            return list;
        }

        public void InsertProduct(Product prod)
        {           
            ProductDB prd = new ProductDB();
            prd.AddProductToDB(prod);
            //Report
            ReportDB repDB = new ReportDB();

            string activity = "Inserted "+prod.name+" product";
            string date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, date);


        }

        public int DeleteProduct(int product_id)
        {
            int pos_to_del_prod=0;
            ProductDB prodDB = new ProductDB();
            pos_to_del_prod = prodDB.DeleteProductDB(product_id);
            //Report
            ReportDB repDB = new ReportDB();

            string activity = "Deleted the product with id "+product_id;
            string date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, date);

            return pos_to_del_prod;
        }

        public void UpdateProduct(Product prod)
        {
            ProductDB prd = new ProductDB();
            prd.UpdateProductToDB(prod);
            //Report
            ReportDB repDB = new ReportDB();

            string activity = "Updated " + prod.name + " product";
            string date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, date);
        }

        public List<Order> ShowOrders()
        {
            OrderDB ord = new OrderDB();
            ProductDB prodDB = new ProductDB();
            List<Order> order_list = new List<Order>();            
            order_list = ord.GetOrders();
            //Report
            ReportDB repDB = new ReportDB();

            string activity = "Viewed orders";
            string date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, date);

            return order_list;
        }

        public int InsertOrder(Order order, int productid, int quantity)
        {
            int checkAvailability = 0;

            OrderDB ordDB = new OrderDB();               
        
            checkAvailability = ordDB.AddOrderToDB(order,productid,quantity);

            //Report
            ReportDB repDB = new ReportDB();

            string activity = "Inserted " + order.id + " order";
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, dateTime);
            return checkAvailability;
        }

        public void UpdateOrder(Order order)
        {
            OrderDB ordDB = new OrderDB();
    
            ordDB.UpdateOrderInDB(order);
            //Report
            ReportDB repDB = new ReportDB();

            string activity = "Updated " + order.id + " order";
            string date = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            repDB.AddReport(this.username, activity, date);
        }
       
        public List<Product> BringOrderProducts(int order_id)
        {
            List<Product> products = new List<Product>();
            ProductDB prod = new ProductDB();
            products = prod.GetProductsByOrderID(order_id);
            return products;
        }

        public List<OrderProduct> BringOP(int order_id)
        {
            List<OrderProduct> order_product = new List<OrderProduct>();
            OrderDB ord = new OrderDB();
            order_product = ord.GetOrderProduct(order_id);
            return order_product;
        }

        public float GetOrderTotalPrice(int order_id)
        {
            List<Product> products = new List<Product>();
            ProductDB prod = new ProductDB();
            products = prod.GetProductsByOrderID(order_id);
            List<OrderProduct> order_product = new List<OrderProduct>();
            OrderDB ord = new OrderDB();
            order_product = ord.GetOrderProduct(order_id);

            float total_price = 0;

            foreach (var product in products)
            {
                foreach (var ordp in order_product)
                {
                    if (ordp.productid == product.id)
                    {                       
                        total_price += product.price * ordp.quantity;
                    }
                }
            }

            return total_price;
        }

        public void DeleteOrderProduct(int order_id, int productid)
        {
            OrderDB ord = new OrderDB();
            ord.DeleteOrderProductFromDB(order_id,productid);
        }
    }*/
    }
}
