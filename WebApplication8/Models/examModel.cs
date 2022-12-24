namespace WebApplication8.Models
{
    public class examModel
    {

        public string? orderNumberExam { get; set; }
        public string? customerExam { get; set; }

        public int? orderQuantityExam { get; set; }


        public examModel()      //constructor used to initialize variables
        {

        }
        //method overloading
        public examModel(string orderNumberExam, string customerExam, int orderQuantityExam)
        {
            this.orderNumberExam = orderNumberExam;
            this.customerExam = customerExam;
            this.orderQuantityExam = orderQuantityExam;

        }
    }

}
