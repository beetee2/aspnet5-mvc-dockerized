# aspnet5

This will give you a working, aspnet5 MVC Web Application that is Dockerized, and has been tested. 

To run this sample app inside a docker container:

1) Clone this repo
2) cd aspnet5
3) docker built -t aspnet5 .
4) docker run -t -d -p 5004:5004 aspnet5
5) navigate to localhost:5004 on your webserver
6) profit
