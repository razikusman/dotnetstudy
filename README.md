# dotnetstudy
craeting an API


//install following nuget packages
1.Microsoft.EntityFrameworkCore.SqlServer<(changes according to the srver used eg:- SqlLite)>
2.Microsoft.EntityFrameworkCore.Tools
3.Bricelum.EnitityFrameworkCore.Pluralaizer
4.Microsoft.AspNetCore.Mvc.NewtonsoftJson

reasons for installing the packages
{
	1.to manage the connection between the server the vs editor ide
	2.to have update,delete.post,het .. etc Http function
	3.to make the models pluralise 
	4.to view and add nested tables(relationa table data)
}

update data
/*Publisher publisher = _context.Publishers.FirstOrDefault();*/

/*publisher.PublsherName = " Egmont Books";*/

delete data
/*_context.Publishers.Remove(publisher);*/

save changes
/* _context.SaveChanges();*/

read data

add - migration < name blabla > will create a migration
update-database will add the table
remove migration will delete the last migration
update-database <name of the migration > will remove all the table created ater thhe stated migration but not the migration
script-migration will create sql scipt aoo all the thin done 

/*add swagger*/
first install Swashbuckle.AspNetCore
then
add following in startup.json
<=/* This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //add ConnectionSTring
            services.AddDbContext<HospitalDBContext>(option =>
            option.UseSqlServer(Configuration.GetConnectionString("HospitalDb")));

            //add swager service
            services.AddSwaggerGen(gen =>
            {
                gen.SwaggerDoc("v1.0", new Microsoft.OpenApi.Models.OpenApiInfo{ Title = "Hospital Api", Version = "v1.0" });
            });

            services.AddScoped<IDoctorRepository , DoctorsRepository>();
        }


/* This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(ui =>
            {
                ui.SwaggerEndpoint("/swagger/v1.0/swagger.json", "Hospital Api Endpoint");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
*/
=>



/*or repositiry architecture patern*/ 
follow link https://medium.com/net-core/repository-pattern-implementation-in-asp-net-core-21e01c6664d7