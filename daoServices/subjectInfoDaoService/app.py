from flask import Flask
from flask_sandboy import Sandboy
from flask_sqlalchemy import SQLAlchemy
import os
import sys

#throws error in editor, it's fine, the hack above lets you import it
#definitely not a best-practices thing though

# from models import Machine, Cloud,

user = os.environ['POSTGRES_USER']
pwd = os.environ['POSTGRES_PASSWORD']
db = os.environ['POSTGRES_DB']
host = os.environ['POSTGRES_HOST']
port = os.environ['POSTGRES_PORT']

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgres://%s:%s@%s:%s/%s' % (user, pwd, host, port, db)
db = SQLAlchemy(app)

########## Define Models #######################################################
#Just including this here so I don't have to worry about actually packaging
#things properly at the moment
class Subject(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(50), nullable=False)

    def __repr__(self):
        return self.name

class Subjectinfo(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    subject_id = db.Column(db.Integer, db.ForeignKey(Subject.id), nullable=False)
    info = db.Column(db.Text, nullable=False)

    def __repr__(self):
        return self.name

################################################################################

db.init_app(app)
with app.app_context():
    db.create_all()
sandboy = Sandboy(app, db, [Subjectinfo])
#0.0.0.0 is important because its the IP in docker from which docker will open
#a port to the outside
app.run(debug=True, host='0.0.0.0')