using System;

namespace classlib
{
    public class Contact
    {
        public int ID { get; init; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public long Visa { get; set; }
        public string Value { get; set; }
        public Contact(int _id, string _firstName, string _surName, long _visa, string _value)
        {
            this.ID = _id;
            this.FirstName = _firstName;
            this.SurName = _surName;
            this.Visa = _visa;
            this.Value = _value;
        }

        public override string ToString()
        {
            return String.Format($"{ID}:{FirstName}:{SurName}:{Visa}:{Value}");
        }
    }
}