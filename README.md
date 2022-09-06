### API_Web_ASP.NET_Core
Projetos de aplicativos ASP.NET Core para serviços HTTP RESTful e ASP.NET Core MVC

passo a passo

* criar projeto terminal [ dotnet new web -o nomeProjeto -f net5.0 ] -f =para indicar a versão
  >classe Startup.cs = classe de configuração
  
  >classe Program.cs = classe que starta o servidor
  
 * Instalar pacotes para trabalhar com Entity Framework ( usar banco de dados )
   > comando cli = dotnet add package Microsoft.EntityFrameworkCore.SqLite ( usar sqlite db)
   
   > comando cli = dotnet add package Microsoft.EntityFrameworkCore.Design ( para gerar migração do banco de dados )
   
 * Criar as pastas e classe mvc
   > Models = ( para os modelos )
   
   > Date = ( criar classe AppDbContext - para configurar e representar o db ORM )
   
 * Definir qual é o banco de dados e a string de conexão (
 
    > pela classe AppDbContext - com o metodo protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder) ou
    
    > pela classe Startup - dentro do metodo  ConfigureServices(IServiceCollection services) - services.AddDbContext<DataContext>
    
  *  
   
            
   
