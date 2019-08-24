FROM python:3.7.4-alpine3.10
RUN pip install -r requirements.txt
RUN export FLASK_APP=app/__init__.py
CMD flask fab create-admin
CMD flask run -h localhost -p 5000