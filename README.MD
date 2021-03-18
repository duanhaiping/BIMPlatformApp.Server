# NETCore



## 前言



## 项目文档



## 项目介绍



### 项目演示



### 组织结构

``` lua
BIMPlatformApp.src  --核心代码
├── BIMPlatform.Host -- .net core 独立主机以及环境配置模块
├── BIMPlatform.HttpApi -- 开放 http api 接口模块
├── BIMPlatform.Application -- 用例层实现模块
├── BIMPlatform.Application.Abstractions -- 用例层定义模块
├── BIMPlatform.Domain -- 业务实体模块
├── BIMPlatform.Domain.Shared -- 业务实体共享层模块
├── BIMPlatform.EntityFrameworkCore -- 仓储层EF实现模块
├── BIMPlatform.EntityFrameworkCore.Abstractions -- 仓储层定义模块
├── BIMPlatform.EntityFrameworkCore.Dbmigrator -- 仓储层迁移文件管理模块
├── BIMPlatform.Dbmigrator -- 仓储层迁移工具，种子数据配置工具
└── BIMPlatform.Toolkits -- 系统通用工具类
BIMPlatformApp.test --测试代码
├── BIMPlatform.Application.Tests -- 用例层测试模块
├── BIMPlatform.Domain.Tests -- 业务实体层测试模块
├── BIMPlatform.EntityFrameworkCore.Tests -- 数据持久化测试模块
└── BIMPlatform.TestBase -- 测试项目基础通用模块
```

### 技术选型

#### 后端技术

| 技术                  | 说明           | 官网                                                         |
| --------------------- | -------------- | ------------------------------------------------------------ |
| .Net Core WEBAPI      | MVC框架        | https://docs.microsoft.com/zh-cn/aspnet/core/?view=aspnetcore-3.1 |
| Identity              | 认证和授权框架 | https://docs.microsoft.com/zh-cn/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio |
| EntityFrameworkCore   | ORM框架        | https://docs.microsoft.com/zh-cn/ef/core/                    |
| Autofac               | IOC 容器       | https://autofaccn.readthedocs.io/zh/latest/                  |
| AutoMapper            | 对象关系映射   | http://automapper.org/                                       |
| Swagger-UI            | 文档生产工具   | https://github.com/swagger-api/swagger-ui                    |
| JetBrains.Annotations | 验证框架       | https://www.nuget.org/packages/JetBrains.Annotations/        |
| Serilog               | 日志框架       | https://serilog.net/                                         |
| RabbitMq              | 消息队列       | https://www.rabbitmq.com/                                    |
| Hangfire              | BackgroudJob   | https://redis.io/                                            |
| OSS                   | 对象存储       | https://github.com/aliyun/aliyun-oss-java-sdk                |
| MinIO                 | 对象存储       | https://github.com/minio/minio                               |
| JWT                   | JWT登录支持    | https://github.com/jwtk/jjwt                                 |
| xunit                 | 测试框架       |                                                              |
| Shouldly              | 断言框架       |                                                              |
| SqlLite               | 单元测试数据库 |                                                              |
| Grpc                  | 远程调用工具   |                                                              |

