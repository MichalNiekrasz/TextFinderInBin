using System;
using System.IO;
using Biblioteki;

static class Program{
    private static void Main(){
        var output = new List<string>();
        string currentOutput = "";
        string? keystring = null;

        string? pathToFile;

        int? number = 4;
        int currentNumber = 0;

        System.Console.Clear();
        pathToFile = Class.GetPathOfFile();
        number = Class.GetNumberOfMinimalLengh();
        keystring = Class.GetKey();

        foreach (var item in File.ReadAllText(pathToFile))
        {
            if(item>32&&item<127){
                currentNumber++;
                currentOutput += item;
            }
            else{
                if(currentNumber>=number){
                    output.Add(currentOutput);                 
                }
                currentOutput = "";
                currentNumber = 0;
            }
            
        }
        if(currentNumber>=number){
            output.Add(currentOutput);    
            currentOutput = "";
            currentNumber = 0;              
        }
        Class.PrintAndFilterList(output,keystring);
    }
}