namespace Biblioteki;
public class Class
{
    static string? path;
    static int? number;
    public static string GetPathOfFile(){
        do{
            Console.Write("Write here a path to file u want to read:  ");
            path = Console.ReadLine();
            
            Console.Clear();
        }
        while(path==null||path=="");

        return path;
    }
    public static int? GetNumberOfMinimalLengh(){
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
}
