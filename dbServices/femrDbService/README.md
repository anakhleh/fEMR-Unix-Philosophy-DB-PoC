#What is this?

A docker container that contains PostgreSQL

#How do I use ?

First, have docker installed, which should install the docker-compose CLI tool.

`cd` over to this directorey, then run `docker-compose up -d`

#How do I check if the container is running

Run `docker container ls`

#How do I kill this?

Run `docker kill dbServiceFemrDb` to kill the container,
and then if you want to get rid of the associated volume, 
run ``

#What If I'm on windows 10 home?
If you are on windows 10 home, you need to download the Docker
Toolbox, and then run all of this stuff through the Docker
Quickstart Terminal, because Win10Home does not get
HyperX Virtualization (Or any virtualizatino)