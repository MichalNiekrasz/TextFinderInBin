using System;
using System.IO;
using Biblioteki;

static class Program{
    private static void Main(){
        var output = new List<string>();
        string currentOutput = "";
        string? keystring = null;

        string? pathToFile;

        bool showOfsset;

        int? number = 4;
        int currentNumber = 0;

        System.Console.Clear();
        pathToFile = Class.GetPathOfFile();
        number = Class.GetNumberOfMinimalLengh();
        keystring = Class.GetKey();
        showOfsset = Class.showOfsset();

        int i = 0;
        string additionalThings = "";
        foreach (var item in File.ReadAllText(pathToFile))
        {
            
            
            if(item>32&&item<127){
                currentNumber++;
                currentOutput += item;
            }
            else{
                if(currentNumber>=number){
                    if(showOfsset){
                        additionalThings = $"{i-currentNumber}. - ";
                    }
                    output.Add(additionalThings + currentOutput);                 
                }
                currentOutput = "";
                currentNumber = 0;
            }
            i++;
        }
        if(currentNumber>=number){
            if(showOfsset){
                additionalThings = $"{i-currentNumber}. - ";
            }
            output.Add(additionalThings + currentOutput);    
            currentOutput = "";
            currentNumber = 0;              
        }
        Class.PrintAndFilterList(output,keystring);
    }
}