using System;
using System.Collections.Generic;
using LNUProject.Entities;
using LNUProject.Repositories;
using LNUProject.UnitOfWork;

namespace LNUProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (LNUProjectContext db = new LNUProjectContext())
            {
                UnitOfWork.UnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(db);
                /*Console.WriteLine("The available tables:\n" +
                                  "1.Addresses\n" +
                                  "2.Cartgoods\n" +
                                  "3.Carts\n" +
                                  "4.Categories\n" +
                                  "5.Goods\n" +
                                  "6.Roles\n" +
                                  "7.Users\n");
                Console.Write
                    ("Please choose the number: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        var addresses = unitOfWork.Addresses.GetAll();
                        foreach (var address in addresses)
                        {
                            Console.WriteLine($"{address.Id} {address.UserId} {address.City} {address.Street_address}");
                        }
                        break;
                    case "2":
                        var cartgoods = unitOfWork.Cartgoods.GetAll();
                        foreach (var cartgood in cartgoods)
                        {
                            Console.WriteLine($"{cartgood.Id} {cartgood.GoodId} {cartgood.CartId} {cartgood.Quantity} {cartgood.Date_purchase}");
                        }
                        break;
                    case "3":
                        var carts = unitOfWork.Carts.GetAll();
                        foreach(var cart in carts)
                        {
                            Console.WriteLine($"{cart.Id} {cart.UserId} {cart.SellerId}");
                        }
                        break;
                    case "4":
                        var categories = unitOfWork.Categories.GetAll();
                        foreach(var category in categories)
                        {
                            Console.WriteLine($"{category.Id} {category.Name}");
                        }
                        break;
                    case "5":
                        var goods = unitOfWork.Goods.GetAll();
                        foreach(var good in goods)
                        {
                            Console.WriteLine($"{good.Id} {good.Name} {good.CategoryId} {good.Price} {good.Quantity}");
                        }
                        break;
                    case "6":
                        var roles = unitOfWork.Roles.GetAll();
                        foreach (var role in roles)
                        {
                            Console.WriteLine($"{role.Id} {role.Name}");
                        }
                        break;
                    case "7":
                        var users = unitOfWork.Users.GetAll();
                        Console.WriteLine("Id  RoleId     Firstname   Lastname   Date_logup   Date_birth   Rating   Email   Password");
                        foreach(var user in users)
                        {
                            Console.WriteLine($"{user.Id}  {user.RoleId}   {user.Firstname}  {user.Lastname}  {user.Date_logup}  {user.Date_birth}  {user.Rating}  {user.Email}  {user.Password} ");
                        }
                        break;
                }*/


                
                Role r = new Role();
                r.Name = "Shoper";
                unitOfWork.Roles.Add(r);
                unitOfWork.Save();

               

                
                /*Console.WriteLine("Enter id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Role u = unitOfWork.Roles.Get(id);
                u.Name = "Shoper";
                unitOfWork.Roles.Update(u);
                unitOfWork.Save();*/

                /*Console.WriteLine("Enter id: ");
                int Id = Convert.ToInt32(Console.ReadLine());
                Role a = unitOfWork.Roles.Get(Id);
                a.Name = "Shoper";
                unitOfWork.Roles.Remove(a);
                unitOfWork.Save();*/


            }
        }
    }

    
}
