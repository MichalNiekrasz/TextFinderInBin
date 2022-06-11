namespace Biblioteki;
public class Class
{
    static string? path;
    static int? number;
    public static string GetPathOfFile(){
        do{
            Console.Clear();
            Console.Write("Write here a path to file u want to read:  ");
            path = Console.ReadLine();
            

        }
        while(path==null||path=="");

        return path;
    }
    public static int? GetNumberOfMinimalLengh(){
        Console.Clear();
        do{
            
            Console.Write("Write here a minimal lenght of the string u want to read:  ");
            try{
                string? s = Console.ReadLine();
                if(s==null) continue;
                number = int.Parse(s);
            }
            catch(FormatException){
                Console.Clear();
                number=null;
                Console.WriteLine("podaj liczbę");
            }
            catch(OverflowException){
                Console.Clear();
                number=null;
                Console.WriteLine("podaj mniejszą liczbę");
            }
        }
        while(number==null);
        
        return number;
    }
    public static string? GetKey(){
        Console.Clear();
        System.Console.Write("Write here a key text to be found (leave blank when u want see everything):  ");
        string? s = Console.ReadLine();
        return s;
    }
    public static bool showOfsset(){
        string? o = null;
        do{
            Console.Clear();
            System.Console.Write("Do u want to show offset of each string? (Y/N):  ");
            string? s = Console.ReadLine();
            if(s==null) continue;
            if(s.ToUpper() == "N" || s.ToUpper() == "Y") o = s.ToUpper();
        }
        while(o == null);

        if(o == "Y") return true;
        else return false;

    }
    public static void PrintAndFilterList(List<string> list, string? key = null){
        var end = new List<string>();
        foreach (var str in list)
        {
            if(key==null || key==""){
                end = list;
                break;
            }
            
            if(str.Contains(key)){
                end.Add(str);
            }
            
        }
        foreach (var item in end)
        {
            System.Console.WriteLine(item);
        }
    }
}
