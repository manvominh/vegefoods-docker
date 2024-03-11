# Vegefoods
This is demo web application that is publish on hub docker using ASP.Net Core Web API, Entity Framework, Microsoft SQL Server, Memory Cache, MediatR + CQRS pattern and Clean Architecture in backend.
## Steps to build the docker:
1. Run the solution with docker-compose to check at local ( if need )
2. Publish the project Vegefoods.API to Docker Hub ( publish to Docker Container Registry)
3. Copy docker-compose.yml to another folder to run docker, for example: copy docker-compose.yml file to D:\test\
4. Modify file docker-compose.yml:
   - remove lines from number 20 to 22 - build section
   - change content of line 19 to 'image: vominhman/vegefoodsapi' -> means to use docker image on hub that just published.
5. run docker command: docker-compose up -d  ( environment that already have installed docker + docker compose)
## Hub Docker
Vegefoods Web API is publish to hub docker and can use by command: docker pull vominhman/vegefoodsapi.

![image](https://github.com/manvominh/vegefoods-docker/assets/133474782/1dba92af-550e-404c-8e7f-32f2398c96f4)
## Web API
-run Vegefoods image on linux docker
![image](https://github.com/manvominh/Vegefoods/assets/133474782/a1a96859-afbd-41c2-93f3-18e5cba4811a)


