#FROM ubuntu:latest
FROM python:3.7.4-buster
ENV FLASK_APP=/app/app/__init__.py
ENV LC_ALL=C.UTF-8
ENV LANG=C.UTF-8
#RUN apt-get update -y
#RUN apt-get install -y python3-pip python3-dev build-essential
COPY .. /app
WORKDIR /app
RUN pip3 install -r requirements.txt
CMD ["flask", "run", "-h", "localhost", "-p", "5000"]
#FROM python:3.7.4-alpine3.10
#COPY . /tmp/appdata
#COPY requirements.txt /tmp/requirements.txt
#ENV FLASK_APP=/tmp/appdata/__init__.py
#RUN pip install -r /tmp/requirements.txt
#CMD flask fab create-admin
#CMD flask run -h localhost -p 5000