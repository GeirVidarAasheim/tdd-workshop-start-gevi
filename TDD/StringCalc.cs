
using System.Security.Cryptography.X509Certificates;

namespace TDD;

public class StringCalc
{
    public int Add(string expression)
    {
       var defaultSeparator  = ',';
       var formula = expression;

       if (String.IsNullOrEmpty( expression)) 
       {
        return 0;
       }

       if (expression.Contains("//"))
       {
          defaultSeparator = expression[2];
          formula = formula.Substring(4).ToString();

       }

       var s = formula.Split(defaultSeparator).Select(x=> {
        string finalTextNumber;
        int finalNumber;
        bool isTax = false;
        if(x.Contains("!")){
            finalTextNumber = x.Substring(1, x.Length-1);
        }else{
            finalTextNumber = x;
            isTax = true;
        }
       finalNumber= int.Parse(finalTextNumber);

       if (finalNumber>1000){
        return 0;
       }else if(finalNumber > 99&& isTax){
        return finalNumber - (finalNumber/100);
       }else{
        return finalNumber;
       }
       } 
       ).Sum();  

       return s;
    }
}
