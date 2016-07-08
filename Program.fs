open System
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http


type Startup() = 
    member this.Configure(app: IApplicationBuilder) =
      app.Run(fun context -> context.Response.WriteAsync("Hello from ASP.NET Core!"))


[<EntryPoint>]
let main argv = 
    let host = WebHostBuilder().UseKestrel().UseStartup<Startup>().Build()
    host.Run()
    printfn "Server finished!"
    0
