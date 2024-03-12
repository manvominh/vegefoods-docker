# Vegefoods
This is demo web application that is publish on hub docker, using docker-compose to populate Vegefoods Web API.
## Steps to build the docker:
1. Clone or download the Vegefoods-docker repository on github.
2. Go to docker-compose-yml folder
3. Open command line or others tool to run docker command: docker-compose up -d  ( run on environment that already have installed docker + docker compose)
4. Currently using port 5269 for WebApi and port 8001 for MS SQL Server, can change the port in docker-compose-yml file. Run the url: http://localhost:5296/swagger/index.html to populate the Swagger UI
5. For reference to publish a vegefoodsapi docker image, please use the Vegefoods_Docker source code to publish.
## Hub Docker
Vegefoods Web API is publish to hub docker and can use by command: docker pull vominhman/vegefoodsapi.

![image](https://github.com/manvominh/vegefoods-docker/assets/133474782/1dba92af-550e-404c-8e7f-32f2398c96f4)
## Web API
-run Vegefoods Web Api: http://localhost:5296/swagger/index.html
![image](https://github.com/manvominh/Vegefoods/assets/133474782/a1a96859-afbd-41c2-93f3-18e5cba4811a)


