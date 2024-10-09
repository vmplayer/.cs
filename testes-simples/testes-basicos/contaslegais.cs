using System;

public class test2 {

    public static void Main (string[] args) {
        double n1;
        double n2;
        double n3;
        double media;

        
        Console.WriteLine("Insira um saldo: ");
        n1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Insira um saldo: ");
        n2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Insira um saldo: ");
        n3 = Convert.ToInt16(Console.ReadLine());
        media = n1+n2+n3;
        Console.WriteLine("Seu saldo final e:{0}",media);
        if(media<50.00){
        Console.WriteLine("Esta sem saldo? Pede pro Agiota!");
        }else
        Console.WriteLine("Tem saldo? Pague o Agiota!");
    }
}
