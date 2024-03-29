﻿using EFCore6FirstConsoleApp;

// добавление данных
using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User user1 = new User { Name = "Tom", Age = 33 };
    User user2 = new User { Name = "Alice", Age = 26 };

    // добавляем их в бд
    db.Users.AddRange(user1, user2);
    db.SaveChanges();
}
// получение данных
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

//// Добавление
//using (ApplicationContext db = new ApplicationContext())
//{
//    User tom = new User { Name = "Tom", Age = 33 };
//    User alice = new User { Name = "Alice", Age = 26 };

//    // Добавление
//    db.Users.Add(tom);
//    db.Users.Add(alice);
//    db.SaveChanges();
//}

//// получение
//using (ApplicationContext db = new ApplicationContext())
//{
//    // получаем объекты из бд и выводим на консоль
//    var users = db.Users.ToList();
//    Console.WriteLine("Данные после добавления:");
//    foreach (User u in users)
//    {
//        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
//    }
//}

//// Редактирование
//using (ApplicationContext db = new ApplicationContext())
//{
//    // получаем первый объект
//    User? user = db.Users.FirstOrDefault();
//    if (user != null)
//    {
//        user.Name = "Bob";
//        user.Age = 44;
//        //обновляем объект
//        //db.Users.Update(user);
//        db.SaveChanges();
//    }
//    // выводим данные после обновления
//    Console.WriteLine("\nДанные после редактирования:");
//    var users = db.Users.ToList();
//    foreach (User u in users)
//    {
//        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
//    }
//}

//// Удаление
//using (ApplicationContext db = new ApplicationContext())
//{
//    // получаем первый объект
//    User? user = db.Users.FirstOrDefault();
//    if (user != null)
//    {
//        //удаляем объект
//        db.Users.Remove(user);
//        db.SaveChanges();
//    }
//    // выводим данные после обновления
//    Console.WriteLine("\nДанные после удаления:");
//    var users = db.Users.ToList();
//    foreach (User u in users)
//    {
//        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
//    }
//}