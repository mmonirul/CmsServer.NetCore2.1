## The world's smallest eComm server

##### Prerequisites (Server)

Mac

- macOS 10.12 "Sierra" and later versions
- [.NET Core 2.1 SDK or later](https://www.microsoft.com/net/download/archives)
- [Visual Studio Code](https://maven.apache.org/)
- [C# for Visual Studio Code](https://rometools.github.io/rome/)

Windows
[Visual Studio 2017 version 15.7.3 or later](https://code.visualstudio.com/download) with the following workloads:

- ASP.NET and web development
- .NET Core cross-platform development
  [.NET Core 2.1 SDK or later](https://www.microsoft.com/net/download)

##### Execute(Server)

- via dotnet cli

```
git clone
cd core.server
dotnet run
Navigate to https://localhost:5001/swagger or http://localhost:500/swagger
replace the existing SERVER_URL with this
```

- Visual studio

```
F5 or Ctrl + F5
https://localhost:44350/swagger/index.html  (used in client app)
```

![alt text](https://i.imgur.com/m5gYktr.png)

---

##### Ececute (Client)

[Download or clone](https://github.com/mmonirul/ProductClient.Vue)

```
git clone https://github.com/mmonirul/ProductClient.Vue
cd // project dir
npm install
npm run serve

http://localhost:8080/#/
```

> lg-screen
>
> ![laptop](https://i.imgur.com/7WDP3DP.png)

> md/sm-screen
>
> ![iphone/ipad](https://i.imgur.com/SQVTmOa.png)

###### Authors

- **Monirul** - _Project work_ -
