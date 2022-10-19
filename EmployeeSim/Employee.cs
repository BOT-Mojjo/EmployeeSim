using System;

public class Employee{
    public byte Age { get; private set; }
    public string Name { get; private set; }
    public string Position { get; private set; }
    public string Discription { get; private set; }
    private string response = "";

    public Employee(){
        Console.WriteLine("Load data from File? Y/N");
        response = Console.ReadLine().Trim().ToLower();
        if(response == "y"){
            Console.Write("File Path: ");
            string filepath = Console.ReadLine();
            if(File.Exists(filepath)){

            }
        }
    }

}

public class Workspace{
    public List<Employee> EmployeeList {
        get{
            return EmployeeList;
        } 
        set{
            for(int i = 0; i < value.Count; i++){
                if(value[i].Name == "selfdestruct"){
                    value.RemoveAt(i+1);
                    i--;
                }
            }

            EmployeeList = value;

        }
    }



}
