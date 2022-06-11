using System;
using System.IO;
using Biblioteki;

static class Program{
    static string output = "";
    static string currentOutput = "";

    static string? pathToFile;


    static int? number = 4;
    static int currentNumber = 0;
    private static void Main(){
        System.Console.Clear();
        pathToFile = Class.GetPathOfFile();
        number = Class.GetNumberOfMinimalLengh();

        foreach (var item in File.ReadAllText(pathToFile))
        {
            if(item>32&&item<127){
                currentNumber++;
                currentOutput += item;
            }
            else{
                if(currentNumber>=number){
                    output+=currentOutput+"\n";                  
                }
                currentOutput = "";
                number = 0;
            }
            
        }
        if(currentNumber>=number){
            output+=currentOutput+"";    
            currentOutput = "";
            number = 0;              
        }
        System.Console.WriteLine(output);
    }
}