### Swagger

 


passo a passo

* Baixar as dependencias no NuGet

  > Swashbuckle.AspNetCore

  > Swashbuckle.AspNetCore.Swagger

  > Swashbuckle.AspNetCore.SwaggerGen
  
  
 * Incluir os metodos classe Startup.cs 

  > No metodo ConfigureServices(IServiceCollection services)
   
     ``` services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "MeuTodo", Version = "v1" }); }); 
     ```

   > No metodo Configure(IApplicationBuilder app, IWebHostEnvironment env)

            ```
             if (env.IsDevelopment())
            {
                app.UseSwagger(); //*
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1")); //*
            } 
            ```
   
   
 * Comandos para executar
   
   > comando cli = dotnet watch run ( para startar o servidor com o swagger )
  
   > Link = https://localhost:5001/swagger/index.html (pagina inicial do Swagger )
   
