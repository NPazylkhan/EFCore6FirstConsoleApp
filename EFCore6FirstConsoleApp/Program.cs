using EFCore6FirstConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
// установка пути к текущему каталогу
builder.SetBasePath(Directory.GetCurrentDirectory());
// получаем конфигурацию из файла appsettings.json
builder.AddJsonFile("appsettings.json");
// создаем конфигурацию
var config = builder.Build();
// получаем строку подключения
string connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlite(connectionString).Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    var users = db.Users.ToList();
    foreach (User user in users)
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
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