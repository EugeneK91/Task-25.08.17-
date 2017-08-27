using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public struct CustomerStruct : IEquatable<CustomerStruct>, IComparable<CustomerStruct>
    {
        public CustomerStruct(int id, string name, string lastName)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
        }

        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }


        public bool Equals(CustomerStruct otherCustomer)
        {
            if (otherCustomer == null)
                return false;
            return this.Id == otherCustomer.Id;
        }

        public override string ToString()
        {
            return $"Id:{this.Id}, Name: {this.Name},LastName: {this.LastName} ";
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 23 + Name.GetHashCode() * 23 + LastName.GetHashCode() * 23;
        }

        public int CompareTo(CustomerStruct otherCustomer)
        {

            return this.Name.CompareTo(otherCustomer.Name);
        }

        public int CompareTo(CustomerStruct otherCustomer, Func<CustomerStruct, CustomerStruct, int> comparator)
        {

            return comparator(this, otherCustomer);
        }

        public static bool operator >(CustomerStruct operand1, CustomerStruct operand2)
        {

            return operand1.Name.CompareTo(operand2.Name) == 1;
        }

        public static bool operator <(CustomerStruct operand1, CustomerStruct operand2)
        {

            return operand1.Name.CompareTo(operand2.Name) == -1;
        }

        public static bool operator >=(CustomerStruct operand1, CustomerStruct operand2)
        {
    
            return operand1.Name.CompareTo(operand2.Name) >= 0;
        }

        public static bool operator <=(CustomerStruct operand1, CustomerStruct operand2)
        {

            return operand1.Name.CompareTo(operand2.Name) <= 0;
        }

        public static bool operator ==(CustomerStruct operand1, CustomerStruct operand2)
        {
            if (operand1 == null) return false;
            return operand1.Id == operand2.Id;
        }

        public static bool operator !=(CustomerStruct operand1, CustomerStruct operand2)
        {
            if (operand1 == null) return false;
            return !(operand1.Id == operand2.Id);

        }
    }
}
