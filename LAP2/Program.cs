using test;

namespace test
{
    class student
    {
        int ssn;
        string name;
        int age;
        int phone;
        public student(int ssn, string name, int age, int phone)
        {
            this.ssn = ssn;
            this.name = name;
            this.age = age;
            this.phone = phone;
        }
        public void displayinfo()
        {
            Console.WriteLine($"Name: {name} \n Age: {age} \n SSN: {ssn} \n Phone: {phone} \n");
        }
    };

}
internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter Number");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i < 100; i++)
        //{
        //    Console.WriteLine($" {i} * {n} =   {i * n} ");
        //}


        //while (true)
        //{
        //    Console.WriteLine("Enter Name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter ID");
        //    int id = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter Age");
        //    int age = int.Parse(Console.ReadLine());
        //    if (age > 0)
        //    {
        //        Console.WriteLine($"Name : {name} \n ID : {id} \n Age : {age} \n ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("try agin");
        //    }
        student st = new student(100, "mahmoud", 25, 0115615);
        st.displayinfo();
    }




}
