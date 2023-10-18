using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Chetvbanke
{
    public int Ncheta;
    public string FIO = "";
    public float sum;



    public void Otk (int Ncheta, string FIO, float sum)
    {
      this.Ncheta = Ncheta; 
      this.FIO = FIO;
      this.sum = sum;
     }
    public void Out()
    {
        Console.WriteLine($"Номер счета {Ncheta} \nВладелец счета {FIO}  \nКол-во средств на счету {sum}");

    }
                                                                                                                                                                       
    public void Dob(float sum)
    {
        float perv = this.sum;
        Console.WriteLine($"Кол-во денег на счету {perv} \nПополнить счет на {sum} ?");
        sum = perv + sum;
        Console.WriteLine($"Ваш баланс {sum}");
    }
    public void umen (float sum)
    {
        float perv = this.sum;
        Console.WriteLine($"Кол-во денег на счету {perv} \nСнять со счета {sum} ?");
        sum = perv - sum;
        Console.WriteLine($"Ваш баланс {sum}");
    }
       



} 

   

