
        public class Customer
        {
            public int Id;
            public string Name;
            
            public Customer()
            {              
            }

            // ctor to create a constructor 
            public Customer(int id)
            {      
                this.Id = id;          
            }
            // this <= keyword ref to current object 
            public Customer(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
        }