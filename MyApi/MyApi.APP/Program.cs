var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // helps cat and list endpoints
builder.Services.AddSwaggerGen(); // graphic interface that will show all endpoints for api

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // the result when we rub our app, our builder, we use this. when we send request in http, this routs it through https, secure endpoint

app.UseAuthorization(); // no configuration just yet.

app.MapControllers(); // like discovering the endpoints.all we're saying let my app know where all these endpoints are. connect address to my logic

app.Run();
