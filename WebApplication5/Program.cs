using WebApplication5;

var builder = WebApplication.CreateBuilder();

builder.Configuration
    .AddJsonFile("myInfo.json")
    .AddJsonFile("config.json")
    .AddXmlFile("config.xml")
    .AddIniFile("config.ini");

var app = builder.Build();

var service = new ComparerOfCompanies(app.Configuration);

app.Map("/myinformation/", (IConfiguration appConfig) => {
    var myInfo = appConfig.Get<Person>();
    return myInfo.ToString();
});

app.Map("/company/", (IConfiguration appConfig) => {
    return service.GetCompanyWithMoreEmployees();
}); 

app.Run();