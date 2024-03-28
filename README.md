# Vegefoods Docker
This is demo web application that is published an Vegefoods Web Application by using docker on hub docker.
## Hub Docker
Vegefoods Web application is published to hub docker and can be used images by command: 
- Web API Swagger Back-End: docker pull vominhman/vegefoodsapi
- Vegefoods ReactJS Front-End: docker pull vominhman/vegefoods.reactui
  
  ![image](https://github.com/manvominh/vegefoods-docker/assets/133474782/a20a7877-2328-411e-b276-a97318e367a5)

## Steps to build the Vegefoods docker images:
- use port 5269 for Web API + port 8001 for MS SQL Server -> both these ports can change in docker-compose.yml file.
- use port 3030 for ReactJS application, the port calling Web Api is using 5269 in .env file, so if change port of Web Api, need to change config at .env file and then re-buiid ReactJS applciation for communicating between ReactJS application and Web Api.
### 1. Web API Swagger Back-End
1. Clone or download the Vegefoods-docker repository on github.
2. Go to docker-compose-yml folder
3. Open command line or others tool to run docker command: docker-compose up -d  ( run on environment that already have installed docker + docker compose)
4. Currently using port 5269 for WebApi and port 8001 for MS SQL Server, can change the port in docker-compose-yml file.
5. Run the url: http://localhost:5296/swagger/index.html to populate the Swagger UI
6. For reference to publish a vegefoodsapi docker image, please use the Vegefoods_Docker source code to publish: Vegefoods_Docker\Vegefoods.API folder on github

   ![image](https://github.com/manvominh/Vegefoods/assets/133474782/a1a96859-afbd-41c2-93f3-18e5cba4811a)
   
### 2. ReactJS Front-End:
1. Pull Vegefood ReactJS Front-End docker: docker pull vominhman/vegefoods.reactui:latest
2. Run Vegefood ReactJS Front-End docker: docker run -d -p 3030:80 --name vegefoods-reactui-container vominhman/vegefoods.reactui
3. For reference to publish a vegefoods ReactJS UI, please use source code at folder Vegefoods_Docker\vegefoods.reactui on github
4. run Vegefoods ReactJS: http://localhost:3030

![image](https://github.com/manvominh/vegefoods-docker/assets/133474782/85a936fc-df79-465a-9635-6539be88cc99)

## The difference between docker compose files in code solution and deployed docker compose file:

![image](https://github.com/manvominh/vegefoods-docker/assets/133474782/472d0dec-52c6-4892-9d07-db19938a6589)

