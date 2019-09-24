

namespace mvc_PHONE.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base(" DefaultConnection")
        {


        }
       
    }
}