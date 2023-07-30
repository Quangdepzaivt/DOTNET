namespace WebApp.Models;
public class Student{
    // string name;
    // //fields
    // public string Name{
    //     get{ return name; }
    //     set{ name = value;}
    // }

    //properties
    //auto properties
    public Student(string name, string email, string password){
        Name = name;
        Email = email;
        Password = password;
    }
    public Student(string password){
        Password = password;
    }
    public string Name{ get; set;}
    public string Email{ private get; set; }
    public string Password { get; private set; }
}