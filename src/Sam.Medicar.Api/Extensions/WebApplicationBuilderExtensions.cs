
//using Sam.Medicar.Api.Interfaces;

//namespace Sam.Medicar.Api.Extensions
//{
//    public static class WebApplicationBuilderExtensions
//    {
//        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder) where TStartup : IStartupCustom
//        {
//            var startup = Activator.CreateInstance(typeof(TStartup)) as IStartupCustom;
//            if (startup == null)
//                throw new ArgumentException("Startup class is invalid.");

//            startup.ConfigureServices(builder.Services);
//            var app = builder.Build();
//            startup.Configure(app, app.Environment);
//            app.Run();

//            return builder;
//        }
//    }
//}
//using Sam.Medicar.Api.Interfaces;

//namespace Sam.Medicar.Api.Extensions
//{
//    public static class WebApplicationBuilderExtensions
//    {
//        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder) where TStartup : IStartupCustom
//        {
//            var startup = Activator.CreateInstance(typeof(TStartup)) as IStartupCustom;
//            if (startup == null)
//                throw new ArgumentException("Startup class is invalid.");

//            startup.ConfigureServices(builder.Services);
//            var app = builder.Build();
//            startup.Configure(app, app.Environment);
//            app.Run();

//            return builder;
//        }
//    }
//}
