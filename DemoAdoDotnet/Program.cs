
using DemoAdoDotnet.Data;
using DemoAdoDotnet.Models;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

IConfiguration configuration =  new ConfigurationBuilder()
                                        .SetBasePath(AppContext.BaseDirectory)
                                        .AddJsonFile("appsettings.json", optional: false)
                                        .Build();


//tester le Dao développé
CategorieDaoImpl categorieDaoImpl = new CategorieDaoImpl(configuration);

List<Categorie> categories = categorieDaoImpl.GetAllCategories();

Console.WriteLine($"Il y a {categories.Count} catégories trouvés");
