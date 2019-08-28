### CONFIGURE CONNECTION STRING FROM MAIN DOCKER-COMPOSE
### IF WORKING WITH THIS SERVICE EXCLUSIVELY, USE dev-docker-compose.yml

#Python Docker Image
FROM python:3.7.4-slim-buster

#Some settings so that python reads text as UTF-8. Reading as ASCII Causes Issues
ENV LC_ALL=C.UTF-8
ENV LANG=C.UTF-8

ENV FLASK_APP=flk/__init__.py
ENV FLASK_RUN_PORT=5000
ENV FLASK_ENV=development
ENV FLASK_SERVER_HOST=0.0.0.0

#Copy app into container
COPY ./ /app
WORKDIR /app
RUN pip3 install -r requirements.txt
ENTRYPOINT ["/bin/bash", "./entrypoint.sh"]