// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Attack grenadeThrow = new Attack("Arc Grenade", 25 );
// Attack shootAttack = new Attack("Shoots", 20);
// Attack meleeAttack = new Attack("Thunderclap", 15);

// Enemy enemy = new Enemy("Arc Titan");

// enemy.AttackList.Add(grenadeThrow);
// enemy.AttackList.Add(shootAttack);
// enemy.AttackList.Add(meleeAttack);

// enemy.RandomAtk();

MeleeFighter meleeClass = new MeleeFighter("The Warrior");
RangedFighter rangedClass = new RangedFighter("The Hunter");
MagicCaster magicClass = new MagicCaster("The Old Caster");

meleeClass.PerformAttack(rangedClass, meleeClass.AttackList[1]);
meleeClass.Rage(magicClass);
rangedClass.PerformAttack(meleeClass, rangedClass.AttackList[0]);
rangedClass.Dash();
rangedClass.PerformAttack(meleeClass, rangedClass.AttackList[0]);
magicClass.PerformAttack(meleeClass, magicClass.AttackList[0]);
magicClass.Heal(rangedClass);
magicClass.Heal(magicClass);