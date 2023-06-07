// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Attack grenadeThrow = new Attack("Arc Grenade", 25 );
Attack shootAttack = new Attack("Shoots", 20);
Attack meleeAttack = new Attack("Thunderclap", 15);

Enemy enemy = new Enemy("Arc Titan");

enemy.AttackList.Add(grenadeThrow);
enemy.AttackList.Add(shootAttack);
enemy.AttackList.Add(meleeAttack);

enemy.RandomAtk();