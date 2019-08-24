RUN pip3 install -r requirements.txt
RUN export FLASK_APP=app/__init__.py
CMD flask fab create-admin
CMD flask run -h localhost -p 5000