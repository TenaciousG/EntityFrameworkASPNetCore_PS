Using Entity Framework with ASP.net Core

After creating models and added db to startup: 
    services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

.. run following commands in package manager console to create db:
add-migration InitialMigration
update-database
