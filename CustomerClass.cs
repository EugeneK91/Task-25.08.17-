using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public class CustomerClass:IEquatable<CustomerClass>,IComparable<CustomerClass>
    {
        public CustomerClass()
        {

        }
        public CustomerClass(int id,string name,string lastName)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        
        public bool Equals(CustomerClass otherCustomer)
        {
            if (otherCustomer == null)
                return false;
            return this.Id == otherCustomer.Id;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            var book = obj as CustomerClass;
            if (book == null)
                return false;
            else
                return Equals(book);
        }

        public override string ToString()
        {
            return $"Id:{this.Id}, Name: {this.Name},LastName: {this.LastName} ";
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 23 + Name.GetHashCode() * 23 + LastName.GetHashCode() * 23;
        }

        public int CompareTo(CustomerClass otherCustomer)
        {
            if (otherCustomer == null) return 1;

            return this.Name.CompareTo(otherCustomer.Name);
        }

        public int CompareTo(CustomerClass otherCustomer,Func<CustomerClass, CustomerClass,int> comparator)
        {
            if (comparator == null) throw new ArgumentNullException();

            return comparator(this, otherCustomer);
        }

        public static bool operator > (CustomerClass operand1, CustomerClass operand2)
        {
            if (operand1 == null) return false;
            return operand1.Name.CompareTo(operand2.Name) == 1;
        }

        public static bool operator <(CustomerClass operand1, CustomerClass operand2)
        {
            if (operand1 == null) return false;
            return operand1.Name.CompareTo(operand2.Name) == -1;
        }

        public static bool operator >=(CustomerClass operand1, CustomerClass operand2)
        {
            if (operand1 == null) return false;
            return operand1.Name.CompareTo(operand2.Name) >= 0;
        }

        public static bool operator <=(CustomerClass operand1, CustomerClass operand2)
        {
            if (operand1 == null) return false;
            return operand1.Name.CompareTo(operand2.Name) <= 0;
        }

        public static bool operator ==(CustomerClass operand1, CustomerClass operand2)
        {
            if (operand1 == null) return false;
            return operand1.Id == operand2.Id;
        }

        public static bool operator !=(CustomerClass operand1, CustomerClass operand2)
        {
            if (operand1 == null) return false;
            return !(operand1.Id == operand2.Id);

        }
    }
}
