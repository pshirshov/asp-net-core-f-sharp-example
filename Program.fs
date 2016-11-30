open System
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Configuration.CommandLine
open Microsoft.Extensions.Configuration.EnvironmentVariables


type Startup() =
    member this.Configure(app: IApplicationBuilder) =
      app.Run(fun context -> context.Response.WriteAsync("Hello from ASP.NET Core!"))


[<EntryPoint>]
let main argv =
    let config = ConfigurationBuilder().AddCommandLine(argv).AddEnvironmentVariables().Build()
    let host = WebHostBuilder().UseKestrel().UseConfiguration(config).UseStartup<Startup>().Build()
    host.Run()
    printfn "Server finished!"
    0
