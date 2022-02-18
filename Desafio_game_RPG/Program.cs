using System;
using Desafio_game_RPG.src;

namespace Desafio_game_RPG
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            Random pl = new Random();
            int spl; 
            int rndatk;           
            
            Players player = new Players();
            Players Yuri = new Players("Billburn",20,"Mage",75,328,60,"Fireball");
            Players Igor = new Players("Atatab",21,"Bard",67,350,50,"Death Symphony");
            Players Artur = new Players("Michael J.",22,"Barbarian",127,0,80,"Animal Fury");
            Players Thiago = new Players("Mat", 26, "Rogue", 97,215,100,"Death Shadow");
            Players Boss = new Players("Pentadieno", 99, "Demon", 400, 0, 250, "Submission");

            
            while(Boss.HP > 0){
                if(Yuri.HP > 0){
                    rndatk = rnd.Next(Yuri.Hit);                    
                    Console.WriteLine(Yuri.PAttack(rndatk));                    
                    Boss.HP -= rndatk;
                    Console.WriteLine($"{Boss.Name} HP: {Boss.HP}");
                }
                if(Igor.HP > 0){
                    rndatk = rnd.Next(Igor.Hit);                    
                    Console.WriteLine(Igor.PAttack(rndatk));                    
                    Boss.HP -= rndatk;
                    Console.WriteLine($"{Boss.Name} HP: {Boss.HP}");
                }
                if(Artur.HP > 0){
                    rndatk = rnd.Next(Artur.Hit);                    
                    Console.WriteLine(Artur.PAttack(rndatk));                    
                    Boss.HP -= rndatk;
                    Console.WriteLine($"{Boss.Name} HP: {Boss.HP}");
                }
                if(Thiago.HP > 0){
                    rndatk = rnd.Next(Thiago.Hit);                    
                    Console.WriteLine(Thiago.PAttack(rndatk));                    
                    Boss.HP -= rndatk;
                    Console.WriteLine($"{Boss.Name} HP: {Boss.HP}");
                }
                if(Boss.HP > 0){
                    spl = pl.Next(3);
                    rndatk = rnd.Next(Boss.Hit);
                    string pselected = spl.ToString();
                    switch (pselected){
                        case "0":
                        pselected = "Billburn";
                        Yuri.HP -= rndatk;
                        Console.WriteLine($"{Yuri.Name} HP: {Yuri.HP}");
                        break;
                        case "1":
                        pselected = "Atatab";
                        Igor.HP -= rndatk;
                        Console.WriteLine($"{Igor.Name} HP: {Igor.HP}");
                        break;
                        case "2":
                        pselected = "Michael J.";
                        Artur.HP -= rndatk;
                        Console.WriteLine($"{Artur.Name} HP: {Artur.HP}");
                        break;
                        case "3":
                        pselected = "Mat";
                        Thiago.HP -= rndatk;
                        Console.WriteLine($"{Thiago.Name} HP: {Thiago.HP}");
                        break;
                    }
                    Console.WriteLine(Boss.BAttack(rndatk , pselected));   
                                     
                }
            }
        }
    }
}
// string spl = pl.ToString();
