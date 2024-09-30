

# Extreme More App Templates

[Dev Docs How To Work on Razor](https://sharpscript.net/docs/script-plugins)


   
  
   

[NetFrameworkCoreTemplates Repo](https://github.com/orgs/NetCoreTemplates/repositories)
[NetFrameworkCoreTemplates Templates](https://github.com/NetFrameworkCoreTemplates)

[Sharp-Apps Repo](https://github.com/sharp-apps)   
[Sharp-Apps Pages](https://sharpscript.net/sharp-apps/)   

[ServiceStack Download](https://servicestack.net/start?Mix=autocrudgen%2Copenapi3%2Cef-sqlite)
[ServiceStack Repo](https://github.com/ServiceStack/dotnet-app/tree/master)
[ServiceStack Docs](https://docs.servicestack.net/self-hosting) 
[Client Apps](https://apps.servicestack.ne)

[ServiceStack Apps](https://stackoverflow.com/questions/15862634/in-what-order-are-the-servicestack-examples-supposed-to-be-grokked/15869816#15869816)
[ServiceStack Pages](https://servicestack.net/)
[ServiceStack AppHost](https://github.com/ServiceStack/ServiceStack.Examples/tree/master/src/StarterTemplates/WinServiceAppHost)
[Gistlyn Repos](https://github.com/gistlyn?tab=repositories)    
[Gistlyn ServiceStack](https://github.com/gistlyn/ServiceStack)   
[Davidfowl 255repos](https://github.com/davidfowl?page=2&tab=repositories)

# LoC WCF Signal OWIN ...
[AutoFaQ Repo](https://github.com/autofac)
[AutoFaq Extension](https://autofac.readthedocs.io/en/latest/integration/aspnetcore.html)
[AutoFaq Docs](https://autofac.readthedocs.io/en/latest/)
[AutoFaq DualStart](https://autofac.readthedocs.io/en/latest/integration/aspnetcore.html#configuration-method-naming-conventions)
[AutoFaq RootDocs](https://autofac.readthedocs.io/en/latest/configuration/index.html)
[AutoFaq 38 Repos](https://github.com/orgs/autofac/repositories)

# Sharp Apps 
[12 Repos](https://github.com/orgs/sharp-apps/repositories)



# RestFull AppTemplates For Generate API Project
[NetcoreApps 65 Repos](https://github.com/orgs/NetCoreApps/repositories)
[Just Generate](https://github.com/NetCoreApps/SharpData)
[SharpData Docs](https://sharpscript.net/sharp-apps/sharpdata)    



# SpringFrameWork Net
[WebPages](https://springframework.net/)     
[Github Repo](https://github.com/spring-projects/spring-net)
[20 Templates](https://github.com/spring-projects/spring-net/blob/main/website/src/pages/examples.md)


# Probot Auto API + Docs Octokit Full GIT DbContext 
**52 Repos**    
 
 [Github Repos](https://github.com/orgs/probot/repositories)

 Extreme Easy AutoAPI     

 For Creating GitHuApps    

````    
export default (app) => {
  app.on("issues.opened", async (context) => {
    const issueComment = context.issue({
      body: "Thanks for opening this issue!",
    });
    return context.octokit.issues.createComment(issueComment);
  });

  app.onAny(async (context) => {
    context.log.info({ event: context.name, action: context.payload.action });
  });

  app.onError(async (error) => {
    app.log.error(error);
  });
};

````
 
Typescript API Documentation   

[Probot Docs](https://probot.github.io/docs/)
[Probot Repo](https://github.com/probot/probot)



# OpenSource For Use    
[GithubApp](https://github.com/marketplace)
