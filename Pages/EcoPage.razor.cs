using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Reflection;

namespace EcoTest.Pages
{
    public partial class EcoPage
    {
        public Delta delta = new Delta(); 
        public int editRow = 0;
       public int index = 1;
        public void EnableEditMode(int num)
        {
             
            Console.WriteLine(num);
            index = 1;
            editRow = num;    // Asignar el valor actual del índice
            
            delta.Id = deltaList[num-1].Id;
            delta.Name = deltaList[num-1].Name;
            delta.LastName = deltaList[num-1].LastName;
            delta.UnitPrice = deltaList[num-1].UnitPrice;
            delta.Item = deltaList[num-1].Item;
            Console.WriteLine(index);
        }
        
        public void Save(int num,string name)
        {
            
            Console.WriteLine(deltaList[num-1].Name);
            editRow = 0;
           index = 1;

            deltaList[num - 1].Id = delta.Id;
            deltaList[num-1].Name = delta.Name;
            deltaList[num-1].LastName = delta.LastName;
            deltaList[num - 1].UnitPrice = delta.UnitPrice;
            deltaList[num - 1].Item = delta.Item;

            delta = new Delta();
           
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
           
                index = 1;
            
        }
        public void Cancel()
        {
            
            index = 1;
            editRow = 0;

        }

        List<Delta> deltaList;

        protected override void OnInitialized()
        {
            deltaList = new List<Delta>();
            deltaList.Add(new Delta { Id = 23, Name = "a n g e l a", LastName = "jauregui", UnitPrice = 8.93, Item = "compu" });
            deltaList.Add(new Delta { Id = 43, Name = "angela", LastName = "ggrt", UnitPrice = 8.93, Item = "feger" });
            deltaList.Add(new Delta { Id = 26, Name = "angela", LastName = "greg", UnitPrice = 8.93, Item = "grege" });
            deltaList.Add(new Delta { Id = 27, Name = "juan", LastName = "romeor", UnitPrice = 8.93, Item = "wfeg" });
            deltaList.Add(new Delta { Id = 29, Name = "francis", LastName = "tghrg", UnitPrice = 8.93, Item = "gege" });
            base.OnInitialized();
        }
   
        private void FormClosed()
        {
            Console.WriteLine("Entro al metodo");
            foreach (var item in deltaList)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.UnitPrice);
                Console.WriteLine(item.Item);
                Console.WriteLine("********************");
            }
        }
    }
    public class Delta
    {
       public int index=1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double UnitPrice { get; set; }
        public string Item { get; set; }


    }

}
