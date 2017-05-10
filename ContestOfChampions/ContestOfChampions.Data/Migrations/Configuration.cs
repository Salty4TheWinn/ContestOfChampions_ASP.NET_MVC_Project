using System.Collections.Generic;
using ContestOfChampions.Models.EntityModels;
using ContestOfChampions.Models.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ContestOfChampions.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContestOfChampions.Data.ContestOfChampionsContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ContestOfChampionsContext context)
        {
            //Adding Roles
            if (!context.Roles.Any(role => role.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("User");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Leader"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Leader");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Officer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Officer");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Member"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Member");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manager.Create(role);
            }

            //Adding Entity Models

            //// 01.Adding Stats
            context.Stats.AddOrUpdate(stats => stats.Id, new Stats[]
            {
                //Hulk
                new Stats()
                {
                    Attack = 750,
                    CriticalHitRating = 20,
                    Defence = 700,
                    PerfectBlockChance = 30
                },
                //Gamora
                new Stats()
                {
                    Attack = 800,
                    CriticalHitRating = 50,
                    Defence = 400,
                    PerfectBlockChance = 5
                },
                //Iron Man
                new Stats()
                {
                    Attack = 600,
                    CriticalHitRating = 20,
                    Defence = 1200,
                    PerfectBlockChance = 60
                },
                //Black Panther
                new Stats()
                {
                    Attack = 900,
                    CriticalHitRating = 50,
                    Defence = 500,
                    PerfectBlockChance = 20
                },
                //Dr. Strange
                new Stats()
                {
                    Attack = 700,
                    CriticalHitRating = 40,
                    Defence = 750,
                    PerfectBlockChance = 55
                },
                //Deadpool
                new Stats()
                {
                    Attack = 600,
                    CriticalHitRating = 40,
                    Defence = 600,
                    PerfectBlockChance = 25
                },
            });

            //Adding Stats to the Db
            context.SaveChanges();

            //// 02.Adding Champions
            context.Champions.AddOrUpdate(champ => champ.Id, new Champion[]
            {
                new Champion()
                {
                    Name = "Hulk",
                    Class = Class.Science,
                    StarLevel = 3,
                    Stats = context.Stats.Find(1),
                    SkinUrl = "https://vignette2.wikia.nocookie.net/marvel-contestofchampions/images/5/57/Hulk_preview.png"
                },
                new Champion()
                {
                    Name = "Gamora",
                    Class = Class.Cosmic,
                    StarLevel = 4,
                    Stats = context.Stats.Find(2),
                    SkinUrl = "https://vignette3.wikia.nocookie.net/marvel-contestofchampions/images/9/92/Gamora_preview.png"
                },
                new Champion()
                {
                    Name = "Iron Man",
                    Class = Class.Tech,
                    StarLevel = 3,
                    Stats = context.Stats.Find(3),
                    SkinUrl = "https://vignette2.wikia.nocookie.net/marvel-contestofchampions/images/f/fb/Iron_Man_preview.png"
                },
                new Champion()
                {
                    Name = "Black Panther",
                    Class = Class.Skill,
                    StarLevel = 4,
                    Stats = context.Stats.Find(4),
                    SkinUrl = "http://vignette1.wikia.nocookie.net/marvel-contestofchampions/images/8/8a/Black_Panther_preview.png"
                },
                new Champion()
                {
                    Name = "Dr. Strange",
                    Class = Class.Mystic,
                    StarLevel = 4,
                    Stats = context.Stats.Find(5),
                    SkinUrl = "http://www.marvel-hq.com/wp-content/uploads/2016/05/GachaChasePrize_256x256_doctor_strange.png"
                },
                new Champion()
                {
                    Name = "Deadpool",
                    Class = Class.Mutant,
                    StarLevel = 3,
                    Stats = context.Stats.Find(5),
                    SkinUrl = "https://vignette3.wikia.nocookie.net/marvel-contestofchampions/images/5/51/Deadpool_preview.png"
                }
            });

            //Adding Champs to the Db
            context.SaveChanges();

            // 03. Adding Treasuries
            context.Treasuries.AddOrUpdate(tres => tres.Id, new Treasury[]
            {
              new Treasury()
              {
                  GoldAmmount = 5000,
                  Loyalty = 25000,
                  BattleChips = 15000
              },
              new Treasury()
              {
                   GoldAmmount = 25000,
                  Loyalty = 150000,
                  BattleChips = 37000
              },
              new Treasury()
              {
                   GoldAmmount = 100000,
                  Loyalty = 45000,
                  BattleChips = 40000
              },
              new Treasury()
              {
                   GoldAmmount = 66666,
                  Loyalty = 66666,
                  BattleChips = 66666
              },
              new Treasury()
              {
                   GoldAmmount = 1500000,
                  Loyalty = 14000,
                  BattleChips = 300000
              },

            });

            //Adding Treasuries to the Db
            context.SaveChanges();

            // 04.Adding Resources
            context.Resources.AddOrUpdate(res => res.Id, new Resources[]
            {
                new Resources()
                {
                  GoldAmount  = 10000,
                  BattleChips = 50000,
                  LoyaltyAmount = 15000,
                  EnergyAmount = 70,
                  UnitsAmount = 450
                },
                new Resources()
                {
                  GoldAmount  = 75000,
                  BattleChips = 17000,
                  LoyaltyAmount = 140000,
                  EnergyAmount = 30,
                  UnitsAmount = 1005
                },
                new Resources()
                {
                  GoldAmount  = 92000,
                  BattleChips = 134000,
                  LoyaltyAmount = 72000,
                  EnergyAmount = 69,
                  UnitsAmount = 42000
                },
                new Resources()
                {
                  GoldAmount  = 90000,
                  BattleChips = 17777,
                  LoyaltyAmount = 61621,
                  EnergyAmount = 12,
                  UnitsAmount = 755
                },
                new Resources()
                {
                  GoldAmount  = 4500300,
                  BattleChips = 44000,
                  LoyaltyAmount = 800000,
                  EnergyAmount = 42,
                  UnitsAmount = 700
                },
            });

            //Adding Resources to the Db
            context.SaveChanges();

            // 05.Adding Alliances
            context.Alliances.AddOrUpdate(all => all.Id, new Alliance[]
            {
                new Alliance()
                {
                    Treasury = context.Treasuries.Find(1),
                    Name = "Avengers"
                },
                new Alliance()
                {
                    Treasury = context.Treasuries.Find(2),
                    Name = "Guardians"
                },
                new Alliance()
                {
                    Treasury = context.Treasuries.Find(3),
                    Name = "HellHounds"
                },
                new Alliance()
                {
                    Treasury = context.Treasuries.Find(4),
                    Name = "Champions"
                },
                new Alliance()
                {
                    Treasury = context.Treasuries.Find(5),
                    Name = "Predators"
                },
            });

            //Adding Alliances to the Db
            context.SaveChanges();

            // 05.Adding Summoners
            context.Summoners.AddOrUpdate(all => all.Id, new Summoner[]
            {
                new Summoner()
                {
                    Alliance = context.Alliances.Find(1),
                    Champions = new HashSet<Champion>()
                    {
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Hulk"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Deadpool"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Dr. Strange")
                    },
                    Resources = context.Resources.Find(1),
                    Title = "Seasoned Summoner",
                    Username = "Stamat"
                },
                new Summoner()
                {
                    Alliance = context.Alliances.Find(2),
                    Champions = new HashSet<Champion>()
                    {
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Gamora"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Iron Man"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Dr. Strange")
                    },
                    Resources = context.Resources.Find(2),
                    Title = "Fallen Angel",
                    Username = "Razer"
                },
                new Summoner()
                {
                    Alliance = context.Alliances.Find(3),
                    Champions = new HashSet<Champion>()
                    {
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Black Panther"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Deadpool"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Iron Man")
                    },
                    Resources = context.Resources.Find(3),
                    Title = "Mastermind",
                    Username = "Haralampi"
                },
                new Summoner()
                {
                    Alliance = context.Alliances.Find(4),
                    Champions = new HashSet<Champion>()
                    {
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Dr. Strange"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Iron Man"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Hulk")
                    },
                    Resources = context.Resources.Find(4),
                    Title = "Imperor",
                    Username = "BashNerd"
                },
                new Summoner()
                {
                    Alliance = context.Alliances.Find(5),
                    Champions = new HashSet<Champion>()
                    {
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Hulk"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Black Panther"),
                        context.Champions.FirstOrDefault(champ=> champ.Name == "Gamora")
                    },
                    Resources = context.Resources.Find(5),
                    Title = "Avenger On Call",
                    Username = "Dimitriii"
                },
            });

            //Adding Summoners to the Db
            context.SaveChanges();

            // 06.Adding members to the alliance
            context.Alliances.Find(1)?.Members.Add(context.Summoners.Find(5));
            context.Alliances.Find(1)?.Members.Add(context.Summoners.Find(4));
            context.Alliances.Find(3)?.Members.Add(context.Summoners.Find(3));
            context.Alliances.Find(4)?.Members.Add(context.Summoners.Find(2));
            context.Alliances.Find(4)?.Members.Add(context.Summoners.Find(1));

        }
    }
}
